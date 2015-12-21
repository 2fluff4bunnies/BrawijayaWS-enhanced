using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class MechanicListModel : BaseModel
    {
        private ISettingRepository _settingRepository;
        private IMechanicRepository _MechanicRepository;
        private IUnitOfWork _unitOfWork;

        public MechanicListModel(ISettingRepository settingRepository,
            IMechanicRepository MechanicRepository, IUnitOfWork unitOfWork)
        {
            _settingRepository = settingRepository;
            _MechanicRepository = MechanicRepository;
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

        public List<Mechanic> SearchMechanic(string MechanicName)
        {
            return _MechanicRepository.GetMany(c => c.Name.Contains(MechanicName)).OrderBy(c => c.Name).ToList();
        }

        public void DeleteMechanic(Mechanic Mechanic)
        {
            _MechanicRepository.Delete(Mechanic);
            _unitOfWork.SaveChanges();
        }
    }
}
