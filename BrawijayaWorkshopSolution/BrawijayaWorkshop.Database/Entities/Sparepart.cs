using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Sparepart : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int StockQty { get; set; }

        public int UnitReferenceId { get; set; }
        public virtual Reference UnitReference { get; set; }

        public int CategoryReferenceId { get; set; }
        public virtual Reference CategoryReference { get; set; }

        [Required]
        public bool IsSpecialSparepart { get; set; }
        [Required]
        public bool IsWheel { get; set; }
    }
}
