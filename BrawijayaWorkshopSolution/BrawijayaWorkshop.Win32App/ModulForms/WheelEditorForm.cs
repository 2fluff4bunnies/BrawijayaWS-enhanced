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

            valSparepart.SetIconAlignment(lookUpSparepart, ErrorIconAlignment.MiddleRight);
            this.Load += WheelEditorForm_Load;
        }

        void WheelEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
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
                return lblCodeValue.Text;
            }
            set
            {
                lblCodeValue.Text = value;
            }
        }

        public List<SparepartViewModel> SparepartList
        {
            get
            {
                return lookUpSparepart.Properties.DataSource as List<SparepartViewModel>;
            }
            set
            {
                lookUpSparepart.Properties.DataSource = value;
            }
        }

        public int SparepartId
        {
            get
            {
                return lookUpSparepart.EditValue.AsInteger();
            }
            set
            {
                lookUpSparepart.EditValue = value;
            }
        }

        #endregion


        protected override void ExecuteSave()
        {
            if (valSparepart.Validate())
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

        private void lookUpSparepart_EditValueChanged(object sender, EventArgs e)
        {
            SparepartViewModel sparepart = lookUpSparepart.GetSelectedDataRow() as SparepartViewModel;

            this.Code = sparepart.Code;
            this.Category = sparepart.CategoryReference.Name;
            this.Unit = sparepart.UnitReference.Name;
        }

    }
}