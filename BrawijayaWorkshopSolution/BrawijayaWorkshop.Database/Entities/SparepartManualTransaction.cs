using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SparepartManualTransaction : BaseModifierEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public int Qty { get; set; }
        [Required]
        public int QtyRemaining { get; set; }
        public string Remark { get; set; }

        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }

        public int UpdateTypeId { get; set; }
        public virtual Reference UpdateType { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
