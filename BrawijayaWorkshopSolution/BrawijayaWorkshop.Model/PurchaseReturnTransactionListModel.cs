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
    public class PurchaseReturnTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnTransactionListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            ISparepartRepository sparepartRepository, ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchaseReturnViewModel> SearchPurchaseReturnList(DateTime? dateFrom, DateTime? dateTo, int purchasingID)
        {
            List<PurchaseReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchaseReturnRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo && c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }
            else
            {
                result = _purchaseReturnRepository.GetMany(c=>c.Status == (int)DbConstant.DefaultDataStatus.Active).OrderByDescending(c => c.Date).ToList();
            }

            if(purchasingID > 0)
            {
                result = result.Where(x => x.PurchasingId == purchasingID).OrderByDescending(c => c.Date).ToList();
            }

            List<PurchaseReturnViewModel> mappedResult = new List<PurchaseReturnViewModel>();
            return Map(result, mappedResult);
        }

        public void DeletePurchaseReturn(int purchaseReturnID, int userID)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    PurchaseReturn purchaseReturn = _purchaseReturnRepository.GetById(purchaseReturnID);
                    purchaseReturn.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    purchaseReturn.ModifyDate = serverTime;
                    purchaseReturn.ModifyUserId = userID;

                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.CreateUser);
                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.ModifyUser);
                    _purchaseReturnRepository.AttachNavigation(purchaseReturn.Purchasing);
                    _purchaseReturnRepository.Update(purchaseReturn);
                    _unitOfWork.SaveChanges();

                    List<PurchaseReturnDetail> listDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
                    foreach (var itemDetail in listDetail)
                    {
                        itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                        itemDetail.ModifyDate = serverTime;
                        itemDetail.ModifyUserId = userID;

                        _purchaseReturnDetailRepository.AttachNavigation(itemDetail.CreateUser);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.ModifyUser);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.PurchaseReturn);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.PurchasingDetail);
                        _purchaseReturnRepository.AttachNavigation(itemDetail.SparepartDetail);
                        _purchaseReturnDetailRepository.Update(itemDetail);

                        SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDetail.SparepartDetailId);
                        spDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

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

                    Reference transactionReferenceTable = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_TRANSTBL_PURCHASERETURN).FirstOrDefault();
                    Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID && x.ReferenceTableId == transactionReferenceTable.Id).FirstOrDefault();
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
