using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class PurchasingListModel : BaseModel
    {
        private IPurchasingRepository _purchasingRepository;
        private IUnitOfWork _unitOfWork;

        public PurchasingListModel(IPurchasingRepository purchasingRepository, IUnitOfWork unitOfWork)
        {
            _purchasingRepository = purchasingRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Purchasing> SearchPurchasing(DateTime? dateFrom, DateTime? dateTo)
        {
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                return _purchasingRepository.GetMany(c => c.Date >= dateFrom && c.Date <= dateTo).OrderBy(c => c.Date).ToList();
            }
            else
            {
                return _purchasingRepository.GetAll().OrderBy(c => c.Date).ToList();
            }
        }

    }
}
