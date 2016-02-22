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
    public partial class WheelEditorForm : BaseEditorForm, IWheelEditorView
    {
        private WheelEditorPresenter _presenter;

        public WheelEditorForm(WheelEditorModel model)
        {
            InitializeComponent();
            _presenter = new WheelEditorPresenter(this, model);


            valCode.SetIconAlignment(txtCode, ErrorIconAlignment.MiddleRight);
            valName.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
        }


        #region Properties
        public WheelViewModel SelectedWheel { get; set; }

        public string Category
        {
            get
            {
                return lblCategoryValue.Text;
            }
            set
            {
                lblCategoryValue.Text = value;
            }
        }

        public string Unit
        {
            get
            {
                return lblUnitValue.Text;
            }
            set
            {
                lblUnitValue.Text = value;
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

        public string WheelName
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
            if (valCode.Validate() && valName.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Wheel's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occored while trying to save wheel: '" + SelectedWheel.Sparepart.Name + "'", ex);
                    this.ShowError("Proses simpan ban gagal!");
                }
            }
        }
       
    }
}