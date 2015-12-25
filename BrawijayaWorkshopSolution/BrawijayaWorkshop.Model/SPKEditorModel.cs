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
            //List<Vehicle> result = _vehicleRepository.GetMany(v => v.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            return _vehicleRepository.GetVehicleForLookUp();
        }

        public List<SPKDetailSparepart> GetSPKSparepartList(int spkId)
        {
            List<SPKDetailSparepart> result = _SPKDetailSparepartRepository.GetMany(sds => sds.SPKId == spkId).ToList();

            return result;
        }

        public List<SPKDetailMechanic> GetSPKMechanicList(int spkId)
        {
            List<SPKDetailMechanic> result = _SPKDetailMechanicRepository.GetMany(sds => sds.SPKId == spkId).ToList();

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

        public SPK InsertSPK(SPK spk, SPK parentSPK, List<SPKDetailMechanic> spkMechanicList, List<SPKDetailSparepart> spkSparepartList,
            List<SPKDetailSparepartDetail> spkSparepartDetailList, int userId, bool isNeedApproval)
        {
            DateTime serverTime = DateTime.Now;

            if (parentSPK != null)
            {
                parentSPK.StatusApprovalId = (int)DbConstant.ApprovalStatus.Endorsed;
                parentSPK.ModifyDate = serverTime;
                parentSPK.ModifyUserId = userId;

                _SPKRepository.Update(parentSPK);
            }

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

            spk.Status = (int)DbConstant.DefaultDataStatus.Active;
            spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Pending;
            spk.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.InProgress;
            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Pending;

            SPK insertedSPK = _SPKRepository.Add(spk);

            foreach (var spkMechanic in spkMechanicList)
            {
                spkMechanic.CreateDate = serverTime;
                spkMechanic.CreateUserId = userId;
                spkMechanic.ModifyDate = serverTime;
                spkMechanic.ModifyUserId = userId;
                spkMechanic.SPK = insertedSPK;
                spkMechanic.Status = (int)DbConstant.DefaultDataStatus.Active;
                _SPKDetailMechanicRepository.Add(spkMechanic);

               
            }

            foreach (var spkSparepart in spkSparepartList)
            {
                spkSparepart.CreateDate = serverTime;
                spkSparepart.CreateUserId = userId;
                spkSparepart.ModifyDate = serverTime;
                spkSparepart.ModifyUserId = userId;
                spkSparepart.SPK = insertedSPK;
                spkSparepart.Status = (int)DbConstant.DefaultDataStatus.Active;

                if (!isNeedApproval)
                {
                    Sparepart sparepart = _sparepartRepository.GetById(spkSparepart.Sparepart.Id);
                    sparepart.StockQty = sparepart.StockQty - spkSparepart.TotalQuantity;
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userId;

                    _sparepartRepository.Update(sparepart);
                }

                SPKDetailSparepart insertedSPKDetailSparepart = _SPKDetailSparepartRepository.Add(spkSparepart);

                var detailList = spkSparepartDetailList.Where(spd => spd.SparepartDetail.SparepartId == spkSparepart.SparepartId);

                foreach (var spkSparepartDetail in detailList)
                {
                    spkSparepartDetail.SPKDetailSparepart = insertedSPKDetailSparepart;
                    spkSparepartDetail.CreateDate = serverTime;
                    spkSparepartDetail.CreateUserId = userId;
                    spkSparepartDetail.ModifyDate = serverTime;
                    spkSparepartDetail.ModifyUserId = userId;
                    spkSparepartDetail.Status = (int)DbConstant.DefaultDataStatus.Active;

                    _SPKDetailSparepartDetailRepository.Add(spkSparepartDetail);

                    if (!isNeedApproval)
                    {
                        SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(spkSparepartDetail.SparepartDetail.Id);
                        sparepartDetail.ModifyDate = serverTime;
                        sparepartDetail.ModifyUserId = userId;
                        if (spkSparepartDetail.SPKDetailSparepart.SPK.CategoryReference.Id == 22)
                        {
                            sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;
                        }
                        else
                        {
                            sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutService;
                        }

                        _sparepartDetailRepository.Update(sparepartDetail);
                    }
                }
            }

            if (!isNeedApproval)
            {
                spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;

#warning TODO print SPK here
            }


            _unitOfWork.SaveChanges();

            return spk;
        }

        public List<Sparepart> LoadSparepart()
        {
            List<Sparepart> result = _sparepartRepository.GetMany(sp => sp.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();

            return result;
        }

        public List<SPKDetailSparepartDetail> getRandomDetails(int sparepartId, int qty)
        {
            List<SparepartDetail> sparepartDetails = _sparepartDetailRepository.GetMany(
                spd => spd.SparepartId == sparepartId && spd.Status == (int)DbConstant.SparepartDetailDataStatus.Active).OrderBy(spd => spd.Id).Take(qty).ToList();

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
            spk.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.InProgress;
            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
            spk.ModifyUserId = userId;
            spk.ModifyDate = serverTime;

            _SPKRepository.Update(spk);

            _unitOfWork.SaveChanges();
        }

        public string GetRepairThreshold()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_P).FirstOrDefault().Value;
        }

        public string GetServiceThreshold()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_SPK_THRESHOLD_S).FirstOrDefault().Value;
        }

        public int getPendingSparpartQty(int sparepartId)
        {
            int result = 0;

            List<SPKDetailSparepart> pendingSPKDetail = _SPKDetailSparepartRepository.GetMany(spkds =>
                                                        spkds.SPK.StatusApprovalId == (int)DbConstant.ApprovalStatus.Pending
                                                        && spkds.Sparepart.Id == sparepartId
                                                        ).ToList();

            foreach (var item in pendingSPKDetail)
            {
                result = result + item.TotalQuantity;
            }

            return result;
        }



    }
}
