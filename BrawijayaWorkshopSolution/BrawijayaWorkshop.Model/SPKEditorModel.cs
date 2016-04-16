﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

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
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IWheelExchangeHistoryRepository _wheelExchangeHistoryRepository;
        private ISPKScheduleRepository _SPKScheduleRepository;
        private IUnitOfWork _unitOfWork;

        public SPKEditorModel(ISettingRepository settingRepository, IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IUsedGoodRepository usedGoodRepository,
            ISpecialSparepartRepository specialSparepartRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IVehicleWheelRepository vehicleWheelRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IWheelExchangeHistoryRepository WheelExchangeHistoryRepository,
            ISPKScheduleRepository spkScheduleRepository,
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
            _sparepartDetailRepository = sparepartDetailRepository;
            _usedGoodRepository = usedGoodRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _specialSparepartRepository = specialSparepartRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _SPKScheduleRepository = spkScheduleRepository;
            _wheelExchangeHistoryRepository = WheelExchangeHistoryRepository;
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
            return Map(result, mappedResult);
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
                    SparepartDetail = item.SparepartDetail,
                    SparepartDetailId = item.SparepartDetailId
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
            int userId,
            bool isNeedApproval)
        {
            DateTime serverTime = DateTime.Now;
            Invoice insertedInvoice = new Invoice();
            Reference spkReference = _referenceRepository.GetById(spk.CategoryReferenceId);
            bool isSPKSales = spkReference.Code == DbConstant.REF_SPK_CATEGORY_SALE;

            string code = "SPK-";

            switch (spkReference.Code)
            {
                case DbConstant.REF_SPK_CATEGORY_SERVICE: code = code + "S";
                    break;
                case DbConstant.REF_SPK_CATEGORY_REPAIR: code = code + "R";
                    break;
                case DbConstant.REF_SPK_CATEGORY_SALE: code = code + "L";
                    break;
                case DbConstant.REF_SPK_CATEGORY_INVENTORY: code = code + "I";
                    break;
            }

            code = code + "-" + serverTime.Month.ToString() + serverTime.Day.ToString() + "-";

            //get total SPK created today
            List<SPK> todaySPK = _SPKRepository.GetMany(s => s.Code.ToString().Contains(code) && s.CreateDate.Year == serverTime.Year).ToList();

            code = code + (todaySPK.Count + 1);

            spk.Code = code;
            spk.CreateDate = serverTime;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;
            spk.CreateUserId = userId;

            spk.Status = (int)DbConstant.DefaultDataStatus.Active;
            if (isNeedApproval)
            {
                spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Pending;
                spk.StatusOverLimit = 1;
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Pending;
            }
            else
            {
                spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                spk.StatusOverLimit = 0;
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            }

            spk.StatusCompletedId = isSPKSales ? (int)DbConstant.SPKCompletionStatus.Completed : (int)DbConstant.SPKCompletionStatus.InProgress;
            SPK entityChild = new SPK();
            Map(spk, entityChild);

            SPK insertedSPK = _SPKRepository.Add(entityChild);

            if (isSPKSales)
            {
                //insert invoice

                Invoice invc = new Invoice();
                //invc.Code = "INV-" + spk.Code.Substring(4, spk.Code.Length);
                invc.Code = spk.Code.Replace("SPK", "INVC");
                invc.TotalPrice = spk.TotalSparepartPrice;
                invc.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
                invc.Status = (int)DbConstant.InvoiceStatus.FeeNotFixed;
                invc.TotalHasPaid = 0;
                invc.SPK = insertedSPK;
                invc.PaymentMethod = invc.PaymentMethod = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG).FirstOrDefault();

                invc.CreateDate = serverTime;
                invc.ModifyDate = serverTime;
                invc.ModifyUserId = userId;
                invc.CreateUserId = userId;

                insertedInvoice = _invoiceRepository.Add(invc);
            }


            foreach (var spkSparepart in spkSparepartList)
            {
                SPKDetailSparepart entitySPKDetailSparepart = new SPKDetailSparepart();
                Sparepart sparepart = _sparepartRepository.GetById(spkSparepart.Sparepart.Id);

                entitySPKDetailSparepart.SparepartId = spkSparepart.SparepartId;
                entitySPKDetailSparepart.TotalPrice = spkSparepart.TotalPrice;
                entitySPKDetailSparepart.TotalQuantity = spkSparepart.TotalQuantity;
                entitySPKDetailSparepart.Sparepart = sparepart;
                entitySPKDetailSparepart.SPK = insertedSPK;

                entitySPKDetailSparepart.CreateDate = serverTime;
                entitySPKDetailSparepart.CreateUserId = userId;
                entitySPKDetailSparepart.ModifyDate = serverTime;
                entitySPKDetailSparepart.ModifyUserId = userId;
                entitySPKDetailSparepart.Status = (int)DbConstant.DefaultDataStatus.Active;

                if (!isNeedApproval)
                {
                    sparepart.StockQty = sparepart.StockQty - spkSparepart.TotalQuantity;
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userId;

                    _sparepartRepository.Update(sparepart);
                }

                if (isSPKSales)
                {
                    UsedGood foundUsedGood = _usedGoodRepository.GetMany(ug => ug.SparepartId == spkSparepart.SparepartId && ug.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                    if (foundUsedGood != null)
                    {
                        foundUsedGood.Stock = foundUsedGood.Stock + spkSparepartList.Count;
                        _usedGoodRepository.Update(foundUsedGood);
                    }
                }

                SPKDetailSparepart insertedSPkDetailSparepart = _SPKDetailSparepartRepository.Add(entitySPKDetailSparepart);

                var detailList = spkSparepartDetailList.Where(spd => spd.SparepartDetail.SparepartId == spkSparepart.SparepartId);

                foreach (var spkSparepartDetail in detailList)
                {
                    SPKDetailSparepartDetail entityNewSparepartDetail = new SPKDetailSparepartDetail();

                    entityNewSparepartDetail.CreateDate = serverTime;
                    entityNewSparepartDetail.CreateUserId = userId;
                    entityNewSparepartDetail.ModifyDate = serverTime;
                    entityNewSparepartDetail.ModifyUserId = userId;
                    entityNewSparepartDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

                    entityNewSparepartDetail.SPKDetailSparepart = insertedSPkDetailSparepart;
                    entityNewSparepartDetail.SparepartDetailId = spkSparepartDetail.SparepartDetailId;

                    SPKDetailSparepartDetail insertedSPKSpDtl = _SPKDetailSparepartDetailRepository.Add(entityNewSparepartDetail);

                    if (!isNeedApproval)
                    {
                        SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(spkSparepartDetail.SparepartDetail.Id);
                        sparepartDetail.ModifyDate = serverTime;
                        sparepartDetail.ModifyUserId = userId;

                        if (spkReference.Code == DbConstant.REF_SPK_CATEGORY_SALE)
                        {
                            sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;
                        }
                        else
                        {
                            sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutService;
                        }

                        _sparepartDetailRepository.Update(sparepartDetail);
                    }

                    //insert invoice detail

                    if (isSPKSales)
                    {
                        InvoiceDetail invcDtl = new InvoiceDetail();

                        invcDtl.Invoice = insertedInvoice;
                        invcDtl.SPKDetailSparepartDetail = insertedSPKSpDtl;

                        if (insertedSPKSpDtl.SparepartDetail.PurchasingDetailId > 0)
                        {
                            invcDtl.SubTotalPrice = insertedSPKSpDtl.SparepartDetail.PurchasingDetail.Price.AsDouble();
                        }
                        else
                        {
                            invcDtl.SubTotalPrice = insertedSPKSpDtl.SparepartDetail.SparepartManualTransaction.Price.AsDouble();
                        }

                        invcDtl.Status = (int)DbConstant.DefaultDataStatus.Active;
                        invcDtl.FeePctg = 0;

                        invcDtl.CreateDate = serverTime;
                        invcDtl.ModifyDate = serverTime;
                        invcDtl.ModifyUserId = userId;
                        invcDtl.CreateUserId = userId;

                        _invoiceDetailRepository.Add(invcDtl);
                    }
                }
            }

            //Wheel Change Handler
            foreach (var item in vehicleWheelList.Where(vw => vw.ReplaceWithWheelDetailId > 0))
            {
                WheelExchangeHistory weh = new WheelExchangeHistory();
                weh.SPK = insertedSPK;
                weh.OriginalWheelId = item.WheelDetailId;
                weh.ReplaceWheelId = item.ReplaceWithWheelDetailId;

                weh.CreateDate = serverTime;
                weh.ModifyDate = serverTime;
                weh.ModifyUserId = userId;
                weh.CreateUserId = userId;

                _wheelExchangeHistoryRepository.Add(weh);
            }

            _unitOfWork.SaveChanges();

            SPKViewModel mappedResult = new SPKViewModel();

            return Map(insertedSPK, mappedResult);
        }


        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId, int SPKId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            Map(result, mappedResult);

            if (SPKId > 0)
            {
                foreach (var item in mappedResult)
                {
                    WheelExchangeHistory wheel = _wheelExchangeHistoryRepository.GetMany(w => w.SPKId == SPKId && w.OriginalWheelId == item.WheelDetailId).FirstOrDefault();
                    item.ReplaceWithWheelDetailId = wheel.ReplaceWheelId;
                    if (wheel.ReplaceWheel.SparepartDetail.PurchasingDetailId > 0)
                    {
                        item.Price = wheel.ReplaceWheel.SparepartDetail.PurchasingDetail.Price;
                    }
                    else if (wheel.ReplaceWheel.SparepartDetail.SparepartManualTransactionId > 0)
                    {
                        item.Price = wheel.ReplaceWheel.SparepartDetail.SparepartManualTransaction.Price;
                    }
                    item.IsUsedWheelRetrieved = true;
                }
            }

            return mappedResult;
        }

        public List<SpecialSparepartDetailViewModel> RetrieveReadyWheelDetails()
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(wd => wd.Status == (int)DbConstant.WheelDetailStatus.Ready
                                                                                       && wd.SpecialSparepart.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL).ToList();
            List<SpecialSparepartDetailViewModel> mappedResult = new List<SpecialSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }

        public List<SpecialSparepartViewModel> LoadWheel()
        {
            List<SpecialSparepart> result = _specialSparepartRepository.GetMany(ss => ss.ReferenceCategory.Code == DbConstant.REF_SPECIAL_SPAREPART_TYPE_WHEEL
                && ss.Status == (int)DbConstant.DefaultDataStatus.Active
                ).ToList();
            List<SpecialSparepartViewModel> mappedResult = new List<SpecialSparepartViewModel>();

            return Map(result, mappedResult);
        }

        public List<SparepartViewModel> LoadSparepart()
        {
            List<SpecialSparepartViewModel> wheelList = LoadWheel();
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            var getSpInWheel = (from sp in result
                                join wh in wheelList on sp.Id equals wh.SparepartId
                                select sp).ToList(); // return sparepart object which in list

            var finalResult = result.Except(getSpInWheel);

            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();

            return Map(finalResult, mappedResult);
        }

        public List<SPKDetailSparepartDetailViewModel> getRandomDetails(int sparepartId, int qty)
        {
            List<SparepartDetail> sparepartDetails = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderBy(spd => spd.Id).Take(qty).ToList();

            List<SPKDetailSparepartDetail> result = new List<SPKDetailSparepartDetail>();

            foreach (var item in sparepartDetails)
            {
                result.Add(new SPKDetailSparepartDetail
                 {
                     SparepartDetailId = item.Id,
                     SparepartDetail = item,
                 });
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

        public SpecialSparepartViewModel GetSparepartSpecial(int sparepartId)
        {
            SpecialSparepart result = _specialSparepartRepository.GetMany(ss => ss.SparepartId == sparepartId && ss.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            SpecialSparepartViewModel mappedResult = new SpecialSparepartViewModel();

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

        public List<SpecialSparepartDetailViewModel> loadSSDetail(int specialSparepartId)
        {
            List<SpecialSparepartDetail> result = _specialSparepartDetailRepository.GetMany(ssd => ssd.SpecialSparepartId == specialSparepartId).ToList();

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
            #region Abort Endorsed SPK
            DateTime serverTime = DateTime.Now;

            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.Completed;
            entity.StatusApprovalId = (int)DbConstant.ApprovalStatus.Endorsed;
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            //_SPKRepository.AttachNavigation<Vehicle>(entity.Vehicle);
            //_SPKRepository.AttachNavigation<User>(entity.ModifyUser);
            //_SPKRepository.AttachNavigation<User>(entity.CreateUser);
            //_SPKRepository.AttachNavigation<Reference>(entity.CategoryReference);
            _SPKRepository.Update(entity);

            foreach (var item in _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == entity.Id))
            {
                Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                sparepart.StockQty = sparepart.StockQty + item.TotalQuantity;
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userId;

                //_sparepartRepository.AttachNavigation<User>(sparepart.ModifyUser);
                //_sparepartRepository.AttachNavigation<User>(sparepart.CreateUser);
                //_sparepartRepository.AttachNavigation<Reference>(sparepart.CategoryReference);
                //_sparepartRepository.AttachNavigation<Reference>(sparepart.UnitReference);
                _sparepartRepository.Update(sparepart);
            }

            foreach (var item in _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SPKDetailSparepart.SPK.Id == entity.Id))
            {
                SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(item.SparepartDetail.Id);
                sparepartDetail.ModifyDate = serverTime;
                sparepartDetail.ModifyUserId = userId;
                sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                //_sparepartDetailRepository.AttachNavigation<User>(sparepartDetail.ModifyUser);
                //_sparepartDetailRepository.AttachNavigation<User>(sparepartDetail.CreateUser);
                //_sparepartDetailRepository.AttachNavigation<Sparepart>(sparepartDetail.Sparepart);
                //_sparepartDetailRepository.AttachNavigation<PurchasingDetail>(sparepartDetail.PurchasingDetail);
                //_sparepartDetailRepository.AttachNavigation<SparepartManualTransaction>(sparepartDetail.SparepartManualTransaction);
                _sparepartDetailRepository.Update(sparepartDetail);
            }

            List<WheelExchangeHistory> wehList = _wheelExchangeHistoryRepository.GetMany(weh => weh.SPKId == spk.Id).ToList();

            foreach (var item in wehList)
            {
                _wheelExchangeHistoryRepository.Delete(item);
            }

            List<SPKSchedule> scheduleList = _SPKScheduleRepository.GetMany(sched => sched.SPKId == spk.Id).ToList();

            foreach (SPKSchedule schedule in scheduleList)
            {
                _SPKScheduleRepository.Delete(schedule);
            }

            _unitOfWork.SaveChanges();
            #endregion
        }
    }
}
