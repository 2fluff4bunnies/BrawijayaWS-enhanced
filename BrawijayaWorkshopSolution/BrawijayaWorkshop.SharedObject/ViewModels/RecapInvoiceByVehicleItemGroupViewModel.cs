
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class RecapInvoiceByVehicleItemGroupViewModel
    {
        public string Category { get; set; }
        public string VehicleGroup { get; set; }
        public string LicenseNumber { get; set; }

        public decimal InvoiceAmount { get; set; }
        public decimal ServiceAmount { get; set; }
        public decimal TotalAmount
        {
            get
            {
                return InvoiceAmount + ServiceAmount;
            }
        }
    }
}
