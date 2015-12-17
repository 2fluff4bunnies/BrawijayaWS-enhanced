﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class VehicleDetailListModel : BaseModel
    {
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IUnitOfWork _unitOfWork;

        public VehicleDetailListModel(IVehicleRepository vehicleRepository, 
            IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
        {
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _unitOfWork = unitOfWork;
        }


        public List<VehicleDetail> SearchVehicleDetail(int vehicleId)
        {
            List<VehicleDetail> result = _vehicleDetailRepository.GetMany(
                vd => vd.VehicleId == vehicleId).OrderByDescending(vd=>vd.Id).ToList();

            return result;
        }
    }
}