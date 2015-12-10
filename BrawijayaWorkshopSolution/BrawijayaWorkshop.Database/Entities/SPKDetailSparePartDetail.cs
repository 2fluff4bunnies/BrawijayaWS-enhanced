using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPKDetailSparepartDetail : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SparepartDetailId { get; set; }
        public virtual SparepartDetail SparepartDetail { get; set; }

        public int SPKDetailSparepartId { get; set; }
        public virtual SPKDetailSparepart SPKDetailSparepart { get; set; }
    }
}
