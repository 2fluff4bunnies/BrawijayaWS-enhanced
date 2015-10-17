﻿using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Utils;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace BrawijayaWorkshop.Win32App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Registering all dependency injection objects
            //Boostrapper.Wire(new ApplicationModule());

            try
            {
                // Initialize Database
                //new BrawijayaWorkshopDbInitializer().InitializeDatabase(new BrawijayaWorkshopDbContext());
                MethodBase.GetCurrentMethod().Info("Initialize database");
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Error("Unable to initialize database!", ex);
                if (XtraMessageBox.Show("An error occured at startup. Please contact developer!", "Startup Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.False) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            XtraMessageBox.AllowCustomLookAndFeel = true;
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            SplashScreenManager.ShowForm(typeof(StartupScreen), true, true);

            Application.Run(new MainForm());
        }
    }
}