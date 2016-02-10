using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class UsedGoods : BaseStatusEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Stock { get; set; }

        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }
    }
}
