using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UsedGoodTransactionListModel : AppBaseModel
    {
        private IUsedGoodTransactionRepository _usedGoodTransactionRepository;
        private IUnitOfWork _unitOfWork;

        public UsedGoodTransactionListModel(IUsedGoodTransactionRepository usedGoodTransactionRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _usedGoodTransactionRepository = usedGoodTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public List<UsedGoodTransactionViewModel> SearchUsedGoodTransaction(string sparepartName)
        {
            List<UsedGoodTransaction> result = _usedGoodTransactionRepository.GetMany(c => c.UsedGood.Sparepart.Name.Contains(sparepartName)).OrderBy(c => c.UsedGood.Sparepart.Name).ToList();
            List<UsedGoodTransactionViewModel> mappedResult = new List<UsedGoodTransactionViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteUsedGoodTransaction(UsedGoodTransactionViewModel usedGoodTransaction)
        {
            UsedGoodTransaction selectedUsedGoodTransaction = _usedGoodTransactionRepository.GetById<int>(usedGoodTransaction.Id);
            _usedGoodTransactionRepository.Delete(selectedUsedGoodTransaction);
            _unitOfWork.SaveChanges();
        }
    }
}
