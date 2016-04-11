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
    public class FirstBalanceListModel : AppBaseModel
    {
        private IBalanceJournalRepository _balanceJournalRepository;
        private IBalanceJournalDetailRepository _balanceJournalDetailRespository;
        private IUnitOfWork _unitOfWork;

        public FirstBalanceListModel(IBalanceJournalRepository balanceJournalRepository,
            IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRespository = balanceJournalDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public BalanceJournalViewModel RetrieveFirstBalance()
        {
            BalanceJournal result = _balanceJournalRepository.GetMany(b => b.IsFirst &&
                b.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            BalanceJournalViewModel mappedResult = new BalanceJournalViewModel();
            return Map(result, mappedResult);
        }

        public List<BalanceJournalDetailViewModel> RetrieveFirstBalanceDetail(int id)
        {
            List<BalanceJournalDetail> result = _balanceJournalDetailRespository.GetMany(bd => bd.ParentId == id).ToList();
            List<BalanceJournalDetailViewModel> mappedResult = new List<BalanceJournalDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteFirstBalanceJournal(BalanceJournalViewModel selectedFirstBalanceJournal, int userId)
        {
            BalanceJournal entity = _balanceJournalRepository.GetById(selectedFirstBalanceJournal.Id);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyUserId = userId;
            entity.ModifyDate = DateTime.Now;
            _balanceJournalRepository.AttachNavigation<User>(entity.CreateUser);
            _balanceJournalRepository.AttachNavigation<User>(entity.ModifyUser);
            _balanceJournalRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
