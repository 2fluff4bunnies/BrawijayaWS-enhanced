using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Model
{
    public class SPKHistoryDetailModel : AppBaseModel
    {
        private IReferenceRepository _referenceRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private IVehicleWheelRepository _vehicleWheelRepository;
        private ISPKScheduleRepository _SPKScheduleRepository;
        private IMechanicRepository _mechanicRepository;
        private IWheelExchangeHistoryRepository _wheelExchangeHistoryRepository;
        private ISpecialSparepartDetailRepository _specialSparepartDetailRepository;
        private ISettingRepository _settingRepository;
        private IUnitOfWork _unitOfWork;

        public SPKHistoryDetailModel(
            IReferenceRepository referenceRepository, 
            IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, 
            ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, 
            ISparepartRepository sparepartRepository,
            ISettingRepository settingRepository,
            IVehicleWheelRepository vehicleWheelRepository,
            ISPKScheduleRepository SPKScheduleReposistory,
            IMechanicRepository mechanicRepository,
            IWheelExchangeHistoryRepository wheelExchangeHistoryRepository,
            ISpecialSparepartDetailRepository specialSparepartDetailRepository,
            IUnitOfWork unitOfWork) :base()
        {
            _referenceRepository = referenceRepository;
            _vehicleRepository = vehicleRepository;
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _settingRepository = settingRepository;
            _vehicleWheelRepository = vehicleWheelRepository;
            _SPKScheduleRepository = SPKScheduleReposistory;
            _mechanicRepository = mechanicRepository;
            _wheelExchangeHistoryRepository = wheelExchangeHistoryRepository;
            _specialSparepartDetailRepository = specialSparepartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKDetailSparepartViewModel> GetSPKSparepartList(int spkId)
        {
            List<SPKDetailSparepart> result = _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == spkId).ToList();
            List<SPKDetailSparepartViewModel> mappedResult = new List<SPKDetailSparepartViewModel>();
            return Map(result, mappedResult);
        }

        public List<VehicleWheelViewModel> GetCurrentVehicleWheel(int vehicleId, int SPKId)
        {
            List<VehicleWheel> result = _vehicleWheelRepository.GetMany(
                  vw => vw.Vehicle.Id == vehicleId && vw.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<VehicleWheelViewModel> mappedResult = new List<VehicleWheelViewModel>();

            Map(result, mappedResult);

            foreach (var item in mappedResult)
            {
                //WheelExchangeHistory wheel = _wheelExchangeHistoryRepository.GetMany(w => w.SPKId == SPKId && w.OriginalWheelId == item.WheelDetailId).FirstOrDefault();
                //if (wheel != null)
                //{
                //    item.ReplaceWithWheelDetailId = wheel.ReplaceWheelId;
                //    item.ReplaceWithWheelDetailSerialNumber = wheel.ReplaceWheel.SerialNumber;

                //    if (wheel.ReplaceWheel.SparepartDetail.PurchasingDetailId > 0)
                //    {
                //        item.Price = wheel.ReplaceWheel.SparepartDetail.PurchasingDetail.Price;
                //    }
                //    else if (wheel.ReplaceWheel.SparepartDetail.SparepartManualTransactionId > 0)
                //    {
                //        item.Price = wheel.ReplaceWheel.SparepartDetail.SparepartManualTransaction.Price;
                //    }
                //}
            }

            return mappedResult;
        }

        public List<MechanicViewModel> GetInvolvedMechanic(int SPKId)
        {
            List<SPKSchedule> allMechanicInSPK = _SPKScheduleRepository.GetMany(
                  sc => sc.SPKId == SPKId && sc.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            List<Mechanic> result = new List<Mechanic>();

            foreach (int mechanicID in allMechanicInSPK.Select(m => m.MechanicId).Distinct())
            {
                result.Add(_mechanicRepository.GetById(mechanicID));
            }

            List<MechanicViewModel> mappedResult = new List<MechanicViewModel>();

            Map(result, mappedResult);

            return mappedResult;
        }
    }
}
