using BrawijayaWorkshop.Constant;
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
    public class InvoiceListModel : AppBaseModel
    {
        private IInvoiceRepository _invoiceRepository;
        private IInvoiceDetailRepository _invoiceDetailRepository;
        private ICustomerRepository _customerRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private IVehicleGroupRepository _vehicleGroupRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private ISPKRepository _spkRepository;
        private ISPKDetailSparepartRepository _spkDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _spkDetailSparepartDetailRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private IUnitOfWork _unitOfWork;

        public InvoiceListModel(IInvoiceRepository invoiceRepository, IInvoiceDetailRepository invoiceDetailRepository,
            ICustomerRepository customerRepository, ISparepartRepository sparepartRepository,
            IReferenceRepository referenceRepository,
            IVehicleGroupRepository vehicleGroupRepository,
            IVehicleDetailRepository vehicleDetailRepository,
            ISPKRepository spkRepository,
            ISPKDetailSparepartRepository spkDetailSparepartRepository,
            ISPKDetailSparepartDetailRepository spkDetailSparepartDetailRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartManualTransactionRepository sparepartManualTransactionRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
            _customerRepository = customerRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _vehicleGroupRepository = vehicleGroupRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _spkRepository = spkRepository;
            _spkDetailSparepartRepository = spkDetailSparepartRepository;
            _spkDetailSparepartDetailRepository = spkDetailSparepartDetailRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<CustomerViewModel> GetAllCustomer()
        {
            List<Customer> result = _customerRepository.GetMany(c => c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<CustomerViewModel> mappedResult = new List<CustomerViewModel>();
            return Map(result, mappedResult);
        }

        public void Print(int[] invoiceIDs)
        {
            foreach (var id in invoiceIDs)
            {
                Invoice invoice = _invoiceRepository.GetById(id);
                invoice.Status = (int)DbConstant.InvoiceStatus.Printed;
                _invoiceRepository.Update(invoice);
            }
            _unitOfWork.SaveChanges();
        }

        public List<InvoiceSparepartViewModel> GetInvoiceSparepartList(int invoiceID)
        {
            List<InvoiceSparepartViewModel> result = new List<InvoiceSparepartViewModel>();
            List<InvoiceDetail> listInvoiceDetail = _invoiceDetailRepository.GetMany(x => x.InvoiceId == invoiceID).ToList();

            foreach (InvoiceDetail invoiceDetail in listInvoiceDetail)
            {
                double itemPrice = 0;

                if (invoiceDetail.SPKDetailSparepartDetail.SparepartManualTransactionId > 0)
                {
                    itemPrice = decimal.ToDouble(invoiceDetail.SPKDetailSparepartDetail.SparepartManualTransaction.Price);
                }
                else if (invoiceDetail.SPKDetailSparepartDetail.PurchasingDetailId > 0)
                {
                    itemPrice = decimal.ToDouble(invoiceDetail.SPKDetailSparepartDetail.PurchasingDetail.Price);
                }

                result.Add(new InvoiceSparepartViewModel
                {
                    SparepartName = invoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.Sparepart.Name,
                    Qty = invoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.TotalQuantity,
                    SubTotalPrice = decimal.ToDouble(invoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.TotalPrice),
                    SparepartCode = invoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.Sparepart.Code,
                    UnitCategoryName = invoiceDetail.SPKDetailSparepartDetail.SPKDetailSparepart.Sparepart.UnitReference.Name,
                    ItemPrice = itemPrice
                });
            }

            //int[] sparepartIDs = listInvoiceDetail.Select(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId).Distinct().ToArray();
            //foreach (var sparepartID in sparepartIDs)
            //{
            //    result.Add(new InvoiceSparepartViewModel
            //    {
            //        SparepartName = _sparepartRepository.GetById(sparepartID).Name,
            //        Qty = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Count(),
            //        SubTotalPrice = listInvoiceDetail.Where(x => x.SPKDetailSparepartDetail.SPKDetailSparepart.SparepartId == sparepartID).Sum(x => x.SubTotalPrice),
            //        SparepartCode = _sparepartRepository.GetById(sparepartID).Code,
            //        UnitCategoryName = _sparepartRepository.GetById(sparepartID).UnitReference.Name
            //    });
            //}
            return result;
        }

        public List<InvoiceViewModel> SearchInvoice(DateTime? dateFrom, DateTime? dateTo,
            DbConstant.InvoiceStatus invoiceStatus, int customerId,
            int serviceCategoryId, int vehicleGroupId, string licenseNumber,
            int paymentStatus)
        {
            List<Invoice> result = null;

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _invoiceRepository.GetMany(c => c.CreateDate >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.CreateDate).ToList();
            }
            else
            {
                result = _invoiceRepository.GetAll().OrderBy(c => c.CreateDate).ToList();
            }

            if ((int)invoiceStatus != 9)
            {
                result = result.Where(spk => spk.Status == (int)invoiceStatus).ToList();
            }

            if (customerId > 0)
            {
                result = result.Where(inv => inv.SPK.Vehicle.CustomerId == customerId).ToList();
            }

            if (vehicleGroupId > 0)
            {
                result = result.Where(inv => inv.SPK.Vehicle.VehicleGroupId == vehicleGroupId).ToList();
            }

            if (!string.IsNullOrEmpty(licenseNumber))
            {
                VehicleDetail vehicleDetail = _vehicleDetailRepository.GetMany(v => string.Compare(v.LicenseNumber, licenseNumber, true) == 1
                                                                                    && v.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                if (vehicleDetail != null)
                {
                    result = result.Where(inv => inv.SPK.VehicleId == vehicleDetail.VehicleId).ToList();
                }
            }

            if (serviceCategoryId > 0)
            {
                result = result.Where(inv => inv.SPK.CategoryReferenceId == serviceCategoryId).ToList();
            }

            if (paymentStatus > -1)
            {
                result = result.Where(inv => inv.PaymentStatus == paymentStatus).ToList();
            }

            List<InvoiceViewModel> mappedResult = new List<InvoiceViewModel>();
            return Map(result, mappedResult);
        }

        public List<InvoiceDetailViewModel> GetInvoiceDetailsByParentId(int invoiceId)
        {
            List<InvoiceDetail> result = _invoiceDetailRepository.GetMany(invd =>
                invd.Status == (int)DbConstant.DefaultDataStatus.Active &&
                invd.InvoiceId == invoiceId).ToList();
            List<InvoiceDetailViewModel> mappedResult = new List<InvoiceDetailViewModel>();
            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> GetServiceCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleGroupViewModel> GetVehicleGroupByCustomer(int customerId)
        {
            List<VehicleGroup> result = _vehicleGroupRepository.GetMany(vg => vg.Status == (int)DbConstant.DefaultDataStatus.Active &&
                vg.CustomerId == customerId).ToList();
            List<VehicleGroupViewModel> mappedResult = new List<VehicleGroupViewModel>();
            return Map(result, mappedResult);
        }

        public void RepairInvoice()
        {
            DateTime start = new DateTime(2018, 11, 1);
            DateTime serverTime = DateTime.Now;

            List<Invoice> invList = _invoiceRepository.GetMany(i => i.CreateDate >= start).ToList();

            using (var trans = _unitOfWork.BeginTransaction())
            {

                try
                {
                    foreach (Invoice inv in invList)
                    {
                        List<InvoiceDetail> invDetails = _invoiceDetailRepository.GetMany(ivd => ivd.InvoiceId == inv.Id).ToList();

                        List<SPKDetailSparepart> spkSps = _spkDetailSparepartRepository.GetMany(spkspd => spkspd.SPKId == inv.SPKId).ToList();
                        List<int> spkSpsId = spkSps.Select(x => x.Id).ToList();
                        List<SPKDetailSparepartDetail> spkSPDetails = _spkDetailSparepartDetailRepository.GetMany(spkspdt => spkSpsId.Contains(spkspdt.SPKDetailSparepartId)).ToList();

                        if (spkSPDetails.Count < spkSps.Count)
                        {
                            spkSps = spkSps.Where(spksp => !spkSPDetails.Any(spkspdt => spkspdt.SPKDetailSparepartId == spksp.Id)).ToList();

                            foreach (SPKDetailSparepart item in spkSps)
                            {
                                SpecialSparepartDetail sspd = _specialSparepartDetailRepository.GetMany(e => e.SparepartId == item.SparepartId).FirstOrDefault();
                                List<SPKDetailSparepartDetail> newSPKdetailSparepartDetails = getRandomSPKDetails(item.SparepartId, item.TotalQuantity, sspd!=null? sspd.Id : 0);

                                foreach (SPKDetailSparepartDetail spkDetailSparepartDetail in newSPKdetailSparepartDetails)
                                {
                                    SPKDetailSparepartDetail newSPKSparepartDetail = new SPKDetailSparepartDetail();

                                    newSPKSparepartDetail.CreateDate = item.CreateDate;
                                    newSPKSparepartDetail.CreateUserId = item.CreateUserId;
                                    newSPKSparepartDetail.ModifyDate = serverTime;
                                    newSPKSparepartDetail.ModifyUserId = item.ModifyUserId;
                                    newSPKSparepartDetail.Status = (int)DbConstant.DefaultDataStatus.Active;
                                    newSPKSparepartDetail.SPKDetailSparepartId = item.Id;
                                    newSPKSparepartDetail.Qty = spkDetailSparepartDetail.Qty;

                                    if (sspd != null)
                                    {
                                        newSPKSparepartDetail.SpecialSparepartDetailId = sspd.Id;
                                        sspd.Status = (int)DbConstant.WheelDetailStatus.Installed;
                                        _specialSparepartDetailRepository.Update(sspd);

                                    }

                                    if (spkDetailSparepartDetail.PurchasingDetailId.HasValue)
                                    {
                                        newSPKSparepartDetail.PurchasingDetailId = spkDetailSparepartDetail.PurchasingDetailId;

                                        PurchasingDetail pdt = spkDetailSparepartDetail.PurchasingDetail;

                                        pdt.ModifyDate = serverTime;
                                        pdt.ModifyUserId = item.CreateUserId;

                                        _purchasingDetailRepository.Update(pdt);
                                    }
                                    else if (spkDetailSparepartDetail.SparepartManualTransactionId.HasValue)
                                    {
                                        newSPKSparepartDetail.SparepartManualTransactionId = spkDetailSparepartDetail.SparepartManualTransactionId;

                                        SparepartManualTransaction spm = spkDetailSparepartDetail.SparepartManualTransaction;

                                        spm.ModifyDate = serverTime;
                                        spm.ModifyUserId = item.CreateUserId;

                                        _sparepartManualTransactionRepository.Update(spm);
                                    }


                                    SPKDetailSparepartDetail insertedSPKSpDtl = _spkDetailSparepartDetailRepository.Add(newSPKSparepartDetail);

                                    InvoiceDetail invcDtl = new InvoiceDetail();

                                    invcDtl.InvoiceId = inv.Id;
                                    invcDtl.SPKDetailSparepartDetail = insertedSPKSpDtl;

                                    if (spkDetailSparepartDetail.PurchasingDetailId > 0)
                                    {
                                        invcDtl.SubTotalPrice = spkDetailSparepartDetail.PurchasingDetail.Price.AsDouble();
                                    }
                                    else
                                    {
                                        invcDtl.SubTotalPrice = spkDetailSparepartDetail.SparepartManualTransaction.Price.AsDouble();
                                    }

                                    invcDtl.Status = (int)DbConstant.DefaultDataStatus.Active;
                                    invcDtl.FeePctg = 0;

                                    invcDtl.CreateDate = serverTime;
                                    invcDtl.ModifyDate = serverTime;
                                    invcDtl.ModifyUserId = item.CreateUserId;
                                    invcDtl.CreateUserId = item.CreateUserId;

                                    _invoiceDetailRepository.Add(invcDtl);

                                    _unitOfWork.SaveChanges();
                                }
                            }
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


        public List<SPKDetailSparepartDetail> getRandomSPKDetails(int sparepartId, int qty, int ssDetailId)
        {
            List<SparepartManualTransaction> spManuals = new List<SparepartManualTransaction>();
            List<PurchasingDetail> purchasingDetails = new List<PurchasingDetail>();
            List<SPKDetailSparepartDetail> result = new List<SPKDetailSparepartDetail>();
            if (qty > 0 && sparepartId > 0)
            {
                int qtyRemains = qty;

                List<SparepartManualTransaction> spManual = _sparepartManualTransactionRepository
                    .GetMany(
                        spd => spd.SparepartId == sparepartId &&
                        spd.QtyRemaining > 0
                    )
                    .OrderBy(spd => spd.CreateDate).ToList();

                foreach (var itemManual in spManual)
                {
                    if (itemManual.QtyRemaining > qtyRemains)
                    {
                        itemManual.QtyRemaining = itemManual.QtyRemaining - qtyRemains;

                        SPKDetailSparepartDetail spkspd = new SPKDetailSparepartDetail
                        {
                            SparepartManualTransaction = itemManual,
                            SparepartManualTransactionId = itemManual.Id,
                            SPKDetailSparepartId = itemManual.SparepartId,
                            Qty = qtyRemains
                        };

                        if (ssDetailId > 0)
                        {
                            spkspd.SpecialSparepartDetailId = ssDetailId;
                        }

                        result.Add(spkspd);

                        qtyRemains = 0;
                    }
                    else
                    {
                        SPKDetailSparepartDetail spkspd = new SPKDetailSparepartDetail
                        {
                            SparepartManualTransaction = itemManual,
                            SparepartManualTransactionId = itemManual.Id,
                            SPKDetailSparepartId = itemManual.SparepartId,
                            Qty = itemManual.QtyRemaining
                        };

                        if (ssDetailId > 0)
                        {
                            spkspd.SpecialSparepartDetailId = ssDetailId;
                        }

                        result.Add(spkspd);

                        qtyRemains -= itemManual.QtyRemaining;
                        itemManual.QtyRemaining = 0;
                    }

                    if (qtyRemains == 0) break;
                }

                if (qtyRemains > 0)
                {
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
                            itemPD.QtyRemaining = itemPD.QtyRemaining - qtyRemains;

                            SPKDetailSparepartDetail spkspd = new SPKDetailSparepartDetail
                            {
                                PurchasingDetail = itemPD,
                                PurchasingDetailId = itemPD.Id,
                                SPKDetailSparepartId = itemPD.SparepartId,
                                Qty = qtyRemains
                            };

                            if (ssDetailId > 0)
                            {
                                spkspd.SpecialSparepartDetailId = ssDetailId;
                            }

                            result.Add(spkspd);

                            qtyRemains = 0;
                        }
                        else
                        {

                            SPKDetailSparepartDetail spkspd = new SPKDetailSparepartDetail
                            {
                                PurchasingDetail = itemPD,
                                PurchasingDetailId = itemPD.Id,
                                SPKDetailSparepartId = itemPD.SparepartId,
                                Qty = itemPD.QtyRemaining
                            };

                            if (ssDetailId > 0)
                            {
                                spkspd.SpecialSparepartDetailId = ssDetailId;
                            }

                            result.Add(spkspd);

                            qtyRemains -= itemPD.QtyRemaining;
                            itemPD.QtyRemaining = 0;

                        }

                        if (qtyRemains == 0) break;
                    }
                }
            }

            return result;

        }

        public void RepairInvoice(int invoiceId)
        {

        }
    }
}
