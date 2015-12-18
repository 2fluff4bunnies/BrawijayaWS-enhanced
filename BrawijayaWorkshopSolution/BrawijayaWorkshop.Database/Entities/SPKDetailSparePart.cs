using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPKDetailSparepart : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public int SPKId { get; set; }
        public virtual SPK SPK { get; set; }

        [Required]
        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }
    }
}
