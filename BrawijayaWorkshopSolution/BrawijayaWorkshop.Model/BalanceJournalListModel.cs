using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BalanceJournalListModel : AppBaseModel
    {
        private IBalanceJournalRepository _balanceJournalRepository;
        private IBalanceJournalDetailRepository _balanceJournalDetailRepository;

        private IJournalMasterRepository _journalMasterRepository;
        private IReferenceRepository _referenceRepository;

        private IPurchasingRepository _purchasingRepository;

        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;

        private IUnitOfWork _unitOfWork;

        public BalanceJournalListModel(IBalanceJournalRepository balanceJournalRepository, IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRepository = balanceJournalDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _purchasingRepository = purchasingRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public Dictionary<int, string> GenerateMonth()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            for (int i = 1; i <= 12; i++)
            {
                result.Add(i, DateTimeFormatInfo.CurrentInfo.GetMonthName(i));
            }
            return result;
        }

        public List<int> GenerateYear()
        {
            List<int> result = new List<int>();
            for (int i = 2016; i <= DateTime.Today.Year; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public BalanceJournalViewModel RetrieveBalanceJournalHeader(int month, int year)
        {
            BalanceJournal result = _balanceJournalRepository.GetMany(bj => bj.Month == month && bj.Year == year &&
                bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            BalanceJournalViewModel mappedResult = new BalanceJournalViewModel();
            return Map(result, mappedResult);
        }

        public List<BalanceJournalDetailViewModel> RetrieveBalanceJournalDetailsByHeaderId(int headerId)
        {
            List<BalanceJournalDetail> result = _balanceJournalDetailRepository.GetMany(bj => bj.JournalId == headerId).ToList();
            List<BalanceJournalDetailViewModel> mappedResult = new List<BalanceJournalDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void RecalculateBalanceJournal(int month, int year, int userId)
        {
            
        }

        public void DeleteBalanceJournal(int headerId, int userId)
        {
            
        }
    }
}
