﻿using log4net;
using System;
using System.Configuration;
using System.Reflection;

namespace BrawijayaWorkshop.Utils
{
    /// <summary>
    /// Logger Extension
    /// </summary>
    public static class LoggerExtensionUtils
    {
        private const string LOGFORMAT = "{0}: {1}";
        private static ILog _log;

        static LoggerExtensionUtils()
        {
            _log = LogManager.GetLogger(ConfigurationManager.AppSettings["LoggerAppName"]);
        }

        public static void Error(this MethodBase method, string message)
        {
            method.Error(message, null);
        }

        public static void Error(this MethodBase method, string message, Exception exception)
        {
            _log.Error(string.Format(LOGFORMAT, method.Name, message), exception);
        }

        public static void Debug(this MethodBase method, string message)
        {
            _log.Debug(string.Format(LOGFORMAT, method.Name, message));
        }

        public static void Info(this MethodBase method, string message)
        {
            _log.Info(string.Format(LOGFORMAT, method.Name, message));
        }

        public static void Fatal(this MethodBase method, string message)
        {
            method.Fatal(message, null);
        }

        public static void Fatal(this MethodBase method, string message, Exception exception)
        {
            _log.Fatal(string.Format(LOGFORMAT, method.Name, message), exception);
        }
    }
}
