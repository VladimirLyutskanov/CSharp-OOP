using Solid.Models.Contracts;
using Solid.Models.Enumerations;
using Solid.Models.Errors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Solid.Factories
{
    public class ErrorFactory
    {
        private const string dateFormat = "M/dd/yyyy h:mm:ss tt";
        public IError GetError(string dateString, string levelstring, string message)
        {
            Level level;
            bool hasParsed = Enum.TryParse<Level>(levelstring, out level);

            if (!hasParsed)
            {
                throw new InvalidOperationException("Invalid Type!");
            }
            DateTime dateTime = DateTime.Now;

            try
            {
                dateTime = DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid DateTime format!", ex);
            }
            return new Error(dateTime, message, level);
        }
    }
}
