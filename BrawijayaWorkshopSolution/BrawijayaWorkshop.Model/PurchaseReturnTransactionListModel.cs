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
    public class PurchaseReturnTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnTransactionListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IPurchaseReturnRepository purchaseReturnRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchaseReturnViewModel> SearchPurchaseReturnList(DateTime? dateFrom, DateTime? dateTo, int? purchasingID)
        {
            List<PurchaseReturn> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                result = _purchaseReturnRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchaseReturnRepository.GetAll().OrderBy(c => c.Date).ToList();
            }

            if(purchasingID.HasValue)
            {
                result = result.Where(x => x.PurchasingId == purchasingID).OrderBy(c => c.Date).ToList();
            }

            List<PurchaseReturnViewModel> mappedResult = new List<PurchaseReturnViewModel>();
            return Map(result, mappedResult);
        }
    }
}
