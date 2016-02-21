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
    public partial class WheelListControl : DevExpress.XtraEditors.XtraUserControl
    {
       
        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_SPAREPART;
            }
        }

        public WheelListControl()
        {
            InitializeComponent();
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmsEditData_Click(object sender, EventArgs e)
        {

        }

        private void cmsDeleteData_Click(object sender, EventArgs e)
        {

        }

        private void btnNewSparepart_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
