using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SPKListModel : BaseModel
    {
        private ISPKRepository _SPKRepository;
        private IVehicleRepository _vehicleRepository;
        private IVehicleDetailRepository _vehicleDetailRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;

        public SPKListModel(ISPKRepository SPKRepository, IReferenceRepository referenceRepository,
            IVehicleRepository vehicleRepository, IVehicleDetailRepository vehicleDetailRepository, IUnitOfWork unitOfWork)
        {
            _SPKRepository = SPKRepository;
            _vehicleRepository = vehicleRepository;
            _vehicleDetailRepository = vehicleDetailRepository;
            _referenceRepository = referenceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPK> SearchSPK(string LicenseNumber, string code, int category, DbConstant.ApprovalStatus approvalStatus, 
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
                    return new List<SPK>();
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

            return result;
        }

        public List<Reference> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            List<Reference> result = _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();

            result.Add(new Reference
            {
                Id = 0,
                Name = "Semua Kategori",
                Description = "Semua Kategori"
            });

            return result;

        }

        public List<Vehicle> GetSPKVehicleList()
        {
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            return result;
        }

        public void PrintSPK(SPK spk, int userId)
        {
            DateTime serverTime = DateTime.Now;

            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            _SPKRepository.Update(spk);

            _unitOfWork.SaveChanges();
        }
    }
}
