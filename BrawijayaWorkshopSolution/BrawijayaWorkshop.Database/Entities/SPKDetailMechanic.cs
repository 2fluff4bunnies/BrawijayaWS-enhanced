using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPKDetailMechanic : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Fee { get; set; }

        public int SPKId { get; set; }
        public virtual SPK SPK { get; set; }

        public int MechanicId { get; set; }
        public virtual Mechanic Mechanic { get; set; }
    }
}
