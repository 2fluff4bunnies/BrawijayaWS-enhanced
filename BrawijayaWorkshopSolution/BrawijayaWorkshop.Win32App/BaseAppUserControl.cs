using BrawijayaWorkshop.Infrastructure.MVP;
using System;

namespace BrawijayaWorkshop.Win32App
{
    public partial class BaseAppUserControl : DevExpress.XtraEditors.XtraUserControl, IView
    {
        public BaseAppUserControl()
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
