using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.Presenter
{
    public class InvoiceListPresenter : BasePresenter<IInvoiceListView, InvoiceListModel>
    {
        public InvoiceListPresenter(IInvoiceListView view, InvoiceListModel model)
            : base(view, model) { }

        public void InitData()
        {
            View.InvoiceStatusList = GetInvoiceStatusDropdownList();
            View.DateFromFilter = DateTime.Now;
            View.DateToFilter = DateTime.Now;
            View.InvoiceStatusFilter = 9;
        }

        public void LoadInvoiceList()
        {
            View.InvoiceListData = Model.SearchInvoice(View.DateFromFilter, View.DateToFilter, (DbConstant.InvoiceStatus)View.InvoiceStatusFilter);
        }

        public List<InvoiceStatusItem> GetInvoiceStatusDropdownList()
        {
            List<InvoiceStatusItem> result = new List<InvoiceStatusItem>();
            result.Add(new InvoiceStatusItem
            {
                Status = 9,
                Description = "Semua"
            });

            result.Add(new InvoiceStatusItem
            {
                Status = (int)DbConstant.InvoiceStatus.FeeNotFixed,
                Description = "Belum Dibuat"
            });

            result.Add(new InvoiceStatusItem
            {
                Status = (int)DbConstant.InvoiceStatus.NotPrinted,
                Description = "Belum Dicetak"
            });

            result.Add(new InvoiceStatusItem
            {
                Status = (int)DbConstant.InvoiceStatus.Printed,
                Description = "Tercetak"
            });

            return result;
        }
    }
}
