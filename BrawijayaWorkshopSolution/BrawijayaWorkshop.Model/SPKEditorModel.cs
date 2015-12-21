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
        private ISettingRepository _settingRepository;
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

        public SPKEditorModel(ISettingRepository settingRepository, IReferenceRepository referenceRepository, IVehicleRepository vehicleRepository,
            ISPKRepository SPKRepository, ISPKDetailSparepartRepository SPKDetailSparePartRepository,
            ISPKDetailSparepartDetailRepository SPKDetailSparepartDetailRepository, ISparepartRepository sparepartRepository,
            ISparepartDetailRepository sparepartDetailRepository, ISPKDetailMechanicRepository SPKDetailMechanicRepository,
            IMechanicRepository mechanicRepository, IUnitOfWork unitOfWork)
        {
            _settingRepository = settingRepository;
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
            List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            return result;
        }

        public string GetFingerprintIpAddress()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_IPADDRESS).FirstOrDefault().Value;
        }

        public string GetFingerprintPort()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_PORT).FirstOrDefault().Value;
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

        public void InsertSPK(SPK spk, List<SPKDetailMechanic> mechanicList, List<SPKDetailSparepart> sparepartList,
            List<SPKDetailSparepartDetail> sparepartDetailList, int userId)
        {
            DateTime serverTime = DateTime.Now;

            string code = "SPK-";

            switch (spk.CategoryReferenceId)
            {
                case 20: code = code + "S";
                    break;
                case 21: code = code + "P";
                    break;
                case 22: code = code + "L";
                    break;
                case 23: code = code + "I";
                    break;
            }

            code = code + "-" + serverTime.Month.ToString() + serverTime.Day.ToString() + "-";

            //get total SPK created today
            List<SPK> todaySPK = _SPKRepository.GetMany(s => s.Code.ToString().Contains(code) && s.CreateDate.Year == serverTime.Year).ToList();

            code = code + (todaySPK.Count + 1);

            spk.Code = code;
            spk.CreateDate = serverTime;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;
            spk.CreateUserId = userId;
            spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Pending;
            spk.Status = (int)DbConstant.DefaultDataStatus.Active;

            SPK insertedSPK = _SPKRepository.Add(spk);

            foreach (var mechanic in mechanicList)
            {
                mechanic.CreateDate = serverTime;
                mechanic.CreateUserId = userId;
                mechanic.ModifyDate = serverTime;
                mechanic.ModifyUserId = userId;
                mechanic.SPKId = insertedSPK.Id;
                mechanic.Status = (int)DbConstant.DefaultDataStatus.Active;
                _SPKDetailMechanicRepository.Add(mechanic);
            }

            foreach (var sparepart in sparepartList)
            {
                sparepart.CreateDate = serverTime;
                sparepart.CreateUserId = userId;
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userId;
                sparepart.SPKId = insertedSPK.Id;
                sparepart.Status = (int)DbConstant.DefaultDataStatus.Active;

                SPKDetailSparepart insertedSPKDetailSparepart = _SPKDetailSparepartRepository.Add(sparepart);

                var detailList = sparepartDetailList.Where(spd => spd.SparepartDetail.SparepartId == sparepart.SparepartId);

                foreach (var sparepartDetail in detailList)
                {
                    sparepartDetail.SPKDetailSparepartId = insertedSPKDetailSparepart.Id;
                    sparepartDetail.CreateDate = serverTime;
                    sparepartDetail.CreateUserId = userId;
                    sparepartDetail.ModifyDate = serverTime;
                    sparepartDetail.ModifyUserId = userId;
                    sparepartDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _SPKDetailSparepartDetailRepository.Add(sparepartDetail);
                }
            }

            _unitOfWork.SaveChanges();

#warning TODO Insert Approval here
        }

        public List<Sparepart> LoadSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            return result;
        }

        public List<SPKDetailSparepartDetail> getRandomDetails(int sparepartId, int qty)
        {
            //List<SparepartDetail> sparepartDetails = _sparepartDetailRepository.GetMany(
            //    spd => spd.SparepartId == sparepartId && spd.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderBy(spd => spd.Id).Take(qty).ToList();

            List<SparepartDetail> sparepartDetails = _sparepartDetailRepository.GetMany(
               spd => spd.SparepartId == sparepartId && spd.Status == (int)DbConstant.SparepartDetailDataStatus.NotVerified).OrderBy(spd => spd.Id).Take(qty).ToList();

            List<SPKDetailSparepartDetail> result = new List<SPKDetailSparepartDetail>();

            foreach (var item in sparepartDetails)
            {
                result.Add(new SPKDetailSparepartDetail
                 {
                     SparepartDetailId = item.Id,
                     SparepartDetail = item
                 });
            }

            return result;
        }

        public List<Mechanic> LoadMechanic()
        {
#warning TODO find mechanic that present

            List<Mechanic> result = _mechanicRepository.GetAll().ToList();

            return result;
        }


        public void ApproveSPK(int spkId, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SPK spk = _SPKRepository.GetMany(s => s.Id == spkId).FirstOrDefault();

            spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
            spk.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.inProgress;
            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.ready;
            spk.ModifyUserId = userId;
            spk.ModifyDate = serverTime;

            _SPKRepository.Update(spk);

            _unitOfWork.SaveChanges();
        }

    }
}
