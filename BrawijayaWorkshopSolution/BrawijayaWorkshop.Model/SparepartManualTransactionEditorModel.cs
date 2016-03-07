using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SparepartManualTransactionEditorModel : AppBaseModel
    {
        private ISparepartManualTransactionRepository _sparepartManualTransactionRepository;
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartManualTransactionEditorModel(ISparepartManualTransactionRepository sparepartManualTransactionRepository, ISparepartRepository sparepartRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartManualTransactionRepository = sparepartManualTransactionRepository;
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrieveTransactionType()
        {
            Reference parent = null;
            parent = _referenceRepository
               .GetMany(c => c.Code == DbConstant.REF_SPAREPART_TRANSACTION_MANUAL_TYPE).FirstOrDefault();
            List<Reference> list = new List<Reference>();
            if (parent != null)
            {
                list = _referenceRepository.GetMany(c => c.ParentId == parent.Id).ToList();
            }
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(list, mappedResult);
        }

        public void InsertSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction)
        {
            SparepartManualTransaction entity = new SparepartManualTransaction();
            Map(sparepartManualTransaction, entity);
            _sparepartManualTransactionRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSparepartManualTransaction(SparepartManualTransactionViewModel sparepartManualTransaction)
        {
            SparepartManualTransaction entity = _sparepartManualTransactionRepository.GetById<int>(sparepartManualTransaction.Id);
            Map(sparepartManualTransaction, entity);
            _sparepartManualTransactionRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
