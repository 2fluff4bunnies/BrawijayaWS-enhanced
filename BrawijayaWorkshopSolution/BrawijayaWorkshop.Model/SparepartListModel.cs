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
    public class SparepartListModel : AppBaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartListModel(ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ReferenceViewModel> GetSparepartCategoryList()
        {
            Reference sparePartCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == sparePartCategory.Id).ToList();
            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();
            return Map(result, mappedResult);
        }

        public List<SparepartViewModel> SearchSparepart(int categoryReferenceId, string name)
        {
            List<Sparepart> result = null;

            if (categoryReferenceId > 0)
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active &&
                    sp.CategoryReferenceId == categoryReferenceId && sp.Name.Contains(name)).ToList();
            }
            else
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active && sp.Name.Contains(name)).ToList();
            }

            List<SparepartViewModel> mappedResult = new List<SparepartViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteSparepart(SparepartViewModel sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            List<SparepartDetail> details = _sparepartDetailRepository.GetMany(spd => spd.SparepartId == sparepart.Id).ToList();
            foreach (var iDetails in details)
            {
                iDetails.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                iDetails.ModifyDate = serverTime;
                iDetails.ModifyUserId = userId;
                _sparepartDetailRepository.Update(iDetails);
            }

            sparepart.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            sparepart.ModifyDate = serverTime;
            sparepart.ModifyUserId = userId;
            Sparepart entity = _sparepartRepository.GetById(sparepart.Id);
            Map(sparepart, entity);
            _sparepartRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }
    }
}
