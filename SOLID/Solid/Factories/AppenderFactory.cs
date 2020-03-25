using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Solid.Models.Appenders;
using Solid.Models.Contracts;
using Solid.Models.Enumerations;
using Solid.Models.Files;


namespace Solid.Factories
{
    public class AppenderFactory
    {
        private LayoutFactory layoutFactory;

        public AppenderFactory()
        {
            this.layoutFactory = new LayoutFactory();  
        }
        public IAppender GetAppender(string appenderType, string layoutType, string levelSrt)
        {
            Level level;

            bool hasParsed = Enum.TryParse<Level>(levelSrt, out level);

            if (!hasParsed)
            {
               throw new InvalidOperationException("Invalid Layout Type!");
            }

            ILayout layout = this.layoutFactory.GetLayout(layoutType);

            IAppender appender;

            if (appenderType == "ConsoleAppender")
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if(appenderType == "FileAppender")
            {
                IFile file = new LogFile();

                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new ArgumentException("Invalid Appender Type!");
            }
            return appender;

        }
    }
}
