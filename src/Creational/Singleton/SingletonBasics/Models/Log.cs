using System;
using System.IO;
using System.Text;

namespace SingletonBasics.Models
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> instance
            = new Lazy<Log>(() => new Log());

        private Log()
        { }

        public static Log GetInstance
        {
            get { return instance.Value; }
        }

        public void LogException(string message)
        {
            string fileName = string.Format("Exception ... {0} .log", DateTime.Now.ToFileTime());
            string logFilePaths = string.Format(@"D:\PROGRAMING\MY PROJECTS\Design Patterns\ExceptionLogging\{0}", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*', 20));
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(logFilePaths));
            using (StreamWriter writer = new StreamWriter(mStrm))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }

        public void LogSomething(string message)
        {
            throw new NotImplementedException();
        }
    }
}
