using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class SparepartEditorForm : BaseEditorForm, ISparepartEditorView
    {
        private SparepartEditorPresenter _presenter;
        public SparepartEditorForm(SparepartEditorModel model)
        {
            InitializeComponent();
            _presenter = new SparepartEditorPresenter(this, model);

            valCategory.SetIconAlignment(lookUpCategory, ErrorIconAlignment.MiddleRight);
            valUnit.SetIconAlignment(lookUpUnit, ErrorIconAlignment.MiddleRight);
            valCode.SetIconAlignment(txtCode, ErrorIconAlignment.MiddleRight);
            valName.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
        }

        public Database.Entities.Sparepart SelectedSparepart { get; set; }

        public List<Database.Entities.Reference> CategoryDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<Database.Entities.Reference>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public List<Database.Entities.Reference> UnitDropdownList
        {
            get
            {
                return lookUpUnit.Properties.DataSource as List<Database.Entities.Reference>;
            }
            set
            {
                lookUpUnit.Properties.DataSource = value;
            }
        }

        #region Field Editor
        public int CategoryId
        {
            get
            {
                return lookUpCategory.EditValue.AsInteger();
            }
            set
            {
                lookUpCategory.EditValue = value;
            }
        }

        public int UnitId
        {
            get
            {
                return lookUpUnit.EditValue.AsInteger();
            }
            set
            {
                lookUpUnit.EditValue = value;
            }
        }

        public string Code
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
            }
        }

        public string SparepartName
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }
        #endregion

        protected override void ExecuteSave()
        {
            if (valCategory.Validate() && valUnit.Validate() && valCode.Validate() && valName.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Sparepart's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occored while trying to save sparepart: '" + SelectedSparepart.Name + "'", ex);
                    this.ShowError("Proses simpan sparepart gagal!");
                }
            }
        }
    }
}