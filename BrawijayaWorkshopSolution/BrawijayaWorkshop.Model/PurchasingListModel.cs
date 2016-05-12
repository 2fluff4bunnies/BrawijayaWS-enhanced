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

        public List<PurchasingViewModel> SearchPurchasing(DateTime? dateFrom, DateTime? dateTo, DbConstant.PurchasingStatus purchasingStatus)
        {
            List<Purchasing> result = null;
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchasingRepository.GetMany(c => c.Date >= dateFrom && c.Date <= dateTo && c.Status != (int) DbConstant.PurchasingStatus.Deleted).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchasingRepository.GetMany(c => c.Status != (int)DbConstant.PurchasingStatus.Deleted).OrderBy(c => c.Date).ToList();
            }
            if ((int)purchasingStatus != 9)
            {
                result = result.Where(p => p.Status == (int)purchasingStatus).ToList();
            } 
            List<PurchasingViewModel> mappedResult = new List<PurchasingViewModel>();
            return Map(result, mappedResult);
        }

    }
}
