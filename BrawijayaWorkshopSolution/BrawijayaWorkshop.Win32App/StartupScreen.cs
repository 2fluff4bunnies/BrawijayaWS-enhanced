using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;

namespace BrawijayaWorkshop.Win32App
{
    public partial class StartupScreen : SplashScreen
    {
        public StartupScreen()
        {
            InitializeComponent();

            lblTitle.Parent = pictureEdit2;
            lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Text = AssemblyTitle;
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
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