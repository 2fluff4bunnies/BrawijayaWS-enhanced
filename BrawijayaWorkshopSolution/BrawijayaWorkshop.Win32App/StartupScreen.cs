using DevExpress.XtraSplashScreen;
using System;

namespace BrawijayaWorkshop.Win32App
{
    public partial class StartupScreen : SplashScreen
    {
        public StartupScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            switch ((SplashScreenCommand)cmd)
            {
                case SplashScreenCommand.Initialize:
                    labelControl2.Text = "Initializing...";
                    break;
                case SplashScreenCommand.CheckDatabaseConnection:
                    labelControl2.Text = "Checking database connection...";
                    break;
                case SplashScreenCommand.Finish:
                    labelControl2.Text = "Complete";
                    break;
                case SplashScreenCommand.Abort:
                    labelControl2.Text = "An error occured while trying to starting application.";
                    break;
            }
        }

        #endregion

        public enum SplashScreenCommand
        {
            Initialize,
            CheckDatabaseConnection,
            Finish,
            Abort
        }
    }
}