using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class InvoiceSparepartViewModel
    {
        public string SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public int Qty { get; set; }
        public string UnitCategoryName { get; set; }
        public double NominalFee { get; set; }
        public double SubTotalPrice { get; set; }
    }
}
