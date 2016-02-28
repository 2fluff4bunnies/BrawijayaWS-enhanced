using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class ManualTransactionListModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IUnitOfWork _unitOfWork;

        public ManualTransactionListModel(ITransactionRepository transactionRepository, IUnitOfWork unitOfWork)
            :base()
        {
            _transactionRepository = transactionRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
