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
                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;

                View.TotalService = View.SelectedInvoice.TotalService;
                View.TotalServicePlusFee = View.SelectedInvoice.TotalServicePlusFee;
                View.TotalFeeService = View.SelectedInvoice.TotalFeeService;
                View.TotalSparepart = View.SelectedInvoice.TotalSparepart;
                View.TotalSparepartPlusFee = View.SelectedInvoice.TotalSparepartPlusFee;
                View.TotalFeeSparepart = View.SelectedInvoice.TotalFeeSparepart;
                View.TotalSparepartAndService = View.SelectedInvoice.TotalSparepartAndService;
                View.TotalValueAdded = View.SelectedInvoice.TotalValueAdded;
                View.TotalTransaction = View.SelectedInvoice.TotalPrice;

                View.TotalPayment = View.SelectedInvoice.TotalHasPaid;
                View.isContractWork = View.SelectedInvoice.SPK.isContractWork;
                if (View.SelectedInvoice.Status != (int)DbConstant.InvoiceStatus.FeeNotFixed)
                {
                    View.PaymentMethodId = View.SelectedInvoice.PaymentMethodId;
                }
                View.SelectedInvoice.ListInvoiceSparepart = Model.GetInvoiceSparepartList(View.SelectedInvoice.Id);
            }
        }

        public void Print()
        {
            Model.Print(View.SelectedInvoice.Id);
        }
    }
}
