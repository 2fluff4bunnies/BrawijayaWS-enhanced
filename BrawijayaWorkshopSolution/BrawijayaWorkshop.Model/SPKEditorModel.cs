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

        public SPKEditorModel(IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
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

        public void InsertSPK(SPK SPK, List<SPKDetailMechanic> mechanicList, List<SPKDetailSparepart> sparepartList,
            List<SPKDetailSparepartDetail> sparepartDetailList, int userId)
        {
            DateTime serverTime = DateTime.Now;
#warning Generate code?
            // SPK.Code = GENERATE CODE HERE?
            SPK.CreateDate = serverTime;
            SPK.CreateUserId = userId;
            SPK.CategoryStatusApprovalId = (int)DbConstant.ApprovalStatus.Pending;
            SPK.Status = (int)DbConstant.DefaultDataStatus.Active;
            _SPKRepository.Add(SPK);

            foreach (var item in mechanicList)
            {
                item.CreateDate = serverTime;
                item.CreateUserId = userId;
                item.SPKId = SPK.Id;
                item.Status = (int)DbConstant.DefaultDataStatus.Active;
                _SPKDetailMechanicRepository.Add(item);
            }

            foreach (var item in sparepartList)
            {
                item.CreateDate = serverTime;
                item.CreateUserId = userId;
                item.SPKId = SPK.Id;
                item.Status = (int)DbConstant.DefaultDataStatus.Active;

                _SPKDetailSparepartRepository.Add(item);

                var detailList = sparepartDetailList.Where(spd => spd.SparepartDetail.SparepartId == item.SparepartId);

                foreach (var itemDetail in detailList)
                {
                    itemDetail.SPKDetailSparepartId = item.Id;
                    itemDetail.CreateDate = serverTime;
                    itemDetail.CreateUserId = userId;
                    itemDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _SPKDetailSparepartDetailRepository.Add(itemDetail);
                }
            }

            _unitOfWork.SaveChanges();

#warning TODO Insert Approval here
        }

        public List<Sparepart> SearchSparepart(string name)
        {
            List<Sparepart> result = null;
            result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active && sp.Name.Contains(name)).ToList();

            return result;
        }

        public List<SparepartDetail> getRandomDetails(int sparepartId, int qty)
        {
            List<SparepartDetail> result = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderBy(spd => spd.Id).Take(qty).ToList();

            return result;
        }

        public List<Mechanic> SearchMechanic(string name)
        {
#warning TODO find mechanic that present

            List<Mechanic> result = _mechanicRepository.GetMany(
                m => m.Name.Contains(name)).ToList();

            return result;
        }

    }
}
