using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleEditorForm : BaseEditorForm, IVehicleEditorView
    {
        private VehicleEditorPresenter _presenter;

        private RepositoryItemLookUpEdit _repoItemLookUpEdit;

        public VehicleEditorForm(VehicleEditorModel model)
        {
            InitializeComponent();
            _presenter = new VehicleEditorPresenter(this, model);

            // set validation alignment
            FieldsValidator.SetIconAlignment(lookUpCustomer, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(lookUpBrand, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(lookUpType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtYearOfPurchase, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtLicenseNumber, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            FieldsValidator.SetIconAlignment(txtCode, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            ValidateExpireDate.SetIconAlignment(dtpExpirationDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);

            this.Load += VehicleEditorForm_Load;

            //lookupWheelDetailGv.EditValueChanged += lookupWheelDetailGv_EditValueChanged;
            gvVehicleWheel.PopupMenuShowing += gvVehicleWheel_PopupMenuShowing;
            gvVehicleWheel.FocusedRowChanged += gvVehicleWheel_FocusedRowChanged;

            ////collumn setting for lookup specialSparepart in grid
            //LookUpColumnInfoCollection coll = lookupWheelDetailGv.Columns;

            //coll.Add(new LookUpColumnInfo("SerialNumber", 0, "Nomor Seri"));
            ////coll.Add(new LookUpColumnInfo("SparepartName", 0, "Sparepart"));
            //lookupWheelDetailGv.BestFitMode = BestFitMode.BestFitResizePopup;
            //lookupWheelDetailGv.SearchMode = SearchMode.AutoComplete;
            //lookupWheelDetailGv.AutoSearchColumnIndex = 1;

            //collumn setting for lookup specialSparepart in grid
            _repoItemLookUpEdit = new RepositoryItemLookUpEdit();
            _repoItemLookUpEdit.DisplayMember = "SerialNumber";
            _repoItemLookUpEdit.ValueMember = "SerialNumber";
            LookUpColumnInfoCollection coll = _repoItemLookUpEdit.Columns;
            coll.Add(new LookUpColumnInfo("SerialNumber", 0, "Nomor Seri"));
            //coll.Add(new LookUpColumnInfo("SparepartName", 0, "Sparepart"));
            _repoItemLookUpEdit.BestFitMode = BestFitMode.BestFitResizePopup;
            _repoItemLookUpEdit.SearchMode = SearchMode.AutoComplete;
            _repoItemLookUpEdit.AutoSearchColumnIndex = 1;
            _repoItemLookUpEdit.NullValuePromptShowForEmptyValue = false;

            lookUpCustomer.EditValueChanged += lookUpCustomer_EditValueChanged;

            gvVehicleWheel.CustomRowCellEditForEditing += gvVehicleWheel_CustomRowCellEditForEditing;
        }

        private void gvVehicleWheel_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "WheelDetail.SerialNumber") return;
            VehicleWheelViewModel currentDataRow = gvVehicleWheel.GetRow(e.RowHandle) as VehicleWheelViewModel;
            List<SpecialSparepartDetailViewModel> listNotUsedWheel = new List<SpecialSparepartDetailViewModel>();

            foreach (var item in VehicleWheelList)
            {
                if (item.Id > 0)
                    listNotUsedWheel.Add(item.WheelDetail);
            }

            listNotUsedWheel.AddRange(WheelDetailList);

            List<string> runtimeSerial = new List<string>();
            if (VehicleWheelList != null && VehicleWheelList.Count > 0 && SelectedVehicle != null)
            {
                //runtimeSerial = VehicleWheelList.Select(w => w.WheelDetail.SerialNumber).ToList();
                foreach (var item in VehicleWheelList)
                {
                    if (item.Id > 0)
                        runtimeSerial.Add(item.WheelDetail.SerialNumber);
                }
            }

            listNotUsedWheel = listNotUsedWheel.Where(w => !runtimeSerial.Contains(w.SerialNumber)).ToList();

            if (currentDataRow != null) // insert current row into list only for edit
            {
                listNotUsedWheel.Insert(0, currentDataRow.WheelDetail);
            }
            _repoItemLookUpEdit.DataSource = listNotUsedWheel;
            e.RepositoryItem = _repoItemLookUpEdit;
        }


        public void lookUpCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (this.CustomerId > 0)
            {
                _presenter.PopulateVehicleGroup();
            }
        }

        private void lookupWheelDetailGv_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SelectedVehicle != null)
            {
                DevExpress.XtraEditors.LookUpEdit lookup = sender as DevExpress.XtraEditors.LookUpEdit;

                SpecialSparepartDetailViewModel selectedWheelDetail = lookup.GetSelectedDataRow() as SpecialSparepartDetailViewModel;
                this.SelectedVehicleWheel.WheelDetail = selectedWheelDetail;
                this.SelectedVehicleWheel.WheelDetailId = selectedWheelDetail.Id;

                VehicleWheelViewModel foundConflict = _presenter.IsWheelUsedByOtherVehicle(selectedWheelDetail.Id);

                if (foundConflict != null)
                {
                    if (this.ShowConfirmation("Ban dengan nomor seri " + lookup.SelectedText +
                       " sudah digunakan pada kendaraan dengan nopol " + foundConflict.Vehicle.ActiveLicenseNumber + "!" +
                       "\n\n Apakah anda yakin ingin menukar?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        foundConflict.WheelDetailId = _presenter.GetCurrentInstalledWheel(this.SelectedVehicleWheel.Id);
                        this.VehicleWheelExchangedList.Add(foundConflict);
                    }
                    else
                    {
                        sender = null;
                    }
                }
            }
        }

        #region Field Editor
        public VehicleViewModel SelectedVehicle { get; set; }

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
        public int TypeId
        {
            get
            {
                TypeViewModel selected = lookUpType.GetSelectedDataRow() as TypeViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpType.EditValue = value;
            }
        }

        public int BrandId
        {
            get
            {
                BrandViewModel selected = lookUpBrand.GetSelectedDataRow() as BrandViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpBrand.EditValue = value;
            }
        }

        public int CustomerId
        {
            get
            {
                CustomerViewModel selected = lookUpCustomer.GetSelectedDataRow() as CustomerViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                lookUpCustomer.EditValue = value;
            }
        }

        public int GroupId
        {
            get
            {
                return lookupGroup.EditValue.AsInteger();
            }
            set
            {
                lookupGroup.EditValue = value;
            }
        }

        public int YearOfPurchase
        {
            get
            {
                return txtYearOfPurchase.Text.AsInteger();
            }
            set
            {
                txtYearOfPurchase.Text = value.ToString();
            }
        }

        public string ActiveLicenseNumber
        {
            get
            {
                return txtLicenseNumber.Text;
            }
            set
            {
                txtLicenseNumber.Text = value;
            }
        }

        public DateTime ExpirationDate
        {
            get
            {
                return dtpExpirationDate.EditValue.AsDateTime();
            }
            set
            {
                dtpExpirationDate.EditValue = value;
            }
        }

        public int Kilometers
        {
            get
            {
                return txtKilometer.EditValue.AsInteger();
            }
            set
            {
                txtKilometer.EditValue = value.ToString();
            }
        }

        public List<CustomerViewModel> CustomerList
        {
            get
            {
                return lookUpCustomer.Properties.DataSource as List<CustomerViewModel>;
            }
            set
            {
                lookUpCustomer.Properties.DataSource = value;
            }
        }

        public List<VehicleGroupViewModel> GroupList
        {
            get
            {
                return lookupGroup.Properties.DataSource as List<VehicleGroupViewModel>;
            }
            set
            {
                lookupGroup.Properties.DataSource = value;
            }
        }

        public List<BrandViewModel> BrandList
        {
            get
            {
                return lookUpBrand.Properties.DataSource as List<BrandViewModel>;
            }
            set
            {
                lookUpBrand.Properties.DataSource = value;
            }
        }

        public List<TypeViewModel> TypeList
        {
            get
            {
                return lookUpType.Properties.DataSource as List<TypeViewModel>;
            }
            set
            {
                lookUpType.Properties.DataSource = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheelList
        {
            get
            {
                return bsVehicleWheel.DataSource as List<VehicleWheelViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        bsVehicleWheel.DataSource = value;
                        gridVehicleWheel.DataSource = bsVehicleWheel;
                        gvVehicleWheel.BestFitColumns();
                    }));
                }
                else
                {
                    bsVehicleWheel.DataSource = value;
                    gridVehicleWheel.DataSource = bsVehicleWheel;
                    gvVehicleWheel.BestFitColumns();
                }
            }
        }

        public List<SpecialSparepartDetailViewModel> WheelDetailList
        {
            get
            {
                return lookupWheelDetailGv.DataSource as List<SpecialSparepartDetailViewModel>;
            }
            set
            {
                lookupWheelDetailGv.DataSource = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheelExchangedList { get; set; }

        public VehicleWheelViewModel SelectedVehicleWheel { get; set; }
        #endregion

        private void gvVehicleWheel_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.SelectedVehicleWheel = gvVehicleWheel.GetFocusedRow() as VehicleWheelViewModel;
        }

        private void gvVehicleWheel_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                cmsEditor.Show(view.GridControl, e.Point);
            }
        }

        private void VehicleEditorForm_Load(object sender, EventArgs e)
        {
            _presenter.InitFormData();

            if (SelectedVehicle != null)
            {
                lblExpirationDate.Visible = false;
                dtpExpirationDate.Visible = false;
                txtLicenseNumber.Enabled = false;
            }
            else
            {
                if (this.WheelDetailList.Count <= 0)
                {
                    this.ShowWarning("Tidak ada ban yang siap dipakai updata data ban terlebih dahulu!");
                }
            }
        }

        //protected override void ExecuteSave()
        //{
        //    if (!bgwSave.IsBusy)
        //    {
        //        if (FieldsValidator.Validate() && VehicleWheelList.Count >= 4)
        //        {
        //            try
        //            {
        //                MethodBase.GetCurrentMethod().Info("Save Vehicle's changes");
        //                bgwSave.RunWorkerAsync();
        //                this.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Vehicle", ex);
        //                this.ShowError("Proses simpan data Kendaraan gagal!");
        //            }
        //        }
        //        else
        //        {
        //            if (VehicleWheelList.Count < 4)
        //            {
        //                this.ShowWarning("Ban yang terpasang pada kendaraan minimal 4!");
        //            }
        //        }
        //    }         
        //}

        protected override void ExecuteSave()
        {
            bool validated = true;
            string errMessage = "";

            List<string> duplicatedWheel = VehicleWheelList.Where(wh => !string.IsNullOrEmpty(wh.WheelDetail.SerialNumber)).GroupBy(x => x.WheelDetail.SerialNumber)
                       .Where(group => group.Count() > 1)
                       .Select(group => group.Key).ToList();

            if (duplicatedWheel.Count > 0)
            {
                errMessage += "Terdapat ban yang sama! \n";
                validated = false;
            }

            if (!_presenter.IsCodeValidated())
            {
                errMessage += "Kode sudah terdaftar! \n";
                validated = false;
            }

            if (!_presenter.IsLicenseNumberValidated())
            {
                errMessage += "Nopol sudah terdaftar! \n";
                validated = false;
            }

            if (FieldsValidator.Validate() && valGroupName.Validate() && validated)
            {
                try
                {
                    MethodBase.GetCurrentMethod().Info("Save Vehicle's changes");
                    _presenter.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Vehicle", ex);
                    this.ShowError("Proses simpan data Kendaraan gagal!");
                }
            }
            else
            {
                this.ShowWarning(errMessage);
            }
        }

        private void btnNewVehicleWheel_Click(object sender, EventArgs e)
        {
            foreach (var item in this.VehicleWheelList)
            {
                SpecialSparepartDetailViewModel toRemove = WheelDetailList.Where(wd => wd.SerialNumber == item.WheelDetail.SerialNumber).FirstOrDefault();
                if (toRemove != null)
                {
                    this.WheelDetailList.Remove(toRemove);
                }
            }

            VehicleWheelList.Add(new VehicleWheelViewModel
            {
                WheelDetail = new SpecialSparepartDetailViewModel()
            });
            gridVehicleWheel.DataSource = VehicleWheelList;
            gvVehicleWheel.BestFitColumns();
        }

        private void deleteWheelDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ShowConfirmation("Yakin menghapus ban kendaraan?") == System.Windows.Forms.DialogResult.Yes)
            {
                if (this.SelectedVehicleWheel != null)
                {
                    this.WheelDetailList.Add(this.SelectedVehicleWheel.WheelDetail);
                }

                VehicleWheelViewModel selectedVWToDelete = this.gvVehicleWheel.GetFocusedRow() as VehicleWheelViewModel;
                _presenter.RemoveVehicleWheel(selectedVWToDelete.Id);
                gvVehicleWheel.DeleteSelectedRows();
            }
        }

        private void bgwSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //try
            //{
            //    _presenter.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save vehicle", ex);
            //    e.Result = ex;
            //}
        }

        private void bgwSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //if (e.Result is Exception)
            //{
            //    this.ShowError("Proses simpan data kendaraan gagal!");
            //    FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data kendaraan gagal", true);
            //}
            //else
            //{
            //    FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data kendaraan selesai", true);
            //    this.Close();
            //}
        }
    }
}