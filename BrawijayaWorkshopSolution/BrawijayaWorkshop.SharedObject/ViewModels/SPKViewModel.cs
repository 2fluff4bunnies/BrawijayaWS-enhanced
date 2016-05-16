using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.SharedObject.ViewModels
{
    public class SPKViewModel : BaseModifierWithStatusViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime DueDate { get; set; }

        public decimal Subtotal { get; set; }

        public decimal TotalSparepartPrice { get; set; }

        public decimal TotalMechanicFee { get; set; }
        public int VehicleId { get; set; }

        public VehicleViewModel Vehicle { get; set; }
        public int StatusApprovalId { get; set; }
        public int StatusPrintId { get; set; }
        public int StatusCompletedId { get; set; }
        public int StatusOverLimit { get; set; }
        public int CategoryReferenceId { get; set; }
        public string Description { get; set; }
        public bool isContractWork { get; set; }
        public decimal ContractWorkFee { get; set; }
        public string Contractor { get; set; }

        public int Kilometers { get; set; }

        public ReferenceViewModel CategoryReference { get; set; }

        public int? SPKParentId { get; set; }

        public SPKViewModel SPKParent { get; set; }

        public List<SPKDetailSparepartViewModel> ListSparepart { get; set; }

        public int VehicleGroupId { get; set; }

        public VehicleGroupViewModel VehicleGroup { get; set; }
    }
}
