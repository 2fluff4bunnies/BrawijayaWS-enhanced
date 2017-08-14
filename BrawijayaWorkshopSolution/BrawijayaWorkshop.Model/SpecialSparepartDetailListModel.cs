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
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartStockCardRepository _sparepartStockCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStockCardDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SpecialSparepartDetailListModel(ISpecialSparepartRepository WheelRepository,
            ISpecialSparepartDetailRepository WheelDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ISparepartStockCardRepository sparepartStockCardRepository,
            ISparepartStockCardDetailRepository sparepartStockCardDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _specialSparepartRepository = WheelRepository;
            _specialSparepartDetailRepository = WheelDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _sparepartStockCardRepository = sparepartStockCardRepository;
            _sparepartStockCardDetailRepository = sparepartStockCardDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SpecialSparepartDetailViewModel> SearchDetail(int specialSparepartId,
            DbConstant.WheelDetailStatus status)
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(whd => whd.Status == (int)status
                && whd.SpecialSparepartId == specialSparepartId).ToList();

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

            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.SpecialSparepart);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.SparepartDetail);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.CreateUser);
            _specialSparepartDetailRepository.AttachNavigation(sspdEntity.ModifyUser);
            _specialSparepartDetailRepository.Update(sspdEntity);
            _unitOfWork.SaveChanges();

            SparepartDetail spdEntity = _sparepartDetailRepository.GetById(sspdEntity.SparepartDetailId);
            spdEntity.ModifyDate = serverTime;
            spdEntity.ModifyUserId = userId;
            spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.Deleted;

            _sparepartDetailRepository.AttachNavigation(spdEntity.Sparepart);
            _sparepartDetailRepository.AttachNavigation(spdEntity.SparepartManualTransaction);
            _sparepartDetailRepository.AttachNavigation(spdEntity.PurchasingDetail);
            _sparepartDetailRepository.AttachNavigation(spdEntity.CreateUser);
            _sparepartDetailRepository.AttachNavigation(spdEntity.ModifyUser);
            _sparepartDetailRepository.Update(spdEntity);
            _unitOfWork.SaveChanges();

            Sparepart spEntity = _sparepartRepository.GetById(spdEntity.SparepartId);
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
            stockCard.QtyOutPrice = Convert.ToDouble(spdEntity.PurchasingDetail != null ? spdEntity.PurchasingDetail.Price : spdEntity.SparepartManualTransaction != null ? spdEntity.SparepartManualTransaction.Price : 0);

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

            if (spdEntity.PurchasingDetail != null)
            {
                SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                stockCardDtail.ParentStockCard = stockCard;
                stockCardDtail.PricePerItem = Convert.ToDouble(spdEntity.PurchasingDetail.Price);
                stockCardDtail.QtyOut = 1;
                stockCardDtail.QtyOutPrice = Convert.ToDouble(spdEntity.PurchasingDetail.Price);
                SparepartStockCardDetail lastStockCardDetail = _sparepartStockCardDetailRepository.RetrieveLastCardDetailByPurchasingId(spdEntity.Sparepart.Id, spdEntity.PurchasingDetail.PurchasingId);
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
                stockCardDtail.PurchasingId = spdEntity.PurchasingDetail.PurchasingId;

                _sparepartStockCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                _sparepartStockCardDetailRepository.Add(stockCardDtail);
                _unitOfWork.SaveChanges();
            }

            if (spdEntity.SparepartManualTransaction != null)
            {
                SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                stockCardDtail.ParentStockCard = stockCard;
                stockCardDtail.PricePerItem = Convert.ToDouble(spdEntity.SparepartManualTransaction.Price);
                stockCardDtail.QtyOut = 1;
                stockCardDtail.QtyOutPrice = Convert.ToDouble(1 * spdEntity.SparepartManualTransaction.Price);
                SparepartStockCardDetail lastStockCardDetail = _sparepartStockCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(spdEntity.Sparepart.Id, spdEntity.SparepartManualTransactionId.Value);
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
                stockCardDtail.SparepartManualTransactionId = spdEntity.SparepartManualTransactionId;

                _sparepartStockCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                _sparepartStockCardDetailRepository.Add(stockCardDtail);
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
    }
}
