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
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnTransactionListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            ISparepartRepository sparepartRepository, ISparepartDetailRepository sparepartDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
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
            DateTime serverTime = DateTime.Now;

            PurchaseReturn purchaseReturn = _purchaseReturnRepository.GetById(purchaseReturnID);
            purchaseReturn.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            purchaseReturn.ModifyDate = serverTime;
            purchaseReturn.ModifyUserId = userID;
            _purchaseReturnRepository.Update(purchaseReturn);

            List<PurchaseReturnDetail> listDetail = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            foreach (var itemDetail in listDetail)
            {
                itemDetail.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                itemDetail.ModifyDate = serverTime;
                itemDetail.ModifyUserId = userID;
                _purchaseReturnDetailRepository.Update(itemDetail);

                SparepartDetail spDetail = _sparepartDetailRepository.GetById(itemDetail.SparepartDetailId);
                spDetail.Status = (int)DbConstant.DefaultDataStatus.Active;
                _sparepartDetailRepository.Update(spDetail);

                Sparepart sparepart = _sparepartRepository.GetById(spDetail.SparepartId);
                sparepart.StockQty += 1;
                _sparepartRepository.Update(sparepart);
            }

            Transaction transaction = _transactionRepository.GetMany(x => x.PrimaryKeyValue == purchaseReturnID).FirstOrDefault();
            transaction.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            transaction.ModifyDate = serverTime;
            transaction.ModifyUserId = userID;
            _transactionRepository.Update(transaction);

            _unitOfWork.SaveChanges();
        }
    }
}
