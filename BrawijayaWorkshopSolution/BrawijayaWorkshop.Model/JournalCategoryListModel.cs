using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class JournalCategoryListModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public JournalCategoryListModel(IReferenceRepository referenceRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> RetrieveAllJournalCategory()
        {
            Reference parent = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == parent.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> RetrieveCategoriesByParentId(int parentId)
        {
            Reference parent = _referenceRepository.GetMany(r => r.Code == DbConstant.REF_CAT_JOURNAL).FirstOrDefault();
            List<int> parentCategoryIdList = _referenceRepository.GetMany(r => r.ParentId == parent.Id).Select(r => r.Id).ToList();
            List<Reference> result = null;
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            if(parentId > 0)
            {
                result = _referenceRepository.GetMany(r => r.ParentId == parentId).ToList();
            }
            else
            {
                result = _referenceRepository.GetMany(r => r.ParentId.HasValue && parentCategoryIdList.Contains(r.ParentId.Value)).ToList();
            }

            return Map(result, mappedResult);
        }

        public void DeleteJournalCategory(int categoryId)
        {
            Reference entity = _referenceRepository.GetById(categoryId);
            _referenceRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
