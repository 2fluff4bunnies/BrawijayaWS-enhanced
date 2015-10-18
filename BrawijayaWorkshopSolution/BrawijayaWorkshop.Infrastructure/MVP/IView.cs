
namespace BrawijayaWorkshop.Infrastructure.MVP
{
    public interface IView
    {
        void RefreshDataView();

        void ShowMessage(EnumViewMessage messageType, string message);
    }
}
