using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IVehicleEditorView : IView
    {
        VehicleViewModel SelectedVehicle { get; set; }

        VehicleWheelViewModel SelectedVehicleWheel { get; set; }

        string Code { get; set; }

        int BrandId { get; set; }

        int TypeId { get; set; }

        int YearOfPurchase { get; set; }

        string ActiveLicenseNumber { get; set; }

        DateTime ExpirationDate { get; set; }

        int Kilometers { get; set; }

        int CustomerId { get; set; }

        int GroupId { get; set; }

        List<CustomerViewModel> CustomerList { get; set; }
        List<VehicleGroupViewModel> GroupList { get; set; }

        List<BrandViewModel> BrandList { get; set; }

        List<TypeViewModel> TypeList { get; set; }

        List<VehicleWheelViewModel> VehicleWheelList { get; set; }

        List<VehicleWheelViewModel> VehicleWheelExchangedList { get; set; }

        List<SpecialSparepartDetailViewModel> WheelDetailList { get; set; }
    }
}
