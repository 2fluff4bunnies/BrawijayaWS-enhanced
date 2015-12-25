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
            View.SPKMechanicList = Model.GetSPKMechanicList(View.SelectedSPK.Id);
            View.SPKSparepartList = Model.GetSPKSparepartList(View.SelectedSPK.Id);
            View.SPKSparepartDetailList = Model.GetSPKSparepartDetailList(View.SelectedSPK.Id);
        }

        public void print()
        {
            Model.PrintSPK(View.SelectedSPK, LoginInformation.UserId);
        }

        public void Approve()
        {
            Model.ApproveSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, true);
        }
        public void Reject()
        {
            Model.ApproveSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId, false);
        }

        public void Abort()
        {
            Model.AbortSPK(View.SelectedSPK, View.SPKSparepartList, View.SPKSparepartDetailList, LoginInformation.UserId);
        }

    }
}
