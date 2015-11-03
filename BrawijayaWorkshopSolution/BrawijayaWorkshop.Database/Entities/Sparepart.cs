using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Sparepart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int StockQty { get; set; }

        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }
    }
}
