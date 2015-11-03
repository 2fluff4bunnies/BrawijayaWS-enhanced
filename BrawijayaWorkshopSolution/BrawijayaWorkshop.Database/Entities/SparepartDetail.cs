using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SparepartDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PurchasingDetailId { get; set; }
        public virtual PurchasingDetail PurchasingDetail { get; set; }

        public int ReferenceId { get; set; }
        public virtual Reference Reference { get; set; }
    }
}
