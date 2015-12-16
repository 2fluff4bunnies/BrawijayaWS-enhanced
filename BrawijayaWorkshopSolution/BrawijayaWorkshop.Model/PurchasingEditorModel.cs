using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class PurchasingEditorModel : BaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISupplierRepository _supplierRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingEditorModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
        {
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchasingRepository = purchasingRepository;
            _supplierRepository = supplierRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
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

        public List<PurchasingDetail> RetrievePurchasingDetail(int purchasingID)
        {
            return _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasingID).ToList();
        }

        public void InsertPurchasing(Purchasing purchasing, List<PurchasingDetail> purchasingDetails, int userID)
        {
            DateTime serverTime = DateTime.Now;

            purchasing.CreateDate = serverTime;
            purchasing.CreateUserId = userID;
            purchasing.ModifyUserId = userID;
            purchasing.ModifyDate = serverTime;
            _purchasingRepository.Add(purchasing);

            foreach (var itemPurchasingDetail in purchasingDetails)
            {
                Sparepart sparepartDB = _sparepartRepository.GetById(itemPurchasingDetail.SparepartId);

                SparepartDetail lastSPDetail =  _sparepartDetailRepository.
                    GetMany(c=>c.SparepartId == itemPurchasingDetail.SparepartId).FirstOrDefault();
                string lastSPID = string.Empty;
                if(lastSPDetail != null) lastSPID = lastSPDetail.Code;

                sparepartDB.StockQty = sparepartDB.StockQty + itemPurchasingDetail.Qty;
                sparepartDB.ModifyUserId = userID;
                sparepartDB.ModifyDate = serverTime;
                _sparepartRepository.Update(sparepartDB);

                itemPurchasingDetail.CreateDate = serverTime;
                itemPurchasingDetail.CreateUserId = userID;
                itemPurchasingDetail.ModifyUserId = userID;
                itemPurchasingDetail.ModifyDate = serverTime;
                _purchasingDetailRepository.Add(itemPurchasingDetail);

                for (int i = 0; i < itemPurchasingDetail.Qty; i++)
                {
                    SparepartDetail spDetail = new SparepartDetail();
                    string spDetailCode = string.Empty;
                    if (string.IsNullOrEmpty(lastSPID))
                    {
                        spDetailCode = sparepartDB.Code + "0000000001";
                    }
                    else
                    {
                        spDetailCode = sparepartDB.Code + Convert.ToInt32(lastSPID.Substring(lastSPID.Length - 10))
                            .ToString("D10");
                    }
                    spDetail.PurchasingDetailId = itemPurchasingDetail.Id;
                    spDetail.SparepartId = sparepartDB.Id;
                    spDetail.Code = spDetailCode;
                    spDetail.CreateDate = serverTime;
                    spDetail.CreateUserId = userID;
                    spDetail.ModifyUserId = userID;
                    spDetail.ModifyDate = serverTime;
                    spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.NotVerified;
                    _sparepartDetailRepository.Add(spDetail);
                }
            }
            _unitOfWork.SaveChanges();
        }

        public void UpdatePurchasing(Purchasing purchasing, List<PurchasingDetail> purchasingDetails, int userID)
        {
            DateTime serverTime = DateTime.Now;

            purchasing.ModifyUserId = userID;
            purchasing.ModifyDate = serverTime;
            _purchasingRepository.Update(purchasing);

            List<PurchasingDetail> purchasingDetailsDB = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasing.Id).ToList();

            //check for updated and deleted item
            foreach (var itemPurchasingDetailDB in purchasingDetailsDB)
            {
                PurchasingDetail itemUpdated = purchasingDetails.Where(i => i.Id == itemPurchasingDetailDB.Id).FirstOrDefault();
                if (itemUpdated != null)
                {
                    //update
                    if (itemUpdated.Qty != itemPurchasingDetailDB.Qty)
                    {
                        //update stock
                        Sparepart sparepartDB = _sparepartRepository.GetById(itemUpdated.SparepartId);

                        SparepartDetail lastSPDetail = _sparepartDetailRepository.
                            GetMany(c => c.SparepartId == itemUpdated.SparepartId).FirstOrDefault();
                        string lastSPID = string.Empty;
                        if (lastSPDetail != null) lastSPID = lastSPDetail.Code;

                        sparepartDB.StockQty = sparepartDB.StockQty - itemPurchasingDetailDB.Qty + itemUpdated.Qty;
                        sparepartDB.ModifyUserId = userID;
                        sparepartDB.ModifyDate = serverTime;
                        _sparepartRepository.Update(sparepartDB);

                        int diffQty = itemPurchasingDetailDB.Qty - itemUpdated.Qty;
                        int absDiffQty = Math.Abs(diffQty);
                        if (diffQty < 0)
                        {
                            List<SparepartDetail> listDetailDeleted = _sparepartDetailRepository
                                .GetMany(c => c.SparepartId == sparepartDB.Id).Take(absDiffQty)
                                .OrderByDescending(c => c.Code).ToList();
                            foreach (var itemDetailDeleted in listDetailDeleted)
                            {
                                _sparepartDetailRepository.Delete(itemDetailDeleted);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < absDiffQty; i++)
                            {
                                SparepartDetail spDetail = new SparepartDetail();
                                spDetail.PurchasingDetailId = itemUpdated.Id;
                                spDetail.SparepartId = sparepartDB.Id;
                                string spDetailCode = string.Empty;
                                if (string.IsNullOrEmpty(lastSPID))
                                {
                                    spDetailCode = sparepartDB.Code + "0000000001";
                                }
                                else
                                {
                                    spDetailCode = sparepartDB.Code + Convert.ToInt32(lastSPID.Substring(lastSPID.Length - 10))
                                        .ToString("D10");
                                } 
                                spDetail.CreateDate = serverTime;
                                spDetail.CreateUserId = userID;
                                spDetail.ModifyUserId = userID;
                                spDetail.ModifyDate = serverTime;
                                spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.NotVerified;
                                _sparepartDetailRepository.Add(spDetail);
                            }
                        }
                    }
                    itemUpdated.ModifyUserId = userID;
                    itemUpdated.ModifyDate = serverTime;
                    _purchasingDetailRepository.Update(itemUpdated);

                    purchasingDetails.Remove(itemUpdated);
                }
                else
                {
                    //delete
                    Sparepart sparepartDB = _sparepartRepository.GetById(itemUpdated.SparepartId);
                    sparepartDB.StockQty = sparepartDB.StockQty - itemPurchasingDetailDB.Qty;
                    sparepartDB.ModifyUserId = userID;
                    sparepartDB.ModifyDate = serverTime;
                    _sparepartRepository.Update(sparepartDB);

                    List<SparepartDetail> listDetailDeleted = _sparepartDetailRepository
                        .GetMany(c => c.SparepartId == sparepartDB.Id).Take(itemPurchasingDetailDB.Qty)
                        .OrderByDescending(c => c.Code).ToList();
                    foreach (var itemDetailDeleted in listDetailDeleted)
                    {
                        _sparepartDetailRepository.Delete(itemDetailDeleted);
                    }

                    _purchasingDetailRepository.Delete(itemPurchasingDetailDB);
                }
            }

            //new item
            foreach (var itemPurchasingDetail in purchasingDetails)
            {
                Sparepart sparepartDB = _sparepartRepository.GetById(itemPurchasingDetail.SparepartId);

                SparepartDetail lastSPDetail = _sparepartDetailRepository.
                            GetMany(c => c.SparepartId == itemPurchasingDetail.SparepartId).FirstOrDefault();
                string lastSPID = string.Empty;
                if (lastSPDetail != null) lastSPID = lastSPDetail.Code; 

                sparepartDB.StockQty = sparepartDB.StockQty + itemPurchasingDetail.Qty;
                sparepartDB.ModifyUserId = userID;
                sparepartDB.ModifyDate = serverTime;
                _sparepartRepository.Update(sparepartDB);


                itemPurchasingDetail.CreateDate = serverTime;
                itemPurchasingDetail.CreateUserId = userID;
                itemPurchasingDetail.ModifyUserId = userID;
                itemPurchasingDetail.ModifyDate = serverTime;
                _purchasingDetailRepository.Add(itemPurchasingDetail);

                for (int i = 0; i < itemPurchasingDetail.Qty; i++)
                {
                    SparepartDetail spDetail = new SparepartDetail();
                    spDetail.PurchasingDetailId = itemPurchasingDetail.Id;
                    spDetail.SparepartId = sparepartDB.Id;
                    string spDetailCode = string.Empty;
                    if (string.IsNullOrEmpty(lastSPID))
                    {
                        spDetailCode = sparepartDB.Code + "0000000001";
                    }
                    else
                    {
                        spDetailCode = sparepartDB.Code + Convert.ToInt32(lastSPID.Substring(lastSPID.Length - 10))
                            .ToString("D10");
                    } 
                    spDetail.CreateDate = serverTime;
                    spDetail.CreateUserId = userID;
                    spDetail.ModifyUserId = userID;
                    spDetail.ModifyDate = serverTime;
                    spDetail.Status = (int)DbConstant.SparepartDetailDataStatus.NotVerified;
                    _sparepartDetailRepository.Add(spDetail);
                }

            }

            _unitOfWork.SaveChanges();
        }
    }
}
