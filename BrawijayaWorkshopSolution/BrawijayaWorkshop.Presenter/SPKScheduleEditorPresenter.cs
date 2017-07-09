using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKScheduleEditorPresenter : BasePresenter<ISPKScheduleEditorView, SPKScheduleEditorModel>
    {
        public SPKScheduleEditorPresenter(ISPKScheduleEditorView view, SPKScheduleEditorModel model) : base(view, model) { }

        public void InitFormData()
        {
            View.MechanicList = Model.LoadMechanic();
            View.SPKList = Model.LoadSPK();
            View.SPKVehicleList = new List<SPKVehicleModel>();
            View.SelectedMechanicList = new List<MechanicViewModel>();
            View.Description = string.Empty;

            foreach (var item in View.SPKList)
            {
                View.SPKVehicleList.Add(new SPKVehicleModel
                { 
                    Id  = item.Id,
                    Code = item.Code,
                    ActiveLicenseNumber = item.Vehicle.ActiveLicenseNumber,
                    CompanyName = item.Vehicle.Customer.CompanyName
                });
            }

            if (View.SelectedSPKSchedule != null)
            {
                View.MechanicId = View.SelectedSPKSchedule.MechanicId;
                View.SPKId = View.SelectedSPKSchedule.SPKId;
                View.Description = View.SelectedSPKSchedule.Description;
                View.SPKDescription = View.SelectedSPKSchedule.SPK.Description;
                View.SPKCategory = View.SelectedSPKSchedule.SPK.CategoryReference.Name;
                View.SPKVehicleCustomer = View.SelectedSPKSchedule.SPK.Vehicle.ActiveLicenseNumber + "/" + View.SelectedSPKSchedule.SPK.Vehicle.Customer.CompanyName;
                View.Date = View.SelectedSPKSchedule.Date;
            }
            else
            {
                View.Date = DateTime.Now;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSPKSchedule == null)
            {
                View.SelectedSPKSchedule = new SharedObject.ViewModels.SPKScheduleViewModel();
            }

            View.SelectedSPKSchedule.MechanicId = View.MechanicId;
            View.SelectedSPKSchedule.SPKId = View.MechanicId;
            View.SelectedSPKSchedule.SPKId = View.SPKId;
            View.SelectedSPKSchedule.Description = View.Description;
            View.SelectedSPKSchedule.Date = View.Date;

            if (View.SelectedSPKSchedule.Id > 0)
            {
                Model.UpdateSPKSchedule(View.SelectedSPKSchedule, LoginInformation.UserId);
            }
            else
            {
                Model.InsertSPKSchedule(View.SelectedSPKSchedule, LoginInformation.UserId);
            }
        }

        public void UpdateMechanicList(List<string> availableCodes)
        {
            View.MechanicList = View.MechanicList.Where(m => availableCodes.Contains(m.Code)).ToList();
        }

        public void SetSelectedSPK(int spkId)
        {
            View.SelectedSPK = Model.GetSPKById(spkId);
        }
    }
}
