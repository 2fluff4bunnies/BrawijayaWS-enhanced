using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class BalanceHelperListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private ITransactionDetailRepository _transactionDetailRepository;

        public BalanceHelperListModel(ITransactionRepository transactionRepository,
            ITransactionDetailRepository transactionDetailRepository)
            : base()
        {
            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
        }


    }
}
