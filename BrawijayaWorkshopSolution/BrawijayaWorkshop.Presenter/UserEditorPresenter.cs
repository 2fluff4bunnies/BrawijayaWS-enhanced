using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class UserEditorPresenter : BasePresenter<IUserEditorView, UserEditorModel>
    {
        public UserEditorPresenter(IUserEditorView view, UserEditorModel model) : base(view, model) { }

        public void InitFormData()
        {
            if(View.SelectedUser != null)
            {
                View.UserName = View.SelectedUser.UserName;
                View.FirstName = View.SelectedUser.FirstName;
                View.MiddleName = View.SelectedUser.MiddleName;
                View.LastName = View.SelectedUser.LastName;
                View.Password = View.SelectedUser.Password.Decrypt();
                View.ReTypePassword = View.SelectedUser.Password.Decrypt();
                View.IsActive = View.SelectedUser.IsActive;
            }
            else
            {
                View.IsActive = true;
            }
        }

        public bool ValidateUser()
        {
            if(View.SelectedUser.Id > 0)
            {
                return Model.Validate(View.SelectedUser.UserName, View.SelectedUser.Id);
            }
            else
            {
                return Model.Validate(View.SelectedUser.UserName);
            }
        }

        public void SaveChanges()
        {
            if(View.SelectedUser == null)
            {
                View.SelectedUser = new UserViewModel();
            }

            View.SelectedUser.UserName = View.UserName;
            View.SelectedUser.FirstName = View.FirstName;
            View.SelectedUser.LastName = View.LastName;
            View.SelectedUser.MiddleName = View.MiddleName;
            View.SelectedUser.Password = View.Password.Encrypt();
            View.SelectedUser.IsActive = View.IsActive;

            if(View.SelectedUser.Id > 0)
            {
                Model.UpdateUser(View.SelectedUser);
            }
            else
            {
                Model.InsertUser(View.SelectedUser);
            }
        }
    }
}
