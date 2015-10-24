using BrawijayaWorkshop.Utils;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace BrawijayaWorkshop.Win32App
{
    static class Program
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string applicationName = ConfigurationManager.AppSettings["LoggerAppName"];
            LoggerExtensionUtils.InitLogger(applicationName);
            MethodBase.GetCurrentMethod().Info("************** " + applicationName + " - START");

            // Registering all dependency injection objects
            Boostrapper.Wire(new DependencyInjectionModul());

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.UserSkins.BonusSkins.Register();
                XtraMessageBox.AllowCustomLookAndFeel = true;
                UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

                SplashScreenManager.ShowForm(typeof(StartupScreen), true, true);

                Application.Run(new MainForm());
                MethodBase.GetCurrentMethod().Info("************** " + applicationName + " - END");
            }
            catch (Exception ex)
            {
                MethodBase.GetCurrentMethod().Error("Unable to initialize database!", ex);
                XtraMessageBoxHelper.ShowError(null, "Aplikasi error! Mohon hubungi developer.");
                //XtraMessageBox.Show(, "Startup Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.False);
                MethodBase.GetCurrentMethod().Info("************** " + applicationName + " - END");
            }
        }
    }
}