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
    public class ManualTransactionEditorModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public ManualTransactionEditorModel(IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<JournalMasterViewModel> RetrieveAllJournal()
        {
            List<JournalMaster> result = _journalMasterRepository.GetMany(j => j.ParentId.HasValue).ToList();
            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public List<TransactionDetailViewModel> RetrieveTransactionDetail(int transactionId)
        {
            List<TransactionDetail> result = _transactionDetailRepository.GetMany(td => td.ParentId == transactionId).ToList();
            List<TransactionDetailViewModel> mappedResult = new List<TransactionDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertTransaction(TransactionViewModel parentTransaction,
            List<TransactionDetailViewModel> detailTransactionList, int userId)
        {
            Reference refTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_MANUAL).FirstOrDefault();

            Transaction parentEntity = new Transaction();
            Map(parentTransaction, parentEntity);
            parentEntity.CreateUserId = userId;
            parentEntity.CreateDate = DateTime.Now;
            parentEntity.ReferenceTableId = refTable.Id;
            parentEntity.Status = (int)DbConstant.DefaultDataStatus.Active;
            parentEntity = _transactionRepository.Add(parentEntity);

            // update primary key value into previous inserted transaction id
            parentEntity.PrimaryKeyValue = parentEntity.Id;
            _transactionRepository.Update(parentEntity);

            foreach (var detailTransaction in detailTransactionList)
            {
                TransactionDetail detailEntity = new TransactionDetail();
                Map(detailTransaction, detailEntity);
                detailEntity.ParentId = parentEntity.Id;
                _transactionDetailRepository.Add(detailEntity);
            }

            _unitOfWork.SaveChanges();
        }

        public void UpdateTransaction(TransactionViewModel parentTransaction,
            List<TransactionDetailViewModel> detailTransactionList, int userId)
        {
            Transaction parentEntity = _transactionRepository.GetById(parentTransaction.Id);
            Map(parentTransaction, parentEntity);
            parentEntity.ModifyUserId = userId;
            parentEntity.ModifyDate = DateTime.Now;
            _transactionRepository.Update(parentEntity);

            foreach (var detailTransaction in detailTransactionList)
            {
                TransactionDetail detailEntity = _transactionDetailRepository.GetById(detailTransaction.Id);
                Map(detailTransaction, detailEntity);
                _transactionDetailRepository.Update(detailEntity);
            }

            _unitOfWork.SaveChanges();
        }
    }
}
