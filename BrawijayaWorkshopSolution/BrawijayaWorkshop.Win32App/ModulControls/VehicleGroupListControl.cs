using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class VehicleGroupListControl : BaseAppUserControl, IVehicleGroupListView
    {
        private VehicleGroupListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_VEHICLEGROUP;
            }
        }

        public VehicleGroupListControl(VehicleGroupListModel model)
        {
            InitializeComponent();
            _presenter = new VehicleGroupListPresenter(this, model);

        }

        public List<CustomerViewModel> ListCustomer
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

        public int SelectedCustomerId
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

        public string GroupNameFilter
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

        public List<VehicleGroupViewModel> ListVehicleGroupData
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

        public VehicleGroupViewModel SelectedGroup
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
