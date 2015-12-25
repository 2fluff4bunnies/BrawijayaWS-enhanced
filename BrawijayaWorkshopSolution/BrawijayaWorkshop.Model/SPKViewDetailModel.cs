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
    public class SPKViewDetailModel : BaseModel
    {
        private IReferenceRepository _referenceRepository;
        private IVehicleRepository _vehicleRepository;
        private ISPKRepository _SPKRepository;
        private ISPKDetailSparepartRepository _SPKDetailSparepartRepository;
        private ISPKDetailSparepartDetailRepository _SPKDetailSparepartDetailRepository;
        private ISparepartRepository _sparepartRepository;
        private ISparepartDetailRepository _sparepartDetailRepository;
        private ISPKDetailMechanicRepository _SPKDetailMechanicRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public SPKViewDetailModel(IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ISPKDetailMechanicRepository SPKDetailMechanicRepository,
            IMechanicRepository mechanicRepository, IUnitOfWork unitOfWork)
        {
            _referenceRepository = referenceRepository;
            _vehicleRepository = vehicleRepository;
            _SPKRepository = SPKRepository;
            _SPKDetailSparepartRepository = SPKDetailSparePartRepository;
            _SPKDetailSparepartDetailRepository = SPKDetailSparepartDetailRepository;
            _sparepartRepository = sparepartRepository;
            _sparepartDetailRepository = sparepartDetailRepository;
            _SPKDetailMechanicRepository = SPKDetailMechanicRepository;
            _mechanicRepository = mechanicRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SPKDetailSparepart> GetSPKSparepartList(int spkId)
        {
            List<SPKDetailSparepart> result = _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == spkId).ToList();

            return result;
        }

        public List<SPKDetailMechanic> GetSPKMechanicList(int spkId)
        {
            List<SPKDetailMechanic> result = _SPKDetailMechanicRepository.GetMany(sms => sms.SPKId == spkId).ToList();

            return result;
        }

        public List<SPKDetailSparepartDetail> GetSPKSparepartDetailList(int spkId, int sparePartId)
        {

            List<SPKDetailSparepartDetail> result = _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SparepartDetail.SparepartId == sparePartId && sdsd.SPKDetailSparepart.SPK.Id == spkId).ToList();

            return result;
        }

        public bool ApproveSPK(SPK spk, List<SPKDetailMechanic> spkMechanicList, List<SPKDetailSparepart> spkSparepartList,
            List<SPKDetailSparepartDetail> spkSparepartDetailList, int userId, DbConstant.ApprovalStatus status)
        {
            bool result = false;

            try
            {
                if (status.CompareTo(DbConstant.ApprovalStatus.Approved) == 1)
                {

                }
                else if (status.CompareTo(DbConstant.ApprovalStatus.Rejected) == 1)
                {

                }

                result = true;
            }
            catch (Exception ex)
            {

                result = false;
            }

            return result;
        }

        public void PrintSPK(SPK spk)
        {
#warning put print here
            //TODO print
        }

    }
}
