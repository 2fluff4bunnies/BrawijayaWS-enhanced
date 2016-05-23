using BrawijayaWorkshop.Model.Mappers;
using BrawijayaWorkshop.Utils;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            string assName = System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location);
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, assName);
            try
            {
                if (mutex.WaitOne(0, false))
                {
                    // Run the application
                    string applicationName = ConfigurationManager.AppSettings["LoggerAppName"];
                    LoggerExtensionUtils.InitLogger(applicationName);
                    LoggerExtensionUtils.FromEmail = ConfigurationManager.AppSettings["MailFrom"].Decrypt();
                    LoggerExtensionUtils.DeveloperEmail = ConfigurationManager.AppSettings["MailDeveloper"].Decrypt();

                    MethodBase.GetCurrentMethod().Info("************** " + applicationName + " - START");

                    // Registering all dependency injection objects
                    Bootstrapper.Wire(new DependencyInjectionModul());

                    // Configure AutoMapper
                    AutoMapperConfiguration.Configure();

                    try
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);

                        DevExpress.Skins.SkinManager.EnableFormSkins();
                        DevExpress.UserSkins.BonusSkins.Register();
                        XtraMessageBox.AllowCustomLookAndFeel = true;
                        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

                        SplashScreenManager.ShowForm(typeof(StartupScreen), true, true);

                        Application.Run(FormHelpers.CurrentMainForm);
                        MethodBase.GetCurrentMethod().Info("************** " + applicationName + " - END");
                    }
                    catch (Exception ex)
                    {
                        MethodBase.GetCurrentMethod().Error("Unable to initialize database!", ex);
                        XtraMessageBoxHelper.ShowError(null, "Aplikasi error! Mohon hubungi developer.");
                        MethodBase.GetCurrentMethod().Info("************** " + applicationName + " - END");
                    }
                }
                else
                {
                    MessageBox.Show("Aplikasi MIS Brawijaya sudah berjalan", "Pemberitahuan");
                }
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }
        }
    }
}