using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }
    }
}
