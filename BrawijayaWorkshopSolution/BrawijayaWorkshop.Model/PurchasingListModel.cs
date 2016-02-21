using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class PurchasingListModel : AppBaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingListModel(IPurchasingRepository purchasingRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _purchasingRepository = purchasingRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchasingViewModel> SearchPurchasing(DateTime? dateFrom, DateTime? dateTo)
        {
            List<Purchasing> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                result = _purchasingRepository.GetMany(c => c.Date >= dateFrom && c.Date <= dateTo).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchasingRepository.GetAll().OrderBy(c => c.Date).ToList();
            }

            List<PurchasingViewModel> mappedResult = new List<PurchasingViewModel>();
            return Map(result, mappedResult);
        }

    }
}
