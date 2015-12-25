using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System.Collections.Generic;
using System.Linq;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.Constant;

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
            View.MechanicLookupList = Model.LoadMechanic();
            View.SparepartLookupList = Model.LoadSparepart();

            View.RepairThreshold = Model.GetRepairThreshold().AsDecimal();
            View.ServiceThreshold = Model.GetServiceThreshold().AsDecimal();

            if (View.ParentSPK != null)
            {
                View.SelectedSPK = new SPK
                {
                    Vehicle = View.ParentSPK.Vehicle,
                    CategoryReference = View.ParentSPK.CategoryReference,
                    DueDate = View.ParentSPK.DueDate,
                    SPKParent = View.ParentSPK
                };

                View.CategoryId = View.SelectedSPK.CategoryReference.Id;
                View.VehicleId = View.SelectedSPK.Vehicle.Id;
                View.DueDate = View.SelectedSPK.DueDate;
                View.TotalSparepartPrice = View.SelectedSPK.TotalSparepartPrice;

                View.SPKMechanicList = Model.GetSPKMechanicList(View.ParentSPK.Id);
                View.SPKSparepartList = Model.GetSPKSparepartList(View.ParentSPK.Id);
            }
        }

        public void UpdateMechanicList(List<string> availableCodes)
        {
            View.MechanicLookupList = View.MechanicLookupList.Where(m => availableCodes.Contains(m.Code)).ToList();
        }

        public void SaveChanges()
        {
            if (View.SelectedSPK == null)
            {
                View.SelectedSPK = new SPK();
            }

            View.SelectedSPK.CategoryReferenceId = View.CategoryId;
            View.SelectedSPK.VehicleId = View.VehicleId;
            View.SelectedSPK.DueDate = View.DueDate;
            View.SelectedSPK.TotalSparepartPrice = View.TotalSparepartPrice;

            View.SelectedSPK = Model.InsertSPK(View.SelectedSPK, View.ParentSPK, View.SPKMechanicList, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, View.IsNeedApproval);
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

    }
}
