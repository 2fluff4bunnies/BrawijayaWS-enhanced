using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class MechanicListModel : AppBaseModel
    {
        private ISettingRepository _settingRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public MechanicListModel(ISettingRepository settingRepository,
            IMechanicRepository mechanicRepository, IUnitOfWork unitOfWork)
        {
            _settingRepository = settingRepository;
            _mechanicRepository = mechanicRepository;
            _unitOfWork = unitOfWork;
        }

        public string GetFingerprintIpAddress()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_IPADDRESS).FirstOrDefault().Value;
        }

        public string GetFingerprintPort()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_PORT).FirstOrDefault().Value;
        }

        public List<MechanicViewModel> SearchMechanic(string mechanicName)
        {
            List<Mechanic> result = _mechanicRepository.GetMany(c => c.Name.Contains(mechanicName)).OrderBy(c => c.Name).ToList();
            List<MechanicViewModel> mappedResult = new List<MechanicViewModel>();
            return Map(result, mappedResult);
        }

        public void DeleteMechanic(MechanicViewModel mechanic)
        {
            Mechanic entity = _mechanicRepository.GetById(mechanic.Id);
            _mechanicRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
