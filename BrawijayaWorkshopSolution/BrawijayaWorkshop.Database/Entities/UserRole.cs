using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class UserRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
