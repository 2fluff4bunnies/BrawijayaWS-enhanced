
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class RecapInvoiceByCustomerItemViewModel
    {
        public string Category { get; set; }
        public string VehicleGroup { get; set; }

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
