using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPKDetailSparepartDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? PurchasingDetailId { get; set; }
        public virtual PurchasingDetail PurchasingDetail { get; set; }

        public int? SparepartManualTransactionId { get; set; }
        public virtual SparepartManualTransaction SparepartManualTransaction { get; set; }

        public int? SpecialSparepartDetailId { get; set; }
        public virtual SpecialSparepartDetail SpecialSparepartDetail { get; set; }

        public int Qty { get; set; }

        public int SPKDetailSparepartId { get; set; }
        public virtual SPKDetailSparepart SPKDetailSparepart { get; set; }
    }
}
