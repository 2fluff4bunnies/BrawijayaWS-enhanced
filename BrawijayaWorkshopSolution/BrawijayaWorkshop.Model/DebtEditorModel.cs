using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class DebtEditorModel : AppBaseModel
    {
        private ITransactionRepository _transactionRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public DebtEditorModel(ITransactionRepository transactionRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _transactionRepository = transactionRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrievePaymentMethod()
        {
            Reference parent = _referenceRepository
                .GetMany(c => c.Code == DbConstant.REF_PURCHASE_PAYMENTMETHOD).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public void InsertDebt(TransactionViewModel transaction)
        {
            Transaction entity = new Transaction();
            Map(transaction, entity);
            _transactionRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateDebt(TransactionViewModel transaction)
        {
            Transaction entity = _transactionRepository.GetById<int>(transaction.Id);
            Map(transaction, entity);
            _transactionRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
