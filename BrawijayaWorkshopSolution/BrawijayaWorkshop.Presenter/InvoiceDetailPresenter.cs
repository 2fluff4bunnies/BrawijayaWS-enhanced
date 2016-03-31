using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System.Linq;
using BrawijayaWorkshop.Runtime;

namespace BrawijayaWorkshop.Presenter
{
    public class InvoiceDetailPresenter : BasePresenter<IInvoiceDetailView, InvoiceDetailModel>
    {
        public InvoiceDetailPresenter(IInvoiceDetailView view, InvoiceDetailModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            View.ListPaymentMethod = Model.RetrievePaymentMethod();
            if (View.SelectedInvoice != null)
            {
                View.ListInvoiceDetail = Model.RetrieveInvoiceDetail(View.SelectedInvoice.Id);
                View.Date = View.SelectedInvoice.CreateDate;
                View.TotalService = View.SelectedInvoice.TotalService;
                View.TotalServicePlusFee = View.SelectedInvoice.TotalServicePlusFee;
                View.TotalTransaction = View.SelectedInvoice.TotalPrice;
                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
                View.TotalSparepart = View.ListInvoiceDetail.Sum(x => x.ItemPrice);
                View.TotalSparepartPlusFee = View.ListInvoiceDetail.Sum(x => x.SubTotalPrice).AsDecimal();
                View.TotalPayment = View.SelectedInvoice.TotalHasPaid;
                if (View.SelectedInvoice.Status != (int)DbConstant.InvoiceStatus.FeeNotFixed)
                {
                    View.PaymentMethodId = View.SelectedInvoice.PaymentMethodId;
                }
            }
        }

        public void Print()
        {
        }
    }
}
