using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SparepartStockCardDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ParentStockCardId { get; set; }
        public virtual SparepartStockCard ParentStockCard { get; set; }

        public double PricePerItem { get; set; }

        public double QtyFirst { get; set; }
        public double QtyFirstPrice { get; set; }

        public double QtyIn { get; set; }
        public double QtyInPrice { get; set; }

        public double QtyOut { get; set; }
        public double QtyOutPrice { get; set; }

        public double QtyLast { get; set; }
        public double QtyLastPrice { get; set; }
    }
}
