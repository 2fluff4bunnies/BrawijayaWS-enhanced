using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class PurchaseReturnDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SparepartDetailId { get; set; }
        public virtual SparepartDetail SparepartDetail { get; set; }

        public int PurchasingDetailId { get; set; }
        public virtual PurchasingDetail PurchasingDetail { get; set; }

        public int PurchaseReturnId { get; set; }
        public virtual PurchaseReturn PurchaseReturn { get; set; }
    }
}
