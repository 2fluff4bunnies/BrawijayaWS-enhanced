﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SalesReturnTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IInvoiceRepository _invoiceRepository;
        private ISalesReturnRepository _salesReturnRepository;
        private ISalesReturnDetailRepository _salesReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SalesReturnTransactionListModel(ITransactionRepository transactionRepository,
            IInvoiceRepository invoiceRepository, ISalesReturnRepository salesReturnRepository,
            ISalesReturnDetailRepository salesReturnDetailRepository,
            ISparepartRepository sparepartRepository, ISparepartDetailRepository sparepartDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _invoiceRepository = invoiceRepository;
            _salesReturnRepository = salesReturnRepository;
            _salesReturnDetailRepository = salesReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SalesReturnViewModel> SearchSalesReturnList(DateTime? dateFrom, DateTime? dateTo, int invoiceID)
        {
            List<SalesReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _salesReturnRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }
            else
            {
                result = _salesReturnRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }

            if (invoiceID > 0)
            {
                result = result.Where(x => x.InvoiceId == invoiceID).OrderByDescending(c => c.Date).ToList();
            }

            List<SalesReturnViewModel> mappedResult = new List<SalesReturnViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteSalesReturn(int salesReturnID, int userID)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    SalesReturn salesReturn = _salesReturnRepository.GetById(salesReturnID);
                    salesReturn.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    salesReturn.ModifyDate = serverTime;
                    salesReturn.ModifyUserId = userID;

                    _salesReturnRepository.AttachNavigation(salesReturn.CreateUser);
                    _salesReturnRepository.AttachNavigation(salesReturn.ModifyUser);
                    _salesReturnRepository.AttachNavigation(salesReturn.Invoice);
                    _salesReturnRepository.Update(salesReturn);
                    _unitOfWork.SaveChanges();

                    List<SalesReturnDetail> listDetail = _salesReturnDetailRepository.GetMany(x => x.SalesReturnId == salesReturnID).ToList();
                    foreach (var itemDetail in listDetail)
                    {
                        itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                        itemDetail.ModifyDate = serverTime;
                        itemDetail.ModifyUserId = userID;

                        _salesReturnDetailRepository.AttachNavigation(itemDetail.CreateUser);
                        _salesReturnDetailRepository.AttachNavigation(itemDetail.ModifyUser);
                        _salesReturnDetailRepository.AttachNavigation(itemDetail.SalesReturn);
                        _salesReturnDetailRepository.AttachNavigation(itemDetail.InvoiceDetail);
                        _salesReturnDetailRepository.Update(itemDetail);

                        SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDetail.InvoiceDetail.SPKDetailSparepartDetail.SparepartDetailId);
                        spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;

                        _sparepartDetailRepository.AttachNavigation(spDetail.CreateUser);
                        _sparepartDetailRepository.AttachNavigation(spDetail.ModifyUser);
                        _sparepartDetailRepository.AttachNavigation(spDetail.PurchasingDetail);
                        _sparepartDetailRepository.AttachNavigation(spDetail.Sparepart);
                        _sparepartDetailRepository.AttachNavigation(spDetail.SparepartManualTransaction);
                        _sparepartDetailRepository.Update(spDetail);

                        Sparepart sparepart = _sparepartRepository.GetById(spDetail.SparepartId);
                        sparepart.StockQty += 1;

                        _sparepartRepository.AttachNavigation(sparepart.CreateUser);
                        _sparepartRepository.AttachNavigation(sparepart.ModifyUser);
                        _sparepartRepository.AttachNavigation(sparepart.CategoryReference);
                        _sparepartRepository.AttachNavigation(sparepart.UnitReference);
                        _sparepartRepository.Update(sparepart);
                    }

                    _unitOfWork.SaveChanges();

                    Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == salesReturnID).FirstOrDefault();
                    transaction.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    transaction.ModifyDate = serverTime;
                    transaction.ModifyUserId = userID;

                    _transactionRepository.AttachNavigation(transaction.CreateUser);
                    _transactionRepository.AttachNavigation(transaction.ModifyUser);
                    _transactionRepository.AttachNavigation(transaction.PaymentMethod);
                    _transactionRepository.AttachNavigation(transaction.ReferenceTable);
                    _transactionRepository.Update(transaction);

                    _unitOfWork.SaveChanges();
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
            
        }
    }
}
