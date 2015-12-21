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
    public class MechanicEditorPresenter : BasePresenter<IMechanicEditorView, MechanicEditorModel>
    {
        public MechanicEditorPresenter(IMechanicEditorView view, MechanicEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.FingerprintIP = Model.GetFingerprintIpAddress();
            View.FingerpringPort = Model.GetFingerprintPort();

            if (View.SelectedMechanic != null)
            {
                View.Code = View.SelectedMechanic.Code;
                View.MechanicName = View.SelectedMechanic.Name;
                View.Address = View.SelectedMechanic.Address;
                View.PhoneNumber = View.SelectedMechanic.PhoneNumber;
            }
            else
            {
                View.Code = Model.GetLastCode().ToString();
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedMechanic == null)
            {
                View.SelectedMechanic = new Mechanic();
            }

            View.SelectedMechanic.Code = View.Code;
            View.SelectedMechanic.Name = View.MechanicName;
            View.SelectedMechanic.Address = View.Address;
            View.SelectedMechanic.PhoneNumber = View.PhoneNumber;

            if (View.SelectedMechanic.Id > 0)
            {
                Model.UpdateMechanic(View.SelectedMechanic);
            }
            else
            {
                Model.InsertMechanic(View.SelectedMechanic);
            }
        }
    }
}
