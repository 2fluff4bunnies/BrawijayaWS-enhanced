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
        private IUnitOfWork _unitOfWork;

        public InvoiceListModel(IInvoiceRepository invoiceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<InvoiceViewModel> SearchInvoice(DateTime? dateFrom, DateTime? dateTo, DbConstant.InvoiceStatus invoiceStatus)
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

            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }
    }
}
