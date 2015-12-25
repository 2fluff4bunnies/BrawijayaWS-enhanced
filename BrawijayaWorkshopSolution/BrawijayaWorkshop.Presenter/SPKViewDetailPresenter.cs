using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKViewDetailPresenter : BasePresenter<ISPKViewDetailView, SPKViewDetailModel>
    {
        public SPKViewDetailPresenter(ISPKViewDetailView view, SPKViewDetailModel model)
            : base(view, model) { }


        public void InitFormData()
        {
            if (View.SelectedSPK != null)
            {
                View.Code = View.SelectedSPK.Code;
                View.Category = View.SelectedSPK.CategoryReference.Name;
                View.Vehicle = View.SelectedSPK.Vehicle.ActiveLicenseNumber;
                View.DueDate = View.SelectedSPK.DueDate.ToShortDateString();
                View.CreateDate = View.SelectedSPK.CreateDate.ToShortDateString();
                View.Customer = View.SelectedSPK.Vehicle.Customer.CompanyName;
            }

            View.SPKMechanicList = Model.GetSPKMechanicList(View.SelectedSPK.Id);
            View.SPKSparepartList = Model.GetSPKSparepartList(View.SelectedSPK.Id);
            View.SPKSparepartDetailList = Model.GetSPKSparepartDetailList(View.SelectedSPK.Id);
        }

        public void print()
        {
            Model.PrintSPK(View.SelectedSPK);
        }

        public void Approve()
        {
            Model.ApproveSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, DbConstant.ApprovalStatus.Approved);
        }
        public void Reject()
        {
            Model.ApproveSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, DbConstant.ApprovalStatus.Rejected);
        }

    }
}
