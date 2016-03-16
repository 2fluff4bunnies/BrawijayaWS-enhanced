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
    public partial class FirstBalanceEditorForm : BaseEditorForm, IFirstBalanceEditorView
    {
        private FirstBalanceEditorPresenter _presenter;
        public FirstBalanceEditorForm(FirstBalanceEditorModel model)
        {
            InitializeComponent();
            _presenter = new FirstBalanceEditorPresenter(this, model);

            this.Load += FirstBalanceEditorForm_Load;
        }

        private void FirstBalanceEditorForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public DateTime FirstBalanceDate
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

        public List<JournalMasterViewModel> JournalList
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

        public BalanceJournalViewModel SelectedFirstBalanceJournal
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

        public BalanceJournalDetailViewModel SelectedFirstBalanceDetailJournal
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

        public List<BalanceJournalDetailViewModel> FirstBalanceJournalDetailList
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

        public List<BalanceJournalDetailViewModel> DeletedDetailList
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