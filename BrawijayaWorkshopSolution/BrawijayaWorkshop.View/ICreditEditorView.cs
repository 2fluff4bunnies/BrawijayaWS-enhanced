using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface ICreditEditorView : IView
    {
        TransactionViewModel SelectedCredit { get; set; }

        InvoiceViewModel SelectedInvoice { get; set; }

        DateTime Date { get; set; }
        string CustomerName { get; set; }
        decimal TotalTransaction { get; set; }
        decimal TotalPaid { get; set; }
        decimal TotalNotPaid { get; set; }
        decimal TotalPayment { get; set; }
        int PaymentMethodId { get; set; }

        List<ReferenceViewModel> ListPaymentMethod { get; set; }

        decimal OldTotalPayment { get; set; }
        decimal OldTotalPaid { get; set; }
        decimal OldTotalNotPaid { get; set; }
    }
}
