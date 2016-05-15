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
            navMasterData.iJournalCategory.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_JOURNAL);
            navMasterData.iManageRole.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCESSIBILITY);
            navMasterData.iManageRoleAccess.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCESSIBILITY);
            navMasterData.iManageUser.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_USERCONTROL);
            navMasterData.iManageUserRole.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCESSIBILITY);
            navMasterData.iUserList.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_MANAGE_APP_USER);
            navMasterData.iSpecialSparepart.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SPAREPART);
            navMasterData.iUsedGood.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_USEDGOOD);
            navMasterData.iBrand.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_BRAND);
            navMasterData.iType.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_TYPE);
            navMasterData.iVehicleGroup.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_VEHICLEGROUP);

            ShowNavigationControl(navMasterData);
            // init event navigation
            navMasterData.iSupplier.LinkClicked += iSupplier_LinkClicked;
            navMasterData.iCustomer.LinkClicked += iCustomer_LinkClicked;
            navMasterData.iSparepart.LinkClicked += iSparepart_LinkClicked;
            navMasterData.iMechanic.LinkClicked += iMechanic_LinkClicked;
            navMasterData.iVehicle.LinkClicked += iVehicle_LinkClicked;
            navMasterData.iJournal.LinkClicked += iJournal_LinkClicked;
            navMasterData.iJournalCategory.LinkClicked += iJournalCategory_LinkClicked;
            navMasterData.iManageRole.LinkClicked += iManageRole_LinkClicked;
            navMasterData.iManageRoleAccess.LinkClicked += iManageRoleAccess_LinkClicked;
            navMasterData.iManageUser.LinkClicked += iManageUser_LinkClicked;
            navMasterData.iManageUserRole.LinkClicked += iManageUserRole_LinkClicked;
            navMasterData.iUserList.LinkClicked += iUserList_LinkClicked;
            navMasterData.iSpecialSparepart.LinkClicked += iSpecialSparepart_LinkClicked;
            navMasterData.iUsedGood.LinkClicked += iUsedGood_LinkClicked;
            navMasterData.iBrand.LinkClicked += iBrand_LinkClicked;
            navMasterData.iType.LinkClicked += iType_LinkClicked;
            navMasterData.iVehicleGroup.LinkClicked += iVehicleGroup_LinkClicked;
        }

        private void iVehicleGroup_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            VehicleGroupListControl vehicleListontrol = Bootstrapper.Resolve<VehicleGroupListControl>();
            ShowUserControl(vehicleListontrol);
        }

        private void iBrand_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BrandListControl brandListControl = Bootstrapper.Resolve<BrandListControl>();
            ShowUserControl(brandListControl);
        }

        private void iType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TypeListControl typeListControl = Bootstrapper.Resolve<TypeListControl>();
            ShowUserControl(typeListControl);
        }

        private void iJournalCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            JournalCategoryListControl manageJournalCategoryListControl = Bootstrapper.Resolve<JournalCategoryListControl>();
            ShowUserControl(manageJournalCategoryListControl);
        }

        private void iUserList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ManageUserListControl manageUserListControl = Bootstrapper.Resolve<ManageUserListControl>();
            ShowUserControl(manageUserListControl);
        }

        private void iManageUserRole_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserRoleListControl listUserRole = Bootstrapper.Resolve<UserRoleListControl>();
            ShowUserControl(listUserRole);
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

        private void iSpecialSparepart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SpecialSparepartListControl specialSparepartListControl = Bootstrapper.Resolve<SpecialSparepartListControl>();
            ShowUserControl(specialSparepartListControl);
        }

        private void iUsedGood_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UsedGoodsListControl usedGoodListtControl = Bootstrapper.Resolve<UsedGoodsListControl>();
            ShowUserControl(usedGoodListtControl);
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
            // init visibility based on role access
            navTransactionData.iPurchasing.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_PURCHASING);
            navTransactionData.iSPK.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SPK);
            navTransactionData.iUsedGoodTrans.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_USEDGOOD_TRANSACTION);
            navTransactionData.iGuestBook.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_VEHICLE);
            navTransactionData.iDebt.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_DEBT);
            navTransactionData.iCredit.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_CREDIT);
            navTransactionData.iInvoice.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_INVOICE);
            navTransactionData.iPurchaseReturn.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_PURCHASE_RETURN);
            navTransactionData.iSalesReturn.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SALES_RETURN);
            navTransactionData.iSPKSales.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SPK_SALES);
            navTransactionData.iSPKSchedule.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SPK_SCHEDULE);

            ShowNavigationControl(navTransactionData);
            // init event navigation
            navTransactionData.iPurchasing.LinkClicked += iPurchasing_LinkClicked;
            navTransactionData.iSPK.LinkClicked += iSPK_LinkClicked;
            navTransactionData.iUsedGoodTrans.LinkClicked += iUsedGoodTrans_LinkClicked;
            navTransactionData.iGuestBook.LinkClicked += iGuestBook_LinkClicked;
            navTransactionData.iDebt.LinkClicked += iDebt_LinkClicked;
            navTransactionData.iCredit.LinkClicked += iCredit_LinkClicked;
            navTransactionData.iInvoice.LinkClicked += iInvoice_LinkClicked;
            navTransactionData.iPurchaseReturn.LinkClicked += iPurchaseReturn_LinkClicked;
            navTransactionData.iSalesReturn.LinkClicked += iSalesReturn_LinkClicked;
            navTransactionData.iSPKSales.LinkClicked += iSPKSales_LinkClicked;
            navTransactionData.iSPKSchedule.LinkClicked += iSPKSchedule_LinkClicked;
        }

        void iSPKSchedule_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SPKScheduleListControl listSPKSchedule = Bootstrapper.Resolve<SPKScheduleListControl>();
            ShowUserControl(listSPKSchedule);
        }

        void iSPKSales_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SPKSaleListControl listSPKSales = Bootstrapper.Resolve<SPKSaleListControl>();
            ShowUserControl(listSPKSales);
        }

        void iInvoice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InvoiceListControl listInvoice = Bootstrapper.Resolve<InvoiceListControl>();
            ShowUserControl(listInvoice);
        }
        void iPurchaseReturn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PurchaseReturnListControl listPurchaseReturn = Bootstrapper.Resolve<PurchaseReturnListControl>();
            ShowUserControl(listPurchaseReturn);
        }
        void iSalesReturn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SalesReturnListControl listSalesReturn = Bootstrapper.Resolve<SalesReturnListControl>();
            ShowUserControl(listSalesReturn);
        }
        void iCredit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CreditListControl listCredit = Bootstrapper.Resolve<CreditListControl>();
            ShowUserControl(listCredit);
        }

        void iDebt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DebtListControl listDebt = Bootstrapper.Resolve<DebtListControl>();
            ShowUserControl(listDebt);
        }

        void iGuestBook_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GuestBookListControl listGuestBook = Bootstrapper.Resolve<GuestBookListControl>();
            ShowUserControl(listGuestBook);
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
        private void iUsedGoodTrans_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UsedGoodsTransactionListControl listUsedGoodsTrans = Bootstrapper.Resolve<UsedGoodsTransactionListControl>();
            ShowUserControl(listUsedGoodsTrans);
        }

        private void iReporting_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Both;

            ClearNavigation();
            ClearUserControl();

            // show navigation list
            ReportingDataNavigationControl navReporting = new ReportingDataNavigationControl();
            navReporting.iSPKHistory.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_SPK);

            ShowNavigationControl(navReporting);
            // init event navigation
            //navTransactionData.iPurchasing.LinkClicked += iPurchasing_LinkClicked;
            navReporting.iSPKHistory.LinkClicked += iSPKHistory_LinkClicked;
        }

        void iSPKHistory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SPKHistoryListControl SPKHistory = Bootstrapper.Resolve<SPKHistoryListControl>();
            ShowUserControl(SPKHistory);
        }

        private void iAccounting_ItemClick(object sender, ItemClickEventArgs e)
        {
            splitContainerControl.PanelVisibility = SplitPanelVisibility.Both;

            ClearNavigation();
            ClearUserControl();

            AccountingNavigationControl navAccounting = new AccountingNavigationControl();
            navAccounting.iFirstBalance.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);
            navAccounting.iManualTransaction.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);
            navAccounting.iJournalTransaction.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);
            navAccounting.iProfitLoss.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);
            navAccounting.iBalanceTotal.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);
            navAccounting.iBalanceSheet.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);
            navAccounting.iBalanceHelper.Visible = LoginInformation.IsModulAllowed(DbConstant.MODUL_ACCOUNTING);

            ShowNavigationControl(navAccounting);

            navAccounting.iFirstBalance.LinkClicked += iFirstBalance_LinkClicked;
            navAccounting.iManualTransaction.LinkClicked += iManualTransaction_LinkClicked;
            navAccounting.iJournalTransaction.LinkClicked += iJournalTransaction_LinkClicked;
            navAccounting.iProfitLoss.LinkClicked += iProfitLoss_LinkClicked;
            navAccounting.iBalanceTotal.LinkClicked += iBalanceTotal_LinkClicked;
            navAccounting.iBalanceSheet.LinkClicked += iBalanceSheet_LinkClicked;
            navAccounting.iBalanceHelper.LinkClicked += iBalanceHelper_LinkClicked;
        }

        private void iBalanceHelper_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BalanceHelperListControl balanceHelper = Bootstrapper.Resolve<BalanceHelperListControl>();
            ShowUserControl(balanceHelper);
        }

        private void iBalanceSheet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BalanceSheetControl balanceSheet = Bootstrapper.Resolve<BalanceSheetControl>();
            ShowUserControl(balanceSheet);
        }

        private void iBalanceTotal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BalanceJournalListControl balance = Bootstrapper.Resolve<BalanceJournalListControl>();
            ShowUserControl(balance);
        }

        private void iProfitLoss_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ProfitLossControl profitLoss = Bootstrapper.Resolve<ProfitLossControl>();
            ShowUserControl(profitLoss);
        }

        private void iJournalTransaction_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            JournalTransactionListControl journalTransactionList = Bootstrapper.Resolve<JournalTransactionListControl>();
            ShowUserControl(journalTransactionList);
        }

        private void iFirstBalance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FirstBalanceListControl firstBalanceList = Bootstrapper.Resolve<FirstBalanceListControl>();
            ShowUserControl(firstBalanceList);
        }

        private void iManualTransaction_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ManualTransactionListControl listManualTrans = Bootstrapper.Resolve<ManualTransactionListControl>();
            ShowUserControl(listManualTrans);
        }
    }
}