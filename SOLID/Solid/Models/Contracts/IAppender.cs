using Solid.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Models.Contracts
{
   public interface IAppender
    {
        ILayout Layout { get; }

        Level Level { get; }

        void Append(IError error);
    }
}
