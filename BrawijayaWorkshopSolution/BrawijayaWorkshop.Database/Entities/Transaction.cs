using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Transaction : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public int ReferenceTableId { get; set; }
        public virtual Reference ReferenceTable { get; set; }

        public int? PaymentMethodId { get; set; }
        public virtual Reference PaymentMethod { get; set; }

        [Required]
        public int PrimaryKeyValue { get; set; }

        [Required]
        public double TotalTransaction { get; set; }

        [Required]
        public double TotalPayment { get; set; }

        public string Description { get; set; }

        public bool IsReconciliation { get; set; }
    }
}
