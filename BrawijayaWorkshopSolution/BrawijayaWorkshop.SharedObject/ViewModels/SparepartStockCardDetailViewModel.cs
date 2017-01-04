namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SparepartStockCardDetailViewModel
    {
        public int Id { get; set; }

        public int ParentStockCardId { get; set; }
        public SparepartStockCardViewModel ParentStockCard { get; set; }

        public int? PurchasingId { get; set; }
        public PurchasingViewModel Purchasing { get; set; }

        public int? SparepartManualTransactionId { get; set; }
        public SparepartManualTransactionViewModel SparepartManualTransaction { get; set; }

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
