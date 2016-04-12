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
    public class SPKListModel : AppBaseModel
    {
        private ISPKRepository _SPKRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SPKListModel(ISPKRepository SPKRepository, IReferenceRepository referenceRepository,
            IVehicleRepository vehicleRepository, IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
            :base()
        {
            _SPKRepository = SPKRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKViewModel> SearchSPK(string LicenseNumber, string code, int category, DbConstant.ApprovalStatus approvalStatus, 
            DbConstant.SPKPrintStatus printStatus, DbConstant.SPKCompletionStatus completedStatus)
        {
            List<SPK> result = _SPKRepository.GetMany(spk => spk.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            if ((int)completedStatus != 9)
            {
                result = result.Where(spk => spk.StatusCompletedId == (int)completedStatus).ToList();
            }

            if ((int)printStatus != 9)
            {
                result = result.Where(spk => spk.StatusPrintId == (int)printStatus).ToList();
            }

            if ((int)approvalStatus != 9)
            {
                result = result.Where(spk => spk.StatusApprovalId == (int)approvalStatus).ToList();
            }

            if (!string.IsNullOrEmpty(LicenseNumber))
            {
                VehicleDetail vehicleDetail = _vehicleDetailRepository.GetMany(v => string.Compare(v.LicenseNumber, LicenseNumber, true) == 1
                                                                                    && v.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();
                if (vehicleDetail != null)
                {
                    result = result.Where(spk => spk.VehicleId == vehicleDetail.VehicleId).ToList();
                }
                else
                {
                    return new List<SPKViewModel>();
                }
            }

            if (!string.IsNullOrEmpty(code))
            {
                result = result.Where(spk => string.Compare(spk.Code, code, true) == 0).ToList();
            }

            if (category > 0)
            {
                result = result.Where(spk => spk.CategoryReferenceId == category).ToList();
            }

            List<SPKViewModel> mappedResult = new List<SPKViewModel>();

            return Map(result, mappedResult);
        }

        public List<ReferenceViewModel> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();

            result.Add(new Reference
            {
                Id = 0,
                Name = "Semua Kategori",
                Description = "Semua Kategori"
            });

            List<ReferenceViewModel> mappedResult = new List<ReferenceViewModel>();

            return Map(result, mappedResult);

        }

        public List<VehicleViewModel> GetSPKVehicleList()
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<VehicleViewModel> mappedResult = new List<VehicleViewModel>();
            return Map(result, mappedResult);
        }

        public void PrintSPK(SPKViewModel spk, int userId)
        {
            DateTime serverTime = DateTime.Now;
            SPK entity = _SPKRepository.GetById(spk.Id);
            entity.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;
           
            _SPKRepository.Update(entity);

            _unitOfWork.SaveChanges();
        }
    }
}
