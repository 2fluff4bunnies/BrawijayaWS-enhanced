using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;

namespace BrawijayaWorkshop.View
{
    public interface ILoginView : IView
    {
        string UserName { get; set; }
        string Password { get; set; }

        void SetLoginResult(User user);
    }
}
