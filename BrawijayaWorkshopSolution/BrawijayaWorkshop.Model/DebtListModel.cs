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
    public class DebtListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IPurchasingRepository _purchasingRepository;
        private IUnitOfWork _unitOfWork;

        public DebtListModel(ITransactionRepository transactionRepository,
            IPurchasingRepository purchasingRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _purchasingRepository = purchasingRepository;
            _unitOfWork = unitOfWork;
        }

        public List<PurchasingViewModel> SearchTransaction(DateTime? dateFrom, DateTime? dateTo)
        {
            List<Purchasing> result = null;

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
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
