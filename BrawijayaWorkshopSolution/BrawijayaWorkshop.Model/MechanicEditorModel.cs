using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class MechanicEditorModel : BaseModel
    {
        private ISettingRepository _settingRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public MechanicEditorModel(IMechanicRepository mechanicRepository,
            ISettingRepository settingRepository, IUnitOfWork unitOfWork)
        {
            _mechanicRepository = mechanicRepository;
            _settingRepository = settingRepository;
            _unitOfWork = unitOfWork;
        }

        public int GetLastCode()
        {
            return _mechanicRepository.GetAll().Max(m => m.Id) + 1;
        }

        public string GetFingerprintIpAddress()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_IPADDRESS).FirstOrDefault().Value;
        }

        public string GetFingerprintPort()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_PORT).FirstOrDefault().Value;
        }

        public void InsertMechanic(Mechanic mechanic)
        {
            _mechanicRepository.Add(mechanic);
            _unitOfWork.SaveChanges();
        }

        public void UpdateMechanic(Mechanic mechanic)
        {
            _mechanicRepository.Update(mechanic);
            _unitOfWork.SaveChanges();
        }
    }
}
