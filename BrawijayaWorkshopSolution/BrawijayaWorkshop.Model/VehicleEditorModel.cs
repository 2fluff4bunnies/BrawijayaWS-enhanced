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
    public class VehicleEditorModel : AppBaseModel
    {
        private ICustomerRepository _customerRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private ITypeRepository _typeRepository;
        private IBrandRepository _brandRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleEditorModel(ICustomerRepository customerRepository, IVehicleGroupRepository vehicleGroupRepository,
            IVehicleRepository vehicleRepository,
            IVehicleDetailRepository vehicleDetailRepository, IVehicleWheelRepository vehicleWheelRepository,
            ISparepartRepository sparepartRepository, ITypeRepository typeRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository, IBrandRepository brandRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            ISparepartStockCardRepository sparepartStokCardRepository,
            ISparepartStockCardDetailRepository sparepartStokCardDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _customerRepository = customerRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _specialSparepartDetailRepository = wheelDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _typeRepository = typeRepository;
            _brandRepository = brandRepository;
            _sparepartStokCardRepository = sparepartStokCardRepository;
            _sparepartStokCardDetailRepository = sparepartStokCardDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetCustomersList()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleGroupViewModel> GetVehicleGroupByCustomer(int customerId)
        {
            List<VehicleGroup> result = _vehicleGroupRepository.GetMany(vg => vg.Status == (int)DbConstant.DefaultDataStatus.Active &&
                vg.CustomerId == customerId).ToList();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            return Map(result, mappedResult);
        }

        public List<SpecialSparepartDetailViewModel> RetrieveAllWheelDetails(int vehicleId, List<VehicleWheelViewModel> currentVehicleWheel)
        {
            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            List<SpecialSparepartDetail> result = new List<SpecialSparepartDetail>();

            if (currentVehicleWheel != null && currentVehicleWheel.Count > 0)
            {
                IEnumerable<int> existingWheelDetailId = from item in currentVehicleWheel
                                                         select item.WheelDetailId;

                result = _specialSparepartDetailRepository.GetMany(wd => (wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                                || wd.Status == (int)DbConstant.WheelDetailStatus.Installed)
                                                                                && wd.SpecialSparepart.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
                                                                                && !existingWheelDetailId.Any(vw => vw == wd.Id)
                                                                          ).ToList();
            }
            else
            {

                result = _specialSparepartDetailRepository.GetMany(wd => (wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                             || wd.Status == (int)DbConstant.WheelDetailStatus.Installed)
                                                                             && wd.SpecialSparepart.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
                                                                       ).ToList();
            }

            return Map(result, mappedResult);
        }

        public List<SpecialSparepartDetailViewModel> RetrieveReadyWheelDetails()
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(wd => wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                                       && wd.SpecialSparepart.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL).ToList();
            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }

        public SpecialSparepartDetailViewModel SearchBySerialNumber(string serialNumber)
        {
            SpecialSparepartDetail result = _specialSparepartDetailRepository.GetMany(ssd => ssd.SerialNumber.ToLower() == serialNumber.ToLower() && ssd.Status != (int)DbConstant.WheelDetailStatus.Deleted).FirstOrDefault();

            SpecialSparepartDetailViewModel mappedResult = new SpecialSparepartDetailViewModel();

            return Map(result, mappedResult);
        }


        public List<VehicleWheelViewModel> ReGenerateVehicleWheelList(List<VehicleWheelViewModel> vehicleWheelList, int userId)
        {
            List<VehicleWheelViewModel> result = new List<VehicleWheelViewModel>();

            foreach (var item in vehicleWheelList)
            {
                if (!string.IsNullOrEmpty(item.WheelDetail.SerialNumber))
                {
                    SpecialSparepartDetailViewModel wheelDetail = SearchBySerialNumber(item.WheelDetail.SerialNumber);

                    if (item.Id > 0 && item.WheelDetailId == wheelDetail.Id)
                    {
                        result.Add(item);
                    }
                    else
                    {
                        if (item.WheelDetailId != wheelDetail.Id && item.WheelDetailId > 0)
                        {
                            RevertVehicleWheel(item.Id, userId);
                        }


                        result.Add(new VehicleWheelViewModel
                        {
                            VehicleId = item.VehicleId,
                            WheelDetailId = wheelDetail.Id
                        });
                    }
                }
            }

            return result;
        }

        public void InsertVehicle(VehicleViewModel vehicle, DateTime expirationDate,
             List<VehicleWheelViewModel> vehicleWheels, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    Vehicle entity = new Vehicle();
                    Map(vehicle, entity);
                    entity.CreateDate = entity.ModifyDate = serverTime;
                    entity.CreateUserId = entity.ModifyUserId = userId;
                    entity.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _vehicleRepository.AttachNavigation(entity.Brand);
                    _vehicleRepository.AttachNavigation(entity.Type);
                    _vehicleRepository.AttachNavigation(entity.VehicleGroup);
                    _vehicleRepository.AttachNavigation(entity.Customer);
                    _vehicleRepository.AttachNavigation(entity.CreateUser);
                    _vehicleRepository.AttachNavigation(entity.ModifyUser);
                    var insertedVehicle = _vehicleRepository.Add(entity);
                    _unitOfWork.SaveChanges();

                    VehicleDetail vehicleDetail = new VehicleDetail
                    {
                        VehicleId = insertedVehicle.Id,
                        LicenseNumber = insertedVehicle.ActiveLicenseNumber,
                        ExpirationDate = expirationDate,
                        CreateDate = serverTime,
                        ModifyDate = serverTime,
                        ModifyUserId = userId,
                        CreateUserId = userId,
                        Status = (int)DbConstant.LicenseNumberStatus.Active
                    };

                    _vehicleDetailRepository.AttachNavigation(vehicleDetail.Vehicle);
                    _vehicleDetailRepository.AttachNavigation(vehicleDetail.CreateUser);
                    _vehicleDetailRepository.AttachNavigation(vehicleDetail.ModifyUser);
                    _vehicleDetailRepository.Add(vehicleDetail);
                    _unitOfWork.SaveChanges();

                    foreach (var vw in vehicleWheels)
                    {
                        if (vw.WheelDetailId > 0)
                        {
                            VehicleWheel vwEntity = new VehicleWheel();
                            Map(vw, vwEntity);
                            vwEntity.Notes = vw.Notes;
                            vwEntity.WheelDetailId = vw.WheelDetailId;
                            vwEntity.CreateDate = vwEntity.ModifyDate = serverTime;
                            vwEntity.CreateUserId = vwEntity.ModifyUserId = userId;
                            vwEntity.VehicleId = insertedVehicle.Id;
                            vwEntity.Status = (int)DbConstant.DefaultDataStatus.Active;

                            _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                            _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                            _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                            _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                            _vehicleWheelRepository.Add(vwEntity);
                            _unitOfWork.SaveChanges();

                            SpecialSparepartDetail wdEntity = _specialSparepartDetailRepository.GetById(vw.WheelDetailId);
                            wdEntity.ModifyDate = serverTime;
                            wdEntity.ModifyUserId = userId;
                            wdEntity.Status = (int)DbConstant.WheelDetailStatus.Installed;

                            _specialSparepartDetailRepository.AttachNavigation(wdEntity.SpecialSparepart);
                            _specialSparepartDetailRepository.AttachNavigation(wdEntity.SparepartDetail);
                            _specialSparepartDetailRepository.AttachNavigation(wdEntity.CreateUser);
                            _specialSparepartDetailRepository.AttachNavigation(wdEntity.ModifyUser);
                            _specialSparepartDetailRepository.Update(wdEntity);
                            _unitOfWork.SaveChanges();

                            SparepartDetail spdEntity = _sparepartDetailRepository.GetById(wdEntity.SparepartDetailId);
                            spdEntity.ModifyDate = serverTime;
                            spdEntity.ModifyUserId = userId;
                            spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.OutInstalled;

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
                            spEntity.StockQty = spEntity.StockQty - 1;

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
                            stockCard.PrimaryKeyValue = wdEntity.Id;
                            stockCard.ReferenceTableId = transactionReferenceTable.Id;
                            stockCard.SparepartId = spEntity.Id;
                            stockCard.Description = "Vehicle Insert";
                            stockCard.QtyOut = 1;
                            stockCard.QtyOutPrice = Convert.ToDouble(spdEntity.PurchasingDetail != null ? spdEntity.PurchasingDetail.Price : spdEntity.SparepartManualTransaction != null ? spdEntity.SparepartManualTransaction.Price : 0);

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
                            stockCard.QtyLast = lastStock - stockCard.QtyOut;
                            stockCard.QtyLastPrice = lastStockPrice - stockCard.QtyOutPrice;
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
                                stockCardDtail.QtyOut = 1;
                                stockCardDtail.QtyOutPrice = Convert.ToDouble(spdEntity.PurchasingDetail.Price);
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
                                stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
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
                                stockCardDtail.QtyOut = 1;
                                stockCardDtail.QtyOutPrice = Convert.ToDouble(1 * spdEntity.SparepartManualTransaction.Price);
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
                                stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                                stockCardDtail.SparepartManualTransactionId = spdEntity.SparepartManualTransactionId;

                                _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                                _sparepartStokCardDetailRepository.Add(stockCardDtail);
                                _unitOfWork.SaveChanges();
                            }

                            _unitOfWork.SaveChanges();
                        }
                    }

                    _unitOfWork.SaveChanges();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
            
        }

        public void UpdateVehicle(VehicleViewModel vehicle, List<VehicleWheelViewModel> vehicleWheels,
            List<VehicleWheelViewModel> vehicleWheelExchanged, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
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

            if (vehicleWheelExchanged.Count > 0)
            {
                foreach (var vw in vehicleWheelExchanged)
                {
                    VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                    vwEntity.WheelDetailId = vw.WheelDetailId;
                    vwEntity.ModifyDate = serverTime;
                    vwEntity.ModifyUserId = userId;
                    vwEntity.Notes = vw.Notes;

                    _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                    _vehicleWheelRepository.Update(vwEntity);
                    _unitOfWork.SaveChanges();
                }
            }

            foreach (var vw in vehicleWheels)
            {
                if (vw.Id > 0)
                {
                    VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                    vwEntity.WheelDetailId = vw.WheelDetailId;
                    vwEntity.ModifyDate = serverTime;
                    vwEntity.ModifyUserId = userId;
                    vwEntity.Notes = vw.Notes;

                    _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                    _vehicleWheelRepository.Update(vwEntity);
                    _unitOfWork.SaveChanges();
                }
                else
                {
                    VehicleWheel vwEntity = new VehicleWheel();
                    Map(vw, vwEntity);
                    vwEntity.Notes = vw.Notes;
                    vwEntity.VehicleId = vehicle.Id;
                    vwEntity.CreateDate = vwEntity.ModifyDate = serverTime;
                    vwEntity.CreateUserId = vwEntity.ModifyUserId = userId;
                    vwEntity.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                    _vehicleWheelRepository.Add(vwEntity);
                    _unitOfWork.SaveChanges();

                    SpecialSparepartDetail wdEntity = _specialSparepartDetailRepository.GetById(vw.WheelDetailId);
                    wdEntity.ModifyDate = serverTime;
                    wdEntity.ModifyUserId = userId;
                    wdEntity.Status = (int)DbConstant.WheelDetailStatus.Installed;

                    _specialSparepartDetailRepository.AttachNavigation(wdEntity.SpecialSparepart);
                    _specialSparepartDetailRepository.AttachNavigation(wdEntity.SparepartDetail);
                    _specialSparepartDetailRepository.AttachNavigation(wdEntity.CreateUser);
                    _specialSparepartDetailRepository.AttachNavigation(wdEntity.ModifyUser);
                    _specialSparepartDetailRepository.Update(wdEntity);
                    _unitOfWork.SaveChanges();

                    SparepartDetail spdEntity = _sparepartDetailRepository.GetById(wdEntity.SparepartDetailId);
                    spdEntity.ModifyDate = serverTime;
                    spdEntity.ModifyUserId = userId;
                    spdEntity.Status = (int)DbConstant.SparepartDetailDataStatus.OutInstalled;

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
                    spEntity.StockQty = spEntity.StockQty - 1;

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
                    stockCard.PrimaryKeyValue = wdEntity.Id;
                    stockCard.ReferenceTableId = transactionReferenceTable.Id;
                    stockCard.SparepartId = spEntity.Id;
                    stockCard.Description = "Vehicle Update";
                    stockCard.QtyOut = 1;
                    stockCard.QtyOutPrice = Convert.ToDouble(spdEntity.PurchasingDetail != null ? spdEntity.PurchasingDetail.Price : spdEntity.SparepartManualTransaction != null ? spdEntity.SparepartManualTransaction.Price : 0);

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
                    stockCard.QtyLast = lastStock - stockCard.QtyOut;
                    stockCard.QtyLastPrice = lastStockPrice - stockCard.QtyOutPrice;
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
                        stockCardDtail.QtyOut = 1;
                        stockCardDtail.QtyOutPrice = Convert.ToDouble(spdEntity.PurchasingDetail.Price);
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
                        stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                        stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
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
                        stockCardDtail.QtyOut = 1;
                        stockCardDtail.QtyOutPrice = Convert.ToDouble(1 * spdEntity.SparepartManualTransaction.Price);
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
                        stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                        stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                        stockCardDtail.SparepartManualTransactionId = spdEntity.SparepartManualTransactionId;

                        _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                        _sparepartStokCardDetailRepository.Add(stockCardDtail);
                        _unitOfWork.SaveChanges();
                    }

                    _unitOfWork.SaveChanges();
                }
            }

            _unitOfWork.SaveChanges();
        }

        public void DeleteVehicle(VehicleViewModel vehicle, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            vehicle.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);
            _vehicleRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            return Map(result, mappedResult);
        }


        public VehicleWheelViewModel IsWheelUsedByOtherVehicle(int wheelDetailId, int vehicleId)
        {
            VehicleWheel result = _vehicleWheelRepository.GetMany(
                vw => vw.VehicleId != vehicleId && vw.WheelDetailId == wheelDetailId).FirstOrDefault();

            VehicleWheelViewModel mappedResult = new VehicleWheelViewModel();

            return Map(result, mappedResult);
        }

        public int GetCurrentWheelDetailId(int vehicleWheelId)
        {
            VehicleWheel result = _vehicleWheelRepository.GetById(vehicleWheelId);

            return result.WheelDetailId;
        }

        public List<TypeViewModel> GetTypeList()
        {
            List<BrawijayaWorkshop.Database.Entities.Type> result = _typeRepository.GetMany(t => t.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<TypeViewModel> mappedResult = new List<TypeViewModel>();

            return Map(result, mappedResult);
        }

        public List<BrandViewModel> GetBrandList()
        {
            List<Brand> result = _brandRepository.GetMany(b => b.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<BrandViewModel> mappedResult = new List<BrandViewModel>();

            return Map(result, mappedResult);
        }

        public bool IsCodeExist(string code, VehicleViewModel selectedVehicle)
        {
            Vehicle result = new Vehicle();

            if (selectedVehicle != null)
            {
                result = _vehicleRepository.GetMany(v =>
                   v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                   v.Code.ToLower() == code.ToLower() &&
                   v.Id != selectedVehicle.Id
                   ).FirstOrDefault();
            }
            else
            {
                result = _vehicleRepository.GetMany(v =>
                   v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                   v.Code.ToLower() == code.ToLower()
                   ).FirstOrDefault();
            }

            return result != null;
        }

        public bool IsLicenseNumberExist(string licenseNumber, VehicleViewModel selectedVehicle)
        {
            Vehicle result = new Vehicle();

            if (selectedVehicle != null)
            {
                result = _vehicleRepository.GetMany(v =>
                   v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                   v.ActiveLicenseNumber.ToLower() == licenseNumber.ToLower() &&
                   v.Id != selectedVehicle.Id
                   ).FirstOrDefault();
            }
            else
            {
                result = _vehicleRepository.GetMany(v =>
                   v.Status == (int)DbConstant.DefaultDataStatus.Active &&
                   v.ActiveLicenseNumber.ToLower() == licenseNumber.ToLower()
                   ).FirstOrDefault();
            }

            return result != null;
        }


        public void RevertVehicleWheel(int vehicleWheelId, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    DateTime serverTime = DateTime.Now;

                    VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vehicleWheelId);
                    vwEntity.ModifyDate = serverTime;
                    vwEntity.ModifyUserId = userId;
                    vwEntity.Status = (int)DbConstant.DefaultDataStatus.Deleted;

                    _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                    _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                    _vehicleWheelRepository.Update(vwEntity);
                    _unitOfWork.SaveChanges();

                    SpecialSparepartDetail wdEntity = _specialSparepartDetailRepository.GetById(vwEntity.WheelDetailId);
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
                    Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_VEHICLE).FirstOrDefault();

                    stockCard.CreateUserId = userId;
                    stockCard.PurchaseDate = serverTime;
                    stockCard.PrimaryKeyValue = wdEntity.Id;
                    stockCard.ReferenceTableId = transactionReferenceTable.Id;
                    stockCard.SparepartId = spEntity.Id;
                    stockCard.Description = "Revert Vehicle Wheel";
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
