﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
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
            View.SPKServiceLimit = GetSetting(DbConstant.SETTING_SPK_THRESHOLD_S).Value;
            View.SPKRepairLimit = GetSetting(DbConstant.SETTING_SPK_THRESHOLD_P).Value;
            View.SPKInventoryLimit = GetSetting(DbConstant.SETTING_SPK_THRESHOLD_I).Value;
            View.SPKDirectSparepartLimit = GetSetting(DbConstant.SETTING_SPK_THRESHOLD_OL).Value;

            View.InvoiceFeeSparepart = GetSetting(DbConstant.SETTING_INVOICE_FEE_SPAREPART).Value;
            View.InvoiceFeeService = GetSetting(DbConstant.SETTING_INVOICE_FEE_SERVICE).Value;
        }

        public void SaveAllConfig()
        {
            Model.SaveSettings(View.ListSettings);
        }

        public SettingViewModel GetSetting(string key)
        {
            return View.ListSettings.Where(s => s.Key == key).FirstOrDefault();
        }

        public void SetSetting(string key, string newValue)
        {
            try
            {
                int index = View.ListSettings.IndexOf(View.ListSettings.Where(s => s.Key == key).FirstOrDefault());
                View.ListSettings[index].Value = newValue;
            }
            catch { }
        }

        public bool ValidatePassword()
        {
            return Model.ValidateOldPassword(LoginInformation.UserId, View.OldPassword.Encrypt());
        }

        public void SavePasswordChanges()
        {
            Model.UpdatePassword(LoginInformation.UserId, View.NewPassword.Encrypt());
        }

        public void ClearChangePasswordForm()
        {
            View.OldPassword = string.Empty;
            View.NewPassword = string.Empty;
            View.ReTypeNewPassword = string.Empty;
        }
    }
}
