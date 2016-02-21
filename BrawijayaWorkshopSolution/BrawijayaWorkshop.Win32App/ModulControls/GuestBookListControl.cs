using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BrawijayaWorkshop.Constant;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class GuestBookListControl : BaseAppUserControl
    {

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_VEHICLE;
            }
        }

        public GuestBookListControl()
        {
            InitializeComponent();
        }
    }
}
