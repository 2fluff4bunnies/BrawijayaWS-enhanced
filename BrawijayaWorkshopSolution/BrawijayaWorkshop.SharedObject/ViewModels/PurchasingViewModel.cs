using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class PurchasingViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalHasPaid { get; set; }

        public int SupplierId { get; set; }
        public SupplierViewModel Supplier { get; set; }
        public int PaymentMethodId { get; set; }
        public ReferenceViewModel PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }
    }
}
