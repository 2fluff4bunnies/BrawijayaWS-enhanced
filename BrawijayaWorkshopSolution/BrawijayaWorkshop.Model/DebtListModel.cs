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

        public List<PurchasingViewModel> SearchTransaction(DateTime? dateFrom, DateTime? dateTo, int paymentStatus)
        {
            List<Purchasing> result = null;

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                dateFrom = dateFrom.Value.Date;
                dateTo = dateTo.Value.Date.AddDays(1).AddSeconds(-1);
                result = _purchasingRepository.GetMany(c => c.Date >= dateFrom && c.Date <= dateTo && c.Status == (int)DbConstant.PurchasingStatus.Active || c.Status == (int)DbConstant.PurchasingStatus.HasReturn).OrderBy(c => c.Date).ToList();
            }
            else
            {
                result = _purchasingRepository.GetMany(c => c.Status == (int)DbConstant.PurchasingStatus.Active || c.Status == (int)DbConstant.PurchasingStatus.HasReturn).OrderBy(c => c.Date).ToList();
            }

            if (paymentStatus > -1)
            {
                result = result.Where(p => p.PaymentStatus == paymentStatus).ToList();
            }

            List<PurchasingViewModel> mappedResult = new List<PurchasingViewModel>();
            return Map(result, mappedResult);
        }
    }
}
