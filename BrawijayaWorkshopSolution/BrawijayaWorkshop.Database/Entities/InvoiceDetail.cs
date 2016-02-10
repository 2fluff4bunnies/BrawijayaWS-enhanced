using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class InvoiceDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

        public int SPKDetailSparepartDetailId { get; set; }
        public virtual SPKDetailSparepartDetail SPKDetailSparepartDetail { get; set; }

        [Required]
        public double FeePctg { get; set; }

        [Required]
        public double SubTotalPrice { get; set; }
    }
}
