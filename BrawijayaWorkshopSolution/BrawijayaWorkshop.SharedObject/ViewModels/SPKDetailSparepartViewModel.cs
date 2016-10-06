
using System;
namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SPKDetailSparepartViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }

        public decimal TotalPriceAfterCommission { get; set; }
        public int SPKId { get; set; }
        public SPKViewModel SPK { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }

        public string SerialNumber { get; set; }

        public string Category { get; set; }
    }
}
