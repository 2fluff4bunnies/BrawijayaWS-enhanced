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
    public partial class UsedGoodsEditorForm : BaseEditorForm, IUsedGoodEditorView
    {
        private UsedGoodEditorPresenter _presenter;

        public UsedGoodsEditorForm(UsedGoodEditorModel model)
        {
            InitializeComponent();
            _presenter = new UsedGoodEditorPresenter(this, model);

            // set validation alignment
            valSparepart.SetIconAlignment(cbSparepart, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += UsedGoodEditorForm_Load;
        }

        private void UsedGoodEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public UsedGoodViewModel SelectedUsedGood { get; set; }

        #region Field Editor
        public int SparepartId
        {
            get
            {
                SparepartViewModel selected = cbSparepart.GetSelectedDataRow() as SparepartViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbSparepart.EditValue = value;
            }
        }
        #endregion
        public List<SparepartViewModel> ListSparepart
        {
            get
            {
                return cbSparepart.Properties.DataSource as List<SparepartViewModel>;
            }
            set
            {
                cbSparepart.Properties.DataSource = value;
            }
        }

        protected override void ExecuteSave()
        {
            if (valSparepart.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save UsedGood's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save UsedGood: '" + SelectedUsedGood.Sparepart.Name + "'", ex);
                    this.ShowError("Proses simpan data barang bekas: '" + SelectedUsedGood.Sparepart.Name + "' gagal!");
                }
            }
        }

    }
}