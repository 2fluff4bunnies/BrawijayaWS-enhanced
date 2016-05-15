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
    public partial class VehicleGroupEditorForm : BaseEditorForm, IVehicleGroupEditorView
    {
        private VehicleGroupEditorPresenter _presenter;
        public VehicleGroupEditorForm(VehicleGroupEditorModel model)
        {
            InitializeComponent();
            _presenter = new VehicleGroupEditorPresenter(this, model);

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

        public int CustomerId
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

        public string GroupName
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