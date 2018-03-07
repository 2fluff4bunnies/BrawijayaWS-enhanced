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

            foreach (VehicleWheel vw in result)
            {
                mappedResult.Add(new VehicleWheelViewModel
                {
                    DisplayName = "(" + vw.WheelDetail.SerialNumber + ") " + vw.WheelDetail.Sparepart.Name,
                    Id = vw.Id,
                    WheelDetail = Map(vw.WheelDetail, new SpecialSparepartDetailViewModel()),
                    WheelDetailId = vw.WheelDetailId,
                    Vehicle = Map(vw.Vehicle, new VehicleViewModel()),
                    VehicleId = vw.VehicleId,
                });
            }

            return mappedResult;
        }


        public void UpdateVehicleWheel(int vehicleId, List<VehicleWheelViewModel> vehicleWheels, int userId)
        {
            DateTime serverTime = DateTime.Now;

            foreach (var vw in vehicleWheels)
            {
                VehicleWheel vwEntity = _vehicleWheelRepository.GetById(vw.Id);
                vwEntity.WheelDetailId = vw.WheelDetailId;
                vwEntity.ModifyDate = serverTime;
                vwEntity.ModifyUserId = userId;
                vwEntity.VehicleId = vehicleId;

                _vehicleWheelRepository.AttachNavigation(vwEntity.Vehicle);
                _vehicleWheelRepository.AttachNavigation(vwEntity.WheelDetail);
                _vehicleWheelRepository.AttachNavigation(vwEntity.CreateUser);
                _vehicleWheelRepository.AttachNavigation(vwEntity.ModifyUser);
                _vehicleWheelRepository.Update(vwEntity);
                _unitOfWork.SaveChanges();
            }
        }
    }
}
