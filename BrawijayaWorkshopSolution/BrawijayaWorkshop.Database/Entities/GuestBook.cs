using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class GuestBook : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
