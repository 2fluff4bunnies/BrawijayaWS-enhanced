using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BalanceSheetBaseModel : AppBaseModel
    {
        protected IBalanceJournalRepository _balanceJournalRepository;
        protected IBalanceJournalDetailRepository _balanceJournalDetailRepository;

        protected IJournalMasterRepository _journalMasterRepository;
        protected IReferenceRepository _referenceRepository;

        protected IPurchasingRepository _purchasingRepository;

        protected ISparepartRepository _sparepartRepository;
        protected ISparepartDetailRepository _sparepartDetailRepository;

        protected ITransactionRepository _transactionRepository;
        protected ITransactionDetailRepository _transactionDetailRepository;

        protected IInvoiceRepository _invoiceRepository;

        protected IUnitOfWork _unitOfWork;

        public BalanceSheetBaseModel(IBalanceJournalRepository balanceJournalRepository, IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IInvoiceRepository invoiceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _balanceJournalRepository = balanceJournalRepository;
            _balanceJournalDetailRepository = balanceJournalDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _purchasingRepository = purchasingRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _invoiceRepository = invoiceRepository;
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

        public BalanceJournalViewModel RetrieveBalanceJournalHeaderById(int headerId)
        {
            BalanceJournal result = _balanceJournalRepository.GetById(headerId);
            BalanceJournalViewModel mappedResult = new BalanceJournalViewModel();
            return Map(result, mappedResult);
        }

        public JournalMasterViewModel RetrieveJournalByCode(string code)
        {
            JournalMaster result = _journalMasterRepository.GetMany(jm => jm.Code == code).FirstOrDefault();
            JournalMasterViewModel mappedResult = new JournalMasterViewModel();
            return Map(result, mappedResult);
        }

        public List<BalanceJournalDetailViewModel> RetrieveBalanceJournalDetailsByHeaderId(int headerId)
        {
            List<BalanceJournalDetail> result = _balanceJournalDetailRepository.GetMany(bj => bj.ParentId == headerId).ToList();
            List<BalanceJournalDetailViewModel> mappedResult = new List<BalanceJournalDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void RecalculateBalanceJournal(int month, int year, int userId)
        {
            // harus pake using, dibiarin aja gak usah try catch commit rollback, kata nya sih udah otomatis
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    BalanceJournalViewModel prevCalculated = RetrieveBalanceJournalHeader(month, year);
                    if (prevCalculated != null)
                    {
                        DeleteBalanceJournal(prevCalculated.Id, userId);
                    }

                    DateTime firstDay = new DateTime(year, month, 1);
                    DateTime lastDay = firstDay.AddMonths(1).AddSeconds(-1);
                    DateTime prevMonth = firstDay.AddDays(-1);

                    List<JournalMaster> listAllJournal = _journalMasterRepository.GetAll().ToList();
                    List<JournalMasterViewModel> mappedListAllJournal = new List<JournalMasterViewModel>();
                    Map(listAllJournal, mappedListAllJournal);

                    Reference catJournalService = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_SERVICE).FirstOrDefault();
                    Reference catJournalCost = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_COST).FirstOrDefault();
                    Reference catJournalIncome = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_INCOME).FirstOrDefault();

                    List<string> catJournalServiceCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalService.Id).Select(r => r.Value).ToList();
                    List<string> catJournalCostCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalCost.Id).Select(r => r.Value).ToList();
                    List<string> catJournalIncomeCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalIncome.Id).Select(r => r.Value).ToList();

                    // calculate neraca
                    // ------------------------------------------------------------------------------
                    // List semua akun jurnal dari tabel transaksi
                    List<TransactionDetail> listTransaction = _transactionDetailRepository.GetMany(t =>
                        t.Parent.TransactionDate >= firstDay && t.Parent.TransactionDate <= lastDay &&
                        t.Parent.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

                    var journalTransactionList = listTransaction.DistinctBy(t => t.JournalId).Select(t => t.JournalId);
                    List<BalanceJournalDetailViewModel> tempListBalanceDetailViewModel = new List<BalanceJournalDetailViewModel>();
                    foreach (var item in journalTransactionList)
                    {
                        BalanceJournalDetailViewModel detailViewModel = new BalanceJournalDetailViewModel();
                        detailViewModel.JournalId = item;
                        tempListBalanceDetailViewModel.Add(detailViewModel);
                    }
                    // end init semua akun

                    // 1. Ambil Saldo Awal dari Saldo Akhir Bulan Sebelumnya
                    BalanceJournal lastJournal = _balanceJournalRepository.GetMany(bj =>
                        bj.Month == prevMonth.Month && bj.Year == prevMonth.Year &&
                        bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

                    if (lastJournal != null)
                    {
                        // check apakah semua jurnal di last journal ada di temp list
                        List<BalanceJournalDetail> lastJournalDetail = _balanceJournalDetailRepository.GetMany(bjd => bjd.ParentId == lastJournal.Id).ToList();
                        foreach (var item in lastJournalDetail)
                        {
                            if (tempListBalanceDetailViewModel.Where(temp => temp.JournalId == item.JournalId).Count() == 0)
                            {
                                JournalMasterViewModel mappedJournal = new JournalMasterViewModel();
                                tempListBalanceDetailViewModel.Add(new BalanceJournalDetailViewModel
                                {
                                    Journal = Map(item.Journal, mappedJournal),
                                    JournalId = item.JournalId
                                });
                            }
                        }

                        // update temp list untuk saldo awal
                        foreach (var item in tempListBalanceDetailViewModel)
                        {
                            BalanceJournalDetail entityDetail = lastJournalDetail.Where(i => i.JournalId == item.JournalId).FirstOrDefault();
                            if (entityDetail == null) continue;

                            item.FirstDebit = entityDetail.LastDebit;
                            item.FirstCredit = entityDetail.LastCredit;
                        }
                    }

                    // 2. Ambil mutasi Debet Kredit dari transaksi bulan berjalan
                    foreach (var item in listTransaction)
                    {
                        if (tempListBalanceDetailViewModel.Where(t => t.JournalId == item.JournalId).Count() == 0)
                        {
                            tempListBalanceDetailViewModel.Add(new BalanceJournalDetailViewModel
                            {
                                JournalId = item.JournalId
                            });
                        }

                        BalanceJournalDetailViewModel currentViewModel = tempListBalanceDetailViewModel.Where(t => t.JournalId == item.JournalId).FirstOrDefault();
                        int currentIndex = tempListBalanceDetailViewModel.IndexOf(currentViewModel);
                        currentViewModel.MutationDebit = (currentViewModel.MutationDebit ?? 0);
                        currentViewModel.MutationCredit = (currentViewModel.MutationCredit ?? 0);
                        currentViewModel.ReconciliationDebit = (currentViewModel.ReconciliationDebit ?? 0);
                        currentViewModel.ReconciliationCredit = (currentViewModel.ReconciliationCredit ?? 0);

                        if (!item.Parent.IsReconciliation)
                        {
                            currentViewModel.MutationCredit += (item.Credit ?? 0);
                            currentViewModel.MutationDebit += (item.Debit ?? 0);
                        }
                        else
                        {
                            currentViewModel.ReconciliationDebit += (item.Debit ?? 0);
                            currentViewModel.ReconciliationCredit += (item.Credit ?? 0);
                        }

                        tempListBalanceDetailViewModel[currentIndex] = currentViewModel;
                    }

                    // 4. Hitung Saldo Akhir
                    decimal? incomeAmount = 0;
                    decimal? serviceAmount = 0;
                    decimal? costAmount = 0;
                    List<string> cachedCode = new List<string>();
                    foreach (var item in tempListBalanceDetailViewModel)
                    {
                        // update saldo awal (saldo akhir + mutasi)
                        item.BalanceAfterMutationDebit = (item.MutationDebit ?? 0);
                        item.BalanceAfterMutationCredit = (item.MutationCredit ?? 0);

                        decimal totalAfterReconciliation =
                            ((item.BalanceAfterMutationDebit ?? 0) + (item.ReconciliationDebit ?? 0)) -
                            ((item.BalanceAfterMutationCredit ?? 0) + (item.ReconciliationCredit ?? 0));
                        if (totalAfterReconciliation > 0)
                        {
                            item.BalanceAfterReconciliationDebit = totalAfterReconciliation;
                            item.BalanceAfterReconciliationCredit = 0;
                        }
                        else
                        {
                            item.BalanceAfterReconciliationDebit = 0;
                            item.BalanceAfterReconciliationCredit = Math.Abs(totalAfterReconciliation);
                        }

                        item.LastDebit = (item.FirstDebit ?? 0) + item.BalanceAfterReconciliationDebit;
                        item.LastCredit = (item.FirstCredit ?? 0) + item.BalanceAfterReconciliationCredit;
                    }

                    // 5. Insert Keb Balance Header & Balance Detail
                    BalanceJournal newBalanceHeader = new BalanceJournal();
                    newBalanceHeader.Month = month;
                    newBalanceHeader.Year = year;
                    newBalanceHeader.Status = (int)DbConstant.DefaultDataStatus.Active;
                    newBalanceHeader.CreateDate = newBalanceHeader.ModifyDate = DateTime.Now;
                    newBalanceHeader.CreateUserId = newBalanceHeader.ModifyUserId = userId;
                    _balanceJournalRepository.AttachNavigation<User>(newBalanceHeader.CreateUser);
                    _balanceJournalRepository.AttachNavigation<User>(newBalanceHeader.ModifyUser);
                    newBalanceHeader = _balanceJournalRepository.Add(newBalanceHeader);
                    _unitOfWork.SaveChanges();

                    foreach (var item in tempListBalanceDetailViewModel)
                    {
                        item.Journal = null;
                        BalanceJournalDetail newBalanceDetail = new BalanceJournalDetail();
                        Map(item, newBalanceDetail);
                        newBalanceDetail.ParentId = newBalanceHeader.Id;
                        _balanceJournalDetailRepository.AttachNavigation<BalanceJournal>(newBalanceDetail.Parent);
                        _balanceJournalDetailRepository.AttachNavigation<JournalMaster>(newBalanceDetail.Journal);
                        _balanceJournalDetailRepository.Add(newBalanceDetail);
                    }

                    _unitOfWork.SaveChanges();

                    List<BalanceJournalDetailViewModel> mappedResult = RetrieveBalanceJournalDetailsByHeaderId(newBalanceHeader.Id);

                    foreach (var item in tempListBalanceDetailViewModel)
                    {
                        foreach (var journalIncomeCode in catJournalIncomeCodeList)
                        {
                            List<int> cachedItems = new List<int>();
                            foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                            {
                                if (IsCurrentJournalValid(itemBalance.Journal, journalIncomeCode))
                                {
                                    decimal currentAmount = (itemBalance.LastCredit ?? 0) - (itemBalance.LastDebit ?? 0);
                                    incomeAmount += currentAmount;

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
                        }

                        foreach (var journalServiceCode in catJournalServiceCodeList)
                        {
                            List<int> cachedItems = new List<int>();
                            foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                            {
                                if (IsCurrentJournalValid(itemBalance.Journal, journalServiceCode))
                                {
                                    decimal currentAmount = (itemBalance.LastCredit ?? 0) - (itemBalance.LastDebit ?? 0);
                                    serviceAmount += currentAmount;

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
                        }

                        foreach (var journalCostCode in catJournalCostCodeList)
                        {
                            List<int> cachedItems = new List<int>();
                            foreach (var itemBalance in mappedResult.Where(m => !m.IsChecked))
                            {
                                if (IsCurrentJournalValid(itemBalance.Journal, journalCostCode))
                                {
                                    decimal currentAmount = (itemBalance.LastCredit ?? 0) - (itemBalance.LastDebit ?? 0);
                                    costAmount += currentAmount;

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
                        }
                    }

                    //profitloss
                    decimal? profitLossAmount = incomeAmount + serviceAmount + costAmount;
                    BalanceJournalDetail profitDetail = new BalanceJournalDetail();
                    profitDetail.ParentId = newBalanceHeader.Id;
                    JournalMasterViewModel profitLossCurrentMonthJournal = mappedListAllJournal.Where(j => j.Code == "2.03.05").FirstOrDefault();
                    profitDetail.JournalId = profitLossCurrentMonthJournal.Id;
                    if (profitLossAmount > 0)
                    {
                        profitDetail.LastDebit = profitLossAmount;
                    }
                    else
                    {
                        profitDetail.LastCredit = Math.Abs(profitLossAmount.Value);
                    }
                    _balanceJournalDetailRepository.AttachNavigation<BalanceJournal>(profitDetail.Parent);
                    _balanceJournalDetailRepository.AttachNavigation<JournalMaster>(profitDetail.Journal);
                    _balanceJournalDetailRepository.Add(profitDetail);
                    _unitOfWork.SaveChanges();

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }

        public void DeleteBalanceJournal(int headerId, int userId)
        {
            BalanceJournal entity = _balanceJournalRepository.GetById(headerId);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyDate = DateTime.Now;
            entity.ModifyUserId = userId;
            _balanceJournalRepository.AttachNavigation<User>(entity.CreateUser);
            _balanceJournalRepository.AttachNavigation<User>(entity.ModifyUser);
            _balanceJournalRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        protected bool IsCurrentJournalValid(JournalMasterViewModel currentJournal, string codeToCompare)
        {
            if (currentJournal.Code == codeToCompare) return true;

            if (currentJournal.Parent != null)
            {
                return IsCurrentJournalValid(currentJournal.Parent, codeToCompare);
            }

            return false;
        }
    }
}
