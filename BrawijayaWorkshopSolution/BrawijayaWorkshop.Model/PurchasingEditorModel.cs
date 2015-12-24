﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.SharedObject.ViewModels;
using AutoMapper;

namespace BrawijayaWorkshop.Model
{
    public class PurchasingEditorModel : BaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISupplierRepository _supplierRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingEditorModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository, IUnitOfWork unitOfWork)
        {
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchasingRepository = purchasingRepository;
            _supplierRepository = supplierRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Supplier> RetrieveSupplier()
        {
            return _supplierRepository.GetAll().ToList();
        }

        public List<Sparepart> RetrieveSparepart()
        {
            return _sparepartRepository.GetAll().ToList();
        }

        public List<PurchasingDetailViewModel> RetrievePurchasingDetail(int purchasingID)
        {
            List<PurchasingDetail> listEntity = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasingID).ToList();
            List<PurchasingDetailViewModel> result = ConvertPurchasingDetailEntityToViewModel(listEntity);
            return result;
        }

        public void InsertPurchasing(Purchasing purchasing, List<PurchasingDetailViewModel> purchasingDetails, int userID)
        {
            DateTime serverTime = DateTime.Now;

            purchasing.CreateDate = serverTime;
            purchasing.CreateUserId = userID;
            purchasing.ModifyUserId = userID;
            purchasing.ModifyDate = serverTime;
            purchasing.Status = (int)DbConstant.PurchasingStatus.NotVerified;
            purchasing.PaymentMethodId = _referenceRepository.GetMany(c => c.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_UTANG).FirstOrDefault().Id;
            purchasing.TotalHasPaid = 0;
            Purchasing purchasingInserted = _purchasingRepository.Add(purchasing);

            foreach (var itemPurchasingDetail in purchasingDetails)
            {
                PurchasingDetail newPurchasingDetail = new PurchasingDetail();
                newPurchasingDetail.CreateDate = serverTime;
                newPurchasingDetail.CreateUserId = userID;
                newPurchasingDetail.ModifyUserId = userID;
                newPurchasingDetail.ModifyDate = serverTime;
                newPurchasingDetail.Purchasing = purchasingInserted;
                newPurchasingDetail.SparepartId = itemPurchasingDetail.SparepartId;
                newPurchasingDetail.Qty = itemPurchasingDetail.Qty;
                newPurchasingDetail.Price = itemPurchasingDetail.Price;
                newPurchasingDetail.Status = (int)DbConstant.PurchasingStatus.NotVerified;
                PurchasingDetail purchasingDetailInserted = _purchasingDetailRepository.Add(newPurchasingDetail);
            }
            _unitOfWork.SaveChanges();
            Recalculate(purchasingInserted);
        }

        public void UpdatePurchasing(Purchasing purchasing, List<PurchasingDetailViewModel> purchasingDetails, int userID)
        {
            DateTime serverTime = DateTime.Now;
            purchasing.ModifyUserId = userID;
            purchasing.ModifyDate = serverTime;
            _purchasingRepository.Update(purchasing);

            List<PurchasingDetail> purchasingDetailsDB = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasing.Id).ToList();
            //check for updated and deleted item
            foreach (var itemPurchasingDetailDB in purchasingDetailsDB)
            {
                PurchasingDetailViewModel itemUpdated = purchasingDetails.Where(i => i.Id == itemPurchasingDetailDB.Id).FirstOrDefault();
                if (itemUpdated != null)
                {
                    PurchasingDetail purchasingDetailUpdated = _purchasingDetailRepository.GetById(itemUpdated.Id);
                    purchasingDetailUpdated.PurchasingId = itemUpdated.PurchasingId;
                    purchasingDetailUpdated.SparepartId = itemUpdated.SparepartId;
                    purchasingDetailUpdated.Qty = itemUpdated.Qty;
                    purchasingDetailUpdated.Price = itemUpdated.Price;
                    purchasingDetailUpdated.ModifyUserId = userID;
                    purchasingDetailUpdated.ModifyDate = serverTime;
                    _purchasingDetailRepository.Update(purchasingDetailUpdated);

                    purchasingDetails.Remove(itemUpdated);
                }
                else
                {
                    //delete
                    _purchasingDetailRepository.Delete(_purchasingDetailRepository.GetById<int>(itemPurchasingDetailDB.Id));
                }
            }

            //new item
            foreach (var itemPurchasingDetail in purchasingDetails)
            {
                PurchasingDetail newPurchasingDetail = new PurchasingDetail();
                newPurchasingDetail.PurchasingId = purchasing.Id;
                newPurchasingDetail.SparepartId = itemPurchasingDetail.SparepartId;
                newPurchasingDetail.Qty = itemPurchasingDetail.Qty;
                newPurchasingDetail.Price = itemPurchasingDetail.Price;
                newPurchasingDetail.CreateDate = serverTime;
                newPurchasingDetail.CreateUserId = userID;
                newPurchasingDetail.ModifyUserId = userID;
                newPurchasingDetail.ModifyDate = serverTime;
                newPurchasingDetail.Status = (int)DbConstant.PurchasingStatus.NotVerified;
                PurchasingDetail purchasingDetailInserted = _purchasingDetailRepository.Add(newPurchasingDetail);
            }

            _unitOfWork.SaveChanges();
            Recalculate(purchasing);
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
            _purchasingRepository.Update(purchasing);
            _unitOfWork.SaveChanges();
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

    }
}
