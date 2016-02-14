using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class MechanicEditorModel : AppBaseModel
    {
        private ISettingRepository _settingRepository;
        private IMechanicRepository _mechanicRepository;
        private IUnitOfWork _unitOfWork;

        public MechanicEditorModel(IMechanicRepository mechanicRepository,
            ISettingRepository settingRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _mechanicRepository = mechanicRepository;
            _settingRepository = settingRepository;
            _unitOfWork = unitOfWork;
        }

        public int GetLastCode()
        {
            return _mechanicRepository.GetAll().Count() > 0 ? _mechanicRepository.GetAll().Max(m => m.Id) + 1 : 1;
        }

        public string GetFingerprintIpAddress()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_IPADDRESS).FirstOrDefault().Value;
        }

        public string GetFingerprintPort()
        {
            return _settingRepository.GetMany(s => s.Key == DbConstant.SETTING_FINGERPRINT_PORT).FirstOrDefault().Value;
        }

        public void InsertMechanic(MechanicViewModel mechanic)
        {
            Mechanic entity = new Mechanic();
            Map(mechanic, entity);
            _mechanicRepository.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateMechanic(MechanicViewModel mechanic)
        {
            Mechanic entity = _mechanicRepository.GetById(mechanic.Id);
            Map(mechanic, entity);
            _mechanicRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
