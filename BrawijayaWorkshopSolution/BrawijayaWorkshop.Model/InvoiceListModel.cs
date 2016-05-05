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
    public class InvoiceListModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ICustomerRepository _customerRepository;
        private IUnitOfWork _unitOfWork;

        public InvoiceListModel(IInvoiceRepository invoiceRepository, IInvoiceDetailRepository invoiceDetailRepository,
            ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetAllCustomer()
        {
            List<Customer> result = _customerRepository.GetAll().ToList();
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

        public List<InvoiceViewModel> SearchInvoice(DateTime? dateFrom, DateTime? dateTo,
            DbConstant.InvoiceStatus invoiceStatus, int customerId, int paymentStatus)
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
    }
}
