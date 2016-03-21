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
    public class FirstBalanceEditorModel : AppBaseModel
    {
        private IJournalMasterRepository _journalMasterRepository;
        private IBalanceJournalRepository _balanceJournalRepository;
        private IBalanceJournalDetailRepository _balanceJournalDetailRepository;
        private IUnitOfWork _unitOfWork;

        public FirstBalanceEditorModel(IJournalMasterRepository journalMasterRepository,
            IBalanceJournalRepository balanceJournalRepository,
            IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _journalMasterRepository = journalMasterRepository;
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRepository = balanceJournalDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<JournalMasterViewModel> RetrieveAllJournal()
        {
            List<JournalMaster> result = _journalMasterRepository.GetAll().ToList();
            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public BalanceJournalViewModel RetrieveFirstBalance(int id)
        {
            BalanceJournal result = _balanceJournalRepository.GetById(id);
            BalanceJournalViewModel mappedResult = new BalanceJournalViewModel();

            return Map(result, mappedResult);
        }

        public List<BalanceJournalDetailViewModel> RetrieveFirstBalanceDetail(int id)
        {
            List<BalanceJournalDetail> result = _balanceJournalDetailRepository.GetMany(bd => bd.ParentId == id).ToList();
            List<BalanceJournalDetailViewModel> mappedResult = new List<BalanceJournalDetailViewModel>();

            return Map(result, mappedResult);
        }

        public void InsertFirstBalance(BalanceJournalViewModel parent,
            List<BalanceJournalDetailViewModel> details, int userId)
        {
            BalanceJournal entity = new BalanceJournal();
            Map(parent, entity);
            entity.IsFirst = true;
            entity.Status = (int)DbConstant.DefaultDataStatus.Active;
            entity.CreateUserId = entity.ModifyUserId = userId;
            entity.CreateDate = entity.ModifyDate = DateTime.Now;
            entity = _balanceJournalRepository.Add(entity);
            _unitOfWork.SaveChanges();

            foreach (var balanceDetail in details)
            {
                BalanceJournalDetail newDetailEntity = new BalanceJournalDetail();
                Map(balanceDetail, newDetailEntity);
                newDetailEntity.ParentId = entity.Id;
                _balanceJournalDetailRepository.Add(newDetailEntity);
            }
            _unitOfWork.SaveChanges();
        }

        public void UpdateFirstBalance(BalanceJournalViewModel parent,
            List<BalanceJournalDetailViewModel> details, int userId)
        {
            BalanceJournal entity = _balanceJournalRepository.GetById(parent.Id);
            Map(parent, entity);
            entity.ModifyUserId = userId;
            entity.ModifyDate = DateTime.Now;
            _balanceJournalRepository.Update(entity);
            _unitOfWork.SaveChanges();

            foreach (var balanceDetail in details)
            {
                if(balanceDetail.Id > 0)
                {
                    BalanceJournalDetail detailEntity = _balanceJournalDetailRepository.GetById(balanceDetail.Id);
                    Map(balanceDetail, detailEntity);
                    _balanceJournalDetailRepository.Update(detailEntity);
                }
                else
                {
                    BalanceJournalDetail detailEntity = new BalanceJournalDetail();
                    Map(balanceDetail, detailEntity);
                    detailEntity.ParentId = entity.Id;
                    _balanceJournalDetailRepository.Add(detailEntity);
                }
            }
            _unitOfWork.SaveChanges();
        }

        public void DeleteFirstBalanceDetail(int detailId)
        {
            BalanceJournalDetail entity = _balanceJournalDetailRepository.GetById(detailId);
            _balanceJournalDetailRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
