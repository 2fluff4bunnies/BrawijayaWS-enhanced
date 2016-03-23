using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.View;

namespace BrawijayaWorkshop.Presenter
{
    public class DebtPaymentListPresenter : BasePresenter<IDebtPaymentListView, DebtPaymentListModel>
    {
        public DebtPaymentListPresenter(IDebtPaymentListView view, DebtPaymentListModel model)
            : base(view, model) { }

        public void LoadTransactionList()
        {
            if(View.SelectedPurchasing != null)
            {
                View.SupplierName = View.SelectedPurchasing.Supplier.Name;
                View.TransactionDate = View.SelectedPurchasing.Date;
                View.TotalPrice = View.SelectedPurchasing.TotalPrice;
                View.TotalHasPaid = View.SelectedPurchasing.TotalHasPaid;
                View.TotalNotPaid = View.SelectedPurchasing.TotalPrice - View.SelectedPurchasing.TotalHasPaid; 
            }
            View.TransactionListData = Model.SearchTransactionByTableRefPK(View.SelectedPurchasing.Id);
        }
    }
}
