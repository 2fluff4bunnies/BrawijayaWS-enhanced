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
        private IVehicleWheelRepository _vehicleWheelRepository;
        private IUsedGoodRepository _usedGoodRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleListModel(IVehicleRepository vehicleRepository, 
            IVehicleWheelRepository vehicleWheelRepository, IUsedGoodRepository usedGoodRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _usedGoodRepository = usedGoodRepository;
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


            foreach (var item in _vehicleWheelRepository.GetMany(vw => vw.VehicleId == vehicle.Id && vw.Status ==(int) DbConstant.DefaultDataStatus.Active))
            {
                UsedGood usedWHeel = _usedGoodRepository.GetMany(ug => ug.SparepartId == item.WheelDetail.SparepartDetail.SparepartId).FirstOrDefault();
                usedWHeel.Stock++;
            }

            _unitOfWork.SaveChanges();
        }
    }
}
