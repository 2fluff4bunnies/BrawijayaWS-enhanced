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
    public class SalesReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private ISalesReturnRepository _salesReturnRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, ISalesReturnRepository salesReturnRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _salesReturnRepository = salesReturnRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SalesReturnViewModel> SearchSalesReturnList(DateTime? dateFrom, DateTime? dateTo)
        {
            List<SalesReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                result = _salesReturnRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _salesReturnRepository.GetAll().OrderBy(c => c.Date).ToList();
            }

            List<SalesReturnViewModel> mappedResult = new List<SalesReturnViewModel>();
            return Map(result, mappedResult);
        }
    }
}
