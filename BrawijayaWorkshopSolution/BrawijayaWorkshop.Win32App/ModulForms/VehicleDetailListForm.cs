using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleDetailListForm : BaseDefaultForm, IVehicleDetailListView
    {
        public VehicleDetailListForm()
        {
            InitializeComponent();
        }

        private void btnUpdateVehicleDetail_Click(object sender, EventArgs e)
        {

        }
    }
}