using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class VehicleDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int VehicleId { get; set; }
        public VehicleViewModel Vehicle { get; set; }
    }
}
