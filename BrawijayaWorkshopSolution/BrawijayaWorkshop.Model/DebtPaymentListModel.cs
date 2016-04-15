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
    public class DebtPaymentListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public DebtPaymentListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<TransactionViewModel> SearchTransactionByTableRefPK(int referencePK)
        {
            List<Transaction> result = null;
            Reference reference = _referenceRepository.GetMany(x => x.Code == DbConstant.REF_TRANSTBL_PURCHASING).FirstOrDefault();
            result = _transactionRepository.GetMany(c => c.PrimaryKeyValue == referencePK && c.ReferenceTableId == reference.Id
                && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.CreateDate).ToList();

            List<TransactionViewModel> mappedResult = new List<TransactionViewModel>();
            return Map(result, mappedResult);
        }

        public PurchasingViewModel GetLatestPurchasingInfo(int purchasingID)
        {
            Purchasing purchasing = _purchasingRepository
                .GetById(purchasingID);
            PurchasingViewModel mappedResult = new PurchasingViewModel();
            return Map(purchasing, mappedResult);
        }

        public void DeleteDebt(TransactionViewModel transaction, int userID)
        {
            DateTime serverTime = DateTime.Now;

            Transaction transactionEntity = _transactionRepository.GetById(transaction.Id);
            transactionEntity.ModifyDate = serverTime;
            transactionEntity.ModifyUserId = userID;
            transactionEntity.Status = (int)DbConstant.DefaultDataStatus.Deleted;

            Purchasing purchasingEntity = _purchasingRepository.GetById(transaction.PrimaryKeyValue);
            NeutralizePurchasing(ref purchasingEntity, transactionEntity);

            _transactionRepository.Update(transactionEntity);
            _purchasingRepository.Update(purchasingEntity);
            _unitOfWork.SaveChanges();
        }

        public void NeutralizePurchasing(ref Purchasing purchasing, Transaction oldTransaction)
        {
            purchasing.TotalHasPaid -= oldTransaction.TotalPayment.AsDecimal();
            if (purchasing.TotalHasPaid != purchasing.TotalPrice)
            {
                purchasing.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            }
        }
    }
}
