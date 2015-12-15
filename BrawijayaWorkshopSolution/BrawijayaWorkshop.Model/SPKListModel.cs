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

        public List<Reference> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            return _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
        }

        public List<SPK> SearchSPK(string LicenseNumber, string code, DateTime? createDate, DateTime? dueDate, int category, DbConstant.ApprovalStatus status)
        {
            VehicleDetail vehicleDetail = _vehicleDetailRepository.GetMany(v => string.Compare(v.LicenseNumber, LicenseNumber, true) == 1 
                                                                                && v.Status == (int)DbConstant.DefaultDataStatus.Active).FirstOrDefault();

            //List<SPK> result = _SPKRepository.GetMany(spk => string.IsNullOrEmpty(code) ? true : string.Compare(spk.Code, code, true) == 0
            //                                                 && vehicleDetail == null ? true : spk.VehicleId == vehicleDetail.VehicleId
            //                                                 && createDate == null ? true : spk.CreateDate == createDate
            //                                                 && dueDate == null ? true : spk.DueDate == dueDate
            //                                                 && spk.CategoryReferenceId <= 0 ? true : spk.CategoryReferenceId == category
            //                                                 && spk.Status == (int)status
            //                                          ).ToList();
            List<SPK> result = _SPKRepository.GetAll().ToList();

            return result;
        }
    }
}
