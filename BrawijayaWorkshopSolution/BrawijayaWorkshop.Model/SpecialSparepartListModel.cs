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
    public class SpecialSparepartListModel : AppBaseModel
    {
        private ISpecialSparepartRepository _specialSparepartRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public SpecialSparepartListModel(ISpecialSparepartRepository specialSparepartRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _specialSparepartRepository = specialSparepartRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }


        public List<SpecialSparepartViewModel> SearchWheel(string name)
        {
            List<SpecialSparepart> result = null;

            result = _specialSparepartRepository.GetMany(wh => wh.Status == (int)DbConstant.DefaultDataStatus.Active && wh.Sparepart.Name.Contains(name)).ToList();
            foreach (var item in result)
            {
                _specialSparepartRepository.RefreshObject(item.Sparepart);
            }

            List<SpecialSparepartViewModel> mappedResult = new List<SpecialSparepartViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteWheel(SpecialSparepartViewModel SpecialSparepart, int userId)
        {
            DateTime serverTime = DateTime.Now;
            List<SpecialSparepartDetail> details = _specialSparepartDetailRepository.GetMany(spd => spd.SpecialSparepartId == SpecialSparepart.Id).ToList();
            foreach (var iDetails in details)
            {
                iDetails.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                iDetails.ModifyDate = serverTime;
                iDetails.ModifyUserId = userId;
                _specialSparepartDetailRepository.Update(iDetails);
            }

            SpecialSparepart.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            SpecialSparepart.ModifyDate = serverTime;
            SpecialSparepart.ModifyUserId = userId;
            SpecialSparepart entity = _specialSparepartRepository.GetById(SpecialSparepart.Id);
            Map(SpecialSparepart, entity);
            _specialSparepartRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }
    }
}
