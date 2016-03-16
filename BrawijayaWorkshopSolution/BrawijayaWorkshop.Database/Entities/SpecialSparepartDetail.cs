using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SpecialSparepartDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int SparepartDetailId { get; set; }
        public virtual SparepartDetail SparepartDetail { get; set; }

        [Required]
        public int SpecialSparepartId { get; set; }
        public virtual SpecialSparepart SpecialSparepart { get; set; }

        [Required]
        [MaxLength(100)]
        public string SerialNumber { get; set; }
    }
}
