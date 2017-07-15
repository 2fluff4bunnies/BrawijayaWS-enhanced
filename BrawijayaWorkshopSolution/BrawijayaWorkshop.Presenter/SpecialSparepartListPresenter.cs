using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class SpecialSparepartListPresenter : BasePresenter<ISpecialSparepartListView, SpecialSparepartListModel>
    {
        
        public SpecialSparepartListPresenter(ISpecialSparepartListView view, SpecialSparepartListModel model)
            : base(view, model) { }

        //public void InitData()
        //{
            
        //}

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = true,
                SeparatorChar = ';', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            var exportSpareparts =
                from sp in View.SpecialSparepartListData
                select new
                {
                    Nama = sp.Sparepart.Name,
                    Kode = sp.Sparepart.Code,
                    Unit = sp.Sparepart.UnitReference.Name,
                    Stok = sp.Sparepart.StockQty,
                };

            cc.Write(exportSpareparts, View.ExportFileName, outputFileDescription);
        }

        public void LoadSpecialSparepart()
        {
            View.SpecialSparepartListData = Model.SearchWheel(View.NameFilter);
        }

        public void DeleteWheel()
        {
            Model.DeleteWheel(View.SelectedSpecialSparepart, LoginInformation.UserId);
        }
    }
}
