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
    public class SpecialSparepartDetailListModel : AppBaseModel
    {
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStockCardDetailRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private IUnitOfWork _unitOfWork;

        public SpecialSparepartDetailListModel(
            ISpecialSparepartDetailRepository WheelDetailRepository,
            ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _specialSparepartDetailRepository = WheelDetailRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
            _sparepartStockCardDetailRepository = sparepartStockCardDetailRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SpecialSparepartDetailViewModel> SearchDetail(int sparepartId, string serialNumber, DbConstant.WheelDetailStatus status)
        {
            List<SpecialSparepartDetail> result;

            if (!string.IsNullOrWhiteSpace(serialNumber))
            {
                result = _specialSparepartDetailRepository.GetMany(whd =>
                    whd.Status == (int)status &&
                    whd.SparepartId == sparepartId &&
                    whd.SerialNumber.ToLower().Contains(serialNumber.ToLower())).ToList();
            }
            else
            {
                result = _specialSparepartDetailRepository.GetMany(whd => whd.Status == (int)status
                    && whd.SparepartId == sparepartId).ToList();
            }

            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }


        public void RemoveSpecialSparepart(int specialSparepartDetailId, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SpecialSparepartDetail sspdEntity = _specialSparepartDetailRepository.GetById(specialSparepartDetailId);
            sspdEntity.ModifyDate = serverTime;
            sspdEntity.ModifyUserId = userId;
            sspdEntity.Status = (int)DbConstant.WheelDetailStatus.Deleted;

            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.Sparepart);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.CreateUser);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.ModifyUser);
            _specialSparepartDetailRepository.Update(sspdEntity);
            _unitOfWork.SaveChanges();

            _unitOfWork.SaveChanges();

            Sparepart spEntity = _sparepartRepository.GetById(sspdEntity.SparepartId);
            spEntity.ModifyDate = serverTime;
            spEntity.ModifyUserId = userId;

            if (spEntity.StockQty > 0)
            {
                spEntity.StockQty = spEntity.StockQty - 1;
            }

            _sparepartRepository.AttachNavigation(spEntity.UnitReference);
            _sparepartRepository.AttachNavigation(spEntity.CategoryReference);
            _sparepartRepository.AttachNavigation(spEntity.CreateUser);
            _sparepartRepository.AttachNavigation(spEntity.ModifyUser);
            _sparepartRepository.Update(spEntity);
            _unitOfWork.SaveChanges();

            SparepartStockCard stockCard = new SparepartStockCard();
            Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_MANUAL).FirstOrDefault();

            stockCard.CreateUserId = userId;
            stockCard.PurchaseDate = serverTime;
            stockCard.PrimaryKeyValue = sspdEntity.Id;
            stockCard.ReferenceTableId = transactionReferenceTable.Id;
            stockCard.SparepartId = spEntity.Id;
            stockCard.Description = "Remove Special Sparepart Detail";
            stockCard.QtyOut = 1;
            stockCard.QtyOutPrice = Convert.ToDouble(sspdEntity.PurchasingDetail != null ? sspdEntity.PurchasingDetail.Price : sspdEntity.SparepartManualTransaction != null ? sspdEntity.SparepartManualTransaction.Price : 0);

            SparepartStockCard lastStockCard = _sparepartStockCardRepository.RetrieveLastCard(spEntity.Id);
            double lastStock = 0;
            double lastStockPrice = 0;
            if (lastStockCard != null)
            {
                lastStock = lastStockCard.QtyLast;
                lastStockPrice = lastStockCard.QtyLastPrice;
            }

            stockCard.QtyFirst = lastStock;
            stockCard.QtyFirstPrice = lastStockPrice;
            stockCard.QtyLast = lastStock - stockCard.QtyOut;
            stockCard.QtyLastPrice = lastStockPrice - stockCard.QtyOutPrice;
            _sparepartStockCardRepository.AttachNavigation(stockCard.CreateUser);
            _sparepartStockCardRepository.AttachNavigation(stockCard.Sparepart);
            _sparepartStockCardRepository.AttachNavigation(stockCard.ReferenceTable);
            stockCard = _sparepartStockCardRepository.Add(stockCard);
            _unitOfWork.SaveChanges();

            if (sspdEntity.PurchasingDetail != null)
            {
                SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                stockCardDtail.ParentStockCard = stockCard;
                stockCardDtail.PricePerItem = Convert.ToDouble(sspdEntity.PurchasingDetail.Price);
                stockCardDtail.QtyOut = 1;
                stockCardDtail.QtyOutPrice = Convert.ToDouble(sspdEntity.PurchasingDetail.Price);
                SparepartStockCardDetail lastStockCardDetail = _sparepartStockCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sspdEntity.Sparepart.Id, sspdEntity.PurchasingDetail.PurchasingId);
                double lastStockDetail = 0;
                double lastStockDetailPrice = 0;
                if (lastStockCardDetail != null)
                {
                    lastStockDetail = lastStockCardDetail.QtyLast;
                    lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                }
                stockCardDtail.QtyFirst = lastStockDetail;
                stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                stockCardDtail.PurchasingId = sspdEntity.PurchasingDetail.PurchasingId;

                _sparepartStockCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                _sparepartStockCardDetailRepository.Add(stockCardDtail);
                _unitOfWork.SaveChanges();

                PurchasingDetail pDetail = _purchasingDetailRepository.GetById(sspdEntity.PurchasingDetailId);
                pDetail.ModifyDate = serverTime;
                pDetail.ModifyUserId = userId;
                pDetail.QtyRemaining = pDetail.QtyRemaining - 1;

                _purchasingDetailRepository.AttachNavigation(pDetail.Purchasing);
                _purchasingDetailRepository.AttachNavigation(pDetail.Sparepart);
                _purchasingDetailRepository.AttachNavigation(pDetail.CreateUser);
                _purchasingDetailRepository.AttachNavigation(pDetail.ModifyUser);
                _purchasingDetailRepository.Update(pDetail);
                _unitOfWork.SaveChanges();
            }

            if (sspdEntity.SparepartManualTransaction != null)
            {
                SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                stockCardDtail.ParentStockCard = stockCard;
                stockCardDtail.PricePerItem = Convert.ToDouble(sspdEntity.SparepartManualTransaction.Price);
                stockCardDtail.QtyOut = 1;
                stockCardDtail.QtyOutPrice = Convert.ToDouble(1 * sspdEntity.SparepartManualTransaction.Price);
                SparepartStockCardDetail lastStockCardDetail = _sparepartStockCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(sspdEntity.Sparepart.Id, sspdEntity.SparepartManualTransactionId.Value);
                double lastStockDetail = 0;
                double lastStockDetailPrice = 0;
                if (lastStockCardDetail != null)
                {
                    lastStockDetail = lastStockCardDetail.QtyLast;
                    lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                }
                stockCardDtail.QtyFirst = lastStockDetail;
                stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                stockCardDtail.SparepartManualTransactionId = sspdEntity.SparepartManualTransactionId;

                _sparepartStockCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                _sparepartStockCardDetailRepository.Add(stockCardDtail);
                _unitOfWork.SaveChanges();

                SparepartManualTransaction spManual = _sparepartManualTransactionRepository.GetById(sspdEntity.SparepartManualTransactionId);
                spManual.ModifyDate = serverTime;
                spManual.ModifyUserId = userId;
                spManual.QtyRemaining = spManual.QtyRemaining - 1;

                _sparepartManualTransactionRepository.AttachNavigation(spManual.UpdateType);
                _sparepartManualTransactionRepository.AttachNavigation(spManual.Sparepart);
                _sparepartManualTransactionRepository.AttachNavigation(spManual.CreateUser);
                _sparepartManualTransactionRepository.AttachNavigation(spManual.ModifyUser);
                _sparepartManualTransactionRepository.Update(spManual);
                _unitOfWork.SaveChanges();
            }

            _unitOfWork.SaveChanges();
        }

        public bool IsSpecialSparepartDetailInstalled(int specialSparepartDetailId)
        {
            bool result = false;

            SpecialSparepartDetail sspdEntity = _specialSparepartDetailRepository.GetById(specialSparepartDetailId);

            if (sspdEntity.Status == (int)DbConstant.WheelDetailStatus.Installed)
                result = true;

            return result;
        }


        public void UpdateSerialNumber(int specialSparepartDetailId, string newSerialNumber)
        {
            if (specialSparepartDetailId > 0)
            {
                SpecialSparepartDetail sspd = _specialSparepartDetailRepository.GetById(specialSparepartDetailId);
                sspd.SerialNumber = newSerialNumber;
                _specialSparepartDetailRepository.Update(sspd);
                _unitOfWork.SaveChanges();
            }
        }

        public bool IsSerialNumberExist(string sn)
        {
            SpecialSparepartDetail ssd = _specialSparepartDetailRepository.GetMany(
                dtl => dtl.SerialNumber.ToLower() == sn.ToLower() && 
                dtl.Status != (int)DbConstant.WheelDetailStatus.Deleted
                ).FirstOrDefault();

            if (ssd != null)
            {
                if (ssd.Status == (int)DbConstant.SparepartDetailDataStatus.OutService)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
