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
    public class WheelListModel : AppBaseModel
    {
        private IWheelRepository _wheelRepository;
        private IWheelDetailRepository _wheelDetailRepository;
        private IUnitOfWork _unitOfWork;

        public WheelListModel(IWheelRepository WheelRepository,
            IWheelDetailRepository WheelDetailRepository,
            IReferenceRepository referenceRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _wheelRepository = WheelRepository;
            _wheelDetailRepository = WheelDetailRepository;
            _unitOfWork = unitOfWork;
        }


        public List<WheelViewModel> SearchWheel(string name)
        {
            List<Wheel> result = null;

            result = _wheelRepository.GetMany(wh => wh.Status == (int)DbConstant.DefaultDataStatus.Active && wh.Sparepart.Name.Contains(name)).ToList();

            List<WheelViewModel> mappedResult = new List<WheelViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteWheel(WheelViewModel Wheel, int userId)
        {
            DateTime serverTime = DateTime.Now;
            List<WheelDetail> details = _wheelDetailRepository.GetMany(spd => spd.WheelId == Wheel.Id).ToList();
            foreach (var iDetails in details)
            {
                iDetails.Status = (int)DbConstant.DefaultDataStatus.Deleted;
                iDetails.ModifyDate = serverTime;
                iDetails.ModifyUserId = userId;
                _wheelDetailRepository.Update(iDetails);
            }

            Wheel.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            Wheel.ModifyDate = serverTime;
            Wheel.ModifyUserId = userId;
            Wheel entity = _wheelRepository.GetById(Wheel.Id);
            Map(Wheel, entity);
            _wheelRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }
    }
}
