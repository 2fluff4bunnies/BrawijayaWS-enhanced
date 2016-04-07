using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrawijayaWorkshop.Database.Entities
{
    public class SPK : BaseModifierWithStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Code { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Subtotal { get; set; }

        public decimal TotalSparepartPrice { get; set; }

        public decimal TotalMechanicFee { get; set; }

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public int StatusApprovalId { get; set; }

        public int StatusPrintId { get; set; }

        public int StatusCompletedId { get; set; }

        public int StatusOverLimit { get; set; }

        public int CategoryReferenceId { get; set; }

        public string Description { get; set; }

        public virtual Reference CategoryReference { get; set; }

        public int? SPKparentId { get; set; }

        public virtual SPK SPKParent { get; set; }

        public virtual List<SPKDetailSparepart> ListSparepart { get; set; }

        public bool isContractWork { get; set; }

        public decimal ContractWorkFee { get; set; }

    }
}
