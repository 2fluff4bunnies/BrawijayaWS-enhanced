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

        public List<SPKDetailSparepartDetail> GetSPKSparepartDetailList(int spkId)
        {
            List<SPKDetailSparepartDetail> result = _SPKDetailSparepartDetailRepository.GetMany(sdsd => sdsd.SPKDetailSparepart.SPK.Id == spkId).ToList();

            return result;
        }

        public bool ApproveSPK(SPK spk, List<SPKDetailSparepart> spkSparepartList, List<SPKDetailSparepartDetail> spkSparepartDetailList, int userId, bool isApproved)
        {
            bool result = false;

            DateTime serverTime = DateTime.Now;

            if (isApproved)
            {
                spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Approved;
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;

                spk.ModifyDate = serverTime;
                spk.ModifyUserId = userId;

                _SPKRepository.Update(spk);

                foreach (var item in spkSparepartList)
                {
                    Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                    sparepart.StockQty = sparepart.StockQty - item.TotalQuantity;
                    sparepart.ModifyDate = serverTime;
                    sparepart.ModifyUserId = userId;

                    _sparepartRepository.Update(sparepart);

                }

                foreach (var item in spkSparepartDetailList)
                {
                    SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(item.SparepartDetail.Id);
                    sparepartDetail.ModifyDate = serverTime;
                    sparepartDetail.ModifyUserId = userId;
                    if (item.SPKDetailSparepart.SPK.CategoryReference.Id == 22)
                    {
                        sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutPurchase;
                    }
                    else
                    {
                        sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.OutService;
                    }

                    _sparepartDetailRepository.Update(sparepartDetail);
                }

                _unitOfWork.SaveChanges();

                result = true;
            }
            else
            {
                spk.StatusApprovalId = (int)DbConstant.ApprovalStatus.Rejected;

                spk.ModifyDate = serverTime;
                spk.ModifyUserId = userId;

                _SPKRepository.Update(spk);

                _unitOfWork.SaveChanges();

                result = true;
            }

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


        public void AbortSPK(SPK spk, List<SPKDetailSparepart> spkSparepartList, List<SPKDetailSparepartDetail> spkSparepartDetailList, int userId)
        {
            DateTime serverTime = DateTime.Now;

            spk.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            _SPKRepository.Update(spk);

            foreach (var item in spkSparepartList)
            {
                Sparepart sparepart = _sparepartRepository.GetById(item.Sparepart.Id);
                sparepart.StockQty = sparepart.StockQty + item.TotalQuantity;
                sparepart.ModifyDate = serverTime;
                sparepart.ModifyUserId = userId;

                _sparepartRepository.Update(sparepart);
            }

            foreach (var item in spkSparepartDetailList)
            {
                SparepartDetail sparepartDetail = _sparepartDetailRepository.GetById(item.SparepartDetail.Id);
                sparepartDetail.ModifyDate = serverTime;
                sparepartDetail.ModifyUserId = userId;
                sparepartDetail.Status = (int)DbConstant.SparepartDetailDataStatus.Active;

                _sparepartDetailRepository.Update(sparepartDetail);
            }

            _unitOfWork.SaveChanges();

        }

        public void RequestPrintSPK(SPK spk, int userId)
        { 
            DateTime serverTime = DateTime.Now;

            spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Pending;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            _SPKRepository.Update(spk);

            _unitOfWork.SaveChanges();
        }

        public void ApprovePrintSPK(SPK spk, int userId, bool isApproved)
        {
            DateTime serverTime = DateTime.Now;

            if (isApproved)
            {
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Ready;
            }
            else
            {
                spk.StatusPrintId = (int)DbConstant.SPKPrintStatus.Printed;
            }

            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            _SPKRepository.Update(spk);

            _unitOfWork.SaveChanges();
        }

        public void SetAsCompletedSPK(SPK spk, int userId)
        {
            DateTime serverTime = DateTime.Now;

            spk.StatusCompletedId = (int)DbConstant.SPKCompletionStatus.Completed;
            spk.ModifyDate = serverTime;
            spk.ModifyUserId = userId;

            _SPKRepository.Update(spk);

            _unitOfWork.SaveChanges();
        }
    }
}
