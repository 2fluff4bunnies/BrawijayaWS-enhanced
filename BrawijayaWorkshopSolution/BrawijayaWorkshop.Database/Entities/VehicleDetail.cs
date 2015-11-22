using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BrawijayaWorkshop.Database.Entities
{
    public class VehicleDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LicenseNumber{ get; set; }
        public DateTime ExpirationDate { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
