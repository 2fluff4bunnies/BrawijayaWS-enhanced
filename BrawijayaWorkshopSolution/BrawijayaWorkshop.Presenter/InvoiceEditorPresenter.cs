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
    public class InvoiceEditorPresenter : BasePresenter<IInvoiceEditorView, InvoiceEditorModel>
    {
        public InvoiceEditorPresenter(IInvoiceEditorView view, InvoiceEditorModel model)
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
                View.TotalFeeService10 = (0.1 *  View.TotalService.AsDouble()).AsDecimal();
                View.TotalFeeService20 = (0.2 * View.TotalService.AsDouble()).AsDecimal();
                View.TotalTransaction = View.SelectedInvoice.TotalPrice;
                View.CustomerName = View.SelectedInvoice.SPK.Vehicle.Customer.CompanyName;
                View.TotalSparepart = View.ListInvoiceDetail.Sum(x => x.ItemPrice);
                View.TotalSparepartPlusFee = View.ListInvoiceDetail.Sum(x => x.SubTotalPrice).AsDecimal();
                View.TotalFeeSparepart = View.TotalSparepartPlusFee - View.TotalSparepart;
                View.TotalPayment = View.SelectedInvoice.TotalHasPaid;
                View.isContractWork = View.SelectedInvoice.SPK.isContractWork;
                if (View.SelectedInvoice.Status != (int)DbConstant.InvoiceStatus.FeeNotFixed)
                {
                    View.PaymentMethodId = View.SelectedInvoice.PaymentMethodId;
                }
            }
        }

        public void SaveChanges()
        {
            if (View.SelectedInvoice == null)
            {
                View.SelectedInvoice = new InvoiceViewModel();
            }

            View.SelectedInvoice.PaymentMethodId = View.PaymentMethodId;
            View.SelectedInvoice.TotalHasPaid = View.TotalPayment;
            View.SelectedInvoice.TotalService = View.TotalService;
            View.SelectedInvoice.TotalServicePlusFee = View.TotalServicePlusFee;
            View.SelectedInvoice.TotalPrice = View.TotalTransaction;

            if (View.SelectedInvoice.Id > 0)
            {
                Model.UpdateInvoice(View.SelectedInvoice, View.ListInvoiceDetail, LoginInformation.UserId);
            }
        }
    }
}
