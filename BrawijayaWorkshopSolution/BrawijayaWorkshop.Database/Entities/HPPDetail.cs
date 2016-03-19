using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class HPPDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int HeaderId { get; set; }
        public virtual HPPHeader Header { get; set; }

        public int JournalId { get; set; }
        public virtual JournalMaster Journal { get; set; }

        public decimal? BaseAmount { get; set; }
        public int? BaseAmountModifierPercentage { get; set; }
        public decimal? BaseAmountWithModifierPercentageResult { get; set; }
        public int? ServicePercentage { get; set; }
        public decimal? ServiceAmount { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
