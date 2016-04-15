﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class ReturnViewModel
    {
        public int SparepartId { get; set; }
        public string SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public string UnitName { get; set; }
        public decimal PricePerItem { get; set; }
        public int ReturQty { get; set; }
        public decimal SubTotal
        {
            get
            {
                return ReturQty * PricePerItem;
            }
        }
        public int ReturQtyLimit { get; set; }
    }
}
