using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Model;
using BrawijayaWorkshop.Presenter;
using BrawijayaWorkshop.SharedObject.ViewModels;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.View;
using BrawijayaWorkshop.Win32App.ModulForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App.ModulControls
{
    public partial class HPPListControl : BaseAppUserControl, IHPPListView
    {
        private HPPListPresenter _presenter;

        protected override string ModulName
        {
            get
            {
                return DbConstant.MODUL_ACCOUNTING;
            }
        }

        public int SelectedMonth { get; set; }

        public int SelectedYear { get; set; }

        public List<dynamic> ListMonth
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

        public List<int> ListYear
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

        public HPPHeaderViewModel AvailableHeader { get; set; }

        public List<HPPDetailViewModel> HPPDetailList
        {
            get
            {
                return gridHPP.DataSource as List<HPPDetailViewModel>;
            }
            set
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate { gridHPP.DataSource = value; gvHPP.BestFitColumns(); }));
                }
                else
                {
                    gridHPP.DataSource = value;
                    gvHPP.BestFitColumns();
                }
            }
        }

        public HPPListControl(HPPListModel model)
        {
            InitializeComponent();
            _presenter = new HPPListPresenter(this, model);

            this.Load += HPPListControl_Load;
        }

        private void HPPListControl_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
