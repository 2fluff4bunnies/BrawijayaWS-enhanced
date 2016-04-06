
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class InternalInvoiceViewModel
    {
        public string ReportTitle { get; set; }
        public string CustomerName { get; set; }
        public string VehicleNumber { get; set; }

        public decimal TotalSparepart { get; set; }
        public decimal TotalDailyMechanic { get; set; }
        public decimal TotalContractMechanic { get; set; }

        public decimal SubTotal
        {
            get
            {
                return (TotalSparepart + TotalDailyMechanic + TotalContractMechanic);
            }
        }

        public decimal TwentyPercentCommision { get; set; }
        public decimal TenPercenCommision { get; set; }

        public decimal GrandTotal
        {
            get
            {
                return (SubTotal + TwentyPercentCommision + TenPercenCommision);
            }
        }
    }
}
