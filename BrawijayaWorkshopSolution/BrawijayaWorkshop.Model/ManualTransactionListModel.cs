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
    public class ManualTransactionListModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private IUnitOfWork _unitOfWork;

        public ManualTransactionListModel(IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository, IUnitOfWork unitOfWork)
            :base()
        {
            _referenceRepository = referenceRepository;
            _transactionRepository = transactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<TransactionViewModel> RetrieveManualTransaction(DateTime from, DateTime to)
        {
            Reference manualRefTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_MANUAL).FirstOrDefault();
            List<Transaction> result = _transactionRepository.GetMany(
                t => t.TransactionDate >= from && t.TransactionDate <= to &&
                    t.ReferenceTableId == manualRefTable.Id).ToList();
            List<TransactionViewModel> mappedResult = new List<TransactionViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteManualTransaction(TransactionViewModel transaction, int userId)
        {
            Transaction entity = _transactionRepository.GetById(transaction.Id);
            entity.ModifyDate = DateTime.Now;
            entity.ModifyUserId = userId;
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _transactionRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
