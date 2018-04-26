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
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleListModel(IVehicleRepository vehicleRepository, 
            IVehicleWheelRepository vehicleWheelRepository, 
            IUsedGoodRepository usedGoodRepository,
            ISparepartRepository sparepartRepository, 
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            ISparepartStockCardRepository sparepartStokCardRepository,
            ISparepartStockCardDetailRepository sparepartStokCardDetailRepository,
            IReferenceRepository referenceRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _usedGoodRepository = usedGoodRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartStokCardRepository = sparepartStokCardRepository;
            _sparepartStokCardDetailRepository = sparepartStokCardDetailRepository;
            _referenceRepository = referenceRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
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
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
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

                    foreach (var item in _vehicleWheelRepository.GetMany(vw => vw.VehicleId == vehicle.Id && vw.Status == (int)DbConstant.DefaultDataStatus.Active))
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

                        _specialSparepartDetailRepository.AttachNavigation(wdEntity.Sparepart);
                        _specialSparepartDetailRepository.AttachNavigation(wdEntity.PurchasingDetail);
                        _specialSparepartDetailRepository.AttachNavigation(wdEntity.SparepartManualTransaction);
                        _specialSparepartDetailRepository.AttachNavigation(wdEntity.CreateUser);
                        _specialSparepartDetailRepository.AttachNavigation(wdEntity.ModifyUser);
                        _specialSparepartDetailRepository.Update(wdEntity);
                        _unitOfWork.SaveChanges();

                        Sparepart spEntity = _sparepartRepository.GetById(wdEntity.SparepartId);
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
                        Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_VEHICLE).FirstOrDefault();

                        stockCard.CreateUserId = userId;
                        stockCard.PurchaseDate = serverTime;
                        stockCard.PrimaryKeyValue = vehicle.Id;
                        stockCard.ReferenceTableId = transactionReferenceTable.Id;
                        stockCard.SparepartId = spEntity.Id;
                        stockCard.Description = "Delete Vehicle";
                        stockCard.QtyIn = 1;
                        stockCard.QtyInPrice = Convert.ToDouble(wdEntity.PurchasingDetail != null ? wdEntity.PurchasingDetail.Price : wdEntity.SparepartManualTransaction != null ? wdEntity.SparepartManualTransaction.Price : 0);

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

                        if (wdEntity.PurchasingDetail != null)
                        {
                            SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                            stockCardDtail.ParentStockCard = stockCard;
                            stockCardDtail.PricePerItem = Convert.ToDouble(wdEntity.PurchasingDetail.Price);
                            stockCardDtail.QtyIn = 1;
                            stockCardDtail.QtyInPrice = Convert.ToDouble(wdEntity.PurchasingDetail.Price);
                            SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(wdEntity.Sparepart.Id, wdEntity.PurchasingDetail.PurchasingId);
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
                            stockCardDtail.PurchasingId = wdEntity.PurchasingDetail.PurchasingId;

                            _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                            _sparepartStokCardDetailRepository.Add(stockCardDtail);
                            _unitOfWork.SaveChanges();

                            PurchasingDetail pDetail = _purchasingDetailRepository.GetById(wdEntity.PurchasingDetailId);
                            pDetail.ModifyDate = serverTime;
                            pDetail.ModifyUserId = userId;
                            pDetail.QtyRemaining = pDetail.QtyRemaining + 1;

                            _purchasingDetailRepository.AttachNavigation(pDetail.Purchasing);
                            _purchasingDetailRepository.AttachNavigation(pDetail.Sparepart);
                            _purchasingDetailRepository.AttachNavigation(pDetail.CreateUser);
                            _purchasingDetailRepository.AttachNavigation(pDetail.ModifyUser);
                            _purchasingDetailRepository.Update(pDetail);
                            _unitOfWork.SaveChanges();
                        }

                        if (wdEntity.SparepartManualTransaction != null)
                        {
                            SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                            stockCardDtail.ParentStockCard = stockCard;
                            stockCardDtail.PricePerItem = Convert.ToDouble(wdEntity.SparepartManualTransaction.Price);
                            stockCardDtail.QtyIn = 1;
                            stockCardDtail.QtyInPrice = Convert.ToDouble(1 * wdEntity.SparepartManualTransaction.Price);
                            SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(wdEntity.Sparepart.Id, wdEntity.SparepartManualTransactionId.Value);
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
                            stockCardDtail.SparepartManualTransactionId = wdEntity.SparepartManualTransactionId;

                            _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                            _sparepartStokCardDetailRepository.Add(stockCardDtail);
                            _unitOfWork.SaveChanges();

                            SparepartManualTransaction spManual = _sparepartManualTransactionRepository.GetById(wdEntity.SparepartManualTransactionId);
                            spManual.ModifyDate = serverTime;
                            spManual.ModifyUserId = userId;
                            spManual.QtyRemaining = spManual.QtyRemaining + 1;

                            _sparepartManualTransactionRepository.AttachNavigation(spManual.UpdateType);
                            _sparepartManualTransactionRepository.AttachNavigation(spManual.Sparepart);
                            _sparepartManualTransactionRepository.AttachNavigation(spManual.CreateUser);
                            _sparepartManualTransactionRepository.AttachNavigation(spManual.ModifyUser);
                            _sparepartManualTransactionRepository.Update(spManual);
                            _unitOfWork.SaveChanges();
                        }
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}
