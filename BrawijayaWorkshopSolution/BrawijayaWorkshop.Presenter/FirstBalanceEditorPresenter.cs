using BrawijayaWorkshop.Infrastructure.MVP;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrawijayaWorkshop.Presenter
{
    public class FirstBalanceEditorPresenter : BasePresenter<IFirstBalanceEditorView, FirstBalanceEditorModel>
    {
        public FirstBalanceEditorPresenter(IFirstBalanceEditorView view, FirstBalanceEditorModel model)
            : base(view, model) { }

        public void InitFormData()
        {
            var today = DateTime.Today;
            var todayMonth = new DateTime(today.Year, today.Month, 1);
            var previousDate = todayMonth.AddDays(-1);

            View.FirstBalanceDate = previousDate;
            View.DeletedDetailList = new List<BalanceJournalDetailViewModel>();

            if (View.SelectedFirstBalanceJournal != null)
            {
                View.FirstBalanceDate = new DateTime(View.SelectedFirstBalanceJournal.Year,
                                                     View.SelectedFirstBalanceJournal.Month,
                                                     DateTime.DaysInMonth(View.SelectedFirstBalanceJournal.Year,
                                                                          View.SelectedFirstBalanceJournal.Month));
                View.FirstBalanceJournalDetailList =
                    Model.RetrieveFirstBalanceDetail(View.SelectedFirstBalanceJournal.Id);
            }
            else
            {
                View.FirstBalanceJournalDetailList = new List<BalanceJournalDetailViewModel>();
            }
        }

        public void SaveChanges()
        {
            if (!ValidateBalanceData()) return;

            if (View.SelectedFirstBalanceJournal == null)
            {
                View.SelectedFirstBalanceJournal = new BalanceJournalViewModel();
            }

            View.SelectedFirstBalanceJournal.Month = View.FirstBalanceDate.Month;
            View.SelectedFirstBalanceJournal.Year = View.FirstBalanceDate.Year;
            
            if(View.SelectedFirstBalanceJournal.Id > 0)
            {
                Model.UpdateFirstBalance(View.SelectedFirstBalanceJournal,
                    View.FirstBalanceJournalDetailList, LoginInformation.UserId);
            }
            else
            {
                Model.InsertFirstBalance(View.SelectedFirstBalanceJournal,
                    View.FirstBalanceJournalDetailList, LoginInformation.UserId);
            }

            foreach (var deletedItem in View.DeletedDetailList)
            {
                if (deletedItem.Id == 0) continue;

                Model.DeleteFirstBalanceDetail(deletedItem.Id);
            }
        }

        public void InsertNewRecord()
        {
            List<BalanceJournalDetailViewModel> listDetail = View.FirstBalanceJournalDetailList;
            listDetail.Add(new BalanceJournalDetailViewModel());
            View.FirstBalanceJournalDetailList = listDetail;
        }

        public void RemoveDetail()
        {
            View.DeletedDetailList.Add(View.SelectedFirstBalanceDetailJournal);
            View.FirstBalanceJournalDetailList.Remove(View.SelectedFirstBalanceDetailJournal);
            View.FirstBalanceJournalDetailList = View.FirstBalanceJournalDetailList;
        }

        public bool ValidateBalanceData()
        {
            if (View.FirstBalanceJournalDetailList.Count > 0)
            {
                double totalBalance = View.FirstBalanceJournalDetailList.Sum(bd =>
                    bd.LastCredit ?? 0 - bd.LastDebit ?? 0).AsDouble();
                int nonSelectedJournal = View.FirstBalanceJournalDetailList.Where(bd => bd.JournalId == 0).Count();

                return totalBalance == 0 && nonSelectedJournal == 0;
            }
            return false;
        }
    }
}
