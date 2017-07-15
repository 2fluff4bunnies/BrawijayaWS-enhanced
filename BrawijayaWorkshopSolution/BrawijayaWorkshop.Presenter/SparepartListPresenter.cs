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
    public class SparepartListPresenter : BasePresenter<ISparepartListView, SparepartListModel>
    {
        public SparepartListPresenter(ISparepartListView view, SparepartListModel model)
            : base(view, model) { }

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
                from sp in View.SparepartListData
                select new
                {
                    Kategori = sp.CategoryReference.Name,
                    Kode = sp.Code,
                    Nama = sp.Name,
                    Unit = sp.UnitReference.Value,
                    Stok = sp.StockQty
                };

            cc.Write(exportSpareparts, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            List<ReferenceViewModel> result = Model.GetSparepartCategoryList();
            result.Insert(0, new ReferenceViewModel
            {
                Id = 0,
                Name = "-- Kategori --",
                Code = "-",
                Value = "-"
            });
            View.CategoryDropdownList = result;
        }

        public void LoadSparepart()
        {
            View.SparepartListData = Model.SearchSparepart(View.CategoryFilter, View.NameFilter);
        }

        public void DeleteSparepart()
        {
            Model.DeleteSparepart(View.SelectedSparepart, LoginInformation.UserId);
        }
    }
}
