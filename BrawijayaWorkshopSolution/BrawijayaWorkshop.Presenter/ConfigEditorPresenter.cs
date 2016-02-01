using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class ConfigEditorPresenter : BasePresenter<IConfigEditorView, ConfigEditorModel>
    {
        public ConfigEditorPresenter(IConfigEditorView view, ConfigEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListSettings = Model.GetAllSettings();
            View.FingerprintIpAddress = GetSetting(DbConstant.SETTING_FINGERPRINT_IPADDRESS).Value;
            View.FingerprintPort = GetSetting(DbConstant.SETTING_FINGERPRINT_PORT).Value;
            View.MinStockQuantity = GetSetting(DbConstant.SETTING_MINTSTOCK).Value;
        }

        public void SaveAllConfig()
        {
            Model.SaveSettings(View.ListSettings);
        }

        public SettingViewModel GetSetting(string key)
        {
            return View.ListSettings.Where(s => s.Key == key).FirstOrDefault();
        }
    }
}
