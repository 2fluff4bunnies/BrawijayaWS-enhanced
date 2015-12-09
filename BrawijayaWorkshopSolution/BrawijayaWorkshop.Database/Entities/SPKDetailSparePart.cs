using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPKDetailSparepart : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int quantity { get; set; }

        public int SPKId { get; set; }
        public virtual SPK SPK { get; set; }

        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }
    }
}
