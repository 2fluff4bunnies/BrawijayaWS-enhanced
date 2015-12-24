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

        public void InitFormData(bool isEndorse)
        {
            View.FingerprintIP = Model.GetFingerprintIpAddress();
            View.FingerpringPort = Model.GetFingerprintPort();
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.VehicleDropdownList = Model.GetSPKVehicleList();
            View.MechanicLookupList = Model.LoadMechanic();
            View.SparepartLookupList = Model.LoadSparepart();

            View.RepairThreshold = Model.GetRepairThreshold().AsDecimal();
            View.ServiceThreshold = Model.GetServiceThreshold().AsDecimal();

            if (View.SelectedSPK != null)
            {
                View.CategoryId = View.SelectedSPK.CategoryReferenceId;
                View.VehicleId = View.SelectedSPK.VehicleId;
                View.Code = View.SelectedSPK.Code;
                View.DueDate = View.SelectedSPK.DueDate;

                View.SPKMechanicList = Model.GetSPKMechanicList(View.SelectedSPK.Id);
                View.SPKSparepartList = Model.GetSPKSparepartList(View.SelectedSPK.Id);
            }

            if (isEndorse)
            {
                View.ParentSPK = View.SelectedSPK;
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

            View.SelectedSPK = Model.InsertSPK(View.SelectedSPK, View.SPKMechanicList, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, View.IsNeedApproval);
        }

        public void populateSparepartDetail()
        {
            View.SPKSparepartDetailList = Model.getRandomDetails(View.SparepartToInsert.Id, View.SparepartQty);
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
