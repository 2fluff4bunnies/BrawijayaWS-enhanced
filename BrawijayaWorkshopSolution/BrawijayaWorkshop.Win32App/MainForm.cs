using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Runtime;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.Win32App.ModulControls;
using BrawijayaWorkshop.Win32App.ModulForms;
using BrawijayaWorkshop.Win32App.NavigationControls;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

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

                ShowNotification();
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
            if (LoginInformation.RoleName != DbConstant.ROLE_SUPERADMIN)
            {
                btnConfig.Visible = false;
                
            }
            if (LoginInformation.RoleName != DbConstant.ROLE_SUPERADMIN &&
                LoginInformation.RoleName != DbConstant.ROLE_ADMIN &&
                LoginInformation.RoleName != DbConstant.ROLE_MANAGER)
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
            ShowNotification();
        }

        private void ShowNotification()
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Panel2;

            ClearNavigation();
            ClearUserControl();

            NotificationListControl listNotification = Bootstrapper.Resolve<NotificationListControl>();
            ShowUserControl(listNotification);
        }

        private void iMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Both;

            ClearNavigation();
            ClearUserControl();

            // show navigation list
            MasterDataNavigationControl navMasterData = new MasterDataNavigationControl();
            // init visibility based on role access
            navMasterData.iSupplier.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SUPPLIER);
            navMasterData.iCustomer.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_CUSTOMER);
            navMasterData.iSparepart.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SPAREPART);
            navMasterData.iMechanic.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_MECHANIC);
            navMasterData.iVehicle.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_VEHICLE);
            navMasterData.iJournal.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_JOURNAL);
            navMasterData.iManageRole.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCESSIBILITY);
            navMasterData.iManageRoleAccess.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCESSIBILITY);
            navMasterData.iManageUser.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCESSIBILITY);

            ShowNavigationControl(navMasterData);
            // init event navigation
            navMasterData.iSupplier.LinkClicked += iSupplier_LinkClicked;
            navMasterData.iCustomer.LinkClicked += iCustomer_LinkClicked;
            navMasterData.iSparepart.LinkClicked += iSparepart_LinkClicked;
            navMasterData.iMechanic.LinkClicked += iMechanic_LinkClicked;
            navMasterData.iVehicle.LinkClicked += iVehicle_LinkClicked;
            navMasterData.iJournal.LinkClicked += iJournal_LinkClicked;
            navMasterData.iManageRole.LinkClicked += iManageRole_LinkClicked;
            navMasterData.iManageRoleAccess.LinkClicked += iManageRoleAccess_LinkClicked;
            navMasterData.iManageUser.LinkClicked += iManageUser_LinkClicked;
        }

        private void iManageUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserListControl listUser = Bootstrapper.Resolve<UserListControl>();
            ShowUserControl(listUser);
        }

        private void iManageRoleAccess_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RoleAccessListControl listRoleAccess = Bootstrapper.Resolve<RoleAccessListControl>();
            ShowUserControl(listRoleAccess);
        }

        private void iManageRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RoleListControl listRole = Bootstrapper.Resolve<RoleListControl>();
            ShowUserControl(listRole);
        }

        private void iJournal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            JournalMasterListControl listJournal = Bootstrapper.Resolve<JournalMasterListControl>();
            ShowUserControl(listJournal);
        }

        private void iVehicle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            VehicleListControl listVehicle = Bootstrapper.Resolve<VehicleListControl>();
            ShowUserControl(listVehicle);
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
            MechanicListControl listMechanic = Bootstrapper.Resolve<MechanicListControl>();
            ShowUserControl(listMechanic);
            
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigEditorForm configForm = Bootstrapper.Resolve<ConfigEditorForm>();
            configForm.ShowDialog(this);
        }

        private void iTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Both;

            ClearNavigation();
            ClearUserControl();

            // show navigation list
            TransactionDataNavigationControl navTransactionData = new TransactionDataNavigationControl();
            ShowNavigationControl(navTransactionData);
            // init event navigation
            navTransactionData.iPurchasing.LinkClicked += iPurchasing_LinkClicked;
            navTransactionData.iSPK.LinkClicked += iSPK_LinkClicked;
        }

        private void iPurchasing_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PurchasingListControl listPurchasing = Bootstrapper.Resolve<PurchasingListControl>();
            ShowUserControl(listPurchasing);
        }

        private void iSPK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SPKListControl listSPK = Bootstrapper.Resolve<SPKListControl>();
            ShowUserControl(listSPK);
        }

        private void iReporting_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Both;

            ClearNavigation();
            ClearUserControl();

            // show navigation list
            ReportingDataNavigationControl navTransactionData = new ReportingDataNavigationControl();
            ShowNavigationControl(navTransactionData);
            // init event navigation
            //navTransactionData.iPurchasing.LinkClicked += iPurchasing_LinkClicked;
        }
    }
}