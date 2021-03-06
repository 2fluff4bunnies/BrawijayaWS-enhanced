﻿using BrawijayaWorkshop.Model;
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
            this.Load += SparepartEditorForm_Load;
        }

        public void SparepartEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();
        }

        public SparepartViewModel SelectedSparepart { get; set; }

        public List<ReferenceViewModel> CategoryDropdownList
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

        public List<ReferenceViewModel> UnitDropdownList
        {
            get
            {
                return lookUpUnit.Properties.DataSource as List<ReferenceViewModel>;
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

        public bool IsSpecialSparepart
        {
            get
            {
                return chkIsSpecialSparepart.Checked;
            }
            set
            {
                chkIsSpecialSparepart.Checked = value;
            }
        }

        public bool IsWheel
        {
            get
            {
                return chkIsWheel.Checked;
            }
            set
            {
                chkIsWheel.Checked = value;
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