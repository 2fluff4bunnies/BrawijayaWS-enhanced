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
    public class BalanceSheetModel : BalanceSheetBaseModel
    {
        public BalanceSheetModel(IBalanceJournalRepository balanceJournalRepository,
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

        public List<BalanceSheetDetailViewModel> RetrieveBalance(int headerId, bool isActiva)
        {
            List<JournalMaster> allJournalMaster = _journalMasterRepository.GetAll().ToList();

            List<BalanceJournalDetailViewModel> mappedResult = base.RetrieveBalanceJournalDetailsByHeaderId(headerId);
            List<BalanceSheetDetailViewModel> formattedResult = new List<BalanceSheetDetailViewModel>();

            Reference catCurrentAssetJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_CURRENTASSET).FirstOrDefault();
            Reference catFixedAssetJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_FIXEDASSET).FirstOrDefault();
            Reference catObligationJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_OBLIGATION).FirstOrDefault();
            Reference catFundJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_FUND).FirstOrDefault();

            List<Reference> listCurrentAssetJournal = _referenceRepository.GetMany(r => r.ParentId == catCurrentAssetJournal.Id).ToList();
            List<Reference> listFixedAssetJournal = _referenceRepository.GetMany(r => r.ParentId == catFixedAssetJournal.Id).ToList();
            List<Reference> listObligationJournal = _referenceRepository.GetMany(r => r.ParentId == catObligationJournal.Id).ToList();
            List<Reference> listFundJournal = _referenceRepository.GetMany(r => r.ParentId == catFundJournal.Id).ToList();

            if (isActiva)
            {
                BalanceSheetViewModel headerCurrentAsset = new BalanceSheetViewModel();
                headerCurrentAsset.GroupName = "Aktiva Lancar";

                foreach (var item in listCurrentAssetJournal)
                {
                    BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                    detail.Header = headerCurrentAsset;
                    JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                    detail.Name = currentJournal.Name;

                    List<int> cachedItems = new List<int>();
                    foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                    {
                        if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                        {
                            detail.Amount += Math.Abs(itemBalance.LastDebit ?? 0 - itemBalance.LastCredit ?? 0);

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

                BalanceSheetViewModel headerFixedAsset = new BalanceSheetViewModel();
                headerFixedAsset.GroupName = "Aktiva Tetap";

                foreach (var item in listFixedAssetJournal)
                {
                    BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                    detail.Header = headerFixedAsset;
                    JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                    detail.Name = currentJournal.Name;

                    List<int> cachedItems = new List<int>();
                    foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                    {
                        if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                        {
                            detail.Amount += Math.Abs(itemBalance.LastDebit ?? 0 - itemBalance.LastCredit ?? 0);

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
            }
            else
            {
                BalanceSheetViewModel headerObligation = new BalanceSheetViewModel();
                headerObligation.GroupName = "Kewajiban";

                foreach (var item in listObligationJournal)
                {
                    BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                    detail.Header = headerObligation;
                    JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                    detail.Name = currentJournal.Name;

                    List<int> cachedItems = new List<int>();
                    foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                    {
                        if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                        {
                            detail.Amount += Math.Abs(itemBalance.LastDebit ?? 0 - itemBalance.LastCredit ?? 0);

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

                BalanceSheetViewModel headerFund = new BalanceSheetViewModel();
                headerFund.GroupName = "Modal";

                foreach (var item in listFundJournal)
                {
                    BalanceSheetDetailViewModel detail = new BalanceSheetDetailViewModel();
                    detail.Header = headerFund;
                    JournalMaster currentJournal = allJournalMaster.Where(j => j.Code == item.Value).FirstOrDefault();
                    detail.Name = currentJournal.Name;

                    List<int> cachedItems = new List<int>();
                    foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                    {
                        if (base.IsCurrentJournalValid(itemBalance.Journal, item.Value))
                        {
                            detail.Amount += Math.Abs(itemBalance.LastDebit ?? 0 - itemBalance.LastCredit ?? 0);

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
            }

            return formattedResult;
        }
    }
}
