using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System.Collections.Generic;
using System.Linq;


namespace BrawijayaWorkshop.Presenter
{
    public class SPKViewDetailPresenter : BasePresenter<ISPKViewDetailView, SPKViewDetailModel>
    {
        public SPKViewDetailPresenter(ISPKViewDetailView view, SPKViewDetailModel model)
            : base(view, model) { }

        List<Sparepart> SparepartWarningList = new List<Sparepart>();

        public void InitFormData()
        {
            View.SPKMechanicList = Model.GetSPKMechanicList(View.SelectedSPK.Id);
            View.SPKSparepartList = Model.GetSPKSparepartList(View.SelectedSPK.Id);
            View.SPKSparepartDetailList = Model.GetSPKSparepartDetailList(View.SelectedSPK.Id);
        }

        public void Print()
        {
            Model.PrintSPK(View.SelectedSPK, LoginInformation.UserId);
        }

        public void Approve()
        {
           

            Model.ApproveSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, true, out SparepartWarningList);

           //TODO : Send Email for stock warning
        }
        public void Reject()
        {
            Model.ApproveSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, false, out SparepartWarningList);
        }

        public void Abort()
        {
            Model.AbortSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId);
        }

        public void RequestPrint()
        {
            SimpleEmailSenderUtils.SendEmail(RuntimeConstant.EMAIL_SUBJECT_REQUESTAPPROVALPRINTSPK,
            View.ApprovalEmailBody.Replace(RuntimeConstant.EMAIL_APPROVALSPK_BODY, View.SelectedSPK.Code),
            View.ApprovalEmailTo, View.ApprovalEmailFrom, string.Empty, string.Empty, string.Empty);

            Model.RequestPrintSPK(View.SelectedSPK, LoginInformation.UserId);
        }

        public void PrintApproval(bool approved)
        {
            Model.ApprovePrintSPK(View.SelectedSPK, LoginInformation.UserId, approved);
        }

        public void SetAsCompleted()
        {
            Model.SetAsCompletedSPK(View.SelectedSPK, LoginInformation.UserId);
        }

    }
}
