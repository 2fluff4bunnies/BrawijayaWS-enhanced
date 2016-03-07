using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IInvoiceEditorView : IView
    {
        InvoiceViewModel SelectedInvoice { get; set; }
        TransactionViewModel SelectedTransaction { get; set; }

        DateTime Date { get; set; }
        string CustomerName { get; set; }
        decimal TotalTransaction { get; set; }
        decimal TotalPayment { get; set; }
        int PaymentMethodId { get; set; }

        List<InvoiceDetailViewModel> ListInvoiceDetail { get; set; }
        List<ReferenceViewModel> ListPaymentMethod { get; set; }
    }
}
