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
    public class SPKViewDetailModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IUnitOfWork _unitOfWork;
        private ISPKScheduleRepository _SPKScheduleReposistory;
        private IMechanicRepository _mechanicRepository;
        private IWheelExchangeHistoryRepository _wheelExchangeHistoryRepository;
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISettingRepository _settingRepository;

        public SPKViewDetailModel(IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            ISettingRepository settingRepository,
            IInvoiceRepository invoiceRepository,
            IInvoiceDetailRepository invoiceDetailRepository,
            IUsedGoodRepository usedGoodrepository,
            IVehicleWheelRepository vehicleWheelRepository,
            ISPKScheduleRepository SPKScheduleReposistory,
            IMechanicRepository mechanicRepository,
            IWheelExchangeHistoryRepository wheelExchangeHistoryRepository,
            ISpecialSparepartRepository specialSparepartRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _vehicleRepository = vehicleRepository;
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _settingRepository = settingRepository;
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _usedGoodRepository = usedGoodrepository;
            _SPKScheduleReposistory = SPKScheduleReposistory;
            _mechanicRepository = mechanicRepository;
            _wheelExchangeHistoryRepository = wheelExchangeHistoryRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _specialSparepartRepository = specialSparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKDetailSparepartViewModel> GetSPKSparepartList(int spkId)
        {
            List<SPKDetailSparepart> result = _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == spkId).ToList();
            List<SPKDetailSparepartViewModel> mappedResult = new List<SPKDetailSparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<SPKDetailSparepartDetailViewModel> GetSPKSparepartDetailList(int spkId)
        {
            List<SPKDetailSparepartDetail> result = _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SPKDetailSparepart.SPK.Id == spkId).ToList();
            List<SPKDetailSparepartDetailViewModel> mappedResult = new List<SPKDetailSparepartDetailViewModel>();
            return Map(result, mappedResult);
        }

        public bool ApproveSPK(SPKViewModel spk, List<SPKDetailSparepartViewModel> spkSparepartList, List<SPKDetailSparepartDetailViewModel> spkSparepartDetailList, int userId, bool isApproved, out List<SparepartViewModel> warningList)
        {
            bool result = false;
            bool hasParent = false;

            warningList = new List<SparepartViewModel>();

            DateTime serverTime = DateTime.Now;
            SPK spkParent = _SPKRepository.GetById(spk.SPKParentId);

            if (spkParent != null)
            {
                hasParent = true;
            }

            if (isApproved)
            {
              
                SPK entity = _SPKRepository.GetById(spk.Id);
                entity.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
                entity.ModifyDate = serverTime;
                entity.ModifyUserId = userId;

                _SPKRepository.Update(entity);
                _unitOfWork.SaveChanges();

                foreach (var item in spkSparepartList)
                {
                    Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                    sparepart.StockQty = sparepart.StockQty - item.TotalQuantity;
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userId;

                    _sparepartRepository.Update(sparepart);

                    if (sparepart.StockQty <= GetStockThreshold())
                    {
                        SparepartViewModel viewModel = new SparepartViewModel();
                        Map(sparepart, viewModel);
                        warningList.Add(viewModel);
                    }
                }

                _unitOfWork.SaveChanges();

                foreach (var item in spkSparepartDetailList)
                {
                    SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(item.SparepartDetail.Id);
                    sparepartDetail.ModifyDate = serverTime;
                    sparepartDetail.ModifyUserId = userId;
                    if (item.SPKDetailSparepart.SPK.CategoryReference.Id == 22)
                    {
                        sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;
                    }
                    else
                    {
                        sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutService;
                    }

                    _sparepartDetailRepository.Update(sparepartDetail);
                }

                _unitOfWork.SaveChanges();

                result = true;
            }
            else
            {

                SPK entity = _SPKRepository.GetById(spk.Id);
                entity.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
                entity.ModifyDate = serverTime;
                entity.ModifyUserId = userId;

                if (spk.SPKParent == null)
                {
                    entity.SPKParent = null;
                }
                _SPKRepository.Update(entity);

                _unitOfWork.SaveChanges();

                if (hasParent)
                {
                    spkParent.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                    spkParent.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.InProgress;
                    spkParent.Status = (int)DbConstant.DefaultDataStatus.Active;

                    spkParent.ModifyDate = serverTime;
                    spkParent.ModifyUserId = userId;

                    _SPKRepository.Update(spkParent);

                    _unitOfWork.SaveChanges();
                }
                result = true;
            }

            return result;
        }

        public void PrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;

            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            SPK entity = _SPKRepository.GetById(spk.Id);
            Map(spk, entity);

            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }


        public void AbortSPK(SPKViewModel spk, List<SPKDetailSparepartViewModel> spkSparepartList, List<SPKDetailSparepartDetailViewModel> spkSparepartDetailList, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            _SPKRepository.Update(entity);

            foreach (var item in spkSparepartList)
            {
                Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                sparepart.StockQty = sparepart.StockQty + item.TotalQuantity;
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userId;

                _sparepartRepository.Update(sparepart);
            }

            foreach (var item in spkSparepartDetailList)
            {
                SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(item.SparepartDetail.Id);
                sparepartDetail.ModifyDate = serverTime;
                sparepartDetail.ModifyUserId = userId;
                sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                _sparepartDetailRepository.Update(sparepartDetail);
            }

            _unitOfWork.SaveChanges();

        }

        public void RequestPrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;

            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Pending;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            SPK entity = _SPKRepository.GetById(spk.Id);
            Map(spk, entity);

            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public void ApprovePrintSPK(SPKViewModel spk, int userId, bool isApproved)
        {
            DateTime serverTime = DateTime.Now;

            if (isApproved)
            {
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
            }
            else
            {
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            }

            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            SPK entity = _SPKRepository.GetById(spk.Id);
            Map(spk, entity);

            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public void SetAsCompletedSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.Completed;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;

            _SPKRepository.Update(entity);

            Invoice invc = new Invoice();
            invc.CreateDate = serverTime;
            invc.ModifyDate = serverTime;
            invc.ModifyUserId = userId;
            invc.CreateUserId = userId;

            invc.TotalPrice = spk.TotalSparepartPrice;
            invc.PaymentStatus = (int)DbConstant.PaymentStatus.NotSettled;
            invc.Status = (int)DbConstant.InvoiceStatus.FeeNotFixed;
            invc.PaymentMethod = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_INVOICE_PAYMENTMETHOD_PIUTANG).FirstOrDefault();
            invc.TotalHasPaid = 0;
            invc.SPKId = spk.Id;

            if (spk.isContractWork)
            {
                invc.TotalPrice = spk.TotalSparepartPrice + spk.ContractWorkFee + (spk.ContractWorkFee * (0.2).AsDecimal());
            }
            else
            {
                decimal ServiceFee = 0;

                TimeSpan SPKTimeSpan = serverTime - spk.CreateDate;
                int SPKWorkingDays = Math.Ceiling(SPKTimeSpan.TotalDays).AsInteger();

                for (int i = 0; i < SPKWorkingDays; i++)
                {
                    List<SPKSchedule> involvedMechanic = _SPKScheduleReposistory.GetMany(sc => sc.CreateDate.Day == spk.CreateDate.Day + i).ToList();

                    foreach (SPKSchedule mechanic in involvedMechanic)
                    {
                        int mechanicJobForToday = _SPKScheduleReposistory.GetMany(sc => sc.CreateDate.Day == spk.CreateDate.Day + i && sc.MechanicId == mechanic.Id).Count();

                        decimal mechanicFeeForToday = mechanic.Mechanic.BaseFee / mechanicJobForToday;

                        ServiceFee = ServiceFee + mechanicFeeForToday;
                    }
                }


                invc.TotalPrice = spk.TotalSparepartPrice + ServiceFee + (ServiceFee * (0.1).AsDecimal());
            }

            Invoice insertedInvoice = _invoiceRepository.Add(invc);

            List<SPKDetailSparepart> SPKSpList = _SPKDetailSparepartRepository.GetMany(sp => sp.SPKId == spk.Id).ToList();

            foreach (SPKDetailSparepart spkSp in SPKSpList)
            {


                List<SPKDetailSparepartDetail> SPKSpDetailList = _SPKDetailSparepartDetailRepository.GetMany(spdt => spdt.SPKDetailSparepartId == spkSp.Id).ToList();

                foreach (SPKDetailSparepartDetail spkSpDtl in SPKSpDetailList)
                {
                    InvoiceDetail invcDtl = new InvoiceDetail();

                    invcDtl.Invoice = insertedInvoice;
                    invcDtl.SPKDetailSparepartDetail = spkSpDtl;
                    invcDtl.SubTotalPrice = spkSpDtl.SparepartDetail.PurchasingDetail.Price.AsDouble();
                    invcDtl.Status = (int)DbConstant.DefaultDataStatus.Active;

                    invcDtl.CreateDate = serverTime;
                    invcDtl.ModifyDate = serverTime;
                    invcDtl.ModifyUserId = userId;
                    invcDtl.CreateUserId = userId;

                    _invoiceDetailRepository.Add(invcDtl);
                }

                UsedGood foundUsedGood = _usedGoodRepository.GetMany(ug => ug.SparepartId == spkSp.Id && ug.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                if (foundUsedGood != null)
                {
                    foundUsedGood.Stock = foundUsedGood.Stock + SPKSpDetailList.Count;
                    _usedGoodRepository.Update(foundUsedGood);
                }

                //Replace Vehicle Wheel
                foreach (var item in getCurrentVehicleWheel(spk.Id, spk.VehicleId).Where(w => w.ReplaceWithWheelDetailId > 0))
                {
                    VehicleWheel vw = _vehicleWheelRepository.GetById(item.Id);

                    vw.WheelDetailId = item.ReplaceWithWheelDetailId;
                    vw.ModifyDate = serverTime;
                    vw.ModifyUserId = userId;

                    _vehicleWheelRepository.Update(vw);
                }

                //Remove Wheel Exchange
                List<WheelExchangeHistory> wehList = _wheelExchangeHistoryRepository.GetMany(weh => weh.SPKId == spk.Id).ToList();

                foreach (var item in wehList)
                {
                    _wheelExchangeHistoryRepository.Delete(item);
                }
            }

            _unitOfWork.SaveChanges();
        }


        public int GetStockThreshold()
        {
            int result = 0;

            string threshold = _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_P).FirstOrDefault().Value;

            int.TryParse(threshold, out result);

            return result;
        }

        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId, int SPKId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                  vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            Map(result, mappedResult);

            foreach (var item in mappedResult)
            {
                WheelExchangeHistory wheel = _wheelExchangeHistoryRepository.GetMany(w => w.SPKId == SPKId && w.OriginalWheelId == item.WheelDetailId).FirstOrDefault();
                if (wheel != null)
                {
                    item.ReplaceWithWheelDetailId = wheel.ReplaceWheelId;
                    item.ReplaceWithWheelDetailSerialNumber = wheel.ReplaceWheel.SerialNumber;
                    item.Price = wheel.ReplaceWheel.SparepartDetail.PurchasingDetail.Price;
                }
            }

            return mappedResult;
        }


    }
}
