
namespace BrawijayaWorkshop.Infrastructure.MVP
{
    public interface IView<T>
    {
        T PresenterObject { get; }

        void RefreshDataView();

        void SetPresenter(T presenter);
    }
}
