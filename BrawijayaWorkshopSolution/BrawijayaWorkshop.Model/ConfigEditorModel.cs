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
        private ISettingRepository _settingRepository;
        private IUnitOfWork _unitOfWork;

        public ConfigEditorModel(ISettingRepository settingRepository, IUnitOfWork unitOfWork)
            : base()
        {
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
                Setting dbObject = new Setting();
                Map(setting, dbObject);
                _settingRepository.Update(dbObject);
            }
            _unitOfWork.SaveChanges();
        }
    }
}
