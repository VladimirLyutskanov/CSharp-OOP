using Solid.Models.Enumerations;
using System;

namespace Solid.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }

        Level Level { get; }
    }
}
