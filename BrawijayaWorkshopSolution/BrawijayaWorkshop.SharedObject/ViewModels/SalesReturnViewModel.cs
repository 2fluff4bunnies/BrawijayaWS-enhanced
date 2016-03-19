using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SalesReturnViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int InvoiceId { get; set; }
        public virtual InvoiceViewModel Invoice { get; set; }
    }
}
