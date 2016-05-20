using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Model
{
    public class CreditPaymentListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public CreditPaymentListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, IReferenceRepository referenceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<TransactionViewModel> SearchTransactionByTableRefPK(int referencePK)
        {
            List<Transaction> result = null;

            Reference reference = _referenceRepository.GetMany(x => x.Code == DbConstant.REF_TRANSTBL_INVOICE).FirstOrDefault();
            result = _transactionRepository.GetMany(c => c.ReferenceTableId == reference.Id && c.PrimaryKeyValue == referencePK && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.CreateDate).ToList();

            List<TransactionViewModel> mappedResult = new List<TransactionViewModel>();
            return Map(result, mappedResult);
        }

        public InvoiceViewModel GetLatestInvoiceInfo(int InvoiceID)
        {
            Invoice Invoice = _invoiceRepository
                .GetById(InvoiceID);
            InvoiceViewModel mappedResult = new InvoiceViewModel();
            return Map(Invoice, mappedResult);
        }

        public void DeleteCredit(TransactionViewModel transaction, int userID)
        {
            DateTime serverTime = DateTime.Now;

            Transaction transactionEntity = _transactionRepository.GetById(transaction.Id);
            transactionEntity.ModifyDate = serverTime;
            transactionEntity.ModifyUserId = userID;
            transactionEntity.Status = (int)DbConstant.DefaultDataStatus.Deleted;

            Invoice InvoiceEntity = _invoiceRepository.GetById(transaction.PrimaryKeyValue);
            NeutralizeInvoice(ref InvoiceEntity, transactionEntity);

            _transactionRepository.Update(transactionEntity);
            _invoiceRepository.Update(InvoiceEntity);
            _unitOfWork.SaveChanges();
        }

        public void NeutralizeInvoice(ref Invoice Invoice, Transaction oldTransaction)
        {
            Invoice.TotalHasPaid -= oldTransaction.TotalPayment.AsDecimal();
            if (Invoice.TotalHasPaid != Invoice.TotalPrice)
            {
                Invoice.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }
        }
    }
}
