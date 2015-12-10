using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.XtraEditors;
using System.Reflection;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Win32App.ModulForms;
using BrawijayaWorkshop.Win32App.ModulControls;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.Win32App.NavigationControls;
using BrawijayaWorkshop.Constant;

namespace BrawijayaWorkshop.Win32App
{
    public partial class MainForm : RibbonForm
    {
        private bool initStartUpResult = false;

        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            initStartUpResult = InitStartUp();

            this.Load += MainForm_Load;
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!initStartUpResult)
            {
                this.ShowError("Ada kesalahan pada sistem. Mohon hubungi developer.");
                Application.Exit();
            }
            else
            {
                LoginForm login = Bootstrapper.Resolve<LoginForm>();
                login.ShowDialog(this);
                if (login.DialogResult == System.Windows.Forms.DialogResult.Abort)
                {
                    this.FormClosing -= MainForm_FormClosing;
                    this.Close();
                }

                siInfo.Caption = string.Format("{0}: {1} - ", LoginInformation.UserName, RuntimeConstant.GetRoleDescription(LoginInformation.RoleName));

                // get login information and generate menus and navigations based on allowed modules
                GenerateRibbonMenu();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (initStartUpResult)
            {
                this.FormClosing -= MainForm_FormClosing;

                if (this.ShowConfirmation("Apakah anda yakin ingin menutup aplikasi?") ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.FormClosing += MainForm_FormClosing;
                    e.Cancel = true;
                }
            }
        }

        #region Helper
        private void GenerateRibbonMenu()
        {
            if(LoginInformation.RoleName == DbConstant.ROLE_MANAGER)
            {
                iMaster.Visibility = BarItemVisibility.Never;
            }
        }

        private void ShowUserControl(XtraUserControl userControl)
        {
            ClearUserControl();
            userControl.Dock = DockStyle.Fill;
            splitContainerControl.Panel2.Controls.Add(userControl);
        }

        private void ShowNavigationControl(XtraUserControl userControl)
        {
            ClearNavigation();
            userControl.Dock = DockStyle.Fill;
            splitContainerControl.Panel1.Controls.Add(userControl);
        }

        private void ClearUserControl()
        {
            splitContainerControl.Panel2.Controls.Clear();
        }

        private void ClearNavigation()
        {
            splitContainerControl.Panel1.Controls.Clear();
        }
        #endregion

        #region Menu Items Event Handler
        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutAppForm aboutForm = new AboutAppForm();
            aboutForm.ShowDialog(this);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Startup Function
        private bool InitStartUp()
        {
            bool isSucceed = true;
            if (!InitializingApplication())
            {
                isSucceed = false;
            }
            if (isSucceed)
            {
                if (!CheckingDatabaseConnection())
                {
                    isSucceed = false;
                }
            }
            if (isSucceed)
            {
                if (!FinishingUp())
                {
                    isSucceed = false;
                }
            }

            if (!isSucceed)
            {
                SplashScreenManager.Default.SendCommand(StartupScreen.SplashScreenCommand.Abort, null);
                Thread.Sleep(2000);
            }
            SplashScreenManager.CloseForm();

            return isSucceed;
        }

        private bool InitializingApplication()
        {
            try
            {
                SplashScreenManager.Default.SendCommand(StartupScreen.SplashScreenCommand.Initialize, null);
                Thread.Sleep(1000); // TODO: do something
                return true;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Error("An error occured while initializing application", ex);
            }

            return false;
        }

        private bool CheckingDatabaseConnection()
        {
            try
            {
                SplashScreenManager.Default.SendCommand(StartupScreen.SplashScreenCommand.CheckDatabaseConnection, null);
                MethodBase.GetCurrentMethod().Info("Initialize database");
                // Initialize Database
                new BrawijayaWorkshopDbInitializer().InitializeDatabase(new BrawijayaWorkshopDbContext());
                MethodBase.GetCurrentMethod().Info("Database initialized successfully");
                return true;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Error("An error occured while checking database connection", ex);
            }

            return false;
        }

        private bool FinishingUp()
        {
            try
            {
                SplashScreenManager.Default.SendCommand(StartupScreen.SplashScreenCommand.Finish, null);
                Thread.Sleep(2000); // TODO: do something
                return true;
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Error("An error occured while finishing up application", ex);
            }

            return false;
        }

        private void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        #endregion

        public void UpdateStatusInformation(string status, bool isComplete)
        {
            this.siStatus.Caption = status;
            biStatusProgress.Visibility = BarItemVisibility.Never;
            if (!isComplete)
            {
                biStatusProgress.Visibility = BarItemVisibility.Always;
            }
        }

        private void iNotification_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Panel2;

            ClearNavigation();
            ClearUserControl();

            // show layout notification
        }

        private void iMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Both;

            ClearNavigation();
            ClearUserControl();

            // show navigation list
            MasterDataNavigationControl navMasterData = new MasterDataNavigationControl();
            ShowNavigationControl(navMasterData);
            // init event navigation
            navMasterData.iSupplier.LinkClicked += iSupplier_LinkClicked;
            navMasterData.iCustomer.LinkClicked += iCustomer_LinkClicked;
            navMasterData.iSparepart.LinkClicked += iSparepart_LinkClicked;
            navMasterData.iMechanic.LinkClicked += iMechanic_LinkClicked;
        }

        private void iCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CustomerListControl listCustomer = Bootstrapper.Resolve<CustomerListControl>();
            ShowUserControl(listCustomer);
        }

        private void iSupplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SupplierListControl listSupplier = Bootstrapper.Resolve<SupplierListControl>();
            ShowUserControl(listSupplier);
        }

        private void iSparepart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SparepartListControl listSparepart = Bootstrapper.Resolve<SparepartListControl>();
            ShowUserControl(listSparepart);
        }

        private void iMechanic_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //MechanicListControl listMechanic = Bootstrapper.Resolve<MechanicListControl>();
            //ShowUserControl(listMechanic);
            PurchasingListControl listSparepart = Bootstrapper.Resolve<PurchasingListControl>();
            ShowUserControl(listSparepart);
        private void btnConfig_Click(object sender, EventArgs e)
        {
            // todo show config
        }
    }
}