using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Models.Contracts
{
    public interface IIOManager
    {
        string CurrentDirectoryPath { get; }

        string CurrentFilePath { get; }

        void ConfirmDirectoryAndFileExist();

        string GetCurrentPath();
    }
}
