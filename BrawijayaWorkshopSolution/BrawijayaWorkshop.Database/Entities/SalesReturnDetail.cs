using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SalesReturnDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int InvoiceDetailId { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }

        public int SalesReturnId { get; set; }
        public virtual SalesReturn SalesReturn { get; set; }
    }
}
