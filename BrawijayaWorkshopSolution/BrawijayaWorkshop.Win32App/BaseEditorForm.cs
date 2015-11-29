using System;

namespace BrawijayaWorkshop.Win32App
{
    public partial class BaseEditorForm : BaseDefaultForm
    {
        public BaseEditorForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExecuteSave();
        }

        protected virtual void ExecuteSave()
        {
            throw new NotImplementedException();
        }
    }
}