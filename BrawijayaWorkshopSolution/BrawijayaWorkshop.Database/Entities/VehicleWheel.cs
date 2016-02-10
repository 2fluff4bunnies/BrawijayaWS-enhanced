using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class VehicleWheel : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [Required]
        public int WheelDetailId { get; set; }
        public virtual WheelDetail WheelDetail { get; set; }
    }
}
