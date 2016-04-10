using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
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

            if (View.SelectedSPKSchedule != null)
            {
                View.MechanicId = View.SelectedSPKSchedule.MechanicId;
                View.SPKId = View.SelectedSPKSchedule.SPKId;
                View.Description = View.SelectedSPKSchedule.Description;
                View.SPKDescription = View.SelectedSPKSchedule.SPK.Description;
                View.SPKCategory = View.SelectedSPKSchedule.SPK.CategoryReference.Name;
                View.SPKVehicleCustomer = View.SelectedSPKSchedule.SPK.Vehicle.ActiveLicenseNumber + "/" + View.SelectedSPKSchedule.SPK.Vehicle.Customer.CompanyName;
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
    }
}
