using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Appender;
using log4net.Core;

namespace CustomAppender
{
    public class MessageBoxAppender : RollingFileAppender
    {
        protected override void AdjustFileBeforeAppend()
        {
            
            base.AdjustFileBeforeAppend();
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            base.Append(loggingEvent);
        }

        protected override void Append(LoggingEvent[] loggingEvents)
        {
            base.Append(loggingEvents);
        }

        //protected override void Append(LoggingEvent loggingEvent)
        //{
        //    string title = $"{loggingEvent.Level.DisplayName} {loggingEvent.LoggerName}";
        //    string message = string.Format(
        //        "{0}{1}{1}{2}{1}{1}(Yes to continue, No to debug)",
        //        RenderLoggingEvent(loggingEvent),
        //        Environment.NewLine,
        //        loggingEvent.LocationInformation.FullInfo);
        //}
    }
}
