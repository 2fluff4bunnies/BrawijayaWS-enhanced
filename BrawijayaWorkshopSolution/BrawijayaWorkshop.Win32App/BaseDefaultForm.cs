using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Runtime;
using System;

namespace BrawijayaWorkshop.Win32App
{
    public partial class BaseDefaultForm : DevExpress.XtraEditors.XtraForm, IView
    {
        #region Credential Members
        protected virtual string ModulName
        {
            get
            {
                return "-";
            }
        }

        protected bool AllowInsert
        {
            get
            {
                if (LoginInformation.IsLoggedIn)
                {
                    ModulInfo currentModul = LoginInformation.GetModul(this.ModulName);
                    if (currentModul != null)
                    {
                        return currentModul.Validate(DbConstant.AccessTypeEnum.Create);
                    }
                }

                return false;
            }
        }

        protected bool AllowEdit
        {
            get
            {
                if (LoginInformation.IsLoggedIn)
                {
                    ModulInfo currentModul = LoginInformation.GetModul(this.ModulName);
                    if (currentModul != null)
                    {
                        return currentModul.Validate(DbConstant.AccessTypeEnum.Update);
                    }
                }

                return false;
            }
        }

        protected bool AllowDelete
        {
            get
            {
                if (LoginInformation.IsLoggedIn)
                {
                    ModulInfo currentModul = LoginInformation.GetModul(this.ModulName);
                    if (currentModul != null)
                    {
                        return currentModul.Validate(DbConstant.AccessTypeEnum.Delete);
                    }
                }

                return false;
            }
        }
        #endregion

        public BaseDefaultForm()
        {
            InitializeComponent();
        }

        public virtual void RefreshDataView()
        {
            throw new NotImplementedException();
        }

        public virtual void ShowMessage(EnumViewMessage messageType, string message)
        {
            switch (messageType)
            {
                case EnumViewMessage.Info:
                    this.ShowInformation(message);
                    break;
                case EnumViewMessage.Error:
                    this.ShowError(message);
                    break;
                case EnumViewMessage.Warning:
                    this.ShowWarning(message);
                    break;
                default:
                    break;
            }
        }
    }
}