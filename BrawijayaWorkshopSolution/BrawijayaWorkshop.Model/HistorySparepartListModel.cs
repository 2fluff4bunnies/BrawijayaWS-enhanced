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
        private IUnitOfWork _unitOfWork;

        public HistorySparepartListModel(IReferenceRepository referenceRepository,
            ISparepartRepository sparepartRepository,
            IVehicleRepository vehicleRepository,
            ISPKRepository spkRepository,
            ISPKDetailSparepartRepository spkDetailSparepartRepository, 
            IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _vehicleRepository = vehicleRepository;
            _spkRepository = spkRepository;
            _spkDetailSparepartRepository = spkDetailSparepartRepository;
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

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _spkDetailSparepartRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _spkDetailSparepartRepository.GetAll().OrderBy(c => c.CreateDate).ToList();
            }

            if(vehicleFilter != 0)
            {
                result = result.Where(x => x.SPK.VehicleId == vehicleFilter).ToList();
            }
            if (sparepartFilter != 0)
            {
                result = result.Where(x => x.SparepartId == sparepartFilter).ToList();
            }

            List<SPKDetailSparepartViewModel> mappedResult = new List<SPKDetailSparepartViewModel>();
            return Map(result, mappedResult);
        }
    }
}
