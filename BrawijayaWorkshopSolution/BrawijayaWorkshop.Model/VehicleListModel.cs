using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleListModel : AppBaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleListModel(IVehicleRepository vehicleRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _unitOfWork = unitOfWork;
        }

        public List<VehicleViewModel> SearchVehicle(string licenseNumber)
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.ActiveLicenseNumber.Contains(licenseNumber) &&
                v.Status == (int)DbConstant.DefaultDataStatus.Active).OrderBy(c => c.Brand).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteVehicle(VehicleViewModel vehicle)
        {
            Vehicle entity = _vehicleRepository.GetById(vehicle.Id);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _vehicleRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
