using System;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SparepartStockCardViewModel
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
        public int CreateUserId { get; set; }
        public UserViewModel CreateUser { get; set; }

        public int SparepartId { get; set; }
        public SparepartViewModel Sparepart { get; set; }

        public int ReferenceTableId { get; set; }
        public ReferenceViewModel ReferenceTable { get; set; }

        public int PrimaryKeyValue { get; set; }

        public string Description { get; set; }

        public double QtyFirst { get; set; }
        public double QtyIn { get; set; }
        public double QtyOut { get; set; }
        public double QtyLast { get; set; }
    }
}
