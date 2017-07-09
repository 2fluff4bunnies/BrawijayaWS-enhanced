using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKScheduleEditorView : IView
    {
        SPKScheduleViewModel SelectedSPKSchedule { get; set; }

        string SPKVehicleCustomer{ get; set; }
        string SPKCategory { get; set; }
        string SPKDescription { get; set; }
        DateTime Date { get; set;}
        int SPKId { get; set; }
        List<SPKViewModel> SPKList { get; set; }
        List<SPKVehicleModel> SPKVehicleList { get; set; }
        int MechanicId { get; set; }
        List<MechanicViewModel> MechanicList { get; set; }
        SPKViewModel SelectedSPK { get; set; }
        string Description { get; set; }
        List<MechanicViewModel> SelectedMechanicList { get; set; }

    }

    public class SPKVehicleModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ActiveLicenseNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
