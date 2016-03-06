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
    public class GuestBookEditorModel : AppBaseModel
    {
        private IGuestBookRepository _guestBookRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IWheelDetailRepository _wheelDetailRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public GuestBookEditorModel(IGuestBookRepository guestBookRepository, IVehicleRepository vehicleRepository,
           IVehicleDetailRepository vehicleDetailRepository, IVehicleWheelRepository vehicleWheelRepository,
            IWheelDetailRepository wheelDetailRepository, ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _guestBookRepository = guestBookRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _wheelDetailRepository = wheelDetailRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }


        public List<VehicleViewModel> GetVehiclesList()
        {
            List<Vehicle> result = _vehicleRepository.GetAll().ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public void InsertGuestBook(GuestBookViewModel guestBook, int userId)
        {
            DateTime serverTime = DateTime.Now;

            guestBook.CreateDate = serverTime;
            guestBook.CreateUserId = userId;
            guestBook.ModifyDate = serverTime;
            guestBook.ModifyUserId = userId;
            guestBook.Status = (int)DbConstant.DefaultDataStatus.Active;

            GuestBook entity = new GuestBook();
            Map(guestBook, entity);

            _guestBookRepository.Add(entity);
        }


        public void UpdateGuestBook(GuestBookViewModel guestBook, int userId)
        {
            DateTime serverTime = DateTime.Now;

            guestBook.ModifyDate = serverTime;
            guestBook.ModifyUserId = userId;

            GuestBook entity = new GuestBook();
            Map(guestBook, entity);

            _guestBookRepository.Update(entity);
        }
    }
}
