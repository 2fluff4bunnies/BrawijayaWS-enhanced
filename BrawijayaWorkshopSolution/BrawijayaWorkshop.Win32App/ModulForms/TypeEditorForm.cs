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
    public partial class TypeEditorForm : BaseEditorForm, ITypeEditorView
    {
        private TypeEditorPresenter _presenter;

        public TypeEditorForm(TypeEditorModel model)
        {
            InitializeComponent();
            _presenter = new TypeEditorPresenter(this, model);

            // set validation alignment
            valName.SetIconAlignment(txtName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            valDescription.SetIconAlignment(txtDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.Load += TypeEditorForm_Load;
        }

        private void TypeEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public TypeViewModel SelectedType { get; set; }

        #region Field Editor
        public string TypeName
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
                    MethodBase.GetCurrentMethod().Info("Save Type's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save type: '" + SelectedType.Name + "'", ex);
                    this.ShowError("Proses simpan data type: '" + SelectedType.Name + "' gagal!");
                }
            }
        }
    }
}