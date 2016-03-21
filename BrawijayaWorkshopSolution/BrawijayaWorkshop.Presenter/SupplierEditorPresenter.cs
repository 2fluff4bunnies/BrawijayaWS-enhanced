using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class SupplierEditorPresenter : BasePresenter<ISupplierEditorView, SupplierEditorModel>
    {
        public SupplierEditorPresenter(ISupplierEditorView view, SupplierEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListCity = Model.RetrieveCity();

            if (View.SelectedSupplier != null)
            {
                View.SupplierName = View.SelectedSupplier.Name;
                View.Address = View.SelectedSupplier.Address;
                View.PhoneNumber = View.SelectedSupplier.PhoneNumber;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSupplier == null)
            {
                View.SelectedSupplier = new SupplierViewModel();
            }

            View.SelectedSupplier.Name = View.SupplierName;
            View.SelectedSupplier.Address = View.Address;
            View.SelectedSupplier.PhoneNumber = View.PhoneNumber;
            View.SelectedSupplier.CityId = View.CityId;
            if (View.SelectedSupplier.Id > 0)
            {
                Model.UpdateSupplier(View.SelectedSupplier);
            }
            else
            {
                Model.InsertSupplier(View.SelectedSupplier);
            }
        }
    }
}
