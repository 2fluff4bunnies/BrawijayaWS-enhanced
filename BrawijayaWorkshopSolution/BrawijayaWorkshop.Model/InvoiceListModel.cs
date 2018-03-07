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
    public class InvoiceListModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ICustomerRepository _customerRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IUnitOfWork _unitOfWork;

        public InvoiceListModel(IInvoiceRepository invoiceRepository, IInvoiceDetailRepository invoiceDetailRepository,
            ICustomerRepository customerRepository, ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository,
            IVehicleGroupRepository vehicleGroupRepository,
            IVehicleDetailRepository vehicleDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _customerRepository = customerRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetAllCustomer()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public void Print(int[] invoiceIDs)
        {
            foreach (var id in invoiceIDs)
            {
                Invoice invoice = _invoiceRepository.GetById(id);
                invoice.Status = (int)DbConstant.InvoiceStatus.Printed;
                _invoiceRepository.Update(invoice);
            }
            _unitOfWork.SaveChanges();
        }

        public List<InvoiceSparepartViewModel> GetInvoiceSparepartList(int invoiceID)
        {
            List<InvoiceSparepartViewModel> result = new List<InvoiceSparepartViewModel>();
            List<InvoiceDetail> listInvoiceDetail = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();

            int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId).Distinct().ToArray();
            foreach (var sparepartID in sparepartIDs)
            {
                result.Add(new InvoiceSparepartViewModel
                {
                    SparepartName = _sparepartRepository.GetById(sparepartID).Name,
                    Qty = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count(),
                    SubTotalPrice = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Sum(x => x.SubTotalPrice),
                    SparepartCode = _sparepartRepository.GetById(sparepartID).Code,
                    UnitCategoryName = _sparepartRepository.GetById(sparepartID).UnitReference.Name
                });
            }
            return result;
        }

        public List<InvoiceViewModel> SearchInvoice(DateTime? dateFrom, DateTime? dateTo,
            DbConstant.InvoiceStatus invoiceStatus, int customerId, 
            int serviceCategoryId, int vehicleGroupId, string licenseNumber,
            int paymentStatus)
        {
            List<Invoice> result = null;

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _invoiceRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _invoiceRepository.GetAll().OrderBy(c => c.CreateDate).ToList();
            }

            if ((int)invoiceStatus != 9)
            {
                result = result.Where(spk => spk.Status == (int)invoiceStatus).ToList();
            }

            if(customerId > 0)
            {
                result = result.Where(inv => inv.SPK.Vehicle.CustomerId == customerId).ToList();
            }

            if (vehicleGroupId > 0)
            {
                result = result.Where(inv => inv.SPK.Vehicle.VehicleGroupId == vehicleGroupId).ToList();
            }

            if (!string.IsNullOrEmpty(licenseNumber))
            {
                VehicleDetail vehicleDetail = _vehicleDetailRepository.GetMany(v => string.Compare(v.LicenseNumber, licenseNumber, true) == 1
                                                                                    && v.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                if (vehicleDetail != null)
                {
                    result = result.Where(inv => inv.SPK.VehicleId == vehicleDetail.VehicleId).ToList();
                }
            }

            if (serviceCategoryId > 0)
            {
                result = result.Where(inv => inv.SPK.CategoryReferenceId == serviceCategoryId).ToList();
            }

            if(paymentStatus > -1)
            {
                result = result.Where(inv => inv.PaymentStatus == paymentStatus).ToList();
            }

            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }

        public List<InvoiceDetailViewModel> GetInvoiceDetailsByParentId(int invoiceId)
        {
            List<InvoiceDetail> result = _invoiceDetailRepository.GetMany(invd =>
                invd.Status == (int)DbConstant.DefaultDataStatus.Active &&
                invd.InvoiceId == invoiceId).ToList();
            List<InvoiceDetailViewModel> mappedResult = new List<InvoiceDetailViewModel>();
            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> GetServiceCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleGroupViewModel> GetVehicleGroupByCustomer(int customerId)
        {
            List<VehicleGroup> result = _vehicleGroupRepository.GetMany(vg => vg.Status == (int)DbConstant.DefaultDataStatus.Active &&
                vg.CustomerId == customerId).ToList();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            return Map(result, mappedResult);
        }
    }
}
