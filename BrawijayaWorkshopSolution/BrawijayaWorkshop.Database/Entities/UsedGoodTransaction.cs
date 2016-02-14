using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class UsedGoodTransaction : BaseModifierEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public int UsedGoodsId { get; set; }
        public virtual UsedGood UsedGoods { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        [Required]
        public double ItemPrice { get; set; }

        [Required]
        public int Qty { get; set; }

        public int TypeReferenceId { get; set; }
        public virtual Reference TypeReference { get; set; }

        public string Remark { get; set; }
    }
}
