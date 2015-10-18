
namespace BrawijayaWorkshop.Infrastructure.MVP
{
    public abstract class BasePresenter<T, U>
        where T : IView
        where U : BaseModel
    {
        protected T View { get; set; }
        protected U Model { get; set; }

        public BasePresenter(T view, U model)
        {
            this.View = view;
            this.Model = model;
        }
    }
}
