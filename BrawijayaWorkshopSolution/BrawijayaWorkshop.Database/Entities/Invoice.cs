﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class Invoice : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }
        public int SPKId { get; set; }
        public virtual SPK SPK { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public decimal TotalHasPaid { get; set; }

        public decimal TotalService { get; set; }
        public decimal TotalFeeService { get; set; }
        public decimal TotalServicePlusFee { get; set; }
        public decimal TotalSparepart { get; set; }
        public decimal TotalFeeSparepart { get; set; }
        public decimal TotalSparepartPlusFee { get; set; }
        public decimal TotalValueAdded { get; set; }
        public decimal TotalSparepartAndService { get; set; }
        
        public int PaymentMethodId { get; set; }
        public virtual Reference PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }

        public virtual List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
