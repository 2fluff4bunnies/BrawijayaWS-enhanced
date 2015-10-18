using System.ComponentModel.DataAnnotations;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Setting
    {
        [MaxLength(100)]
        [Required]
        [Key]
        public string Key { get; set; }

        [MaxLength(100)]
        [Required]
        public string Value { get; set; }
    }
}
