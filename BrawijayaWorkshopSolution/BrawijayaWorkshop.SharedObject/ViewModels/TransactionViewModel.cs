using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class TransactionViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }

        public int ReferenceTableId { get; set; }
        public ReferenceViewModel ReferenceTable { get; set; }
        public int PrimaryKeyValue { get; set; }
        public double TotalTransaction { get; set; }
        public double TotalPayment { get; set; }
    }
}
