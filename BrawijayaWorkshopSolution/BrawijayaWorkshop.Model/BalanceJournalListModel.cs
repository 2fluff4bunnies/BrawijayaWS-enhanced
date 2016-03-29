using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BalanceJournalListModel : BalanceSheetBaseModel
    {
        public BalanceJournalListModel(IBalanceJournalRepository balanceJournalRepository,
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

        public List<BalanceJournalDetailViewModel> RetrieveFormattedBalanceJournalDetailsByHeaderId(int headerId)
        {
            List<BalanceJournalDetailViewModel> mappedResult = base.RetrieveBalanceJournalDetailsByHeaderId(headerId);
            List<BalanceJournalDetailViewModel> formattedResult = new List<BalanceJournalDetailViewModel>();

            Reference catBalanceSheetJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_BALANCESHEET).FirstOrDefault();
            List<Reference> listBalanceSheetJournal = _referenceRepository.GetMany(r => r.ParentId == catBalanceSheetJournal.Id).ToList();

            foreach (var itemJournal in listBalanceSheetJournal)
            {
                BalanceJournalDetailViewModel itemResult = new BalanceJournalDetailViewModel();
                itemResult.ParentId = headerId;

                List<int> cachedItems = new List<int>();
                foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                {
                    if(base.IsCurrentJournalValid(itemBalance.Journal, itemJournal.Value))
                    {
                        itemResult.FirstDebit += itemBalance.FirstDebit ?? 0;
                        itemResult.FirstCredit += itemBalance.FirstCredit ?? 0;
                        itemResult.MutationDebit += itemBalance.MutationDebit ?? 0;
                        itemResult.MutationCredit += itemBalance.MutationCredit ?? 0;
                        itemResult.BalanceAfterMutationDebit += itemBalance.BalanceAfterMutationDebit ?? 0;
                        itemResult.BalanceAfterMutationCredit += itemBalance.BalanceAfterMutationCredit ?? 0;
                        itemResult.ReconciliationDebit += itemBalance.ReconciliationDebit ?? 0;
                        itemResult.ReconciliationCredit += itemBalance.ReconciliationCredit ?? 0;
                        itemResult.BalanceAfterReconciliationDebit += itemBalance.BalanceAfterReconciliationDebit ?? 0;
                        itemResult.BalanceAfterReconciliationCredit += itemBalance.BalanceAfterReconciliationCredit ?? 0;
                        itemResult.ProfitLossDebit += itemBalance.ProfitLossDebit ?? 0;
                        itemResult.ProfitLossCredit += itemBalance.ProfitLossCredit ?? 0;
                        itemResult.LastDebit += itemBalance.LastDebit ?? 0;
                        itemResult.LastCredit += itemBalance.LastCredit ?? 0;

                        cachedItems.Add(itemBalance.Id);
                    }
                }

                formattedResult.Add(itemResult);

                foreach (var iCache in cachedItems)
                {
                    BalanceJournalDetailViewModel current = mappedResult.Where(m => m.Id == iCache).FirstOrDefault();
                    int iCacheIndex = mappedResult.IndexOf(current);
                    current.IsChecked = true;
                    mappedResult[iCacheIndex] = current;
                }
            }

            return formattedResult;
        }
    }
}
