using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class BalanceHelperItemViewModel
    {
        public DateTime TransactionDate { get; set; }

        public string JournalCode { get; set; }
        public string JournalName { get; set; }
        public string Description { get; set; }

        public decimal MutationDebit { get; set; }
        public decimal MutationCredit { get; set; }

        public decimal Balance { get; set; }
    }
}
