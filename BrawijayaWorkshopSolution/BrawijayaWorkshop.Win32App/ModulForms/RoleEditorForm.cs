using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class RoleEditorForm : BaseEditorForm, IRoleEditorView
    {
        private RoleEditorPresenter _presenter;

        public RoleEditorForm(RoleEditorModel model)
        {
            InitializeComponent();

            _presenter = new RoleEditorPresenter(this, model);

            valRoleName.SetIconAlignment(txtRoleName, ErrorIconAlignment.MiddleRight);

            this.Load += RoleEditorForm_Load;
        }

        private void RoleEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public RoleViewModel SelectedRole { get; set; }

        public string RoleName
        {
            get
            {
                return txtRoleName.Text;
            }
            set
            {
                txtRoleName.Text = value;
            }
        }

        protected override void ExecuteSave()
        {
            if (valRoleName.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Role's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save role: '" + SelectedRole.Name + "'", ex);
                    this.ShowError("Proses simpan data role: '" + SelectedRole.Name + "' gagal!");
                }
            }
        }
    }
}