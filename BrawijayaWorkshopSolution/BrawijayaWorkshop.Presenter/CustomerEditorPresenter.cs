using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class CustomerEditorPresenter : BasePresenter<ICustomerEditorView, CustomerEditorModel>
    {
        public CustomerEditorPresenter(ICustomerEditorView view, CustomerEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListCity = Model.RetrieveCity();

            if(View.SelectedCustomer != null)
            {
                View.Code = View.SelectedCustomer.Code;
                View.CompanyName = View.SelectedCustomer.CompanyName;
                View.Address = View.SelectedCustomer.Address;
                View.CityId = View.SelectedCustomer.CityId;
                View.PhoneNumber = View.SelectedCustomer.PhoneNumber;
                View.ContactPerson = View.SelectedCustomer.ContactPerson;
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedCustomer == null)
            {
                View.SelectedCustomer = new CustomerViewModel();
            }

            View.SelectedCustomer.Code = View.Code;
            View.SelectedCustomer.CompanyName = View.CompanyName;
            View.SelectedCustomer.Address = View.Address;
            View.SelectedCustomer.CityId = View.CityId;
            View.SelectedCustomer.PhoneNumber = View.PhoneNumber;
            View.SelectedCustomer.ContactPerson = View.ContactPerson;

            if(View.SelectedCustomer.Id > 0)
            {
                Model.UpdateCustomer(View.SelectedCustomer, LoginInformation.UserId);
            }
            else
            {
                Model.InsertCustomer(View.SelectedCustomer, LoginInformation.UserId);
            }
        }
    }
}
