using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Presenter
{
    public class SupplierEditorPresenter : BasePresenter<ISupplierEditorView, SupplierEditorModel>
    {
        public SupplierEditorPresenter(ISupplierEditorView view, SupplierEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
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
                View.SelectedSupplier = new Supplier();
            }

            View.SelectedSupplier.Name = View.SupplierName;
            View.SelectedSupplier.Address = View.Address;
            View.SelectedSupplier.PhoneNumber = View.PhoneNumber;

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
