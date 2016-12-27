using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class GroupSparepartStockCardViewModel
    {
        public DateTime LastPurchaseDate { get; set; }

        public int SparepartId { get; set; }
        public virtual SparepartViewModel Sparepart { get; set; }

        public double PricePerItem { get; set; }

        public double TotalQtyFirst { get; set; }
        public double TotalQtyFirstPrice { get; set; }

        public double TotalQtyIn { get; set; }
        public double TotalQtyInPrice { get; set; }

        public double TotalQtyOut { get; set; }
        public double TotalQtyOutPrice { get; set; }

        public double TotalQtyLast { get; set; }
        public double TotalQtyLastPrice { get; set; }
    }
}
