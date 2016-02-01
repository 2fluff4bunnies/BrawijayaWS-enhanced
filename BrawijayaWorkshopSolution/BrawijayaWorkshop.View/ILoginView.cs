using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;

namespace BrawijayaWorkshop.View
{
    public interface ILoginView : IView
    {
        string UserName { get; set; }
        string Password { get; set; }

        void SetLoginResult(UserViewModel user);
    }
}
