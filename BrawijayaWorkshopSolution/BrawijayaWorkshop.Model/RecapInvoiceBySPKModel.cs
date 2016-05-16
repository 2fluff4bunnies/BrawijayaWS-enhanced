using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class RecapInvoiceBySPKModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ICustomerRepository _customerRepository;

        public RecapInvoiceBySPKModel(IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            ICustomerRepository customerRepository)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _customerRepository = customerRepository;
        }

        public List<CustomerViewModel> RetrieveCustomers()
        {
            List<Customer> result = _customerRepository.GetAll().ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public List<InvoiceViewModel> RetrieveRecap(DateTime dateFrom, DateTime dateTo, int customerId)
        {
            List<Invoice> result = _invoiceRepository.GetMany(i => i.CreateDate >= dateFrom && i.CreateDate <= dateTo &&
                i.Status == (int)DbConstant.DefaultDataStatus.Active &&
                i.PaymentStatus != (int)DbConstant.PaymentStatus.Settled &&
                i.SPK.Vehicle.CustomerId == customerId).OrderBy(i => i.CreateDate).ToList();
            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }
    }
}
