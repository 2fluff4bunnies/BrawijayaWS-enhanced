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
    public class SparepartEditorModel : AppBaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartEditorModel(ISparepartRepository sparepartRepository, IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork):base()
        {
            _sparepartRepository = sparepartRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> GetSparepartCategoryList()
        {
            Reference sparepartCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == sparepartCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> GetSparepartUnitList()
        {
            Reference sparepartUnit = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTUNIT, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == sparepartUnit.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertSparepart(SparepartViewModel sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepart.CreateDate = serverTime;
            sparepart.CreateUserId = userId;
            Sparepart entity = new Sparepart();
            Map(sparepart, entity);
            _sparepartRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSparepart(SparepartViewModel sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            sparepart.ModifyDate = serverTime;
            sparepart.ModifyUserId = userId;
            Sparepart entity = _sparepartRepository.GetById(sparepart.Id);
            Map(sparepart, entity);
            _sparepartRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
