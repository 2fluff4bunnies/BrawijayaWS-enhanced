﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class CreditListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private ICustomerRepository _customerRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IUnitOfWork _unitOfWork;

        public CreditListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository,
            ICustomerRepository customerRepository,
            IVehicleGroupRepository vehicleGroupRepository,
            IVehicleDetailRepository vehicleDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _customerRepository = customerRepository;
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

        public List<VehicleGroupViewModel> GetVehicleGroupByCustomer(int customerId)
        {
            List<VehicleGroup> result = _vehicleGroupRepository.GetMany(vg => vg.Status == (int)DbConstant.DefaultDataStatus.Active &&
                vg.CustomerId == customerId).ToList();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            return Map(result, mappedResult);
        }

        public List<InvoiceViewModel> SearchTransaction(DateTime? dateFrom, DateTime? dateTo, int customerId, 
            int vehicleGroupId, string licenseNumber,
            int paymentStatus)
        {
            List<Invoice> result = null;

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _invoiceRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo && (c.Status == (int)DbConstant.InvoiceStatus.Printed || c.Status == (int)DbConstant.InvoiceStatus.HasReturn)).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _invoiceRepository.GetMany(c => (c.Status == (int)DbConstant.InvoiceStatus.Printed || c.Status == (int)DbConstant.InvoiceStatus.HasReturn)).OrderBy(c => c.CreateDate).ToList();
            }

            if (customerId > 0)
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

            if (paymentStatus > -1)
            {
                result = result.Where(inv => inv.PaymentStatus == paymentStatus).ToList();
            }

            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }
    }
}
