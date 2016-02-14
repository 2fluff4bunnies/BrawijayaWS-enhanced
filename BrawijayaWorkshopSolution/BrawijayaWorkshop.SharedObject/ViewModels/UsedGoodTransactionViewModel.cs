using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class UsedGoodTransactionViewModel: BaseModifierEntityViewModel
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }

        public int UsedGoodsId { get; set; }
        public UsedGoodViewModel UsedGoods { get; set; }
        public double TotalPrice { get; set; }
        public double ItemPrice { get; set; }
        public int Qty { get; set; }

        public int TypeReferenceId { get; set; }
        public ReferenceViewModel TypeReference { get; set; }
    }
}
