using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class BrandEditorForm : BaseEditorForm, IBrandEditorView
    {
        private BrandEditorPresenter _presenter;

        public BrandEditorForm(BrandEditorModel model)
        {
            InitializeComponent();
            _presenter = new BrandEditorPresenter(this, model);

            // set validation alignment
            valName.SetIconAlignment(txtName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valDescription.SetIconAlignment(txtDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.Load += BrandEditorForm_Load;
        }

        private void BrandEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public BrandViewModel SelectedBrand { get; set; }

        #region Field Editor
        public string BrandName
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

        public string Description
        {
            get
            {
                return txtDescription.Text;
            }
            set
            {
                txtDescription.Text = value;
            }
        }
        #endregion

        protected override void ExecuteSave()
        {
            if (valName.Validate() && valDescription.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Brand's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save brand: '" + SelectedBrand.Name + "'", ex);
                    this.ShowError("Proses simpan data brand: '" + SelectedBrand.Name + "' gagal!");
                }
            }
        }
    }
}