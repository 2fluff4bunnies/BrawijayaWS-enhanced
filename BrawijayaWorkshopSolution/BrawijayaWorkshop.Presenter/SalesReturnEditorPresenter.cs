using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System.Linq;
using BrawijayaWorkshop.Runtime;
using System;

namespace BrawijayaWorkshop.Presenter
{
    public class SalesReturnEditorPresenter : BasePresenter<ISalesReturnEditorView, SalesReturnEditorModel>
    {
        public SalesReturnEditorPresenter(ISalesReturnEditorView view, SalesReturnEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            if (View.SelectedInvoice != null)
            {
                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
                if (View.SelectedSalesReturn != null)
                {
                    View.Date = View.SelectedSalesReturn.CreateDate;
                    View.ListReturn = Model.RetrieveReturnList(View.SelectedSalesReturn.Id, View.SelectedInvoice.Id);
                }
                else
                {
                    View.Date = DateTime.Now;
                    View.ListReturn = Model.RetrieveReturnList(0, View.SelectedInvoice.Id);
                }
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSalesReturn == null)
            {
                Model.InsertSalesReturn(View.SelectedInvoice.Id, View.ListReturn, LoginInformation.UserId);
            }
            else
            {
                Model.UpdateSalesReturn(View.SelectedInvoice.Id, View.SelectedSalesReturn.Id, View.ListReturn, LoginInformation.UserId);
            }
        }
    }
}
