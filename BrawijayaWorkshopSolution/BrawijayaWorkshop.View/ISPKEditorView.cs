using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ISPKEditorView : IView
    {
        string ApprovalEmailBody { get; set; }
        string ApprovalEmailFrom { get; set; }
        string ApprovalEmailTo { get; set; }

        string FingerprintIP { get; set; }
        string FingerpringPort { get; set; }

        SPKViewModel SelectedSPK { get; set; }
        SPKViewModel ParentSPK { get; set; }

        List<VehicleViewModel> VehicleDropdownList { get; set; }
        List<ReferenceViewModel> CategoryDropdownList { get; set; }

        List<SPKDetailSparepartViewModel> SPKSparepartList { get; set; }
        List<SPKDetailSparepartDetailViewModel> SPKSparepartDetailList { get; set; }
        List<SparepartViewModel> SparepartLookupList { get; set; }
        SparepartViewModel SparepartToInsert { get; }
        SparepartViewModel SelectedSparepart { get; set; }
        SPKDetailSparepartViewModel LastUsageRecord { get; set; }
        List<SpecialSparepartDetailViewModel> SSDetailList { get; set; }
        List<SpecialSparepartDetailViewModel> WheelDetailList { get; set; }
        List<VehicleWheelViewModel> VehicleWheelList { get; set; }
        VehicleWheelViewModel SelectedVehicleWheel { get; set; }
        SpecialSparepartDetailViewModel SelectedWheelDetailToChange { get; set; }

        int SSDetailId { get; set; }
        string Code { get; set; }
        DateTime DueDate { get; set; }
        int VehicleId { get; set; }
        int CategoryId { get; set; }

        int SparepartId { get; set; }
        string SparepartName { get; set; }
        int SparepartQty { get; set; }

        decimal RepairThreshold { get; set; }
        decimal ServiceThreshold { get; set; }

        bool IsNeedApproval { get; set; }
        decimal TotalSparepartPrice { get; set; }
        string Description { get; set; }
        bool IsUsedSparepartRequired { get; set; }

        string SparepartLastUsageDate { get; set; }
        string SparepartLastUsageQty { get; set; }

        bool isContractWork { get; set; }
        decimal ContractWorkFee { get; set; }

    }
}
