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
    public partial class JournalCategoryEditorForm : BaseEditorForm, IJournalCategoryEditorView
    {
        private JournalCategoryEditorPresenter _presenter;
        public JournalCategoryEditorForm(JournalCategoryEditorModel model)
        {
            InitializeComponent();

            _presenter = new JournalCategoryEditorPresenter(this, model);

            valCategory.SetIconAlignment(lookUpCategory, ErrorIconAlignment.MiddleRight);
            valJournal.SetIconAlignment(lookUpJournal, ErrorIconAlignment.MiddleRight);
            valCatName.SetIconAlignment(txtCatName, ErrorIconAlignment.MiddleRight);
            valCatDescription.SetIconAlignment(txtCatDescription, ErrorIconAlignment.MiddleRight);
            valCatCode.SetIconAlignment(txtCatCode, ErrorIconAlignment.MiddleRight);

            this.Load += JournalCategoryEditorForm_Load;
        }

        private void JournalCategoryEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        protected override void ExecuteSave()
        {
            if (!valCategory.Validate() || !valJournal.Validate() || !valCatCode.Validate()
                || !valCatName.Validate() || !valCatDescription.Validate()) return;

            try
            {
                MethodBase.GetCurrentMethod().Info("Save category journal account's changes");
                _presenter.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save category journal account: '" + SelectedChildren.Description + "'", ex);
                this.ShowError("Proses simpan data kategori akun journal: '" + SelectedChildren.Description + "' gagal!");
            }
        }

        public int SelectedParentId
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

        public List<ReferenceViewModel> ParentDropdownList
        {
            get
            {
                return lookUpCategory.Properties.DataSource as List<ReferenceViewModel>;
            }
            set
            {
                lookUpCategory.Properties.DataSource = value;
            }
        }

        public JournalMasterViewModel SelectedJournal { get; set; }

        public List<JournalMasterViewModel> JournalMasterList
        {
            get
            {
                return lookUpJournal.Properties.DataSource as List<JournalMasterViewModel>;
            }
            set
            {
                lookUpJournal.Properties.DataSource = value;
            }
        }

        public ReferenceViewModel SelectedChildren { get; set; }

        public string Code
        {
            get
            {
                return txtCatCode.Text;
            }
            set
            {
                txtCatCode.Text = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return txtCatName.Text;
            }
            set
            {
                txtCatName.Text = value;
            }
        }

        public string CategoryDescription
        {
            get
            {
                return txtCatDescription.Text;
            }
            set
            {
                txtCatDescription.Text = value;
            }
        }
    }
}