using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.View;
using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class SPKHistoryListPresenter : BasePresenter<ISPKHistoryListView, SPKHistoryListModel>
    {
        public SPKHistoryListPresenter(ISPKHistoryListView view, SPKHistoryListModel model)
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
            var exportSPKs =
                from spk in View.SPKListData
                select new
                {
                    Kode = spk.Code,
                    TanggalPembuatan = spk.CreateDate.ToString("yyyyMMdd"),
                    BatasWaktu = spk.DueDate.ToString("yyyyMMdd"),
                    NoPol = spk.Vehicle.ActiveLicenseNumber,
                    Kategori = spk.CategoryReference.Name,
                    StatusPersetujuan = spk.StatusApprovalId == -1 ? "Ditolak" : 
                        spk.StatusApprovalId == 0 ? "Menunggu Persetujuan" :
                        spk.StatusApprovalId == 1 ? "Disetujui" : "Direvisi",
                    StatusPrint = spk.StatusPrintId == 0 ? "Menunggu Persetujuan" :
                        spk.StatusApprovalId == 1 ? "Siap Print" : "Sudah DiPrint",
                    StatusPengerjaan = spk.StatusCompletedId == 0 ? "Dalam Pengerjaan" : "Selesai",
                };

            cc.Write(exportSPKs, View.ExportFileName, outputFileDescription);
        }

        public void InitData()
        {
            View.DateFilterFrom = DateTime.Now;
            View.DateFilterTo = DateTime.Now;
            View.CategoryDropdownList = Model.GetSPKCategoryList();
            View.CustomerDropdownList = Model.GetSPKCustomerList();
            View.ContractWorkStatusDropdownList = GetContractWorkStatusDropdownList();
        }

        public void LoadSPK()
        {
            View.SPKListData = Model.SearchSPK(View.LicenseNumberFilter, View.CodeFilter, View.CategoryFilter, View.DateFilterFrom, View.DateFilterTo, View.ContractWorkStatusFilter, View.CustomerFIlter);
        }

        public List<SPKStatusItem> GetContractWorkStatusDropdownList()
        {
            List<SPKStatusItem> result = new List<SPKStatusItem>();

            result.Add(new SPKStatusItem
            {
                Status = -1,
                Description = "Semua"
            });

            result.Add(new SPKStatusItem
            {
                Status = 1,
                Description = "Borongan"
            });

            result.Add(new SPKStatusItem
            {
                Status = 0,
                Description = "Bukan Borongan"
            });

            return result;
        }
    }
}
