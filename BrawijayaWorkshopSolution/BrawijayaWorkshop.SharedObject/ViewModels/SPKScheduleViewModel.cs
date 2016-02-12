using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SPKScheduleViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } // only date
        public int SPKId { get; set; }
        public SPKViewModel SPK { get; set; }
        public int MechanicId { get; set; }
        public MechanicViewModel Mechanic { get; set; }
        public string Description { get; set; }
    }
}
