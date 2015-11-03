using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class ReferenceDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Value { get; set; }

        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }
    }
}
