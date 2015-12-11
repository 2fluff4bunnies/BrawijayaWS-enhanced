using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Infrastructure.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Model
{
    public class ConfigEditorModel : BaseModel
    {
        private ISettingRepository _settingRepository;
        private IUnitOfWork _unitOfWork;

        public ConfigEditorModel(ISettingRepository settingRepository, IUnitOfWork unitOfWork)
        {
            _settingRepository = settingRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Setting> GetAllSettings()
        {
            return _settingRepository.GetAll().ToList();
        }

        public void SaveSettings(List<Setting> listSettings)
        {
            foreach (var setting in listSettings)
            {
                _settingRepository.Update(setting);
            }
            _unitOfWork.SaveChanges();
        }
    }
}
