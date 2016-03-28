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
using MoreLinq;

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

        protected IHPPHeaderRepository _hppHeaderRepository;
        protected IHPPDetailRepository _hppDetailRepository;

        protected IInvoiceRepository _invoiceRepository;

        protected IUnitOfWork _unitOfWork;

        public BalanceSheetBaseModel(IBalanceJournalRepository balanceJournalRepository, IBalanceJournalDetailRepository balanceJournalDetailRepository,
            IJournalMasterRepository journalMasterRepository, IReferenceRepository referenceRepository,
            IPurchasingRepository purchasingRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IHPPHeaderRepository hppHeaderRepository, IHPPDetailRepository hppDetailRepository,
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
            _hppHeaderRepository = hppHeaderRepository;
            _hppDetailRepository = hppDetailRepository;
            _invoiceRepository = invoiceRepository;
            _unitOfWork = unitOfWork;
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
            List<BalanceJournalDetail> result = _balanceJournalDetailRepository.GetMany(bj => bj.ParentId == headerId).ToList();
            List<BalanceJournalDetailViewModel> mappedResult = new List<BalanceJournalDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void RecalculateBalanceJournal(int month, int year, int userId)
        {
            // Calculate HPP
            RecalculateHPP(month, year, userId);

            BalanceJournalViewModel prevCalculated = RetrieveBalanceJournalHeader(month, year);
            if (prevCalculated != null)
            {
                DeleteBalanceJournal(prevCalculated.Id, userId);
            }

            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime prevMonth = firstDay.AddDays(-1);

            List<JournalMaster> listAllJournal = _journalMasterRepository.GetAll().ToList();

            Reference catJournalService = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_SERVICE).FirstOrDefault();
            Reference catJournalCost = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_COST).FirstOrDefault();
            Reference catJournalIncome = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL_INCOME).FirstOrDefault();

            List<string> catJournalServiceCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalService.Id).Select(r => r.Value).ToList();
            List<string> catJournalCostCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalCost.Id).Select(r => r.Value).ToList();
            List<string> catJournalIncomeCodeList = _referenceRepository.GetMany(r => r.ParentId == catJournalIncome.Id).Select(r => r.Value).ToList();

            List<JournalMaster> listProfitLossJournalParents = listAllJournal.Where(j =>
                catJournalServiceCodeList.Contains(j.Code) ||
                catJournalCostCodeList.Contains(j.Code) ||
                catJournalIncomeCodeList.Contains(j.Code)).ToList();
            List<JournalMasterViewModel> mappedListProfitLossJournalParents = new List<JournalMasterViewModel>();
            Map(listProfitLossJournalParents, mappedListProfitLossJournalParents);

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
                currentViewModel.MutationDebit = currentViewModel.MutationDebit ?? 0;
                currentViewModel.MutationCredit = currentViewModel.MutationCredit ?? 0;
                currentViewModel.ReconciliationDebit = currentViewModel.ReconciliationDebit ?? 0;
                currentViewModel.ReconciliationCredit = currentViewModel.ReconciliationCredit ?? 0;

                if (!item.Parent.IsReconciliation)
                {
                    currentViewModel.MutationCredit += item.Credit ?? 0;
                    currentViewModel.MutationDebit += item.Debit ?? 0;
                }
                else
                {
                    currentViewModel.ReconciliationDebit += item.Debit ?? 0;
                    currentViewModel.ReconciliationCredit += item.Credit ?? 0;
                }

                tempListBalanceDetailViewModel[currentIndex] = currentViewModel;
            }

            // 4. Hitung Saldo Akhir
            foreach (var item in tempListBalanceDetailViewModel)
            {
                // update saldo awal (saldo akhir + mutasi)
                item.BalanceAfterMutationDebit = item.FirstDebit ?? 0 + item.MutationDebit ?? 0;
                item.BalanceAfterMutationCredit = item.FirstCredit ?? 0 + item.MutationCredit ?? 0;

                decimal totalAfterReconciliation =
                    (item.BalanceAfterMutationDebit ?? 0 + item.ReconciliationDebit ?? 0) -
                    (item.BalanceAfterMutationCredit ?? 0 + item.ReconciliationCredit ?? 0);
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

                bool isProfitLoss = false;
                foreach (var iJournalParent in mappedListProfitLossJournalParents)
                {
                    isProfitLoss = IsCurrentJournalValid(item.Journal, iJournalParent.Code);

                    if (isProfitLoss) break;
                }

                JournalMaster currentJournal = listAllJournal.Where(cj => cj.Id == item.JournalId).FirstOrDefault();
                if (isProfitLoss)
                {
                    item.ProfitLossDebit = item.BalanceAfterReconciliationDebit ?? 0;
                    item.ProfitLossCredit = item.BalanceAfterReconciliationCredit ?? 0;
                }
                else
                {
                    item.LastDebit = item.BalanceAfterReconciliationDebit;
                    item.LastCredit = item.BalanceAfterReconciliationCredit;
                }

                item.LastDebit = item.BalanceAfterReconciliationDebit;
                item.LastCredit = item.BalanceAfterReconciliationCredit;
            }

            // 5. Insert Keb Balance Header & Balance Detail
            BalanceJournal newBalanceHeader = new BalanceJournal();
            newBalanceHeader.Month = month;
            newBalanceHeader.Year = year;
            newBalanceHeader.Status = (int)DbConstant.DefaultDataStatus.Active;
            newBalanceHeader.CreateDate = newBalanceHeader.ModifyDate = DateTime.Now;
            newBalanceHeader.CreateUserId = newBalanceHeader.ModifyUserId = userId;
            newBalanceHeader = _balanceJournalRepository.Add(newBalanceHeader);
            _unitOfWork.SaveChanges();

            foreach (var item in tempListBalanceDetailViewModel)
            {
                item.Journal = null;
                BalanceJournalDetail newBalanceDetail = new BalanceJournalDetail();
                Map(item, newBalanceDetail);
                newBalanceDetail.ParentId = newBalanceHeader.Id;
                _balanceJournalDetailRepository.Add(newBalanceDetail);
            }
            _unitOfWork.SaveChanges();
        }

        public void DeleteBalanceJournal(int headerId, int userId)
        {
            BalanceJournal entity = _balanceJournalRepository.GetById(headerId);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyDate = DateTime.Now;
            entity.ModifyUserId = userId;
            _balanceJournalRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        public HPPHeaderViewModel RetrieveHPPHeader(int month, int year)
        {
            HPPHeader result = _hppHeaderRepository.GetMany(hpp => hpp.Month == month && hpp.Year == year &&
                hpp.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            HPPHeaderViewModel mappedResult = new HPPHeaderViewModel();
            return Map(result, mappedResult);
        }

        public List<HPPDetailViewModel> RetrieveHPPDetailsByHeaderId(int headerId)
        {
            List<HPPDetail> result = _hppDetailRepository.GetMany(hpp => hpp.HeaderId == headerId).ToList();
            List<HPPDetailViewModel> mappedResult = new List<HPPDetailViewModel>();
            return Map(result, mappedResult);
        }

        public void RecalculateHPP(int month, int year, int userId)
        {
            HPPHeaderViewModel header = RetrieveHPPHeader(month, year);
            if (header != null)
            {
                DeleteHPP(header.Id, userId);
            }

            HPPHeader newHeader = new HPPHeader();
            newHeader.CreateUserId = newHeader.ModifyUserId = userId;
            newHeader.CreateDate = newHeader.ModifyDate = DateTime.Now;
            newHeader.Month = month;
            newHeader.Year = year;
            newHeader.Status = (int)DbConstant.DefaultDataStatus.Active;
            newHeader = _hppHeaderRepository.Add(newHeader);
            _unitOfWork.SaveChanges();

            // TODO : Recalculate
            // 1. Ambil persediaan awal sparepart (Akhir bulan sebelumnya) + Pembelian sparepart bulan ini
            // 2. Ambil persediaan awal tukang harian (akhir bulan sebelumnya) + Pemakaian tukang bulan ini
            // 3. Ambil persediaan awal tukang borongan (akhir bulan sebelumnya) + Pemakaian borongan bulan ini

            // step 1 --> Ambil persediaan awal sparepart (Akhir bulan sebelumnya) + Pembelian sparepart bulan ini
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            DateTime prevMonth = firstDay.AddDays(-1);
            BalanceJournal lastJournal = _balanceJournalRepository.GetMany(bj =>
                bj.Month == prevMonth.Month && bj.Year == prevMonth.Year &&
                bj.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            // daftar kode akun untuk HPP
            Reference hppJournal = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_HPP_JOURNAL).FirstOrDefault();
            List<Reference> hppJournalList = _referenceRepository.GetMany(r => r.ParentId == hppJournal.Id).ToList();

            // Calculate HPP sparepart this month
            double lastPrevSparepartBalance = 0;
            double totalPurchase = 0;
            double lastSparepartBalance = 0;
            if (lastJournal != null)
            {
                string stockSparepartCode = "1.01.04.01";
                JournalMaster sparepartStockJournal = _journalMasterRepository.GetMany(jm => jm.Code == stockSparepartCode).FirstOrDefault();
                BalanceJournalDetail details = _balanceJournalDetailRepository.GetMany(d => d.ParentId == lastJournal.Id &&
                    d.JournalId == sparepartStockJournal.Id).FirstOrDefault();
                // persediaan awal (bulan sebelumnya)
                lastPrevSparepartBalance = details.LastDebit.AsDouble();

                // pembelian sparepart
                List<Purchasing> listPurchasing = _purchasingRepository.GetMany(p =>
                    p.Status == (int)DbConstant.PurchasingStatus.Active &&
                    p.Date >= firstDay && p.Date <= lastDay).ToList();
                totalPurchase = listPurchasing.Sum(p => p.TotalPrice).AsDouble();

                // persediaan akhir
                List<SparepartDetail> sparepartDetailList = _sparepartDetailRepository.GetMany(sp =>
                    sp.Status == (int)DbConstant.SparepartDetailDataStatus.Active).ToList();
                lastSparepartBalance = sparepartDetailList.Sum(sp =>
                    sp.PurchasingDetailId.HasValue ? sp.PurchasingDetail.Price :
                                                     sp.SparepartManualTransaction.Price).AsDouble();
            }
            double hppSparepartAmount = lastPrevSparepartBalance + totalPurchase - lastSparepartBalance;
            double hppSparepartFeeAmount = hppSparepartAmount * 0.1;

            string sparepartHPPCode = hppJournalList.Where(r => r.Code == DbConstant.REF_HPP_JOURNAL_SPAREPART).FirstOrDefault().Value;
            JournalMaster sparepartHPPJournal = _journalMasterRepository.GetMany(jm => jm.Code == sparepartHPPCode).FirstOrDefault();

            HPPDetail hppSparepartDetail = new HPPDetail();
            hppSparepartDetail.HeaderId = newHeader.Id;
            hppSparepartDetail.JournalId = sparepartHPPJournal.Id;

            hppSparepartDetail.BaseAmount = hppSparepartAmount.AsDecimal();
            hppSparepartDetail.ServicePercentage = 10;
            hppSparepartDetail.ServiceAmount = hppSparepartFeeAmount.AsDecimal();
            hppSparepartDetail.TotalAmount = hppSparepartDetail.BaseAmount + hppSparepartDetail.ServiceAmount;

            _hppDetailRepository.Add(hppSparepartDetail);
            // End calculate HPP sparepart this month

            string dailyMechanicHPPCode = hppJournalList.Where(r => r.Code == DbConstant.REF_HPP_JOURNAL_DAILYMECHANIC).FirstOrDefault().Value;
            JournalMaster dailyMechanicHPPJournal = _journalMasterRepository.GetMany(jm => jm.Code == dailyMechanicHPPCode).FirstOrDefault();
            // Calculate Daily Tukang
            List<Invoice> listMonthlyInvoices = _invoiceRepository.GetMany(i => i.CreateDate >= firstDay && i.CreateDate <= lastDay).ToList();
            decimal hppDailyMechanicAmount = 0;
            decimal hppDailyMechanicFeeAmount = 0;
            foreach (var item in listMonthlyInvoices)
            {
                if (item.SPK.isContractWork) continue;
                hppDailyMechanicAmount += item.TotalService;
                hppDailyMechanicFeeAmount += item.TotalServicePlusFee - item.TotalService;
            }
            HPPDetail hppDailyMechanic = new HPPDetail();
            hppDailyMechanic.HeaderId = newHeader.Id;
            hppDailyMechanic.JournalId = dailyMechanicHPPJournal.Id;

            hppDailyMechanic.BaseAmount = hppDailyMechanicAmount;
            hppDailyMechanic.ServicePercentage = 10;
            hppDailyMechanic.ServiceAmount = hppDailyMechanicFeeAmount;
            hppDailyMechanic.TotalAmount = hppDailyMechanic.BaseAmount + hppDailyMechanic.ServiceAmount;

            _hppDetailRepository.Add(hppDailyMechanic);
            // End calculate HPP daily mechanic this month

            string outSourceMechanicHPPCode = hppJournalList.Where(r => r.Code == DbConstant.REF_HPP_JOURNAL_OUTSOURCEMECHANIC).FirstOrDefault().Value;
            JournalMaster outSourceMechanicHPPJournal = _journalMasterRepository.GetMany(jm => jm.Code == outSourceMechanicHPPCode).FirstOrDefault();
            // Calculate Borongan Tukang
            decimal hppOutSourceMechanicAmount = 0;
            decimal hppOutSourceMechanicFeeAmount = 0;
            decimal hppOutSourceMechanicAddInAmount = 0;
            foreach (var item in listMonthlyInvoices)
            {
                if (!item.SPK.isContractWork) continue;
                hppOutSourceMechanicAmount += item.TotalService;
                hppOutSourceMechanicFeeAmount += item.TotalService * 0.1M;
                hppOutSourceMechanicAddInAmount += item.TotalService * 0.2M;
            }

            HPPDetail hppOutSourceMechanic = new HPPDetail();
            hppOutSourceMechanic.HeaderId = newHeader.Id;
            hppOutSourceMechanic.JournalId = outSourceMechanicHPPJournal.Id;

            hppOutSourceMechanic.BaseAmount = hppOutSourceMechanicAmount;
            hppOutSourceMechanic.ServicePercentage = 10;
            hppOutSourceMechanic.ServiceAmount = hppOutSourceMechanicFeeAmount;
            hppOutSourceMechanic.BaseAmountModifierPercentage = 20;
            hppOutSourceMechanic.BaseAmountWithModifierPercentageResult = hppOutSourceMechanicAddInAmount;
            hppOutSourceMechanic.TotalAmount = hppOutSourceMechanic.BaseAmount + hppOutSourceMechanic.ServiceAmount + hppOutSourceMechanic.BaseAmountWithModifierPercentageResult;

            _hppDetailRepository.Add(hppOutSourceMechanic);
            // End calculate HPP outsource mechanic this month

            _unitOfWork.SaveChanges();

            // insert it into transaction table
            Reference refTableHPP = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_HPP).FirstOrDefault();
            Transaction hppSaleTransaction = new Transaction();
            hppSaleTransaction.CreateUserId = hppSaleTransaction.ModifyUserId = userId;
            hppSaleTransaction.CreateDate = hppSaleTransaction.ModifyDate = newHeader.CreateDate;
            hppSaleTransaction.TransactionDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            hppSaleTransaction.ReferenceTableId = refTableHPP.Id;
            hppSaleTransaction.PrimaryKeyValue = newHeader.Id;
            hppSaleTransaction.Status = (int)DbConstant.DefaultDataStatus.Active;
            hppSaleTransaction.TotalTransaction = (hppSparepartDetail.BaseAmount + hppDailyMechanic.BaseAmount + hppOutSourceMechanic.BaseAmount).AsDouble();
            hppSaleTransaction.TotalPayment = hppSaleTransaction.TotalTransaction;
            hppSaleTransaction = _transactionRepository.Add(hppSaleTransaction);

            _unitOfWork.SaveChanges();

            // insert transaction detail
            // HPP
            TransactionDetail sparepartDetailTransaction = new TransactionDetail();
            sparepartDetailTransaction.ParentId = hppSaleTransaction.Id;
            sparepartDetailTransaction.JournalId = sparepartHPPJournal.Id;
            sparepartDetailTransaction.Debit = hppSparepartDetail.BaseAmount;

            TransactionDetail dailyMechanicTransaction = new TransactionDetail();
            dailyMechanicTransaction.ParentId = hppSaleTransaction.Id;
            dailyMechanicTransaction.JournalId = dailyMechanicHPPJournal.Id;
            dailyMechanicTransaction.Debit = hppDailyMechanic.BaseAmount;

            TransactionDetail outSourceMechanicTransaction = new TransactionDetail();
            outSourceMechanicTransaction.ParentId = hppSaleTransaction.Id;
            outSourceMechanicTransaction.JournalId = outSourceMechanicHPPJournal.Id;
            outSourceMechanicTransaction.Debit = hppOutSourceMechanic.BaseAmount;
            // End HPP

            // All Stock
            JournalMaster allStockJournal = _journalMasterRepository.GetMany(j => j.Code == "1.01.04.01").FirstOrDefault();
            TransactionDetail sparepartStockTransaction = new TransactionDetail();
            sparepartStockTransaction.ParentId = hppSaleTransaction.Id;
            sparepartStockTransaction.JournalId = allStockJournal.Id;
            sparepartStockTransaction.Credit = hppSaleTransaction.TotalTransaction.AsDecimal();
            // End All Stock

            _transactionDetailRepository.Add(sparepartDetailTransaction);
            _transactionDetailRepository.Add(dailyMechanicTransaction);
            _transactionDetailRepository.Add(outSourceMechanicTransaction);
            _transactionDetailRepository.Add(sparepartStockTransaction);

            _unitOfWork.SaveChanges();
        }

        public void DeleteHPP(int headerId, int userId)
        {
            HPPHeader entity = _hppHeaderRepository.GetById(headerId);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyUserId = userId;
            entity.ModifyDate = DateTime.Now;
            _hppHeaderRepository.Update(entity);

            Transaction transEntity = _transactionRepository.GetMany(t => t.PrimaryKeyValue == headerId).FirstOrDefault();
            transEntity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            transEntity.ModifyUserId = userId;
            transEntity.ModifyDate = DateTime.Now;
            _transactionRepository.Update(transEntity);
        }

        protected bool IsCurrentJournalValid(JournalMasterViewModel currentJournal, string codeToCompare)
        {
            if (currentJournal.Code == codeToCompare) return true;

            if(currentJournal.Parent != null)
            {
                return IsCurrentJournalValid(currentJournal.Parent, codeToCompare);
            }

            return false;
        }
    }
}
