
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class RecapInvoiceItemViewModel
    {
        public InvoiceViewModel Invoice { get; set; }
        public CustomerViewModel Customer { get; set; }
        public VehicleGroupViewModel VehicleGroup { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }
        public decimal NominalFee { get; set; }

        public decimal SubTotalWithFee { get; set; }

        public decimal SubTotalWithoutFee { get; set; }
    }
}
