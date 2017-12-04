using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class JournalMasterListPresenter : BasePresenter<IJournalMasterListView, JournalMasterListModel>
    {
        public JournalMasterListPresenter(IJournalMasterListView view, JournalMasterListModel model)
            : base(view, model) { }

        public void ExportToCSV()
        {
            CsvContext cc = new CsvContext();
            CsvFileDescription outputFileDescription = new CsvFileDescription
            {
                QuoteAllFields = true,
                SeparatorChar = ',', // tab delimited
                FirstLineHasColumnNames = true,
                FileCultureName = "en-US"
            };

            // prepare invoices
            var exportJournals =
                from jou in View.JournalMasterListData
                select new
                {
                    Kode = jou.Code,
                    Nama = jou.Name,
                    Induk = jou.Parent.Code,
                };

            cc.Write(exportJournals, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            List<JournalMasterViewModel> listParent = Model.GetAllParentJournal();
            listParent.Insert(0, new JournalMasterViewModel
            {
                Id = 0,
                Code = "-- Pilih Account --",
                Name = "-- Pilih Account --"
            });
            View.ParentDropdownList = listParent;
        }

        public void LoadData()
        {
            View.JournalMasterListData = Model.GetAllJournal(View.ParentId, View.NameFilter);
        }

        public void DeleteData()
        {
            Model.DeleteJournal(View.SelectedJournalMaster);
        }
    }
}
