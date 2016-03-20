using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class GuestBookListPresenter : BasePresenter<IGuestBookListView, GuestBookListModel>
    {
        public GuestBookListPresenter(IGuestBookListView view, GuestBookListModel model) : base(view, model) { }

        public void LoadGuestBook()
        {
            View.GuestBookListData = Model.SearchGuestBook(View.ActiveLicenseNumberFilter, View.CreatedDate);
        }

        public void DeleteGuestBook()
        {
            Model.DeleteGuestBook(View.SelectedGuestBook);
        }
    }
}
