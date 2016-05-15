using System.ComponentModel.DataAnnotations;

namespace BrawijayaWorkshop.Database.Entities
{
    public class VehicleGroup : BaseModifierWithStatus
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
