using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public bool IsActive { get; set; }
    }
}
