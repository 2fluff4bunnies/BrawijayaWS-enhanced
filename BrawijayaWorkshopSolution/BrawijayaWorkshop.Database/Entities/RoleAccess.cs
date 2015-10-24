using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class RoleAccess
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int ApplicationModulId { get; set; }
        public virtual ApplicationModul ApplicationModul { get; set; }

        [Required]
        public int AccessCode { get; set; }
    }
}
