using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Models.Contracts
{
    public interface IFile
    {
        string Path { get; }
        int Size { get; }

        string Write(ILayout layout, IError error);
    }
}
