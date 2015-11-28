using BrawijayaWorkshop.Database.Entities;
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
    public partial class JournalMasterEditorForm : BaseEditorForm, IJournalMasterEditorView
    {
        private JournalMasterEditorPresenter _presenter;

        public JournalMasterEditorForm(JournalMasterEditorModel model)
        {
            InitializeComponent();

            _presenter = new JournalMasterEditorPresenter(this, model);

            valCode.SetIconAlignment(txtCode, ErrorIconAlignment.MiddleRight);
            valName.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);

            this.Load += JournalMasterEditorForm_Load;
        }

        private void JournalMasterEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public JournalMaster SelectedJournalMaster { get; set; }

        public List<JournalMaster> ParentDropdownList
        {
            get
            {
                return lookupJournalParent.Properties.DataSource as List<JournalMaster>;
            }
            set
            {
                lookupJournalParent.Properties.DataSource = value;
            }
        }

        #region Field Editor
        public int ParentId
        {
            get
            {
                return lookupJournalParent.EditValue.AsInteger();
            }
            set
            {
                lookupJournalParent.EditValue = value;
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


        public string JournalName
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
                    MethodBase.GetCurrentMethod().Info("Save journal account's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save journal account: '" + SelectedJournalMaster.Name + "'", ex);
                    this.ShowError("Proses simpan data journal account: '" + SelectedJournalMaster.Name + "' gagal!");
                }
            }
        }
    }
}