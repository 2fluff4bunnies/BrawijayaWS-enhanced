using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class PurchasingViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalHasPaid { get; set; }

        public int SupplierId { get; set; }
        public SupplierViewModel Supplier { get; set; }
        public int PaymentMethodId { get; set; }
        public ReferenceViewModel PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }

        public List<PurchasingDetailViewModel> PurchasingDetails { get; set; }

        public bool IsHasReturn { get; set; }
    }
}
