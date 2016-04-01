using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKEditorPresenter : BasePresenter<ISPKEditorView, SPKEditorModel>
    {
        public SPKEditorPresenter(ISPKEditorView view, SPKEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.FingerprintIP = Model.GetFingerprintIpAddress();
            View.FingerpringPort = Model.GetFingerprintPort();
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.VehicleDropdownList = Model.GetSPKVehicleList();
            View.SparepartLookupList = Model.LoadSparepart();

            View.RepairThreshold = Model.GetRepairThreshold().AsDecimal();
            View.ServiceThreshold = Model.GetServiceThreshold().AsDecimal();
            

            if (View.ParentSPK != null)
            {
                View.SelectedSPK = new SPKViewModel
                {
                    Vehicle = View.ParentSPK.Vehicle,
                    CategoryReference = View.ParentSPK.CategoryReference,
                    DueDate = View.ParentSPK.DueDate,
                    SPKParent = View.ParentSPK,
                    TotalSparepartPrice = View.ParentSPK.TotalSparepartPrice,
                    Description = View.Description
                };

                View.CategoryId = View.SelectedSPK.CategoryReference.Id;
                View.VehicleId = View.SelectedSPK.Vehicle.Id;
                View.DueDate = View.SelectedSPK.DueDate;
                View.TotalSparepartPrice = View.SelectedSPK.TotalSparepartPrice;
                View.Description = View.SelectedSPK.Description;

                View.SPKSparepartList = Model.GetEndorsedSPKSparepartList(View.ParentSPK.Id);
                View.SPKSparepartDetailList = Model.GetEndorsedSPKSparepartDetailList(View.SelectedSPK.Id);

                LoadVehicleWheel();
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSPK == null)
            {
                View.SelectedSPK = new SPKViewModel();
            }

            View.SelectedSPK.CategoryReferenceId = View.CategoryId;
            View.SelectedSPK.VehicleId = View.VehicleId;
            View.SelectedSPK.DueDate = View.DueDate;
            View.SelectedSPK.TotalSparepartPrice = View.TotalSparepartPrice;
            View.SelectedSPK.Description = View.Description;

            View.SelectedSPK = Model.InsertSPK(View.SelectedSPK, View.ParentSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, View.IsNeedApproval);
        }

        public void populateSparepartDetail()
        {
            View.SPKSparepartDetailList.AddRange(Model.getRandomDetails(View.SparepartToInsert.Id, View.SparepartQty));
        }

        public void SendApproval()
        {
            SimpleEmailSenderUtils.SendEmail(RuntimeConstant.EMAIL_SUBJECT_REQUESTAPPROVALSPK,
                View.ApprovalEmailBody.Replace(RuntimeConstant.EMAIL_APPROVALSPK_BODY, View.SelectedSPK.Code),
                View.ApprovalEmailTo, View.ApprovalEmailFrom, string.Empty, string.Empty, string.Empty);
        }

        public int getPendingSparpartQty()
        {
            return Model.getPendingSparpartQty(View.SparepartId);
        }

        public void Print()
        {
            Model.PrintSPK(View.SelectedSPK, LoginInformation.UserId);
        }

        public SpecialSparepartViewModel GetSpecialSparepart()
        {
            return Model.GetSparepartSpecial(View.SparepartId);
        }

        public void CheckIsUsedSparepartRequired()
        {
            View.IsUsedSparepartRequired = Model.IsUsedSparepartRequired(View.SparepartId);
        }

        public void GetLastUsageRecord()
        {
            View.LastUsageRecord = Model.GetSparepartLastUsageRecord(View.VehicleId, View.SparepartId);
        }

        public void LoadSSDetails(int specialSparepartId)
        {
            View.SSDetailList = Model.loadSSDetail(specialSparepartId);
        }

        public void LoadVehicleWheel()
        {
            View.VehicleWheelList = Model.getCurrentVehicleWheel(View.VehicleId);
            View.WheelDetailList = Model.RetrieveReadyWheelDetails();
        }


        public VehicleWheelViewModel ResetSelectedWheel(int VehicleWheelId)
        {
            return Model.GetVehicleWHeelById(VehicleWheelId);
        }
    }
}
