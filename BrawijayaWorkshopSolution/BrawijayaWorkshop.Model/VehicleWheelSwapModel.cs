using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Model
{
    public class VehicleWheelSwapModel : AppBaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleWheelSwapModel(
                IVehicleRepository vehicleRepository,
                IVehicleWheelRepository vehicleWheelRepository,
                IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _unitOfWork = unitOfWork;
        }


        public List<VehicleViewModel> GetVehicleList()
        {
            //List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<Vehicle> result = _vehicleRepository.GetVehicleForLookUp();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            //return Map(result, mappedResult);

            foreach (var vehicle in result)
            {
                mappedResult.Add(new VehicleViewModel
                {
                    Id = vehicle.Id,
                    TypeId = vehicle.TypeId,
                    BrandId = vehicle.BrandId,
                    ActiveLicenseNumber = vehicle.ActiveLicenseNumber,
                    YearOfPurchase = vehicle.YearOfPurchase,
                    CustomerId = vehicle.CustomerId,
                    VehicleGroupId = vehicle.VehicleGroupId,
                    Kilometers = vehicle.Kilometers,
                    Code = vehicle.Code,
                    CompanyName = vehicle.Customer.CompanyName,
                    VehicleGroupName = vehicle.VehicleGroup.Name,
                });
            }

            return mappedResult;
        }

        public List<VehicleWheelViewModel> GetVehicleWheels(int vehicleId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

           return Map(result, mappedResult);
        }


        public void UpdateVehicleWheel(VehicleViewModel vehicle, List<VehicleWheelViewModel> vehicleWheels, int userId)
        {
            DateTime serverTime = DateTime.Now;

            vehicle.ModifyDate = serverTime;
            vehicle.ModifyUserId = userId;
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            Map(vehicle, entity);

            _vehicleRepository.AttachNavigation(entity.Brand);
            _vehicleRepository.AttachNavigation(entity.Type);
            _vehicleRepository.AttachNavigation(entity.VehicleGroup);
            _vehicleRepository.AttachNavigation(entity.Customer);
            _vehicleRepository.AttachNavigation(entity.CreateUser);
            _vehicleRepository.AttachNavigation(entity.ModifyUser);
            _vehicleRepository.Update(entity);
            _unitOfWork.SaveChanges();

            foreach (var vw in vehicleWheels)
            {
                VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                vwEntity.WheelDetailId = vw.WheelDetailId;
                vwEntity.ModifyDate = serverTime;
                vwEntity.ModifyUserId = userId;
                vwEntity.Notes = vw.Notes;

                _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                _vehicleWheelRepository.Update(vwEntity);
                _unitOfWork.SaveChanges();
            }

            _unitOfWork.SaveChanges();
        }
    }
}
