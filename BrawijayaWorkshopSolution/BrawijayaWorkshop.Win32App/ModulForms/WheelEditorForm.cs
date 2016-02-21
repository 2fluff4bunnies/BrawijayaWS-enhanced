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
    public partial class WheelEditorForm : BaseEditorForm
    {
        public WheelEditorForm()
        {
            InitializeComponent();

            valCode.SetIconAlignment(txtCode, ErrorIconAlignment.MiddleRight);
            valName.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
        }

        protected override void ExecuteSave()
        {
            if (valCode.Validate() && valName.Validate())
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Wheel's changes");
                    //_presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    //MethodBase.GetCurrentMethod().Fatal("An error occored while trying to save sparepart: '" + SelectedSparepart.Name + "'", ex);
                    this.ShowError("Proses simpan sparepart gagal!");
                }
            }
        }
    }
}