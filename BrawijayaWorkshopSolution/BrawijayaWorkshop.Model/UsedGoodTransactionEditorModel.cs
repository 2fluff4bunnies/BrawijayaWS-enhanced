using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class UsedGoodTransactionEditorModel : AppBaseModel
    {
        private IUsedGoodTransactionRepository _usedGoodTransactionRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public UsedGoodTransactionEditorModel(IUsedGoodTransactionRepository usedGoodTransactionRepository, IUsedGoodRepository usedGoodRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _usedGoodTransactionRepository = usedGoodTransactionRepository;
            _usedGoodRepository = usedGoodRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }
        
        public List<ReferenceViewModel> RetrieveTransactionType(bool isManual)
        {
            Reference parent = null;
            if (isManual)
            {
                parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_USEDGOOD_TRANSACTION_MANUAL_TYPE).FirstOrDefault();
            }
            else
            {
                parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_USEDGOOD_TRANSACTION_TYPE).FirstOrDefault();
            }
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public void InsertUsedGoodTransaction(UsedGoodTransactionViewModel usedGoodTransaction)
        {
            UsedGoodTransaction entity = new UsedGoodTransaction();
            Map(usedGoodTransaction, entity);
            _usedGoodTransactionRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateUsedGoodTransaction(UsedGoodTransactionViewModel usedGoodTransaction)
        {
            UsedGoodTransaction entity = _usedGoodTransactionRepository.GetById<int>(usedGoodTransaction.Id);
            Map(usedGoodTransaction, entity);
            _usedGoodTransactionRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
