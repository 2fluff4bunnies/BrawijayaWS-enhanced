using BrawijayaWorkshop.Constant;
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
    public class PurchasingApprovalModel : BaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISupplierRepository _supplierRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingApprovalModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository, IUnitOfWork unitOfWork)
        {
            _purchasingDetailRepository = purchasingDetailRepository;
            _purchasingRepository = purchasingRepository;
            _supplierRepository = supplierRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchasingDetail> RetrievePurchasingDetail(int purchasingID)
        {
            List<PurchasingDetail> listEntity = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasingID).ToList();
            return listEntity;
        }
        public List<Sparepart> RetrieveSparepart()
        {
            return _sparepartRepository.GetAll().ToList();
        }
        public List<Reference> RetrievePaymentMethod()
        {
            Reference parent =  _referenceRepository
                .GetMany(c=>c.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if(parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            return list;
        }

        public void Approve(Purchasing purchasing, int userID)
        {
            DateTime serverTime = DateTime.Now;

            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository
                .GetMany(c => c.PurchasingId == purchasing.Id).ToList();
            foreach (var purchasingDetail in listPurchasingDetail)
            {
                List<SparepartDetail> listSparepartDetail = _sparepartDetailRepository
                    .GetMany(c => c.PurchasingDetailId == purchasingDetail.Id).ToList();
                foreach (var sparepartDetail in listSparepartDetail)
                {
                    sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;
                    _sparepartDetailRepository.Update(sparepartDetail);

                }
                purchasingDetail.Status = (int)DbConstant.PurchasingStatus.Active;
                _purchasingDetailRepository.Update(purchasingDetail);
            }
            
            Reference refSelected = _referenceRepository.GetById(purchasing.PaymentMethodId);
            purchasing.Status = (int)DbConstant.PurchasingStatus.Active;
            if (refSelected != null &&
                (refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_BANK
                || refSelected.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD_KAS)
               )
            {
                purchasing.TotalHasPaid = purchasing.TotalPrice;
            }
            _purchasingRepository.Update(purchasing);

            Reference transactionReferenceTable = _referenceRepository.GetMany(c=>c.Code == DbConstant.REF_TRANSTBL_PURCHASING).FirstOrDefault();
            Transaction transaction = new Transaction();
            transaction.TransactionDate = purchasing.Date;
            transaction.TotalPayment = Convert.ToDouble(purchasing.TotalHasPaid);
            transaction.TotalTransaction = Convert.ToDouble(purchasing.TotalPrice);
            transaction.ReferenceTableId = transactionReferenceTable.Id;
            transaction.PrimaryKeyValue = purchasing.Id;
            transaction.CreateDate = serverTime;
            transaction.CreateUserId = userID;
            transaction.ModifyUserId = userID;
            transaction.ModifyDate = serverTime;
            _transactionRepository.Add(transaction);
            //to do transaction detail aka journal
            //........

            _unitOfWork.SaveChanges();
        }

        public void Reject(Purchasing purchasing)
        {
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository
                .GetMany(c => c.PurchasingId == purchasing.Id).ToList();
            foreach (var purchasingDetail in listPurchasingDetail)
	        {
                List<SparepartDetail> listSparepartDetail = _sparepartDetailRepository
                    .GetMany(c=>c.PurchasingDetailId == purchasingDetail.Id).ToList();
                foreach (var sparepartDetail in listSparepartDetail)
	            {
                    _sparepartDetailRepository.Delete(sparepartDetail);
		 
	            }
                _purchasingDetailRepository.Delete(purchasingDetail);
	        }
            _purchasingRepository.Delete(purchasing);
            _unitOfWork.SaveChanges();
        }
    }
}
