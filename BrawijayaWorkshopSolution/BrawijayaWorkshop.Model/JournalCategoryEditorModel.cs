using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class JournalCategoryEditorModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private IJournalMasterRepository _journalMasterRepository;
        private IUnitOfWork _unitOfWork;

        public JournalCategoryEditorModel(IReferenceRepository referenceRepository,
            IJournalMasterRepository journalMasterRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _journalMasterRepository = journalMasterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<JournalMasterViewModel> RetrieveAllMasterJournal()
        {
            List<JournalMaster> result = _journalMasterRepository.GetAll().ToList();
            List<JournalMasterViewModel> mappedResult = new List<JournalMasterViewModel>();
            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> RetrieveAllJournalCategory()
        {
            Reference parent = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == parent.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertChildren(ReferenceViewModel children)
        {
            if (!Validate(children.ParentId, children.Value)) return;

            Reference entity = new Reference();
            Map(children, entity);
            _referenceRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateChildren(ReferenceViewModel children)
        {
            if (!Validate(children.Id, children.ParentId, children.Value)) return;

            Reference entity = _referenceRepository.GetById(children.Id);
            Map(children, entity);
            _referenceRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        public override bool Validate(params object[] parameters)
        {
            if(parameters.Length == 2)
            {
                int parentid = parameters[0].AsInteger();
                string valueCat = parameters[1].ToString();

                return _referenceRepository.GetMany(r => r.ParentId == parentid && r.Value == valueCat).Count() == 0;
            }
            else
            {
                int currentId = parameters[0].AsInteger();
                int parentId = parameters[1].AsInteger();
                string valueCat = parameters[2].ToString();

                return _referenceRepository.GetMany(r => r.Id != currentId && r.ParentId == parentId && r.Value == valueCat).Count() == 0;
            }
        }
    }
}
