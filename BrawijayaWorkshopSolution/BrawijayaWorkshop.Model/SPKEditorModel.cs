using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SPKEditorModel : AppBaseModel
    {
        private ISettingRepository _settingRepository;
        private IReferenceRepository _referenceRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        //private ISparepartDetailRepository _sparepartDetailRepository;
        private IUsedGoodRepository _usedGoodRepository;
        //private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IWheelExchangeHistoryRepository _wheelExchangeHistoryRepository;
        private ISPKScheduleRepository _SPKScheduleRepository;
        private ISparepartStockCardRepository _sparepartStokCardRepository;
        private ISparepartStockCardDetailRepository _sparepartStokCardDetailRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransaction;
        private ICustomerRepository _customerRepository;
        private IBrandRepository _brandRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public SPKEditorModel(ISettingRepository settingRepository, IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            //ISparepartDetailRepository sparepartDetailRepository,
            IUsedGoodRepository usedGoodRepository,
            //ISpecialSparepartRepository specialSparepartRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IVehicleWheelRepository vehicleWheelRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IWheelExchangeHistoryRepository WheelExchangeHistoryRepository,
            ISPKScheduleRepository spkScheduleRepository,
            ISparepartStockCardRepository sparepartStokCardRepository,
            ISparepartStockCardDetailRepository sparepartStokCardDetailRepository,
            IVehicleGroupRepository vehicleGroupRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransaction,
            ICustomerRepository customerRepository,
            IBrandRepository brandRepository,
            IMechanicRepository mechanicRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _settingRepository = settingRepository;
            _referenceRepository = referenceRepository;
            _vehicleRepository = vehicleRepository;
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            //_sparepartDetailRepository = sparepartDetailRepository;
            _usedGoodRepository = usedGoodRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            //_specialSparepartRepository = specialSparepartRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _SPKScheduleRepository = spkScheduleRepository;
            _wheelExchangeHistoryRepository = WheelExchangeHistoryRepository;
            _sparepartStokCardRepository = sparepartStokCardRepository;
            _sparepartStokCardDetailRepository = sparepartStokCardDetailRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransaction = sparepartManualTransaction;
            _customerRepository = customerRepository;
            _brandRepository = brandRepository;
            _mechanicRepository = mechanicRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleViewModel> GetSPKVehicleList()
        {
            //List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<Vehicle> result = _vehicleRepository.GetVehicleForLookUp();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            //return Map(result, mappedResult);

            foreach (var vehicle in result)
            {
                mappedResult.Add(new VehicleViewModel
                {
                    Id = vehicle.Id,
                    TypeId = vehicle.TypeId,
                    BrandId = vehicle.BrandId,
                    ActiveLicenseNumber = vehicle.ActiveLicenseNumber,
                    YearOfPurchase = vehicle.YearOfPurchase,
                    CustomerId = vehicle.CustomerId,
                    VehicleGroupId = vehicle.VehicleGroupId,
                    Kilometers = vehicle.Kilometers,
                    Code = vehicle.Code,
                    CompanyName = vehicle.Customer.CompanyName,
                    VehicleGroupName = vehicle.VehicleGroup.Name,
                });
            }

            return mappedResult;
        }


        public List<SPKDetailSparepartViewModel> GetEndorsedSPKSparepartList(int spkId)
        {
            List<SPKDetailSparepart> result = new List<SPKDetailSparepart>();

            List<SPKDetailSparepart> sparepartList = _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == spkId).ToList();

            foreach (var item in sparepartList)
            {
                result.Add(new SPKDetailSparepart
                {
                    Sparepart = item.Sparepart,
                    SparepartId = item.SparepartId,
                    TotalQuantity = item.TotalQuantity,
                    TotalPrice = item.TotalPrice,
                });
            }

            List<SPKDetailSparepartViewModel> mappedResult = new List<SPKDetailSparepartViewModel>();

            return Map(result, mappedResult);
        }

        public List<SPKDetailSparepartDetailViewModel> GetEndorsedSPKSparepartDetailList(int spkId)
        {
            List<SPKDetailSparepartDetail> result = new List<SPKDetailSparepartDetail>();

            List<SPKDetailSparepartDetail> sparepartDetailList = _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SPKDetailSparepart.SPK.Id == spkId).ToList();

            foreach (var item in sparepartDetailList)
            {
                result.Add(new SPKDetailSparepartDetail
                {
                    SPKDetailSparepart = item.SPKDetailSparepart,
                    SPKDetailSparepartId = item.SPKDetailSparepartId,
                    //SparepartDetail = item.SparepartDetail,
                    //SparepartDetailId = item.SparepartDetailId
                });
            }

            List<SPKDetailSparepartDetailViewModel> mappedResult = new List<SPKDetailSparepartDetailViewModel>();

            return Map(result, mappedResult);
        }

        public string GetFingerprintIpAddress()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_IPADDRESS).FirstOrDefault().Value;
        }

        public string GetFingerprintPort()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_PORT).FirstOrDefault().Value;
        }

        public SPKViewModel InsertSPK(SPKViewModel spk,
            List<SPKDetailSparepartViewModel> spkSparepartList,
            List<SPKDetailSparepartDetailViewModel> spkSparepartDetailList,
            List<VehicleWheelViewModel> vehicleWheelList,
            List<SPKScheduleViewModel> assignedScheduleList,
            int userId,
            bool isNeedApproval)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    //DateTime serverTime = DateTime.Now;
                    //Invoice insertedInvoice = new Invoice();
                    //Reference spkReference = _referenceRepository.GetById(spk.CategoryReferenceId);
                    //bool isSPKSales = spkReference.Code == DbConstant.REF_SPK_CATEGORY_SALE;

                    //string code = "SPK-";

                    //switch (spkReference.Code)
                    //{
                    //    case DbConstant.REF_SPK_CATEGORY_SERVICE: code = code + "S";
                    //        break;
                    //    case DbConstant.REF_SPK_CATEGORY_REPAIR: code = code + "P";
                    //        break;
                    //    case DbConstant.REF_SPK_CATEGORY_SALE: code = code + "L";
                    //        break;
                    //    case DbConstant.REF_SPK_CATEGORY_INVENTORY: code = code + "I";
                    //        break;
                    //}

                    //code = code + "-" + spk.Vehicle.ActiveLicenseNumber + "-" + spk.CreateDate.Month.ToString() + spk.CreateDate.Day.ToString() + "-";

                    ////get total SPK created today
                    //List<SPK> todaySPK = _SPKRepository.GetMany(s => s.Code.ToString().Contains(code) && s.CreateDate.Year == spk.CreateDate.Year).ToList();

                    //code = code + (todaySPK.Count + 1);

                    //spk.Code = code;
                    //spk.ModifyDate = serverTime;
                    //spk.ModifyUserId = userId;
                    //spk.CreateUserId = userId;
                    //spk.Status = (int)DbConstant.DefaultDataStatus.Active;

                    //if (isNeedApproval)
                    //{
                    //    spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Pending;
                    //    spk.StatusOverLimit = 1;
                    //    spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Pending;
                    //}
                    //else
                    //{
                    //    spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                    //    spk.StatusOverLimit = 0;
                    //    spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
                    //}

                    //spk.StatusCompletedId = isSPKSales ? (int)DbConstant.SPKCompletionStatus.Completed : (int)DbConstant.SPKCompletionStatus.InProgress;

                    //SPK entitySPK = new SPK();
                    //Vehicle spkVehicle = _vehicleRepository.GetById(spk.VehicleId);

                    //Map(spk, entitySPK);
                    //entitySPK.Vehicle = spkVehicle;

                    //_vehicleRepository.AttachNavigation<Vehicle>(entitySPK.Vehicle);
                    //_vehicleRepository.AttachNavigation<VehicleGroup>(entitySPK.Vehicle.VehicleGroup);
                    //_referenceRepository.AttachNavigation<Reference>(entitySPK.CategoryReference);
                    //_SPKRepository.AttachNavigation<SPK>(entitySPK.SPKParent);

                    //SPK insertedSPK = _SPKRepository.Add(entitySPK);

                    //_unitOfWork.SaveChanges();

                    //if (isSPKSales)
                    //{
                    //    //insert invoice

                    //    Invoice invc = new Invoice();
                    //    invc.Code = spk.Code.Replace("SPK", "INVC");
                    //    invc.TotalSparepart = spk.TotalSparepartPrice;
                    //    invc.TotalFeeSparepart = 0;
                    //    invc.TotalSparepartPlusFee = invc.TotalSparepart + invc.TotalFeeSparepart;
                    //    invc.TotalService = 0;
                    //    invc.TotalFeeService = 0;
                    //    invc.TotalServicePlusFee = invc.TotalService + invc.TotalFeeService;
                    //    invc.TotalSparepartAndService = invc.TotalSparepartPlusFee + invc.TotalServicePlusFee;
                    //    invc.TotalValueAdded = (invc.TotalSparepartAndService * (0.1).AsDecimal());
                    //    invc.TotalPrice = invc.TotalValueAdded + invc.TotalSparepartAndService;
                    //    invc.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
                    //    invc.Status = (int)DbConstant.InvoiceStatus.FeeNotFixed;
                    //    invc.TotalHasPaid = 0;
                    //    invc.SPK = insertedSPK;
                    //    invc.PaymentMethod = invc.PaymentMethod = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG).FirstOrDefault();

                    //    invc.CreateDate = spk.CreateDate;
                    //    invc.ModifyDate = serverTime;
                    //    invc.ModifyUserId = userId;
                    //    invc.CreateUserId = userId;

                    //    _SPKRepository.AttachNavigation<SPK>(invc.SPK);
                    //    insertedInvoice = _invoiceRepository.Add(invc);
                    //    _unitOfWork.SaveChanges();
                    //}


                    //foreach (var spkSparepart in spkSparepartList)
                    //{
                    //    SPKDetailSparepart entitySPKDetailSparepart = new SPKDetailSparepart();
                    //    Sparepart sparepart = _sparepartRepository.GetById(spkSparepart.Sparepart.Id);

                    //    entitySPKDetailSparepart.SparepartId = spkSparepart.SparepartId;
                    //    entitySPKDetailSparepart.TotalPrice = spkSparepart.TotalPrice;
                    //    entitySPKDetailSparepart.TotalQuantity = spkSparepart.TotalQuantity;
                    //    entitySPKDetailSparepart.Sparepart = sparepart;
                    //    entitySPKDetailSparepart.SPK = insertedSPK;

                    //    //Map(spkSparepart, entitySPKDetailSparepart);

                    //    entitySPKDetailSparepart.CreateDate = spk.CreateDate;
                    //    entitySPKDetailSparepart.CreateUserId = userId;
                    //    entitySPKDetailSparepart.ModifyDate = serverTime;
                    //    entitySPKDetailSparepart.ModifyUserId = userId;
                    //    entitySPKDetailSparepart.Status = (int)DbConstant.DefaultDataStatus.Active;


                    //    if (!isNeedApproval)
                    //    {
                    //        sparepart.StockQty = sparepart.StockQty - spkSparepart.TotalQuantity;
                    //        sparepart.ModifyDate = serverTime;
                    //        sparepart.ModifyUserId = userId;

                    //        _sparepartRepository.AttachNavigation<Sparepart>(entitySPKDetailSparepart.Sparepart);
                    //        _sparepartRepository.Update(sparepart);
                    //        _unitOfWork.SaveChanges();
                    //    }

                    //    if (isSPKSales)
                    //    {
                    //        UsedGood foundUsedGood = _usedGoodRepository.GetMany(ug => ug.SparepartId == spkSparepart.SparepartId && ug.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                    //        if (foundUsedGood != null)
                    //        {
                    //            foundUsedGood.Stock = foundUsedGood.Stock + spkSparepartList.Count;
                    //            _usedGoodRepository.Update(foundUsedGood);
                    //        }
                    //    }


                    //    _SPKRepository.AttachNavigation<SPK>(entitySPKDetailSparepart.SPK);
                    //    _sparepartRepository.AttachNavigation<Sparepart>(entitySPKDetailSparepart.Sparepart);

                    //    SPKDetailSparepart insertedSPkDetailSparepart = _SPKDetailSparepartRepository.Add(entitySPKDetailSparepart);

                    //    _unitOfWork.SaveChanges();

                    //    var detailList = spkSparepartDetailList.Where(spd => spd.SparepartDetail.SparepartId == spkSparepart.SparepartId);

                    //    List<PurchasingDetail> listPurchasingDetail = new List<PurchasingDetail>();
                    //    List<SparepartManualTransaction> listSparepartManualTrans = new List<SparepartManualTransaction>();
                    //    foreach (var spkSparepartDetail in detailList)
                    //    {
                    //        SPKDetailSparepartDetail entityNewSparepartDetail = new SPKDetailSparepartDetail();

                    //        entityNewSparepartDetail.CreateDate = spk.CreateDate;
                    //        entityNewSparepartDetail.CreateUserId = userId;
                    //        entityNewSparepartDetail.ModifyDate = serverTime;
                    //        entityNewSparepartDetail.ModifyUserId = userId;
                    //        entityNewSparepartDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

                    //        entityNewSparepartDetail.SPKDetailSparepart = insertedSPkDetailSparepart;
                    //        entityNewSparepartDetail.SparepartDetailId = spkSparepartDetail.SparepartDetailId;
                    //        //entityNewSparepartDetail.SPKDetailSparepartId = insertedSPkDetailSparepart.Id;

                    //        _SPKDetailSparepartRepository.AttachNavigation<SPKDetailSparepart>(entityNewSparepartDetail.SPKDetailSparepart);
                    //        SPKDetailSparepartDetail insertedSPKSpDtl = _SPKDetailSparepartDetailRepository.Add(entityNewSparepartDetail);
                    //        _unitOfWork.SaveChanges();

                    //        if (!isNeedApproval)
                    //        {
                    //            SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(spkSparepartDetail.SparepartDetail.Id);
                    //            sparepartDetail.ModifyDate = serverTime;
                    //            sparepartDetail.ModifyUserId = userId;

                    //            if (spkReference.Code == DbConstant.REF_SPK_CATEGORY_SALE)
                    //            {
                    //                sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;
                    //            }
                    //            else
                    //            {
                    //                sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutService;
                    //            }

                    //            _sparepartRepository.AttachNavigation<Sparepart>(sparepartDetail.Sparepart);
                    //            _purchasingDetailRepository.AttachNavigation<PurchasingDetail>(sparepartDetail.PurchasingDetail);
                    //            _sparepartManualTransaction.AttachNavigation<SparepartManualTransaction>(sparepartDetail.SparepartManualTransaction);

                    //            _sparepartDetailRepository.Update(sparepartDetail);
                    //            _unitOfWork.SaveChanges();

                    //            if (sparepartDetail.PurchasingDetail != null)
                    //            {
                    //                listPurchasingDetail.Add(sparepartDetail.PurchasingDetail);
                    //            }
                    //            if (sparepartDetail.SparepartManualTransaction != null)
                    //            {
                    //                listSparepartManualTrans.Add(sparepartDetail.SparepartManualTransaction);
                    //            }
                    //        }

                    //        //insert invoice detail

                    //        if (isSPKSales)
                    //        {
                    //            InvoiceDetail invcDtl = new InvoiceDetail();

                    //            invcDtl.Invoice = insertedInvoice;
                    //            invcDtl.SPKDetailSparepartDetail = insertedSPKSpDtl;

                    //            if (insertedSPKSpDtl.SparepartDetail.PurchasingDetailId > 0)
                    //            {
                    //                invcDtl.SubTotalPrice = insertedSPKSpDtl.SparepartDetail.PurchasingDetail.Price.AsDouble();
                    //            }
                    //            else
                    //            {
                    //                invcDtl.SubTotalPrice = insertedSPKSpDtl.SparepartDetail.SparepartManualTransaction.Price.AsDouble();
                    //            }

                    //            invcDtl.Status = (int)DbConstant.DefaultDataStatus.Active;
                    //            invcDtl.FeePctg = 0;

                    //            invcDtl.CreateDate = spk.CreateDate;
                    //            invcDtl.ModifyDate = serverTime;
                    //            invcDtl.ModifyUserId = userId;
                    //            invcDtl.CreateUserId = userId;

                    //            _invoiceRepository.AttachNavigation<Invoice>(invcDtl.Invoice);
                    //            _SPKDetailSparepartDetailRepository.AttachNavigation<SPKDetailSparepartDetail>(invcDtl.SPKDetailSparepartDetail);

                    //            _invoiceDetailRepository.Add(invcDtl);
                    //            _unitOfWork.SaveChanges();
                    //        }
                    //    }

                    //    if (!isNeedApproval)
                    //    {
                    //        SparepartStockCard stockCard = new SparepartStockCard();
                    //        Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_SPK).FirstOrDefault();

                    //        stockCard.CreateUserId = userId;
                    //        stockCard.PurchaseDate = serverTime;
                    //        stockCard.PrimaryKeyValue = spk.Id;
                    //        stockCard.ReferenceTableId = transactionReferenceTable.Id;
                    //        stockCard.SparepartId = sparepart.Id;
                    //        stockCard.Description = "SPK";
                    //        stockCard.QtyOut = spkSparepart.TotalQuantity;
                    //        stockCard.QtyOutPrice = Convert.ToDouble(listPurchasingDetail.Sum(x => x.Price) + listSparepartManualTrans.Sum(x => x.Price));

                    //        SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(sparepart.Id);
                    //        double lastStock = 0;
                    //        double lastStockPrice = 0;
                    //        if (lastStockCard != null)
                    //        {
                    //            lastStock = lastStockCard.QtyLast;
                    //            lastStockPrice = lastStockCard.QtyLastPrice;
                    //        }
                    //        stockCard.QtyFirst = lastStock;
                    //        stockCard.QtyFirstPrice = lastStockPrice;
                    //        stockCard.QtyLast = lastStock - stockCard.QtyOut;
                    //        stockCard.QtyLastPrice = lastStockPrice - stockCard.QtyOutPrice;

                    //        _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                    //        _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                    //        _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);

                    //        stockCard = _sparepartStokCardRepository.Add(stockCard);
                    //        _unitOfWork.SaveChanges();

                    //        if (listPurchasingDetail.Count > 0)
                    //        {
                    //            List<PurchasingDetailViewModel> listPurchasing = listPurchasingDetail
                    //                            .GroupBy(l => l.PurchasingId)
                    //                            .Select(cl => new PurchasingDetailViewModel
                    //                            {
                    //                                PurchasingId = cl.Key,
                    //                                Qty = cl.Count(),
                    //                                Price = cl.First().Price
                    //                            }).ToList();

                    //            foreach (var itemPurchasing in listPurchasing)
                    //            {
                    //                SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                    //                stockCardDtail.ParentStockCard = stockCard;
                    //                stockCardDtail.PricePerItem = Convert.ToDouble(itemPurchasing.Price);
                    //                stockCardDtail.QtyOut = itemPurchasing.Qty;
                    //                stockCardDtail.QtyOutPrice = Convert.ToDouble(itemPurchasing.Qty * itemPurchasing.Price);
                    //                SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(sparepart.Id, itemPurchasing.PurchasingId);
                    //                double lastStockDetail = 0;
                    //                double lastStockDetailPrice = 0;
                    //                if (lastStockCardDetail != null)
                    //                {
                    //                    lastStockDetail = lastStockCardDetail.QtyLast;
                    //                    lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                    //                }
                    //                stockCardDtail.QtyFirst = lastStockDetail;
                    //                stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                    //                stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                    //                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                    //                stockCardDtail.PurchasingId = itemPurchasing.PurchasingId;

                    //                _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                    //                _sparepartStokCardDetailRepository.Add(stockCardDtail);
                    //                _unitOfWork.SaveChanges();
                    //            }
                    //        }

                    //        if (listSparepartManualTrans.Count > 0)
                    //        {
                    //            List<SparepartManualTransactionViewModel> listSpManual = listSparepartManualTrans
                    //                            .GroupBy(l => l.Id)
                    //                            .Select(cl => new SparepartManualTransactionViewModel
                    //                            {
                    //                                Id = cl.Key,
                    //                                Qty = cl.Count(),
                    //                                Price = cl.First().Price
                    //                            }).ToList();
                    //            foreach (var itemSpTrans in listSpManual)
                    //            {
                    //                SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                    //                stockCardDtail.ParentStockCard = stockCard;
                    //                stockCardDtail.PricePerItem = Convert.ToDouble(itemSpTrans.Price);
                    //                stockCardDtail.QtyOut = itemSpTrans.Qty;
                    //                stockCardDtail.QtyOutPrice = Convert.ToDouble(itemSpTrans.Qty * itemSpTrans.Price);
                    //                SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(sparepart.Id, itemSpTrans.Id);
                    //                double lastStockDetail = 0;
                    //                double lastStockDetailPrice = 0;
                    //                if (lastStockCardDetail != null)
                    //                {
                    //                    lastStockDetail = lastStockCardDetail.QtyLast;
                    //                    lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                    //                }
                    //                stockCardDtail.QtyFirst = lastStockDetail;
                    //                stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                    //                stockCardDtail.QtyLast = lastStockDetail - stockCardDtail.QtyOut;
                    //                stockCardDtail.QtyLastPrice = lastStockDetailPrice - stockCardDtail.QtyOutPrice;
                    //                stockCardDtail.SparepartManualTransactionId = itemSpTrans.Id;

                    //                _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                    //                _sparepartStokCardDetailRepository.Add(stockCardDtail);
                    //                _unitOfWork.SaveChanges();
                    //            }
                    //        }
                    //    }
                    //}

                    ////Wheel Change Handler
                    //foreach (var item in vehicleWheelList.Where(vw => vw.ReplaceWithWheelDetailId > 0))
                    //{
                    //    SpecialSparepartDetail wheel = _specialSparepartDetailRepository.GetById(item.WheelDetailId);
                    //    SpecialSparepartDetail wheelReplace = _specialSparepartDetailRepository.GetById(item.ReplaceWithWheelDetailId);
                    //    WheelExchangeHistory weh = new WheelExchangeHistory();

                    //    weh.SPK = insertedSPK;
                    //    weh.OriginalWheelId = item.WheelDetailId;
                    //    weh.ReplaceWheelId = item.ReplaceWithWheelDetailId;
                    //    weh.OrignialWheel = wheel;
                    //    weh.ReplaceWheel = wheelReplace;

                    //    weh.CreateDate = serverTime;
                    //    weh.ModifyDate = serverTime;
                    //    weh.ModifyUserId = userId;
                    //    weh.CreateUserId = userId;

                    //    _SPKRepository.AttachNavigation<SPK>(entitySPK);
                    //    _specialSparepartDetailRepository.AttachNavigation<SpecialSparepartDetail>(weh.OrignialWheel);
                    //    _specialSparepartDetailRepository.AttachNavigation<SpecialSparepartDetail>(weh.ReplaceWheel);

                    //    _wheelExchangeHistoryRepository.Add(weh);
                    //    _unitOfWork.SaveChanges();

                    //    wheel.Kilometers = spk.Kilometers;
                    //    wheel.ModifyDate = serverTime;
                    //    wheel.ModifyUserId = userId;
                    //    wheel.Status = (int)DbConstant.WheelDetailStatus.Deleted;

                    //    wheelReplace.Kilometers = spk.Kilometers;
                    //    wheelReplace.ModifyDate = serverTime;
                    //    wheelReplace.ModifyUserId = userId;
                    //    wheelReplace.Status = (int)DbConstant.WheelDetailStatus.Installed;

                    //    _specialSparepartRepository.AttachNavigation<SpecialSparepart>(wheel.SpecialSparepart);
                    //    _sparepartDetailRepository.AttachNavigation<SparepartDetail>(wheel.SparepartDetail);

                    //    _specialSparepartDetailRepository.Update(wheel);
                    //    _specialSparepartDetailRepository.Update(wheelReplace);
                    //    _unitOfWork.SaveChanges();
                    //}

                    //// Update Vehicle Kilometers
                    //Vehicle vehicle = _vehicleRepository.GetById(spk.VehicleId);

                    //vehicle.Kilometers = spk.Kilometers;
                    //vehicle.ModifyDate = serverTime;
                    //vehicle.ModifyUserId = userId;

                    //_vehicleGroupRepository.AttachNavigation(vehicle.VehicleGroup);
                    //_customerRepository.AttachNavigation(vehicle.Customer);
                    //_brandRepository.AttachNavigation(vehicle.Brand);
                    //_vehicleRepository.Update(vehicle);

                    //_unitOfWork.SaveChanges();

                    ////Update SPK Schedule

                    //if (assignedScheduleList.Count > 0)
                    //{
                    //    foreach ( SPKScheduleViewModel sched in assignedScheduleList)
                    //    {
                    //        SPKSchedule entitySched = new SPKSchedule();
                    //        Mechanic mechanic = _mechanicRepository.GetById(sched.MechanicId);
                         
                    //        Map(sched, entitySched);
                    //        entitySched.SPK = insertedSPK;
                    //        entitySched.Mechanic = mechanic;
                    //        entitySched.CreateDate = serverTime;
                    //        entitySched.CreateUserId = userId;
                    //        entitySched.ModifyDate = serverTime;
                    //        entitySched.ModifyUserId = userId;
                    //        entitySched.Status = (int)DbConstant.DefaultDataStatus.Active;

                    //        _SPKRepository.AttachNavigation<SPK>(entitySched.SPK);
                    //        _mechanicRepository.AttachNavigation<Mechanic>(entitySched.Mechanic);
                    //        _SPKScheduleRepository.Add(entitySched);
                    //        _unitOfWork.SaveChanges();
                    //    } 

                    //}

                    //trans.Commit();
                    //SPKViewModel mappedResult = new SPKViewModel();

                    //return Map(insertedSPK, mappedResult);

                    return null;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }


        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId, int SPKId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            Map(result, mappedResult);

            //if (SPKId > 0)
            //{
            //    foreach (var item in mappedResult)
            //    {
            //        WheelExchangeHistory wheel = _wheelExchangeHistoryRepository.GetMany(w => w.SPKId == SPKId && w.OriginalWheelId == item.WheelDetailId).FirstOrDefault();
            //        if (wheel != null)
            //        {
            //            item.ReplaceWithWheelDetailId = wheel.ReplaceWheelId;
            //            item.ReplaceWithWheelDetailName = wheel.ReplaceWheel.SparepartDetail.Sparepart.Name;
            //            item.ReplaceWithWheelDetailSerialNumber = wheel.ReplaceWheel.SerialNumber;

            //            if (wheel.ReplaceWheel.SparepartDetail.PurchasingDetailId > 0)
            //            {
            //                item.Price = wheel.ReplaceWheel.SparepartDetail.PurchasingDetail.Price;
            //            }
            //            else if (wheel.ReplaceWheel.SparepartDetail.SparepartManualTransactionId > 0)
            //            {
            //                item.Price = wheel.ReplaceWheel.SparepartDetail.SparepartManualTransaction.Price;
            //            }
            //            item.IsUsedWheelRetrieved = true;
            //        }
            //    }
            //}

            return mappedResult;
        }

        public List<SpecialSparepartDetailViewModel> RetrieveReadyWheelDetails(int sparepartId)
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(wd => wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                                       && wd.Sparepart.CategoryReference.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
                                                                                       && wd.SparepartId == sparepartId).ToList();
            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }

        //public List<SpecialSparepartViewModel> LoadWheel()
        //{
        //    List<SpecialSparepart> result = _specialSparepartRepository.GetMany(ss => ss.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
        //        && ss.Status == (int)DbConstant.DefaultDataStatus.Active
        //        ).ToList();
        //    List<SpecialSparepartViewModel> mappedResult = new List<SpecialSparepartViewModel>();

        //    return Map(result, mappedResult);
        //}

        public List<SparepartViewModel> LoadSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active && sp.IsSpecialSparepart
                && sp.CategoryReference.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL).ToList();

            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();

            return Map(result, mappedResult);
        }

        public List<SPKDetailSparepartDetailViewModel> getRandomDetails(int sparepartId, int qty)
        {
            List<SparepartManualTransaction> spManuals = new List<SparepartManualTransaction>();
            List<PurchasingDetail> purchasingDetails = new List<PurchasingDetail>();
            List<SPKDetailSparepartDetail> result = new List<SPKDetailSparepartDetail>();
            if (qty > 0 && sparepartId > 0)
            {
                int qtyRemains = qty;
                
                List<SparepartManualTransaction> spManual = _sparepartManualTransaction
                    .GetMany(
                        spd => spd.SparepartId == sparepartId &&
                        spd.QtyRemaining > 0
                    )
                    .OrderBy(spd => spd.CreateDate).ToList();

                foreach (var itemManual in spManual)
                {
                    if(itemManual.QtyRemaining > qtyRemains)
                    {
                        result.Add(new SPKDetailSparepartDetail
                        {
                            SparepartManualTransaction = itemManual,
                            SparepartManualTransactionId = itemManual.Id,
                            Qty = qtyRemains
                        }); 
                        
                        itemManual.QtyRemaining = itemManual.QtyRemaining - qtyRemains;
                        spManuals.Add(itemManual);
                        qtyRemains = 0;
                    }
                    else
                    {
                        result.Add(new SPKDetailSparepartDetail
                        {
                            SparepartManualTransaction = itemManual,
                            SparepartManualTransactionId = itemManual.Id,
                            Qty = itemManual.QtyRemaining
                        }); 

                        itemManual.QtyRemaining = 0;
                        spManuals.Add(itemManual);
                        qtyRemains -= itemManual.QtyRemaining;
                    }

                    if (qtyRemains == 0) break;
                }

                List<PurchasingDetail> purchasingDetail = _purchasingDetailRepository
                    .GetMany(
                        spd => spd.SparepartId == sparepartId &&
                        spd.QtyRemaining > 0
                    )
                    .OrderBy(spd => spd.CreateDate).ToList();

                foreach (var itemPD in purchasingDetail)
                {
                    if (itemPD.QtyRemaining > qtyRemains)
                    {
                        result.Add(new SPKDetailSparepartDetail
                        {
                            PurchasingDetail = itemPD,
                            PurchasingDetailId = itemPD.Id,
                            Qty = qtyRemains
                        }); 

                        itemPD.QtyRemaining = itemPD.QtyRemaining - qtyRemains;
                        purchasingDetails.Add(itemPD);
                        qtyRemains = 0;
                    }
                    else
                    {
                        result.Add(new SPKDetailSparepartDetail
                        {
                            PurchasingDetail = itemPD,
                            PurchasingDetailId = itemPD.Id,
                            Qty = itemPD.QtyRemaining
                        });
                        itemPD.QtyRemaining = 0;
                        purchasingDetails.Add(itemPD);
                        qtyRemains -= itemPD.QtyRemaining;
                    }

                    if (qtyRemains == 0) break;
                }
            }

            List<SPKDetailSparepartDetailViewModel> mappedResult = new List<SPKDetailSparepartDetailViewModel>();

            return Map(result, mappedResult);
        }


        public SpecialSparepartDetailViewModel GetWheelDetailById(int wheelDetailId)
        {
            SpecialSparepartDetail result = _specialSparepartDetailRepository.GetById(wheelDetailId);

            SpecialSparepartDetailViewModel mappedResult = new SpecialSparepartDetailViewModel();

            return Map(result, mappedResult);
        }

        public void PrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;
            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public string GetRepairThreshold()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_P).FirstOrDefault().Value;
        }

        public string GetServiceThreshold()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_S).FirstOrDefault().Value;
        }

        public string GetContractThreshold()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_I).FirstOrDefault().Value;
        }


        public int getPendingSparpartQty(int sparepartId)
        {
            int result = 0;

            List<SPKDetailSparepart> pendingSPKDetail = _SPKDetailSparepartRepository.GetMany(spkds =>
                                                        spkds.SPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending
                                                        && spkds.Sparepart.Id == sparepartId
                                                        ).ToList();

            foreach (var item in pendingSPKDetail)
            {
                result = result + item.TotalQuantity;
            }

            return result;
        }

        public SparepartViewModel GetSparepartSpecial(int sparepartId)
        {
            Sparepart result = _sparepartRepository.GetMany(ss => ss.Id == sparepartId && ss.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            SparepartViewModel mappedResult = new SparepartViewModel();

            return Map(result, mappedResult);
        }

        public SpecialSparepartDetailViewModel GetSpecialSparepartDetail(int id)
        {
            SpecialSparepartDetail result = _specialSparepartDetailRepository.GetById(id);
            SpecialSparepartDetailViewModel mappedResult = new SpecialSparepartDetailViewModel();

            return Map(result, mappedResult);
        }

        public bool IsUsedSparepartRequired(int sparepartId)
        {
            var foundUsedGood = _usedGoodRepository.GetMany(ug => ug.SparepartId == sparepartId && ug.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            return foundUsedGood != null;
        }

        public SPKDetailSparepartViewModel GetSparepartLastUsageRecord(int vehicleId, int sparepartId)
        {
            SPKDetailSparepart result = _SPKDetailSparepartRepository.GetMany(spks => spks.SPK.VehicleId == vehicleId
                && spks.SparepartId == sparepartId).OrderBy(s => s.Id).LastOrDefault();

            SPKDetailSparepartViewModel mappedResult = new SPKDetailSparepartViewModel();

            return Map(result, mappedResult);
        }

        public List<SpecialSparepartDetailViewModel> loadSSDetail(int sparepartId)
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(ssd => ssd.SparepartId == sparepartId).ToList();

            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();

            return Map(result, mappedResult);
        }


        public VehicleWheelViewModel GetVehicleWHeelById(int VehicleWheelid)
        {
            VehicleWheel entity = _vehicleWheelRepository.GetById(VehicleWheelid);

            VehicleWheelViewModel result = new VehicleWheelViewModel();

            return Map(entity, result);
        }

        public int SPKSalesCategoryReferenceId()
        {
            return _referenceRepository.GetMany(r => r.Code == DbConstant.REF_SPK_CATEGORY_SALE).FirstOrDefault().Id;
        }

        public void AbortParentSPK(SPKViewModel spk, int userId)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    //#region Abort Endorsed SPK
                    //DateTime serverTime = DateTime.Now;

                    //SPK entity = _SPKRepository.GetById(spk.Id);
                    //entity.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.Completed;
                    //entity.StatusApprovalId = (int)DbConstant.ApprovalStatus.Endorsed;
                    //entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                    //entity.ModifyDate = serverTime;
                    //entity.ModifyUserId = userId;

                    //_SPKRepository.AttachNavigation<Vehicle>(entity.Vehicle);
                    //_SPKRepository.AttachNavigation<User>(entity.ModifyUser);
                    //_SPKRepository.AttachNavigation<User>(entity.CreateUser);
                    //_SPKRepository.AttachNavigation<Reference>(entity.CategoryReference);
                    //_SPKRepository.Update(entity);
                    //_unitOfWork.SaveChanges();

                    //foreach (var spkSp in _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == entity.Id))
                    //{
                    //    Sparepart sparepart = _sparepartRepository.GetById(spkSp.Sparepart.Id);
                    //    sparepart.StockQty = sparepart.StockQty + spkSp.TotalQuantity;
                    //    sparepart.ModifyDate = serverTime;
                    //    sparepart.ModifyUserId = userId;

                    //    _sparepartRepository.AttachNavigation<User>(sparepart.ModifyUser);
                    //    _sparepartRepository.AttachNavigation<User>(sparepart.CreateUser);
                    //    _sparepartRepository.AttachNavigation<Reference>(sparepart.CategoryReference);
                    //    _sparepartRepository.AttachNavigation<Reference>(sparepart.UnitReference);
                    //    _sparepartRepository.Update(sparepart);
                    //    _unitOfWork.SaveChanges();
                    //}

                    //List<PurchasingDetail> listPurchasingDetail = new List<PurchasingDetail>();
                    //List<SparepartManualTransaction> listSparepartManualTrans = new List<SparepartManualTransaction>();
                    //foreach (var item in _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SPKDetailSparepart.SPK.Id == entity.Id))
                    //{
                    //    SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(item.SparepartDetail.Id);
                    //    sparepartDetail.ModifyDate = serverTime;
                    //    sparepartDetail.ModifyUserId = userId;
                    //    sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                    //    _sparepartDetailRepository.AttachNavigation<User>(sparepartDetail.ModifyUser);
                    //    _sparepartDetailRepository.AttachNavigation<User>(sparepartDetail.CreateUser);
                    //    _sparepartDetailRepository.AttachNavigation<Sparepart>(sparepartDetail.Sparepart);
                    //    _sparepartDetailRepository.AttachNavigation<PurchasingDetail>(sparepartDetail.PurchasingDetail);
                    //    _sparepartDetailRepository.AttachNavigation<SparepartManualTransaction>(sparepartDetail.SparepartManualTransaction);
                    //    _sparepartDetailRepository.Update(sparepartDetail);
                    //    _unitOfWork.SaveChanges();

                    //    if (sparepartDetail.PurchasingDetail != null)
                    //    {
                    //        listPurchasingDetail.Add(sparepartDetail.PurchasingDetail);
                    //    }
                    //    if (sparepartDetail.SparepartManualTransaction != null)
                    //    {
                    //        listSparepartManualTrans.Add(sparepartDetail.SparepartManualTransaction);
                    //    }
                    //}

                    //foreach (var spkSp in _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == entity.Id))
                    //{
                    //    SparepartStockCard stockCard = new SparepartStockCard();
                    //    Reference transactionReferenceTable = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_TRANSTBL_SPK).FirstOrDefault();

                    //    stockCard.CreateUserId = userId;
                    //    stockCard.PurchaseDate = serverTime;
                    //    stockCard.PrimaryKeyValue = spk.Id;
                    //    stockCard.ReferenceTableId = transactionReferenceTable.Id;
                    //    stockCard.SparepartId = spkSp.SparepartId;
                    //    stockCard.Description = "Pembatalan SPK";
                    //    stockCard.QtyIn = spkSp.TotalQuantity;
                    //    stockCard.QtyInPrice = Convert.ToDouble(listPurchasingDetail.Sum(x => x.Price) + listSparepartManualTrans.Sum(x => x.Price));

                    //    SparepartStockCard lastStockCard = _sparepartStokCardRepository.RetrieveLastCard(spkSp.SparepartId);
                    //    double lastStock = 0;
                    //    double lastStockPrice = 0;
                    //    if (lastStockCard != null)
                    //    {
                    //        lastStock = lastStockCard.QtyLast;
                    //        lastStockPrice = lastStockCard.QtyLastPrice;
                    //    }
                    //    stockCard.QtyFirst = lastStock;
                    //    stockCard.QtyFirstPrice = lastStockPrice;
                    //    stockCard.QtyLast = lastStock + stockCard.QtyIn;
                    //    stockCard.QtyLastPrice = lastStockPrice + stockCard.QtyInPrice;

                    //    _sparepartStokCardRepository.AttachNavigation(stockCard.CreateUser);
                    //    _sparepartStokCardRepository.AttachNavigation(stockCard.Sparepart);
                    //    _sparepartStokCardRepository.AttachNavigation(stockCard.ReferenceTable);
                    //    stockCard = _sparepartStokCardRepository.Add(stockCard);

                    //    _unitOfWork.SaveChanges();

                    //    if (listPurchasingDetail.Count > 0)
                    //    {
                    //        List<PurchasingDetailViewModel> listPurchasing = listPurchasingDetail
                    //                        .GroupBy(l => l.PurchasingId)
                    //                        .Select(cl => new PurchasingDetailViewModel
                    //                        {
                    //                            PurchasingId = cl.Key,
                    //                            Qty = cl.Count(),
                    //                            Price = cl.First().Price,
                    //                            SparepartId = cl.First().SparepartId
                    //                        }).ToList();

                    //        foreach (var itemPurchasing in listPurchasing)
                    //        {
                    //            SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                    //            stockCardDtail.ParentStockCard = stockCard;
                    //            stockCardDtail.PricePerItem = Convert.ToDouble(itemPurchasing.Price);
                    //            stockCardDtail.QtyIn = itemPurchasing.Qty;
                    //            stockCardDtail.QtyInPrice = Convert.ToDouble(itemPurchasing.Qty * itemPurchasing.Price);
                    //            SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByPurchasingId(itemPurchasing.SparepartId, itemPurchasing.PurchasingId);
                    //            double lastStockDetail = 0;
                    //            double lastStockDetailPrice = 0;
                    //            if (lastStockCardDetail != null)
                    //            {
                    //                lastStockDetail = lastStockCardDetail.QtyLast;
                    //                lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                    //            }
                    //            stockCardDtail.QtyFirst = lastStockDetail;
                    //            stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                    //            stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                    //            stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                    //            stockCardDtail.PurchasingId = itemPurchasing.PurchasingId;

                    //            _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                    //            _sparepartStokCardDetailRepository.Add(stockCardDtail);
                    //            _unitOfWork.SaveChanges();
                    //        }
                    //    }

                    //    if (listSparepartManualTrans.Count > 0)
                    //    {
                    //        List<SparepartManualTransactionViewModel> listSpManual = listSparepartManualTrans
                    //                        .GroupBy(l => l.Id)
                    //                        .Select(cl => new SparepartManualTransactionViewModel
                    //                        {
                    //                            Id = cl.Key,
                    //                            Qty = cl.Count(),
                    //                            Price = cl.First().Price,
                    //                            SparepartId = cl.First().SparepartId
                    //                        }).ToList();
                    //        foreach (var itemSpTrans in listSpManual)
                    //        {
                    //            SparepartStockCardDetail stockCardDtail = new SparepartStockCardDetail();
                    //            stockCardDtail.ParentStockCard = stockCard;
                    //            stockCardDtail.PricePerItem = Convert.ToDouble(itemSpTrans.Price);
                    //            stockCardDtail.QtyIn = itemSpTrans.Qty;
                    //            stockCardDtail.QtyInPrice = Convert.ToDouble(itemSpTrans.Qty * itemSpTrans.Price);
                    //            SparepartStockCardDetail lastStockCardDetail = _sparepartStokCardDetailRepository.RetrieveLastCardDetailByTransactionManualId(itemSpTrans.SparepartId, itemSpTrans.Id);
                    //            double lastStockDetail = 0;
                    //            double lastStockDetailPrice = 0;
                    //            if (lastStockCardDetail != null)
                    //            {
                    //                lastStockDetail = lastStockCardDetail.QtyLast;
                    //                lastStockDetailPrice = lastStockCardDetail.QtyLastPrice;
                    //            }
                    //            stockCardDtail.QtyFirst = lastStockDetail;
                    //            stockCardDtail.QtyFirstPrice = lastStockDetailPrice;
                    //            stockCardDtail.QtyLast = lastStockDetail + stockCardDtail.QtyIn;
                    //            stockCardDtail.QtyLastPrice = lastStockDetailPrice + stockCardDtail.QtyInPrice;
                    //            stockCardDtail.SparepartManualTransactionId = itemSpTrans.Id;

                    //            _sparepartStokCardDetailRepository.AttachNavigation(stockCardDtail.ParentStockCard);
                    //            _sparepartStokCardDetailRepository.Add(stockCardDtail);
                    //            _unitOfWork.SaveChanges();
                    //        }
                    //    }
                    //}

                    //List<WheelExchangeHistory> wehList = _wheelExchangeHistoryRepository.GetMany(weh => weh.SPKId == spk.Id).ToList();

                    //foreach (var item in wehList)
                    //{
                    //    _wheelExchangeHistoryRepository.Delete(item);
                    //}

                    //List<SPKSchedule> scheduleList = _SPKScheduleRepository.GetMany(sched => sched.SPKId == spk.Id).ToList();

                    //foreach (SPKSchedule schedule in scheduleList)
                    //{
                    //    _SPKScheduleRepository.Delete(schedule);
                    //}

                    //_unitOfWork.SaveChanges();
                    //#endregion
                    //trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }

        }

        public decimal AllPurchaseByVehicle(int vehicleId, int spkParentId)
        {
            decimal result = 0;

            DateTime startTime = DateTime.Today;

            var AllSparepartPurchased = _SPKDetailSparepartRepository.GetMany(sp =>
                DbFunctions.TruncateTime(sp.CreateDate) == DbFunctions.TruncateTime(DateTime.Today) &&
                sp.SPK.VehicleId == vehicleId && sp.SPK.Id != spkParentId);

            foreach (var item in AllSparepartPurchased)
            {
                result += item.TotalPrice;
            }

            return result;
        }

        public List<SparepartViewModel> LoadSparepartWheel()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();


            List<Sparepart> getSpInWheel = (from sp in result
                                            where sp.IsSpecialSparepart && sp.StockQty > 0
                                            && sp.CategoryReference.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
                                            select sp).ToList(); // return sparepart object which in list

            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();

            return Map(getSpInWheel, mappedResult);
        }
    }
}
