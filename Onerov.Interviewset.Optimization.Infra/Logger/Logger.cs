using System;
using System.Globalization;
using System.IO;

namespace Onerov.Interviewset.Optimization.Infra.Logger
{
    public class Logger<T> : ILogger<T> where T : class
    {
        private const string LogFilePath = @"c:\logfile\corp\applications\category5";

        private readonly string serviceName;

        public Logger()
        {
            this.serviceName = typeof(T).Name;
        }

        public void Log(string log)
        {
            var logFile = new FileStream(
                GetFilePath(),
                FileMode.OpenOrCreate,
                FileAccess.Write);
            var streamWriter = new StreamWriter(logFile);
            string line = $"{DateTime.UtcNow.ToString(CultureInfo.InvariantCulture)};{log}";
            streamWriter.WriteLine(line);
            streamWriter.Flush();
            logFile.Close();
        }

        private string GetFilePath()
        {
            return @$"{LogFilePath}\{serviceName}.log";
        }
    }
}