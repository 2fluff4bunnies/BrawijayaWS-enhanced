using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BrawijayaWorkshop.Win32App.PrintItems
{
    public partial class SPKPrintItem : DevExpress.XtraReports.UI.XtraReport
    {
        public SPKPrintItem()
        {
            InitializeComponent();
            lblSpkDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

    }
}
