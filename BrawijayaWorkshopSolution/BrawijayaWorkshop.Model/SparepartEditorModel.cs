using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SparepartEditorModel : BaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartEditorModel(ISparepartRepository sparepartRepository, IReferenceRepository referenceRepository)
        {
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = new AppUnitOfWork(_sparepartRepository.DatabaseFactory);
        }

        public List<Reference> GetSparepartCategoryList()
        {
            Reference sparepartCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTCATEGORY, true) == 0).FirstOrDefault();
            return _referenceRepository.GetMany(r => r.ParentId == sparepartCategory.Id).ToList();
        }

        public List<Reference> GetSparepartUnitList()
        {
            Reference sparepartUnit = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTUNIT, true) == 0).FirstOrDefault();
            return _referenceRepository.GetMany(r => r.ParentId == sparepartUnit.Id).ToList();
        }

        public void InsertSparepart(Sparepart sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepart.CreateDate = serverTime;
            sparepart.CreateUserId = userId;
            _sparepartRepository.Add(sparepart);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSparepart(Sparepart sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepart.ModifyDate = serverTime;
            sparepart.ModifyUserId = userId;
            _sparepartRepository.Update(sparepart);
            _unitOfWork.SaveChanges();
        }
    }
}
