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
    public class PurchaseReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IPurchasingDetailRepository purchasingDetailRepository, IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            ISparepartRepository sparepartRepository, ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchasingViewModel> SearchPurchasingList(DateTime? dateFrom, DateTime? dateTo)
        {
            List<Purchasing> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchasingRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchasingRepository.GetAll().OrderBy(c => c.Date).ToList();
            }

            List<PurchasingViewModel> mappedResult = new List<PurchasingViewModel>();
            return Map(result, mappedResult);
        }

        public bool IsHasReturnActive(int purchasingID)
        {
            return _purchaseReturnRepository.GetMany(x => x.PurchasingId == purchasingID && x.Status == (int)DbConstant.DefaultDataStatus.Active).Count() > 0;
        }

        public PurchaseReturnViewModel GetPurchaseReturn(int purchasingID)
        {
            PurchaseReturn purchaseReturn =  _purchaseReturnRepository.GetMany(x => x.PurchasingId == purchasingID && x.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
            PurchaseReturnViewModel viewModel = new PurchaseReturnViewModel();
            return Map(purchaseReturn, viewModel);
        }

        public void DeletePurchaseReturn(int purchaseReturnID, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
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

        public List<PurchaseReturnDetail> RetrievePurchaseReturnDetail(int purchaseReturnID)
        {
            List<PurchaseReturnDetail> result = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            return result;
        }

        public List<ReturnViewModel> GetReturnListDetail(int purchaseReturnID, int purchasingID)
        {
            List<ReturnViewModel> result = new List<ReturnViewModel>();
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository.GetMany(x => x.PurchasingId == purchasingID).ToList();

            if (purchaseReturnID > 0)
            {
                List<PurchaseReturnDetail> listDetail = this.RetrievePurchaseReturnDetail(purchaseReturnID);
                if (listDetail != null && listDetail.Count > 0)
                {
                    foreach (var itemDetail in listPurchasingDetail)
                    {
                        result.Add(new ReturnViewModel
                        {
                            SparepartId = itemDetail.SparepartId,
                            SparepartName = itemDetail.Sparepart.Name,
                            ReturQty = listDetail.Where(x => x.SparepartDetail.SparepartId == itemDetail.SparepartId).Count(),
                            ReturQtyLimit = itemDetail.Qty,
                            PricePerItem = itemDetail.Price,
                            SparepartCode = itemDetail.Sparepart.Code,
                            UnitName = itemDetail.Sparepart.UnitReference.Name
                        });
                    }
                }
            }
            return result;
        }
    }
}
