using Solid.Models.Contracts;
using Solid.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Models.Errors
{
    public class Error : IError
    {
        public Error(DateTime dateTime, string message, Level level = Level.INFO)
        {
            DateTime = dateTime;
            Message = message;
            Level = level;
        }

        public DateTime DateTime { get; }

        public string Message { get; }

        public Level Level { get; }
    }
}
