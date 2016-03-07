using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class GuestBookEditorPresenter : BasePresenter<IGuestBookEditorView, GuestBookEditorModel>
    {
        public GuestBookEditorPresenter(IGuestBookEditorView view, GuestBookEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.VehicleList = Model.GetVehiclesList();

            if (View.SelectedGuestBook != null)
            {
                View.VehicleId = View.VehicleId;
                View.Description = View.Description;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedGuestBook == null)
            {
                View.SelectedGuestBook = new GuestBookViewModel();
            }

            View.SelectedGuestBook.VehicleId = View.VehicleId;


            if (View.SelectedGuestBook.Id > 0)
            {
                Model.UpdateGuestBook(View.SelectedGuestBook, LoginInformation.UserId);
            }
            else
            {
                Model.InsertGuestBook(View.SelectedGuestBook, LoginInformation.UserId);
            }
        }
    }

}
