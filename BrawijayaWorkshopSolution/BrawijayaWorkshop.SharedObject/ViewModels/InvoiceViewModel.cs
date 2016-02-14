
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class InvoiceViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int SPKId { get; set; }
        public SPKViewModel SPK { get; set; }
        public double TotalPrice { get; set; }
    }
}
