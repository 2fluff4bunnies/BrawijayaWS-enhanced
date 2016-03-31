
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class InvoiceDetailViewModel:BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; }
        public InvoiceViewModel Invoice { get; set; }

        public int SPKDetailSparepartDetailId { get; set; }
        public SPKDetailSparepartDetailViewModel SPKDetailSparepartDetail { get; set; }

        public double FeePctg { get; set; }
        public double SubTotalPrice { get; set; }

        public decimal ItemPrice
        {
            get
            {
                return SPKDetailSparepartDetail.SparepartDetail.PurchasingDetailId.HasValue ? SPKDetailSparepartDetail.SparepartDetail.PurchasingDetail.Price : SPKDetailSparepartDetail.SparepartDetail.SparepartManualTransaction.Price;
            }
        }
    }
}
