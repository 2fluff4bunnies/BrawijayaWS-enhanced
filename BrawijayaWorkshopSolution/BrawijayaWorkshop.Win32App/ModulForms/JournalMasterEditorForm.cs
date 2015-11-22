using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Database.Entities;

namespace BrawijayaWorkshop.Win32App.ModulForms
{
    public partial class JournalMasterEditorForm : BaseEditorForm, IJournalMasterEditorView
    {
        

        public JournalMasterEditorForm()
        {
            InitializeComponent();
        }

        public JournalMaster SelectedJournalMaster
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

        public int ParentId
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

        public List<JournalMaster> ParentDropdownList
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

        public string Code
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


        public string JournalName
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