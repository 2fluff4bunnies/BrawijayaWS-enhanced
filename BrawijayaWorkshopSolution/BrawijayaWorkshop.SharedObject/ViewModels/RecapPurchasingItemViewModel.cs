
using System;
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class RecapPurchasingItemViewModel
    {
        public SupplierViewModel Supplier { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public bool IsReturn { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
