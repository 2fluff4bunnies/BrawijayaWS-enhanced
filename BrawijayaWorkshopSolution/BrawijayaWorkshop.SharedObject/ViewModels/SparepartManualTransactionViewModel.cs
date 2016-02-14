using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SparepartManualTransactionViewModel : BaseModifierEntityViewModel
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Qty { get; set; }

        public string Remark { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }
    }
}
