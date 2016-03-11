using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SparepartManualTransactionViewModel : BaseModifierEntityViewModel
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Qty { get; set; }

        public string Remark { get; set; }

        public string SerialNumber { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }
        public int UpdateTypeId { get; set; }
        public ReferenceViewModel UpdateType { get; set; }
    }
}
