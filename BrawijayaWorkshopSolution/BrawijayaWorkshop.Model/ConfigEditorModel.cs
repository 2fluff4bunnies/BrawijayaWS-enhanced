using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class ConfigEditorModel : AppBaseModel
    {
        private IUserRepository _userRepository;
        private ISettingRepository _settingRepository;
        private IUnitOfWork _unitOfWork;

        public ConfigEditorModel(IUserRepository userRepository, ISettingRepository settingRepository, IUnitOfWork unitOfWork)
            : base()
        {
            _userRepository = userRepository;
            _settingRepository = settingRepository;
            _unitOfWork = unitOfWork;
        }

        public List<SettingViewModel> GetAllSettings()
        {
            List<Setting> result = _settingRepository.GetAll().ToList();
            List<SettingViewModel> mappedResult = new List<SettingViewModel>();
            return Map(result, mappedResult);
        }

        public void SaveSettings(List<SettingViewModel> listSettings)
        {
            foreach (var setting in listSettings)
            {
                Setting dbObject = _settingRepository.GetMany(set => set.Key == setting.Key).FirstOrDefault();
                Map(setting, dbObject);
                _settingRepository.Update(dbObject);
            }
            _unitOfWork.SaveChanges();
        }

        public bool ValidateOldPassword(int userId, string oldPassword)
        {
            return _userRepository.GetMany(u => u.Id == userId &&
                u.Password == oldPassword).FirstOrDefault() != null;
        }

        public void UpdatePassword(int userId, string newPassword)
        {
            User entity = _userRepository.GetById(userId);
            entity.Password = newPassword;
            _userRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
