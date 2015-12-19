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
        private IUnitOfWork _unitOfWork;

        public PurchasingApprovalModel(IPurchasingRepository purchasingRepository, ISupplierRepository supplierRepository,
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

        public List<PurchasingDetail> RetrievePurchasingDetail(int purchasingID)
        {
            List<PurchasingDetail> listEntity = _purchasingDetailRepository.GetMany(c => c.PurchasingId == purchasingID).ToList();
            return listEntity;
        }
        public List<Sparepart> RetrieveSparepart()
        {
            return _sparepartRepository.GetAll().ToList();
        }

        public void Approve(Purchasing purchasing)
        {
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
            purchasing.Status = (int)DbConstant.PurchasingStatus.Active;
            purchasing.TotalHasPaid = purchasing.TotalHasPaid;
            _purchasingRepository.Update(purchasing);
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
