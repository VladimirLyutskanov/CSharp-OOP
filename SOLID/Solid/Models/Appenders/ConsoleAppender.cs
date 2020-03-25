using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Solid.Models.Contracts;
using Solid.Models.Enumerations;

namespace Solid.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private const string dateFormat = "M/dd/yyyy h:mm:ss tt";
        private int messagesAppended;
        public ConsoleAppender()
        {
            messagesAppended = 0;
        }
        public ConsoleAppender(ILayout layout, Level level)
        {
            this.Layout = layout;
            this.Level = level;
        }
        public ILayout Layout { get; }

        public Level Level { get; private set; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;
            DateTime dateTime = error.DateTime;
            Level level = error.Level;
            string message = error.Message;

            string formattedMessage = String.Format(format, dateTime
                .ToString(dateFormat, CultureInfo.InvariantCulture)
                , level.ToString()
                , message);

            Console.WriteLine(formattedMessage);
            messagesAppended++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {this.messagesAppended}";
        }
    }
}
