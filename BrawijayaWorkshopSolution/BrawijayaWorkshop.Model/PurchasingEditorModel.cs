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
    public class PurchasingEditorModel : AppBaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISupplierRepository _supplierRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingEditorModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository,
            IReferenceRepository referenceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchasingRepository = purchasingRepository;
            _supplierRepository = supplierRepository;
            _sparepartRepository = sparepartRepository;
            _specialSparepartDetailRepository = wheelDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SupplierViewModel> RetrieveSupplier()
        {
            List<Supplier> result = _supplierRepository.GetMany(c=>c.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<SupplierViewModel> mappedResult = new List<SupplierViewModel>();
            return Map(result, mappedResult);
        }

        public List<SparepartViewModel> RetrieveSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetAll().ToList();
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<PurchasingDetailViewModel> RetrievePurchasingDetail(int purchasingID)
        {
            List<PurchasingDetail> result = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasingID).ToList();
            List<PurchasingDetailViewModel> mappedResult = new List<PurchasingDetailViewModel>();
            Map(result, mappedResult);

            foreach (var itemMapped in mappedResult)
            {
                itemMapped.IsSpecialSparepart = IsSparepartWheel(itemMapped.SparepartId);
            }

            return mappedResult;
        }

        public void InsertPurchasing(PurchasingViewModel purchasing, List<PurchasingDetailViewModel> purchasingDetails, int userID)
        {
            using (var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    InsertPurchasingMethod(purchasing, purchasingDetails, userID);
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
                
            }
        }

        public void UpdatePurchasing(PurchasingViewModel purchasing, List<PurchasingDetailViewModel> purchasingDetails, int userID)
        {
            using(var trans = _unitOfWork.BeginTransaction())
            {
                try
                {
                    List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository
                .GetMany(c => c.PurchasingId == purchasing.Id).ToList();
                    foreach (var purchasingDetail in listPurchasingDetail)
                    {
                        purchasingDetail.Status = (int)DbConstant.PurchasingStatus.Deleted;
                        purchasingDetail.ModifyUserId = userID;
                        purchasingDetail.ModifyDate = DateTime.Now;
                        _purchasingDetailRepository.Update(purchasingDetail);
                    }
                    Purchasing entity = _purchasingRepository.GetById(purchasing.Id);
                    entity.Status = (int)DbConstant.PurchasingStatus.Deleted;
                    entity.ModifyUserId = userID;
                    entity.ModifyDate = DateTime.Now;
                    _purchasingRepository.Update(entity);
                    _unitOfWork.SaveChanges();

                    int supplierID = purchasing.SupplierId;
                    DateTime purchaseDate = purchasing.Date;

                    purchasing = new PurchasingViewModel();
                    purchasing.SupplierId = supplierID;
                    purchasing.Date = purchaseDate;
                    InsertPurchasingMethod(purchasing, purchasingDetails, userID);
                    
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
                
            }
        }

        public void Recalculate(Purchasing purchasing)
        {
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasing.Id).ToList();
            decimal totalPrice = 0;
            foreach (var itemPD in listPurchasingDetail)
            {
                totalPrice += itemPD.Qty * itemPD.Price;
            }

            purchasing.TotalPrice = totalPrice;

            _purchasingRepository.AttachNavigation(purchasing.CreateUser);
            _purchasingRepository.AttachNavigation(purchasing.ModifyUser);
            _purchasingRepository.AttachNavigation(purchasing.PaymentMethod);
            _purchasingRepository.AttachNavigation(purchasing.Supplier);

            _purchasingRepository.Update(purchasing);
            _unitOfWork.SaveChanges();
        }

        public void InsertPurchasingMethod(PurchasingViewModel purchasing, List<PurchasingDetailViewModel> purchasingDetails, int userID)
        {
            DateTime serverTime = DateTime.Now;

            purchasing.CreateDate = serverTime;
            purchasing.CreateUserId = userID;
            purchasing.ModifyUserId = userID;
            purchasing.ModifyDate = serverTime;
            purchasing.Status = (int)DbConstant.PurchasingStatus.NotVerified;
            purchasing.PaymentMethodId = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UTANG).FirstOrDefault().Id;
            purchasing.TotalHasPaid = 0;

            string code = "PRC" + "-" + serverTime.Month.ToString() + serverTime.Day.ToString() + "-";
            //get total purchasing created today
            List<Purchasing> todayPCR = _purchasingRepository.GetMany(s => s.Code.ToString().Contains(code) && s.CreateDate.Year == serverTime.Year).ToList();
            code = code + (todayPCR.Count + 1);
            purchasing.Code = code;

            Purchasing entity = new Purchasing();
            Map(purchasing, entity);

            _purchasingRepository.AttachNavigation(entity.CreateUser);
            _purchasingRepository.AttachNavigation(entity.ModifyUser);
            _purchasingRepository.AttachNavigation(entity.PaymentMethod);
            _purchasingRepository.AttachNavigation(entity.Supplier);
            Purchasing purchasingInserted = _purchasingRepository.Add(entity);
            _unitOfWork.SaveChanges();

            foreach (var itemPurchasingDetail in purchasingDetails)
            {
                PurchasingDetail newPurchasingDetail = new PurchasingDetail();
                newPurchasingDetail.CreateDate = serverTime;
                newPurchasingDetail.CreateUserId = userID;
                newPurchasingDetail.ModifyUserId = userID;
                newPurchasingDetail.ModifyDate = serverTime;
                newPurchasingDetail.PurchasingId = purchasingInserted.Id;
                newPurchasingDetail.SparepartId = itemPurchasingDetail.SparepartId;
                newPurchasingDetail.Qty = itemPurchasingDetail.Qty;
                newPurchasingDetail.Price = itemPurchasingDetail.Price;
                newPurchasingDetail.SerialNumber = itemPurchasingDetail.SerialNumber;
                newPurchasingDetail.Status = (int)DbConstant.PurchasingStatus.NotVerified;

                _purchasingDetailRepository.AttachNavigation(newPurchasingDetail.CreateUser);
                _purchasingDetailRepository.AttachNavigation(newPurchasingDetail.ModifyUser);
                _purchasingDetailRepository.AttachNavigation(newPurchasingDetail.Purchasing);
                _purchasingDetailRepository.AttachNavigation(newPurchasingDetail.Sparepart);
                PurchasingDetail purchasingDetailInserted = _purchasingDetailRepository.Add(newPurchasingDetail);
            }
            _unitOfWork.SaveChanges();
            Recalculate(purchasingInserted);
        }

        public List<PurchasingDetailViewModel> ConvertPurchasingDetailEntityToViewModel(List<PurchasingDetail> list)
        {
            List<PurchasingDetailViewModel> result = new List<PurchasingDetailViewModel>();
            foreach (var item in list)
            {
                result.Add(new PurchasingDetailViewModel
                    {
                        PurchasingId = item.PurchasingId,
                        SparepartId = item.SparepartId,
                        Qty = item.Qty,
                        Price = item.Price,
                        Id = item.Id
                    });
            }
            return result;
        }

        public bool IsSparepartWheel(int sparepartId)
        {
            Sparepart wheelSparepart = _sparepartRepository.GetMany(w => w.Id == sparepartId && w.Status == (int)DbConstant.DefaultDataStatus.Active && w.IsSpecialSparepart).FirstOrDefault();

            return wheelSparepart != null;
        }

        public bool IsSerialNumberExist(string sn)
        {
            SpecialSparepartDetail ssd = _specialSparepartDetailRepository.GetMany(dtl => dtl.SerialNumber.ToLower() == sn.ToLower() && dtl.Status != (int)DbConstant.WheelDetailStatus.Deleted).FirstOrDefault();

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
