using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class RoleAccessEditorForm : BaseEditorForm, IRoleAccessEditorView
    {
        private RoleAccessEditorPresenter _presenter;

        public RoleAccessEditorForm(RoleAccessEditorModel model)
        {
            InitializeComponent();
            _presenter = new RoleAccessEditorPresenter(this, model);

            valModul.SetIconAlignment(lookUpModul, ErrorIconAlignment.MiddleRight);
            valRole.SetIconAlignment(lookUpRole, ErrorIconAlignment.MiddleRight);

            this.Load += RoleAccessEditorForm_Load;
        }

        public List<RoleViewModel> RoleDropdownList
        {
            get
            {
                return lookUpRole.Properties.DataSource as List<RoleViewModel>;
            }
            set
            {
                lookUpRole.Properties.DataSource = value;
            }
        }

        public List<ApplicationModulViewModel> ApplicationModulDropdownList
        {
            get
            {
                return lookUpModul.Properties.DataSource as List<ApplicationModulViewModel>;
            }
            set
            {
                lookUpModul.Properties.DataSource = value;
            }
        }

        public int RoleId
        {
            get
            {
                return lookUpRole.EditValue.AsInteger();
            }
            set
            {
                lookUpRole.EditValue = value;
            }
        }

        public int ApplicationModulId
        {
            get
            {
                return lookUpModul.EditValue.AsInteger();
            }
            set
            {
                lookUpModul.EditValue = value;
            }
        }

        public bool AllowRead
        {
            get
            {
                return cbxRead.EditValue.AsBoolean();
            }
            set
            {
                cbxRead.EditValue = value;
            }
        }

        public bool AllowCreate
        {
            get
            {
                return cbxCreate.EditValue.AsBoolean();
            }
            set
            {
                cbxCreate.EditValue = value;
            }
        }

        public bool AllowUpdate
        {
            get
            {
                return cbxUpdate.EditValue.AsBoolean();
            }
            set
            {
                cbxUpdate.EditValue = value;
            }
        }

        public new bool AllowDelete
        {
            get
            {
                return cbxDelete.EditValue.AsBoolean();
            }
            set
            {
                cbxDelete.EditValue = value;
            }
        }

        public RoleAccessViewModel SelectedRoleAccess { get; set; }

        private void RoleAccessEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        protected override void ExecuteSave()
        {
            if(valModul.Validate() && valRole.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Role Access's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save role access", ex);
                    this.ShowError("Proses simpan data role access gagal!");
                }
            }
        }
    }
}