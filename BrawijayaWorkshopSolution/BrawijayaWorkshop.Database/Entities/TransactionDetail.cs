using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class TransactionDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ParentId { get; set; }
        public virtual Transaction Parent { get; set; }

        public int JournalId { get; set; }
        public virtual JournalMaster Journal { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }
    }
}
