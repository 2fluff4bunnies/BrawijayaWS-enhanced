using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleDetailListModel : AppBaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleDetailListModel(IVehicleRepository vehicleRepository,
            IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _unitOfWork = unitOfWork;
        }


        public List<VehicleDetailViewModel> SearchVehicleDetail(int vehicleId)
        {
            List<VehicleDetail> result = _vehicleDetailRepository.GetMany(
                vd => vd.VehicleId == vehicleId).OrderByDescending(vd => vd.Id).ToList();
            List<VehicleDetailViewModel> mappedResult = new List<VehicleDetailViewModel>();

            return Map(result, mappedResult);
        }
    }
}
