﻿using System;
using System.Reflection;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)] // initialize the log4net environment 

namespace Sample.Log4Net
{
    class Program
    {
        private static readonly ILog log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main()
        {
            log.Debug("Debug logging");
            log.Info("Info logging");
            log.Warn("Warning logging");
            log.Error("Error logging");
            log.Fatal("Fatal logging");

            bool debugEnabled = log.IsDebugEnabled;
            bool infoEnabled = log.IsInfoEnabled;
            bool warnEnabled = log.IsWarnEnabled;
            bool errorEnabled = log.IsErrorEnabled;
            bool fatalEnabled = log.IsFatalEnabled;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Log Levels Enabled:");
            Console.ResetColor();

            const string outputFormat = "\t{0}:\t{1}";

            Console.WriteLine(outputFormat, "Debug", debugEnabled);
            Console.WriteLine(outputFormat, "Info", infoEnabled);
            Console.WriteLine(outputFormat, "Warn", warnEnabled);
            Console.WriteLine(outputFormat, "Error", errorEnabled);
            Console.WriteLine(outputFormat, "Fatal", fatalEnabled);
        }
    }
}
