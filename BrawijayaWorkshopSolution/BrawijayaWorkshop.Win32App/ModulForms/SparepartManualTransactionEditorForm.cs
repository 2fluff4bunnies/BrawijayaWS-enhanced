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
    public partial class SparepartManualTransactionEditorForm : BaseEditorForm, ISparepartManualTransactionEditorView
    {
        private SparepartManualTransactionEditorPresenter _presenter;

        public SparepartManualTransactionEditorForm(SparepartManualTransactionEditorModel model)
        {
            InitializeComponent();
            _presenter = new SparepartManualTransactionEditorPresenter(this, model);

            // set validation alignment
            valMode.SetIconAlignment(cbMode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += SparepartsTransactionEditorForm_Load;
        }

        private void SparepartsTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public SparepartManualTransactionViewModel SelectedSparepartManualTransaction { get; set; }

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
        public SparepartViewModel Sparepart
        {
            get
            {
                return cbSparepart.Properties.DataSource as SparepartViewModel;
            }
            set
            {
                cbSparepart.Properties.DataSource = value;
            }
        }

        protected override void ExecuteSave()
        {
            if (valMode.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Sparepart Transaction's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save SparepartManualTransaction: '" + SelectedSparepartManualTransaction.Sparepart.Name + "'", ex);
                    this.ShowError("Proses simpan data transaksi barang bekas: '" + SelectedSparepartManualTransaction.Sparepart.Name + "' gagal!");
                }
            }
        }



        public bool IsManual
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReferenceViewModel> ListTransactionTypeReference
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}