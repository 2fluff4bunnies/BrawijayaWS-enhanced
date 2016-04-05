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
    public class PurchaseReturnEditorModel : AppBaseModel
    {
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IPurchaseReturnDetailRepository _purchaseReturnDetailRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchasingDetailRepository _purchasingDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnEditorModel(
            IPurchaseReturnRepository purchaseReturnRepository,
            IPurchaseReturnDetailRepository purchaseReturnDetailRepository,
            IPurchasingRepository purchasingRepository,
            IPurchasingDetailRepository purchasingDetailRepository,
            ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _purchaseReturnRepository = purchaseReturnRepository;
            _purchaseReturnDetailRepository = purchaseReturnDetailRepository;
            _purchasingRepository = purchasingRepository;
            _purchasingDetailRepository = purchasingDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
            _journalMasterRepository = journalMasterRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchaseReturnDetailViewModel> RetrievePurchaseReturnDetail(int purchaseReturnID)
        {
            List<PurchaseReturnDetail> result = _purchaseReturnDetailRepository.GetMany(x => x.PurchaseReturnId == purchaseReturnID).ToList();
            List<PurchaseReturnDetailViewModel> mappedResult = new List<PurchaseReturnDetailViewModel>();
            Map(result, mappedResult);
            return mappedResult;
        }

        public List<ReturnViewModel> RetrieveReturnList(int purchaseReturnID)
        {
            List<ReturnViewModel> result = new List<ReturnViewModel>();
            PurchaseReturn purchaseReturn = _purchaseReturnRepository.GetById(purchaseReturnID);
            List<PurchasingDetail> listPurchasingDetail = _purchasingDetailRepository.GetMany(x => x.PurchasingId == purchaseReturn.PurchasingId).ToList();
            List<PurchaseReturnDetailViewModel> listDetail = this.RetrievePurchaseReturnDetail(purchaseReturnID);

            if(listDetail != null && listDetail.Count > 0)
            {
                foreach (var itemDetail in listPurchasingDetail)
                {
                    result.Add(new ReturnViewModel
                    {
                        SparepartId = itemDetail.SparepartId,
                        SparepartName = itemDetail.Sparepart.Name,
                        ReturQty = listDetail.Where(x=>x.SparepartDetaill.SparepartId == itemDetail.SparepartId).Count(),
                        ReturQtyLimit = itemDetail.Qty
                    });
                }
            }
            else
            {
                foreach (var itemDetail in listPurchasingDetail)
                {
                    result.Add(new ReturnViewModel
                    {
                        SparepartId = itemDetail.SparepartId,
                        SparepartName = itemDetail.Sparepart.Name,
                        ReturQty = itemDetail.Qty,
                        ReturQtyLimit = itemDetail.Qty
                    });
                }
            }
            return result;
        }

        

    }
}
