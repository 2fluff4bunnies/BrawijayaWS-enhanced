using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKEditorPresenter : BasePresenter<ISPKEditorView, SPKEditorModel>
    {
        public SPKEditorPresenter(ISPKEditorView view, SPKEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.VehicleDropdownList = Model.GetSPKVehicleList();

            if (View.SelectedSPK != null)
            {
                View.CategoryId = View.SelectedSPK.CategoryReferenceId;
                View.VehicleId = View.SelectedSPK.VehicleId;
                View.Code = View.SelectedSPK.Code;
                View.DueDate = View.SelectedSPK.DueDate;
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedSPK == null)
            {
                View.SelectedSPK = new SPK();
            }

            View.SelectedSPK.CategoryReferenceId = View.CategoryId;
            View.SelectedSPK.VehicleId = View.VehicleId;
            View.SelectedSPK.Code = View.Code;
            View.SelectedSPK.DueDate = View.DueDate;


            Model.InsertSPK(View.SelectedSPK, View.MechanicList, View.SparepartList, View.SparepartDetailList, LoginInformation.UserId);

        }

        public List<Sparepart> loadSparepart()
        {
           return Model.SearchSparepart(View.SparepartName);
        }

        public List<Mechanic> loadMechanic()
        {
           return Model.SearchMechanic(View.MechanicName);
        }

        public void populateSparepartDetail( )
        {
            Model.getRandomDetails(View.SparepartId, View.SparepartQty);
        }
    }
}
