using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SparepartDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }

        public int PurchasingDetailId { get; set; }
        public virtual PurchasingDetail PurchasingDetail { get; set; }

        public int SparepartManualTransactionId { get; set; }
        public virtual SparepartManualTransaction SparepartManualTransaction { get; set; }
    }
}
