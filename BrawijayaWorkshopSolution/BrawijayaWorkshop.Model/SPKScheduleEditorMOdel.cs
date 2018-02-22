using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class SPKScheduleEditorModel : AppBaseModel
    {
        private ISPKScheduleRepository _SPKScheduleRepository;
        private IMechanicRepository _mechanicRepository;
        private ISPKRepository _SPKRepository;
        private ISettingRepository _settingRepository;
        private IUnitOfWork _unitOfWork;

        public SPKScheduleEditorModel(ISPKScheduleRepository SPKScheduleRepository, 
            IMechanicRepository mechanicRepository,
            ISPKRepository SPKRepository,
            ISettingRepository settingRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _SPKScheduleRepository = SPKScheduleRepository;
            _mechanicRepository = mechanicRepository;
            _SPKRepository = SPKRepository;
            _settingRepository = settingRepository;
            _unitOfWork = unitOfWork;
        }

        public List<MechanicViewModel> LoadMechanic()
        {
            List<Mechanic> result = _mechanicRepository.GetMany(m => m.Status == (int)DbConstant.DefaultDataStatus.Active).ToList();
            List<MechanicViewModel> mappedResult = new List<MechanicViewModel>();

            return Map(result, mappedResult);
        }

        public List<SPKViewModel> LoadSPK()
        {
            List<SPK> result = _SPKRepository.GetMany(s => s.Status == (int)DbConstant.DefaultDataStatus.Active 
                                                            && s.StatusCompletedId == (int) DbConstant.SPKCompletionStatus.InProgress
                                                            && s.StatusApprovalId == (int)DbConstant.ApprovalStatus.Approved
                                                            &&!s.isContractWork
                                                            //&& DbFunctions.TruncateTime(s.DueDate) <= DbFunctions.TruncateTime(DateTime.Now)
                                                            ).ToList();
            List<SPKViewModel> mappedResult = new List<SPKViewModel>();

            return Map(result, mappedResult);
        }


        public string GetFingerprintIpAddress()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_IPADDRESS).FirstOrDefault().Value;
        }

        public string GetFingerprintPort()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_PORT).FirstOrDefault().Value;
        }

        public void InsertSPKSchedule(SPKScheduleViewModel SPKSchedule, int userId)
        {
            DateTime serverTime = DateTime.Now;
            SPKSchedule.CreateUserId = userId;
            SPKSchedule.ModifyDate = serverTime;
            SPKSchedule.ModifyUserId = userId;
            SPKSchedule.Status = (int)DbConstant.DefaultDataStatus.Active;
            SPKSchedule entity = new SPKSchedule();

            Map(SPKSchedule, entity);
            _SPKScheduleRepository.AttachNavigation<SPK>(entity.SPK);
            _SPKScheduleRepository.AttachNavigation<Mechanic>(entity.Mechanic);
            _SPKScheduleRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSPKSchedule(SPKScheduleViewModel SPKSchedule, int userId)
        {
            DateTime serverTime = DateTime.Now;

            SPKSchedule entity = _SPKScheduleRepository.GetById(SPKSchedule.Id);
            entity.ModifyDate = serverTime;
            entity.ModifyUserId = userId;
            entity.Date = SPKSchedule.Date;
            entity.Description = SPKSchedule.Description;
            entity.SPKId = SPKSchedule.SPKId;
            entity.MechanicId = SPKSchedule.MechanicId;
          
            //Map(SPKSchedule, entity);
            //_SPKScheduleRepository.AttachNavigation<Mechanic>(entity.Mechanic);
            //_SPKScheduleRepository.AttachNavigation<SPK>(entity.SPK);
           
            _SPKScheduleRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }


        public SPKViewModel GetSPKById(int spkId)
        {
            SPK result = _SPKRepository.GetById(spkId);

            SPKViewModel mappedResult = new SPKViewModel();

            return Map(result, mappedResult);
        }
    }
}
