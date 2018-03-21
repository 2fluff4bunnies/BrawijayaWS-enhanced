using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class PurchasingDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public int QtyRemaining { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string SerialNumber { get; set; }

        public int PurchasingId { get; set; }
        public virtual Purchasing Purchasing { get; set; }

        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }
    }
}
