using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RecapInvoiceBaseModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ICustomerRepository _customerRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartRepository _sparepartRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleRepository _vehicleRepository;

        public RecapInvoiceBaseModel(IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            ICustomerRepository customerRepository,
            IReferenceRepository referenceRepository,
            ISparepartRepository sparepartRepository,
            IVehicleGroupRepository vehicleGroupRepository,
            IVehicleRepository vehicleRepository)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _customerRepository = customerRepository;
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _vehicleRepository = vehicleRepository;
        }

        public List<ReferenceViewModel> RetrieveCategories()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<CustomerViewModel> RetrieveCustomers()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleGroupViewModel> RetrieveVehicleGroupsByCustomerId(int customerId)
        {
            List<VehicleGroup> result = _vehicleGroupRepository.GetMany(vg => vg.CustomerId == customerId &&
                vg.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleViewModel> RetrieveVehiclesByCustomerId(int customerId)
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                v.CustomerId == customerId).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        private List<InvoiceSparepartViewModel> GetInvoiceSparepartList(int invoiceID)
        {
            List<InvoiceSparepartViewModel> result = new List<InvoiceSparepartViewModel>();
            List<InvoiceDetail> listInvoiceDetail = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();

            int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId).Distinct().ToArray();
            foreach (var sparepartID in sparepartIDs)
            {
                result.Add(new InvoiceSparepartViewModel
                {
                    SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                    Qty = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Count(),
                    NominalFee = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Sum(x => x.FeePctg > 0 ? (100 / (100 + x.FeePctg)) * x.SubTotalPrice : 0),
                    SubTotalPrice = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SparepartDetail.SparepartId == sparepartID).Sum(x => x.SubTotalPrice),
                    SparepartCode = _sparepartRepository.GetById(sparepartID).Code,
                    UnitCategoryName = _sparepartRepository.GetById(sparepartID).UnitReference.Name,
                });
            }
            return result;
        }

        public List<RecapInvoiceItemViewModel> RetrieveRecap(DateTime dateFrom, DateTime dateTo, int categoryId,
            int customerId, int vehicleGroupId = 0, int vehicleId = 0)
        {
            List<Invoice> result = null;

            if (categoryId == -1)
            {
                result =_invoiceRepository.GetMany(i =>
                DbFunctions.TruncateTime(i.CreateDate) >= DbFunctions.TruncateTime(dateFrom) &&
                DbFunctions.TruncateTime(i.CreateDate) <= DbFunctions.TruncateTime(dateTo) &&
                i.Status != (int)DbConstant.DefaultDataStatus.Deleted &&
                i.PaymentStatus != (int)DbConstant.PaymentStatus.Settled).ToList();
            }
            else
            {
                result = _invoiceRepository.GetMany(i =>
                DbFunctions.TruncateTime(i.CreateDate) >= DbFunctions.TruncateTime(dateFrom) &&
                DbFunctions.TruncateTime(i.CreateDate) <= DbFunctions.TruncateTime(dateTo) &&
                i.Status != (int)DbConstant.DefaultDataStatus.Deleted &&
                i.PaymentStatus != (int)DbConstant.PaymentStatus.Settled &&
                i.SPK.CategoryReferenceId == categoryId && i.SPK.Vehicle.CustomerId == customerId).ToList();
            }

            if (vehicleGroupId > 0)
            {
                result = result.Where(i => i.SPK.VehicleGroupId == vehicleGroupId).ToList();
            }
            if (vehicleId > 0)
            {
                result = result.Where(i => i.SPK.VehicleId == vehicleId).ToList();
            }
            result = result.OrderBy(i => i.CreateDate).ToList();

            List<InvoiceViewModel> mappedInvoice = new List<InvoiceViewModel>();
            Map(result, mappedInvoice);

            List<RecapInvoiceItemViewModel> mappedResult = new List<RecapInvoiceItemViewModel>();

            foreach (var item in mappedInvoice)
            {
                List<InvoiceSparepartViewModel> listSparepart = GetInvoiceSparepartList(item.Id);
                foreach (var sparepart in listSparepart)
                {
                    decimal nominalWithoutFee = sparepart.SubTotalPrice.AsDecimal() + sparepart.NominalFee.AsDecimal();
                    decimal fee = nominalWithoutFee * 0.1M;
                    mappedResult.Add(new RecapInvoiceItemViewModel
                    {
                        Invoice = item,
                        Customer = item.SPK.Vehicle.Customer,
                        VehicleGroup = item.SPK.VehicleGroup,
                        ItemName = sparepart.SparepartName,
                        Quantity = sparepart.Qty,
                        NominalFee = fee,
                        SubTotalWithFee = nominalWithoutFee + fee,
                        SubTotalWithoutFee = nominalWithoutFee
                    });
                }

                if (item.TotalService > 0)
                {
                    decimal fee = 0;
                    decimal nominalWithoutFee = 0;

                    if (item.SPK.isContractWork)
                    {
                        nominalWithoutFee = item.TotalService + (item.TotalService * 0.2M);
                        fee = nominalWithoutFee * 0.1M;
                    }
                    else
                    {
                        nominalWithoutFee = item.TotalService;
                        fee = nominalWithoutFee * 0.1M;
                    }

                    mappedResult.Add(new RecapInvoiceItemViewModel
                    {
                        Invoice = item,
                        Customer = item.SPK.Vehicle.Customer,
                        VehicleGroup = item.SPK.VehicleGroup,
                        ItemName = item.SPK.isContractWork ? "Gaji Tukang Borongan" : "Gaji Tukang Harian",
                        Quantity = 1,
                        NominalFee = fee,
                        SubTotalWithFee = nominalWithoutFee + fee,
                        SubTotalWithoutFee = nominalWithoutFee
                    });
                }
            }

            return mappedResult;
        }
    }
}
