using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.SharedObject.ViewModels;
using System;
using System.Collections.Generic;

namespace BrawijayaWorkshop.View
{
    public interface IInvoiceDetailView : IView
    {
        InvoiceViewModel SelectedInvoice { get; set; }
        DateTime Date { get; set; }
        string CustomerName { get; set; }
        decimal TotalSparepart { get; set; }
        decimal TotalFeeSparepart { get; set; }
        decimal TotalSparepartPlusFee { get; set; }
        decimal TotalService { get; set; }
        decimal TotalServicePlusFee { get; set; }
        decimal TotalFeeService { get; set; }
        decimal TotalValueAdded { get; set; }
        decimal TotalSparepartAndService { get; set; }
        bool isContractWork { get; set; }
        decimal TotalTransaction { get; set; }
        decimal TotalPayment { get; set; }
        int PaymentMethodId { get; set; }

        List<InvoiceDetailViewModel> ListInvoiceDetail { get; set; }
        List<ReferenceViewModel> ListPaymentMethod { get; set; }
    }
}
