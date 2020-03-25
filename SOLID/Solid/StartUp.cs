using Solid.Core;
using Solid.Factories;
using Solid.Models;
using Solid.Models.Contracts;
using Solid.Models.Layouts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Solid
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            ICollection<IAppender> appenders = new List<IAppender>();
            AppenderFactory appenderFactory = new AppenderFactory();

            ReadAppendersDara(count, appenders, appenderFactory);

            ILogger logger = new Logger(appenders);

            Engine engine = new Engine(logger);
            engine.Run();
        }

        private static void ReadAppendersDara(int count, ICollection<IAppender> appenders, AppenderFactory appenderFactory)
        {
            for (int i = 0; i < count; i++)
            {
                string[] appendersInfo = Console.ReadLine().Split().ToArray();
                string appenderType = appendersInfo[0];
                string layouttype = appendersInfo[1];
                string levelStr = "INFO";

                if (appendersInfo.Length==3)
                {
                    levelStr = appendersInfo[2];
                }

                IAppender appender=null;
                
                try
                {
                    appender = appenderFactory.GetAppender(appenderType, layouttype, levelStr);

                    appenders.Add(appender);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                    
                }  

            }
        }
    }
}
