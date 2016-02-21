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

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class WheelDetailListForm : BaseDefaultForm
    {
        public WheelDetailListForm()
        {
            InitializeComponent();

            this.Load += WheelDetailEditorForm_Load;
        }

        void WheelDetailEditorForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lookupStatus_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}