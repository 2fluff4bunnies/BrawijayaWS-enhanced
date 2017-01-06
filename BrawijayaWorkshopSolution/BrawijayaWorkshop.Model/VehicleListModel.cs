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
    public class VehicleListModel : AppBaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleListModel(IVehicleRepository vehicleRepository, 
            IVehicleWheelRepository vehicleWheelRepository, 
            IUsedGoodRepository usedGoodRepository,
            ISparepartRepository sparepartRepository, 
            ISparepartDetailRepository sparepartDetailRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            ISparepartStockCardRepository sparepartStokCardRepository,
            ISparepartStockCardDetailRepository sparepartStokCardDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _usedGoodRepository = usedGoodRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartStokCardRepository = sparepartStokCardRepository;
            _sparepartStokCardDetailRepository = sparepartStokCardDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<VehicleViewModel> SearchVehicle(string licenseNumber)
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.ActiveLicenseNumber.Contains(licenseNumber) &&
                v.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.VehicleGroupId).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteVehicle(VehicleViewModel vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);

            _vehicleRepository.AttachNavigation(entity.Brand);
            _vehicleRepository.AttachNavigation(entity.Type);
            _vehicleRepository.AttachNavigation(entity.VehicleGroup);
            _vehicleRepository.AttachNavigation(entity.Customer);
            _vehicleRepository.AttachNavigation(entity.CreateUser);
            _vehicleRepository.AttachNavigation(entity.ModifyUser);
            _vehicleRepository.Update(entity);
            _unitOfWork.SaveChanges();

            foreach (var item in _vehicleWheelRepository.GetMany(vw => vw.VehicleId == vehicle.Id && vw.Status ==(int) DbConstant.DefaultDataStatus.Active))
            {
                item.ModifyDate = serverTime;
                item.ModifyUserId = userId;
                item.Status = (int)DbConstant.DefaultDataStatus.Deleted;

                _vehicleWheelRepository.AttachNavigation(item.Vehicle);
                _vehicleWheelRepository.AttachNavigation(item.WheelDetail);
                _vehicleWheelRepository.AttachNavigation(item.CreateUser);
                _vehicleWheelRepository.AttachNavigation(item.ModifyUser);
                _vehicleWheelRepository.Update(item);
                _unitOfWork.SaveChanges();

                SpecialSparepartDetail wdEntity = _specialSparepartDetailRepository.GetById(item.WheelDetailId);
                wdEntity.ModifyDate = serverTime;
                wdEntity.ModifyUserId = userId;
                wdEntity.Status = (int)DbConstant.WheelDetailStatus.Ready;

                _specialSparepartDetailRepository.AttachNavigation(wdEntity.SpecialSparepart);
                _specialSparepartDetailRepository.AttachNavigation(wdEntity.SparepartDetail);
                _specialSparepartDetailRepository.AttachNavigation(wdEntity.CreateUser);
                _specialSparepartDetailRepository.AttachNavigation(wdEntity.ModifyUser);
                _specialSparepartDetailRepository.Update(wdEntity);
                _unitOfWork.SaveChanges();

                SparepartDetail spdEntity = _sparepartDetailRepository.GetById(wdEntity.SparepartDetailId);
                spdEntity.ModifyDate = serverTime;
                spdEntity.ModifyUserId = userId;
                spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                _sparepartDetailRepository.AttachNavigation(spdEntity.Sparepart);
                _sparepartDetailRepository.AttachNavigation(spdEntity.SparepartManualTransaction);
                _sparepartDetailRepository.AttachNavigation(spdEntity.PurchasingDetail);
                _sparepartDetailRepository.AttachNavigation(spdEntity.CreateUser);
                _sparepartDetailRepository.AttachNavigation(spdEntity.ModifyUser);
                _sparepartDetailRepository.Update(spdEntity);
                _unitOfWork.SaveChanges();

                Sparepart spEntity = _sparepartRepository.GetById(wdEntity.SparepartDetail.SparepartId);
                spEntity.ModifyDate = serverTime;
                spEntity.ModifyUserId = userId;
                spEntity.StockQty = spEntity.StockQty + 1;

                _sparepartRepository.AttachNavigation(spEntity.UnitReference);
                _sparepartRepository.AttachNavigation(spEntity.CategoryReference);
                _sparepartRepository.AttachNavigation(spEntity.CreateUser);
                _sparepartRepository.AttachNavigation(spEntity.ModifyUser);
                _sparepartRepository.Update(spEntity);
                _unitOfWork.SaveChanges();

                SparepartStockCard stockCard = new SparepartStockCard();
                Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.MODUL_VEHICLE).FirstOrDefault();

                stockCard.CreateUserId = userId;
                stockCard.PurchaseDate = serverTime;
                stockCard.PrimaryKeyValue = vehicle.Id;
                stockCard.ReferenceTableId = transactionReferenceTable.Id;
                stockCard.SparepartId = spEntity.Id;
                stockCard.Description = "Delete Vehicle";
                stockCard.QtyIn = 1;
                stockCard.QtyInPrice = Convert.ToDouble(spdEntity.PurchasingDetail != null ? spdEntity.PurchasingDetail.Price : spdEntity.SparepartManualTransaction != null ? spdEntity.SparepartManualTransaction.Price : 0);

                SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(spEntity.Id);
                double lastStock = 0;
                double lastStockPrice = 0;
                if (lastStockCard != null)
                {
                    lastStock = lastStockCard.QtyLast;
                    lastStockPrice = lastStockCard.QtyLastPrice;
                }
                stockCard.QtyFirst = lastStock;
                stockCard.QtyFirstPrice = lastStockPrice;
                stockCard.QtyLast = lastStock + stockCard.QtyIn;
                stockCard.QtyLastPrice = lastStockPrice + stockCard.QtyInPrice;
                _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                stockCard = _sparepartStokCardRepository.Add(stockCard);
                _unitOfWork.SaveChanges();

                if (spdEntity.PurchasingDetail != null)
                {
                    SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                    stockCardDtail.ParentStockCard = stockCard;
                    stockCardDtail.PricePerItem = Convert.ToDouble(spdEntity.PurchasingDetail.Price);
                    stockCardDtail.QtyIn = 1;
                    stockCardDtail.QtyInPrice = Convert.ToDouble(spdEntity.PurchasingDetail.Price);
                    SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(spdEntity.Sparepart.Id, spdEntity.PurchasingDetail.PurchasingId);
                    double lastStockDetail = 0;
                    double lastStockDetailPrice = 0;
                    if (lastStockCardDetail != null)
                    {
                        lastStockDetail = lastStockCardDetail.QtyLast;
                        lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                    }
                    stockCardDtail.QtyFirst = lastStockDetail;
                    stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                    stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                    stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                    stockCardDtail.PurchasingId = spdEntity.PurchasingDetail.PurchasingId;

                    _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                    _sparepartStokCardDetailRepository.Add(stockCardDtail);
                    _unitOfWork.SaveChanges();
                }

                if (spdEntity.SparepartManualTransaction != null)
                {
                    SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                    stockCardDtail.ParentStockCard = stockCard;
                    stockCardDtail.PricePerItem = Convert.ToDouble(spdEntity.SparepartManualTransaction.Price);
                    stockCardDtail.QtyIn = 1;
                    stockCardDtail.QtyInPrice = Convert.ToDouble(1 * spdEntity.SparepartManualTransaction.Price);
                    SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(spdEntity.Sparepart.Id, spdEntity.SparepartManualTransactionId.Value);
                    double lastStockDetail = 0;
                    double lastStockDetailPrice = 0;
                    if (lastStockCardDetail != null)
                    {
                        lastStockDetail = lastStockCardDetail.QtyLast;
                        lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                    }
                    stockCardDtail.QtyFirst = lastStockDetail;
                    stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                    stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                    stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                    stockCardDtail.SparepartManualTransactionId = spdEntity.SparepartManualTransactionId;

                    _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                    _sparepartStokCardDetailRepository.Add(stockCardDtail);
                    _unitOfWork.SaveChanges();
                }
            }

            
        }
    }
}
