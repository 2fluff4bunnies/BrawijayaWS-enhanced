using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Purchasing : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public decimal TotalHasPaid { get; set; }

        [Required]
        public int PaymentStatus { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int PaymentMethodId { get; set; }
        public virtual Reference PaymentMethod { get; set; }

        public virtual List<PurchasingDetail> PurchasingDetails { get; set; }
    }
}
