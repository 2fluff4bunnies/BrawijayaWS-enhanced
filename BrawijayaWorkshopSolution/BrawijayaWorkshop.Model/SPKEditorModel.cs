using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrawijayaWorkshop.Model
{
    public class SPKEditorModel : BaseModel
    {
        private ISPKRepository _SPKRepository;
        private IReferenceRepository _referenceRepository;
        private IUnitOfWork _unitOfWork;
        private IVehicleRepository _vehicleRepository;
        private ISPKDetailMechanicRepository _SPKDetailMechanicRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;

        public SPKEditorModel(ISPKRepository SPKRepository, IVehicleRepository vehicleRepository,
            IReferenceRepository referenceRepository, ISPKDetailMechanicRepository SPKDetailMechanicRepository,
            ISPKDetailSparepartRepository SPKDetailSparepartRepository, ISPKDetailSparepartDetailRepository SPKDetailSparePartDetailRepository,
            IUnitOfWork unitOfWork)
        {
            _SPKRepository = SPKRepository;
            _vehicleRepository = vehicleRepository;
            _referenceRepository = referenceRepository;
            _SPKDetailMechanicRepository = SPKDetailMechanicRepository;
            _SPKDetailSparepartRepository = SPKDetailSparepartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparePartDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Reference> GetSPKCategoryList()
        {
            Reference spkCategory = _referenceRepository.GetMany(r => string.Compare(r.Code, DbConstant.REF_SPKCATEGORY, true) == 0).FirstOrDefault();
            return _referenceRepository.GetMany(r => r.ParentId == spkCategory.Id).ToList();
        }

        public List<Vehicle> GetSPKVehicleList()
        {
            return _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
        }


        public SPK EndorseSPk(int SPKId)
        {
            SPK spk = _SPKRepository.GetById(SPKId);

            spk.Status = (int)DbConstant.ApprovalStatus.Endorsed;

            _SPKRepository.Add(spk);

            return new SPK
            {
                DueDate = spk.DueDate,
                VehicleId = spk.VehicleId,
                CategoryReferenceId = spk.CategoryReferenceId,
            };
        }

        public void InsertSPK(SPK SPK, int userId)
        {
            DateTime serverTime = DateTime.Now;
#warning Generate code?
            // SPK.Code = GENERATE CODE HERE?
            SPK.CreateDate = serverTime;
            SPK.CreateUserId = userId;
            SPK.CategoryStatusApprovalId = (int)DbConstant.ApprovalStatus.Pending;
            SPK.Status = (int)DbConstant.DefaultDataStatus.Active;
            _SPKRepository.Add(SPK);

            //foreach (var item in SPKDetailMechanics)
            //{
            //    item.CreateDate = serverTime;
            //    item.CreateUserId = userId;
            //    item.Status = (int)DbConstant.DefaultDataStatus.Active;
            //    _SPKDetailMechanicRepository.Add(item);
            //}

            //foreach (var item in SPKDetailSpareparts)
            //{
            //    item.CreateDate = serverTime;
            //    item.CreateUserId = userId;
            //    item.Status = (int)DbConstant.DefaultDataStatus.Active;

            //    _SPKDetailSparepartRepository.Add(item);
            //}

           

            _unitOfWork.SaveChanges();

#warning TODO Insert Approval here
        }

   


    }
}
