using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class ManualTransactionEditorForm : BaseEditorForm, IManualTransactionEditorView
    {
        private ManualTransactionEditorPresenter _presenter;
        public ManualTransactionEditorForm(ManualTransactionEditorModel model)
        {
            InitializeComponent();
            _presenter = new ManualTransactionEditorPresenter(this, model);
        }

        public TransactionViewModel SelectedTransaction { get; set; }

        public List<TransactionDetailViewModel> TransactionDetailList
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<JournalMasterViewModel> JournalList { get; set; }

        public DateTime TransactionDate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string TransactionDescription
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double TotalTransaction
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}