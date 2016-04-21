using System.Collections.Generic;
using BrawijayaWorkshop.Utils;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class InvoiceViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int SPKId { get; set; }
        public SPKViewModel SPK { get; set; }
        public decimal TotalPrice { get; set; }
        public string TotalPriceStr
        {
            get
            {
                return TotalPrice.NumberToWordID();
            }
        }
        public decimal TotalHasPaid { get; set; }
        public decimal TotalService { get; set; }
        public decimal TotalServicePlusFee { get; set; }
        public int PaymentMethodId { get; set; }
        public ReferenceViewModel PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }

        public List<InvoiceDetailViewModel> InvoiceDetails { get; set; }

        public List<InvoiceSparepartViewModel> ListInvoiceSparepart { get; set; }
    }
}
