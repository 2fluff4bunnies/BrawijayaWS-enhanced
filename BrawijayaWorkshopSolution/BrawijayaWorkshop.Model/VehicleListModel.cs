using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleListModel : BaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleListModel(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
            _unitOfWork = new AppUnitOfWork(_vehicleRepository.DatabaseFactory);
        }

        public List<Vehicle> SearchVehicle(string licenseId)
        {
            return _vehicleRepository.GetMany(v => v.Brand.Contains(licenseId)).OrderBy(c => c.Brand).ToList();
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            _vehicleRepository.Delete(vehicle);
            _unitOfWork.SaveChanges();
        }
    }
}
