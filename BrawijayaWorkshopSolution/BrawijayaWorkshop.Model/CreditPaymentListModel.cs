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
    public class CreditPaymentListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IUnitOfWork _unitOfWork;

        public CreditPaymentListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<TransactionViewModel> SearchTransactionByTableRef(int referenceId)
        {
            List<Transaction> result = null;

            result = _transactionRepository.GetMany(c => c.ReferenceTableId == referenceId).OrderBy(c => c.CreateDate).ToList();


            List<TransactionViewModel> mappedResult = new List<TransactionViewModel>();
            return Map(result, mappedResult);
        }
    }
}
