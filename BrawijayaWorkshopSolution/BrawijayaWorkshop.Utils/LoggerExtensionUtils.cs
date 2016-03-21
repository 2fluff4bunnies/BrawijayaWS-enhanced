using log4net;
using System;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace BrawijayaWorkshop.Utils
{
    /// <summary>
    /// Logger Extension
    /// </summary>
    public static class LoggerExtensionUtils
    {
        private static string _appName;
        private const string LOGFORMAT = "{0}: {1}";
        private static ILog _log;
        private static bool _isSendErrorToDeveloper;
        private const string EMAIL_SUBJECT_ERROR = "[{0}] Error Notification";
        private const string EMAIL_SUBJECT_FATALERROR = "[{0}] Fatal Error Notification";
        private static string _errorEmailSubject;
        private static string _fatalErrorEmailSubject;

        public static string FromEmail { get; set; }
        /// <summary>
        /// Get or Set Email Destination, using separator (,) if multiple
        /// </summary>
        public static string DeveloperEmail { get; set; }

        public static void InitLogger(string appName)
        {
            _appName = appName;
            _errorEmailSubject = string.Format(EMAIL_SUBJECT_ERROR, appName);
            _fatalErrorEmailSubject = string.Format(EMAIL_SUBJECT_FATALERROR, appName);
            _log = LogManager.GetLogger(appName);
            _isSendErrorToDeveloper = ConfigurationManager.AppSettings["SendErrorEmail"].AsBoolean();
        }

        public static void Error(this MethodBase method, string message)
        {
            method.Error(message, null);
        }

        public static void Error(this MethodBase method, string message, Exception exception)
        {
            string errorMessage = string.Format(LOGFORMAT, method.GetMethodFullName(), message);
            _log.Error(errorMessage, exception);
            //SendErrorToDeveloper(false, errorMessage, exception);
        }

        public static void Debug(this MethodBase method, string message)
        {
            _log.Debug(string.Format(LOGFORMAT, method.GetMethodFullName(), message));
        }

        public static void Info(this MethodBase method, string message)
        {
            _log.Info(string.Format(LOGFORMAT, method.GetMethodFullName(), message));
        }

        public static void Fatal(this MethodBase method, string message)
        {
            method.Fatal(message, null);
        }

        public static void Fatal(this MethodBase method, string message, Exception exception)
        {
            string errorMessage = string.Format(LOGFORMAT, method.GetMethodFullName(), message);
            _log.Fatal(errorMessage, exception);
            //SendErrorToDeveloper(true, errorMessage, exception);
        }

        private static string GetMethodFullName(this MethodBase method)
        {
            string methodName = method.Name;
            string className = method.ReflectedType.Name;

            return className + "." + methodName;
        }

        private static string GenerateErrorMessage(string errorMessage, Exception exception)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(errorMessage);
            if(exception != null)
            {
                sb.AppendLine("Original Error: " + exception.Message);
                sb.AppendLine("Source: " + exception.Source);
                sb.AppendLine("Stack Trace: " + exception.StackTrace);

                string innerExceptionMessage = GenerateInnerExceptionMessage(exception.InnerException);
                if(innerExceptionMessage.Length > 0)
                {
                    sb.AppendLine(innerExceptionMessage);
                }
            }

            return sb.ToString();
        }

        private static string GenerateInnerExceptionMessage(Exception innerException)
        {
            if(innerException != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Original Error: " + innerException.Message);
                sb.AppendLine("Source: " + innerException.Source);
                sb.AppendLine("Stack Trace: " + innerException.StackTrace);

                string innerExceptionMessage = GenerateInnerExceptionMessage(innerException.InnerException);
                if(innerExceptionMessage.Length > 0)
                {
                    sb.AppendLine(innerExceptionMessage);
                }

                return sb.ToString();
            }

            return string.Empty;
        }

        private static void SendErrorToDeveloper(bool isFatal, string errorMessage, Exception exception)
        {
            if (_isSendErrorToDeveloper)
            {
                try
                {
                    string emailSubject = _errorEmailSubject;
                    if (isFatal)
                    {
                        emailSubject = _fatalErrorEmailSubject;
                    }
                    string body = EmailTemplates.ErrorNotification.Replace(SimpleEmailConstants.MAIL_TEMPLATE_APPNAME, _appName)
                        .Replace(SimpleEmailConstants.MAIL_TEMPLATE_ERRORCONTENT, GenerateErrorMessage(errorMessage, exception));
                    SimpleEmailSenderUtils.SendEmail(emailSubject, body,
                        DeveloperEmail, FromEmail, string.Empty, string.Empty, string.Empty);
                }
                catch (Exception ex)
                {
                    _log.Warn("Unable to send error email to developer.", ex);
                }
            }
        }
    }
}
