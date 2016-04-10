using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class ProfitLossModel : BalanceSheetBaseModel
    {
        public ProfitLossModel(IBalanceJournalRepository balanceJournalRepository,
            IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IInvoiceRepository invoiceRepository,
            IUnitOfWork unitOfWork)
            : base(balanceJournalRepository, balanceJournalDetailRepository, journalMasterRepository,
                   referenceRepository, purchasingRepository, sparepartRepository, sparepartDetailRepository,
                   transactionRepository, transactionDetailRepository, invoiceRepository, unitOfWork) { }

        public List<BalanceSheetDetailViewModel> RetrieveProfitLoss(int headerId)
        {
            List<JournalMaster> allJournalMaster = _journalMasterRepository.GetAll().ToList();

            List<BalanceJournalDetailViewModel> mappedResult = base.RetrieveBalanceJournalDetailsByHeaderId(headerId);
            List<BalanceSheetDetailViewModel> formattedResult = new List<BalanceSheetDetailViewModel>();

            Reference catServiceJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_SERVICE).FirstOrDefault();
            Reference catCostJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_COST).FirstOrDefault();
            Reference catIncomeJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_INCOME).FirstOrDefault();

            List<Reference> listServiceJournal = _referenceRepository.GetMany(r => r.ParentId == catServiceJournal.Id).ToList();
            List<Reference> listCostJournal = _referenceRepository.GetMany(r => r.ParentId == catCostJournal.Id).ToList();
            List<Reference> listIncomeJournal = _referenceRepository.GetMany(r => r.ParentId == catIncomeJournal.Id).ToList();

            BalanceSheetViewModel headerService = new BalanceSheetViewModel();
            headerService.GroupName = "1. Penjualan";

            foreach (var item in listServiceJournal)
            {
                BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                detail.Header = headerService;
                JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                detail.Name = currentJournal.Name;

                List<int> cachedItems = new List<int>();
                foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                {
                    if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                    {
                        decimal currentAmount = (itemBalance.LastCredit ?? 0) - (itemBalance.LastDebit ?? 0);
                        detail.Amount += currentAmount;

                        cachedItems.Add(itemBalance.Id);
                    }
                }

                foreach (var iCache in cachedItems)
                {
                    BalanceJournalDetailViewModel current = mappedResult.Where(m => m.Id == iCache).FirstOrDefault();
                    int iCacheIndex = mappedResult.IndexOf(current);
                    current.IsChecked = true;
                    mappedResult[iCacheIndex] = current;
                }

                formattedResult.Add(detail);
            }

            BalanceSheetViewModel headerCost = new BalanceSheetViewModel();
            headerCost.GroupName = "2. Biaya Umum & Administrasi";

            foreach (var item in listCostJournal)
            {
                BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                detail.Header = headerCost;
                JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                detail.Name = currentJournal.Name;

                List<int> cachedItems = new List<int>();
                foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                {
                    if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                    {
                        decimal currentAmount = (itemBalance.LastCredit ?? 0) - (itemBalance.LastDebit ?? 0);
                        detail.Amount += currentAmount;

                        cachedItems.Add(itemBalance.Id);
                    }
                }

                foreach (var iCache in cachedItems)
                {
                    BalanceJournalDetailViewModel current = mappedResult.Where(m => m.Id == iCache).FirstOrDefault();
                    int iCacheIndex = mappedResult.IndexOf(current);
                    current.IsChecked = true;
                    mappedResult[iCacheIndex] = current;
                }

                formattedResult.Add(detail);
            }

            BalanceSheetViewModel headerIncome = new BalanceSheetViewModel();
            headerIncome.GroupName = "3. Pendapatan";

            foreach (var item in listIncomeJournal)
            {
                BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                detail.Header = headerIncome;
                JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                detail.Name = currentJournal.Name;

                List<int> cachedItems = new List<int>();
                foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                {
                    if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                    {
                        decimal currentAmount = (itemBalance.LastCredit ?? 0) - (itemBalance.LastDebit ?? 0);
                        detail.Amount += currentAmount;

                        cachedItems.Add(itemBalance.Id);
                    }
                }

                foreach (var iCache in cachedItems)
                {
                    BalanceJournalDetailViewModel current = mappedResult.Where(m => m.Id == iCache).FirstOrDefault();
                    int iCacheIndex = mappedResult.IndexOf(current);
                    current.IsChecked = true;
                    mappedResult[iCacheIndex] = current;
                }

                formattedResult.Add(detail);
            }

            return formattedResult;
        }
    }
}
