using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Purchasing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
