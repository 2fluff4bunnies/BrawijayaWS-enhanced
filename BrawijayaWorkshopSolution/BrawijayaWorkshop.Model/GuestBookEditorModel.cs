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
        private ISpecialSparepartDetailRepository _wheelDetailRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private IUnitOfWork _unitOfWork;

        public GuestBookEditorModel(IGuestBookRepository guestBookRepository, IVehicleRepository vehicleRepository,
           IVehicleDetailRepository vehicleDetailRepository, IVehicleWheelRepository vehicleWheelRepository,
            ISpecialSparepartDetailRepository wheelDetailRepository, ISparepartDetailRepository sparepartDetailRepository, IUnitOfWork unitOfWork)
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
            _guestBookRepository.AttachNavigation<Vehicle>(entity.Vehicle);
            _guestBookRepository.Add(entity);

            _unitOfWork.SaveChanges();
        }

        public void UpdateGuestBook(GuestBookViewModel guestBook, int userId)
        {
            DateTime serverTime = DateTime.Now;

            guestBook.ModifyDate = serverTime;
            guestBook.ModifyUserId = userId;

            GuestBook entity = _guestBookRepository.GetById(guestBook.Id);
            Map(guestBook, entity);

            _guestBookRepository.AttachNavigation<Vehicle>(entity.Vehicle);
            _guestBookRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }

        public List<VehicleWheelViewModel> getCurrentVehicleWheel(int vehicleId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            return Map(result, mappedResult);
        }

        public DateTime GetLicenseNumberExpirationDate(string licenseNumber)
        {
            return _vehicleDetailRepository.GetMany(vd => string.Compare(vd.LicenseNumber, licenseNumber, true) == 0).FirstOrDefault().ExpirationDate;
        }
    }
}
