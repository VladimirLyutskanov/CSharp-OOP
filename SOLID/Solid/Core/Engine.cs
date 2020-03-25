using Solid.Factories;
using Solid.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Core
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorfactory;

        private Engine()
        {
            this.errorfactory = new ErrorFactory();
        }

        public Engine(ILogger logger) : this()
        {
            this.logger = logger;
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command!="END")
            {
                string[] errorArgs = command.Split("|").ToArray();
                string level = errorArgs[0];
                string date = errorArgs[1];
                string message = errorArgs[2];

                IError error;

                try
                {
                    error = this.errorfactory.GetError(date, level, message);
                    this.logger.Log(error);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                 
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(this.logger.ToString());
        }

    }
}
