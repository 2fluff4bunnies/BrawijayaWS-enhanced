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
    public class SpecialSparepartEditorModel : AppBaseModel
    {
        private ISpecialSparepartRepository _specialSparepartRepository;
        private IReferenceRepository _referenceRepository;
        private ISparepartRepository _sparepartRepository;
        private IUnitOfWork _unitOfWork;

        public SpecialSparepartEditorModel(ISpecialSparepartRepository WheelRepository, IReferenceRepository referenceRepository,
           ISparepartRepository sparepartRepository,IUnitOfWork unitOfWork)
            : base()
        {
            _specialSparepartRepository = WheelRepository;
            _referenceRepository = referenceRepository;
            _sparepartRepository = sparepartRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SparepartViewModel> GetSparepartLookupList()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();

            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> GetSpecialSparepartCategoryList()
        {
            Reference specialSparepartCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPECIAL_SPAREPART_TYPE, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == specialSparepartCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertWheel(SpecialSparepartViewModel specialSparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            specialSparepart.CreateDate = serverTime;
            specialSparepart.CreateUserId = userId;
            specialSparepart.ModifyDate = serverTime;
            specialSparepart.ModifyUserId = userId;
            specialSparepart.Status = (int)DbConstant.DefaultDataStatus.Active;
            SpecialSparepart entity = new SpecialSparepart();
            Map(specialSparepart, entity);
            _specialSparepartRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateWheel(SpecialSparepartViewModel specialSparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            specialSparepart.ModifyDate = serverTime;
            specialSparepart.ModifyUserId = userId;
            SpecialSparepart entity = _specialSparepartRepository.GetById(specialSparepart.Id);
            Map(specialSparepart, entity);
            _specialSparepartRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
