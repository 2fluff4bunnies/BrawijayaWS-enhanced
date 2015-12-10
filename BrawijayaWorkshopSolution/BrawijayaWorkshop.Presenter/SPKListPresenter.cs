using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKListPresenter : BasePresenter<ISPKListView, SPKListModel>
    {
        public SPKListPresenter(ISPKListView view, SPKListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.CategoryDropdownList = Model.GetSPKCategoryList();
        }

        public void LoadSPKList()
        {
            DbConstant.ApprovalStatus status = new DbConstant.ApprovalStatus();
            status.CompareTo(View.StatusFilter);

            View.SPKListData = Model.SearchSPK(View.CodeFilter, status);
        }
    }
}
