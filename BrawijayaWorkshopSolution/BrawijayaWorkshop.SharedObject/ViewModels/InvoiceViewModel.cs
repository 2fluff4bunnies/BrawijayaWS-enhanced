
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class InvoiceViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SPKId { get; set; }
        public SPKViewModel SPK { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalHasPaid { get; set; }
        public int PaymentMethodId { get; set; }
        public ReferenceViewModel PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }
    }
}
