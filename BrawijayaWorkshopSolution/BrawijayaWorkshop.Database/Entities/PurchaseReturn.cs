using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class PurchaseReturn : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int PurchasingId { get; set; }
        public virtual Purchasing Purchasing { get; set; }

        public virtual List<PurchaseReturnDetail> PurchasingReturnDetailList { get; set; }
    }
}
