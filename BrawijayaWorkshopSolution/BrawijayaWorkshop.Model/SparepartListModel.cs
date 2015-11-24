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
    public class SparepartListModel : BaseModel
    {
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SparepartListModel(ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
        {
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Reference> GetSparepartCategoryList()
        {
            Reference sparePartCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPAREPARTCATEGORY, true) == 0).FirstOrDefault();
            return _referenceRepository.GetMany(r => r.ParentId == sparePartCategory.Id).ToList();
        }

        public List<Sparepart> SearchSparepart(int categoryReferenceId, string name)
        {
            List<Sparepart> result = null;

            if (categoryReferenceId > 0)
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.SparepartDataStatus.Active &&
                    sp.CategoryReferenceId == categoryReferenceId && sp.Name.Contains(name)).ToList();
            }
            else
            {
                result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.SparepartDataStatus.Active && sp.Name.Contains(name)).ToList();
            }

            return result;
        }

        public void DeleteSparepart(Sparepart sparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            List<SparepartDetail> details = _sparepartDetailRepository.GetMany(spd => spd.SparepartId == sparepart.Id).ToList();
            foreach (var iDetails in details)
            {
                iDetails.Status = (int)DbConstant.SparepartDataStatus.Deleted;
                iDetails.ModifyDate = serverTime;
                iDetails.ModifyUserId = userId;
                _sparepartDetailRepository.Update(iDetails);
            }

            sparepart.Status = (int)DbConstant.SparepartDataStatus.Deleted;
            sparepart.ModifyDate = serverTime;
            sparepart.ModifyUserId = userId;
            _sparepartRepository.Update(sparepart);

            _unitOfWork.SaveChanges();
        }
    }
}
