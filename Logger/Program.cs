using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net.Appender;
using log4net.Core;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Logger
{
    public class AppenderKu : AppenderSkeleton
    {
        List<LoggingEvent> eventsList = new List<LoggingEvent>();
        protected override void Append(LoggingEvent loggingEvent)
        {
            eventsList.Add(loggingEvent);
        }

        public void close()
        {
            
        }
        

        protected new bool RequiresLayout()
        {
            return false;
        }
    }

    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            while (true)
            {
                log.Error("This is error");
                log.Info("heyy");
                Thread.Sleep(5000);
            }
        }
    }
}
