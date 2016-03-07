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
    public partial class UsedGoodsTransactionForm : BaseEditorForm, IUsedGoodTransactionEditorView
    {
        private UsedGoodTransactionEditorPresenter _presenter;

        public UsedGoodsTransactionForm(UsedGoodTransactionEditorModel model)
        {
            InitializeComponent();
            _presenter = new UsedGoodTransactionEditorPresenter(this, model);

            // set validation alignment
            valMode.SetIconAlignment(cbMode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += UsedGoodsTransactionEditorForm_Load;
        }

        private void UsedGoodsTransactionEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public UsedGoodTransactionViewModel SelectedUsedGoodTransaction { get; set; }

        #region Field Editor
        public int UsedGoodId
        {
            get
            {
                UsedGoodViewModel selected = cbSparepart.GetSelectedDataRow() as UsedGoodViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                cbSparepart.EditValue = value;
            }
        }
        #endregion
        public UsedGoodViewModel UsedGood
        {
            get
            {
                return cbSparepart.Properties.DataSource as UsedGoodViewModel;
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
                    MethodBase.GetCurrentMethod().Info("Save UsedGood Transaction's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save UsedGoodTransaction: '" + SelectedUsedGoodTransaction.UsedGood.Sparepart.Name + "'", ex);
                    this.ShowError("Proses simpan data transaksi barang bekas: '" + SelectedUsedGoodTransaction.UsedGood.Sparepart.Name + "' gagal!");
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