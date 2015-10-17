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
                XtraMessageBox.Show("Ada kesalahan pada sistem. Mohon hubungi developer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            else
            {
                // TODO
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (initStartUpResult)
            {
                this.FormClosing -= MainForm_FormClosing;
                if (XtraMessageBox.Show("Apakah anda yakin ingin menutup aplikasi?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
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

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutAppForm aboutForm = new AboutAppForm();
            aboutForm.ShowDialog(this);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

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
                Thread.Sleep(3000); // TODO: do something
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
    }
}