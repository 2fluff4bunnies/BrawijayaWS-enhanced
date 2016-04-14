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
    public class PurchaseReturnListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IPurchaseReturnRepository _purchaseReturnRepository;
        private IUnitOfWork _unitOfWork;

        public PurchaseReturnListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository,
            IPurchaseReturnRepository purchaseReturnRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _purchaseReturnRepository = purchaseReturnRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchasingViewModel> SearchPurchasingList(DateTime? dateFrom, DateTime? dateTo)
        {
            List<Purchasing> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchasingRepository.GetMany(c => c.Date >= dateFrom && c.CreateDate <= dateTo).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchasingRepository.GetAll().OrderBy(c => c.Date).ToList();
            }

            List<PurchasingViewModel> mappedResult = new List<PurchasingViewModel>();
            return Map(result, mappedResult);
        }

        public bool IsHasReturnActive(int purchasingID)
        {
            return _purchaseReturnRepository.GetMany(x => x.PurchasingId == purchasingID && x.Status == (int)DbConstant.DefaultDataStatus.Active).Count() > 0;
        }
    }
}
