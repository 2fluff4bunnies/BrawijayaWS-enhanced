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
    public class RecapInvoiceBySPKModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;

        public RecapInvoiceBySPKModel(IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
        }

        public List<InvoiceViewModel> RetrieveRecap(DateTime dateFrom, DateTime dateTo, int vehicleId)
        {
            List<Invoice> result = _invoiceRepository.GetMany(i => i.CreateDate >= dateFrom && i.CreateDate <= dateTo &&
                i.Status == (int)DbConstant.DefaultDataStatus.Active &&
                i.PaymentStatus != (int)DbConstant.PaymentStatus.Settled &&
                i.SPK.VehicleId == vehicleId).OrderBy(i => i.CreateDate).ToList();
            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }
    }
}
