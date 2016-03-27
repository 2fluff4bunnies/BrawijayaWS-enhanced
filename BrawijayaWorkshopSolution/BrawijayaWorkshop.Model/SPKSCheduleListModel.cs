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
    public class SPKScheduleListModel : AppBaseModel
    {
        private ISPKScheduleRepository _SPKScheduleRepository;
        private IMechanicRepository _mechanicRepository;
        private ISPKRepository _SPKRepository;
        private IUnitOfWork _unitOfWork;

        public SPKScheduleListModel(ISPKScheduleRepository SPKScheduleRepository, 
            IMechanicRepository mechanicRepository,
            ISPKRepository SPKRepository,
            IUnitOfWork unitOfWork)
            : base()
        {
            _SPKScheduleRepository = SPKScheduleRepository;
            _mechanicRepository = mechanicRepository;
            _SPKRepository = SPKRepository;
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
            List<SPK> result = _SPKRepository.GetMany(s => s.Status == (int)DbConstant.DefaultDataStatus.Active && !s.isContractWork).ToList();
            List<SPKViewModel> mappedResult = new List<SPKViewModel>();

            return Map(result, mappedResult);
        }


        public List<SPKScheduleViewModel> SearchSPKSchedule(int mechanicId, int SPKId, DateTime createDate)
        {
            List<SPKSchedule> result = _SPKScheduleRepository.GetMany(sched => sched.CreateDate == createDate).ToList();

            if (mechanicId > 0)
            {
                result = result.Where(sched => sched.MechanicId == mechanicId).ToList();
            }

            if (SPKId > 0)
            {
                result = result.Where(sched => sched.SPKId == SPKId).ToList();
            }

            List<SPKScheduleViewModel> mappedResult = new List<SPKScheduleViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteSPKSchedule(SPKScheduleViewModel SPKSchedule)
        {
            SPKSchedule entity = _SPKScheduleRepository.GetById(SPKSchedule.Id);
            entity.Status = (int)DbConstant.DefaultDataStatus.Deleted;
            _SPKScheduleRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
