using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class HistorySparepartListModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private ISparepartRepository _sparepartRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _spkRepository;
        private ISPKDetailSparepartRepository _spkDetailSparepartRepository;
        private ISalesReturnRepository _salesReturnRepository;
        private ISalesReturnDetailRepository _salesReturnDetailRepository;
        private IUnitOfWork _unitOfWork;

        public HistorySparepartListModel(IReferenceRepository referenceRepository,
            ISparepartRepository sparepartRepository,
            IVehicleRepository vehicleRepository,
            ISPKRepository spkRepository,
            ISPKDetailSparepartRepository spkDetailSparepartRepository, 
            ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _vehicleRepository = vehicleRepository;
            _spkRepository = spkRepository;
            _spkDetailSparepartRepository = spkDetailSparepartRepository;
            _salesReturnRepository = salesReturnRepository;
            _salesReturnDetailRepository = salesReturnDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SparepartViewModel> GetAllSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleViewModel> GetAllVehicle()
        {
            List<Vehicle> result = _vehicleRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public List<SPKDetailSparepartViewModel> SearchHistorySparepart(DateTime? dateFrom, DateTime? dateTo, int vehicleFilter, int sparepartFilter)
        {
            List<SPKDetailSparepart> result = null;
            List<SalesReturnDetail> listReturnSource = null;

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _spkDetailSparepartRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo && c.SPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.Completed && c.SPK.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.CreateDate).ToList();
                listReturnSource = _salesReturnDetailRepository.GetMany(c => c.InvoiceDetail.CreateDate >= dateFrom && c.InvoiceDetail.CreateDate <= dateTo && c.SalesReturn.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.InvoiceDetail.CreateDate).ToList();
                
            }
            else
            {
                result = _spkDetailSparepartRepository.GetMany(c => c.SPK.StatusCompletedId == (int)DbConstant.SPKCompletionStatus.Completed && c.SPK.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.CreateDate).ToList();
                listReturnSource = _salesReturnDetailRepository.GetMany(c => c.SalesReturn.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.InvoiceDetail.CreateDate).ToList();
            }

            if(vehicleFilter != 0)
            {
                result = result.Where(x => x.SPK.VehicleId == vehicleFilter).ToList();
                listReturnSource = listReturnSource.Where(x => x.InvoiceDetail.Invoice.SPK.VehicleId == vehicleFilter).ToList();
            }
            if (sparepartFilter != 0)
            {
                result = result.Where(x => x.SparepartId == sparepartFilter).ToList();
                listReturnSource = listReturnSource.Where(x => x.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartFilter).ToList();
            }

            List<SPKDetailSparepartViewModel> mappedResult = new List<SPKDetailSparepartViewModel>();
            List<SPKDetailSparepartViewModel> listSPK = new List<SPKDetailSparepartViewModel>();
            listSPK = Map(result, mappedResult);

            List<SPKDetailSparepartViewModel> listReturn = listReturnSource
                            .GroupBy(l => l.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId)
                            .Select(cl => new SPKDetailSparepartViewModel
                            {
                                SparepartId = cl.First().InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.SparepartId,
                                SPK = Map(cl.First().InvoiceDetail.Invoice.SPK, new SPKViewModel()),
                                Sparepart = Map(cl.First().InvoiceDetail.SPKDetailSparepartDetail.SparepartDetail.Sparepart, new SparepartViewModel()),
                                TotalQuantity = cl.Count(),
                                TotalPrice = (decimal) cl.Sum(x => x.InvoiceDetail.SubTotalPrice),
                                Category = "Retur"
                            }).ToList();


            List<SPKDetailSparepartViewModel> listMerge = listSPK.Union(listReturn).ToList();
            return listMerge;
        }
    }
}
