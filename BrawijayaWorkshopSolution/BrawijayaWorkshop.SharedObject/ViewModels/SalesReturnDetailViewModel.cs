using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SalesReturnDetailViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }

        public int InvoiceDetailId { get; set; }
        public virtual InvoiceDetailViewModel InvoiceDetail { get; set; }

        public int SalesReturnId { get; set; }
        public virtual SalesReturnViewModel SalesReturn { get; set; }
    }
}
