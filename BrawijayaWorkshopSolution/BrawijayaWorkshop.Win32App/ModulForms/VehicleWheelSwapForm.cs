using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Presenter;
using System.Reflection;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class VehicleWheelSwapForm : BaseEditorForm, IVehicleWheelSwapView
    {
        private VehicleWheelSwapPresenter _presenter;

        public VehicleWheelSwapForm(VehicleWheelSwapModel model)
        {
            InitializeComponent();
            _presenter = new VehicleWheelSwapPresenter(this, model);
        }

        private void bgwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _presenter.Save();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save vehicle wheel ", ex);
                e.Result = ex;
            }
        }

        private void bgwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;

            if (e.Result is Exception)
            {
                this.ShowError("Proses simpan data ban kendaraan gagal!");
                FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data ban kendaraan gagal", true);
            }
            else
            {
                FormHelpers.CurrentMainForm.UpdateStatusInformation("simpan data ban kendaraan selesai", true);
                this.Close();
            }
        }

        private void VehicleWheelSwapForm_Load(object sender, EventArgs e)
        {
            _presenter.InitData();
            this.VaildateWheel();
        }

        public List<VehicleViewModel> VehicleList1
        {
            get
            {
                return LookUpVehicle1.Properties.DataSource as List<VehicleViewModel>;
            }
            set
            {
                LookUpVehicle1.Properties.DataSource = value;
            }
        }

        public List<VehicleViewModel> VehicleList2
        {
            get
            {
                return LookUpVehicle2.Properties.DataSource as List<VehicleViewModel>;
            }
            set
            {
                LookUpVehicle2.Properties.DataSource = value;
            }
        }

        public int SelectedVehicle1
        {
            get
            {
                VehicleViewModel selected = LookUpVehicle1.GetSelectedDataRow() as VehicleViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                LookUpVehicle1.EditValue = value;
            }
        }

        public int SelectedVehicle2
        {
            get
            {
                VehicleViewModel selected = LookUpVehicle2.GetSelectedDataRow() as VehicleViewModel;
                if (selected == null) return 0;
                return selected.Id;
            }
            set
            {
                LookUpVehicle2.EditValue = value;
            }
        }

        public List<VehicleWheelViewModel> VehicleWheel1 { get; set; }

        public List<VehicleWheelViewModel> VehicleWheel2 { get; set; }

        private void RebindListbox1()
        {
            lbxVehicleWheel1.DataSource = null;
            lbxVehicleWheel1.DataSource = VehicleWheel1;
            lbxVehicleWheel1.ValueMember = "Id";
            lbxVehicleWheel1.DisplayMember = "DisplayName";
            lbxVehicleWheel1.SelectionMode = SelectionMode.MultiSimple;
            lbxVehicleWheel1.ClearSelected();
        }

        private void RebindListbox2()
        {
            lbxVehicleWheel2.DataSource = null;
            lbxVehicleWheel2.DataSource = VehicleWheel2;
            lbxVehicleWheel2.ValueMember = "Id";
            lbxVehicleWheel2.DisplayMember = "DisplayName";
            lbxVehicleWheel2.SelectionMode = SelectionMode.MultiSimple;
            lbxVehicleWheel2.ClearSelected();
        }

        private void LookUpVehicle1_EditValueChanged(object sender, EventArgs e)
        {
            this.VehicleWheel1 = _presenter.LoadVehicleWhel(this.SelectedVehicle1);
            RebindListbox1();
            VaildateWheel();
        }

        private void LookUpVehicle2_EditValueChanged(object sender, EventArgs e)
        {
            this.VehicleWheel2 = _presenter.LoadVehicleWhel(this.SelectedVehicle2);
            RebindListbox2();
            VaildateWheel();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lbxVehicleWheel1.SelectedItems != null)
            {
                foreach (var item in lbxVehicleWheel1.SelectedItems)
                {
                    VehicleWheel2.Add((VehicleWheelViewModel)item);
                }

                foreach (VehicleWheelViewModel item in VehicleWheel2)
                {
                    VehicleWheel1.Remove(item);
                }

                RebindListbox1();
                RebindListbox2();
            }
        }

        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            VehicleWheel2.AddRange(VehicleWheel1);
            VehicleWheel1.Clear();
            RebindListbox1();
            RebindListbox2();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lbxVehicleWheel2.SelectedItems != null)
            {
                foreach (var item in lbxVehicleWheel2.SelectedItems)
                {
                    VehicleWheel1.Add((VehicleWheelViewModel)item);
                }

                foreach (VehicleWheelViewModel item in VehicleWheel1)
                {
                    VehicleWheel2.Remove(item);
                }

                RebindListbox1();
                RebindListbox2();
            }
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            VehicleWheel1.AddRange(VehicleWheel2);
            VehicleWheel2.Clear();
            RebindListbox1();
            RebindListbox2();
        }


        protected override void ExecuteSave()
        {
            FormHelpers.CurrentMainForm.UpdateStatusInformation("Proses Penyimpanan dimulai", false);

            try
            {
                MethodBase.GetCurrentMethod().Info("Save Vehicle's wheel changes");
                this.Enabled = false;
                bgwSave.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Fatal("An error occured while trying to save Vehicle wheel", ex);
                this.ShowError("Proses simpan data ban kendaraan gagal!");
            }
        }

        private void VaildateWheel()
        {
            bool result = this.VehicleWheel1 != null && this.VehicleWheel1.Count > 0 && this.VehicleWheel2 != null && this.VehicleWheel2.Count > 0;

            btnMoveAllLeft.Enabled = btnMoveAllRight.Enabled = btnMoveRight.Enabled = btnMoveLeft.Enabled = result;
        }
    }
}