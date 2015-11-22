using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleEditorModel : BaseModel
    {
        private ICustomerRepository _customerRepository;
        private IVehicleRepository _vehicleRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleEditorModel(ICustomerRepository customerRepository, IVehicleRepository vehicleRepository)
        {
            _customerRepository = customerRepository;
            _vehicleRepository = vehicleRepository;
            _unitOfWork = new AppUnitOfWork(_vehicleRepository.DatabaseFactory);
        }

        public List<Customer> RetrieveCustomer()
        {
            return _customerRepository.GetAll().ToList();
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            _vehicleRepository.Add(vehicle);
            _unitOfWork.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _vehicleRepository.Update(vehicle);
            _unitOfWork.SaveChanges();
        }
    }
}
