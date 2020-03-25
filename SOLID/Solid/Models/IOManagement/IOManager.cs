using Solid.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solid.Models.IOManagement
{
    public class IOManager : IIOManager
    {
        private string currentPath;
        private string currentDirectory;
        private string currentFile;
        public IOManager()
        {
            this.currentPath = this.GetCurrentPath();
        }
        public IOManager(string currentDirectory, string currentFile)
            :this()
        {
            this.currentDirectory = currentDirectory;
            this.currentFile = currentFile;
        }
        public string CurrentDirectoryPath => this.currentPath + this.currentDirectory;

        public string CurrentFilePath => this.CurrentDirectoryPath + this.currentFile;

        public void ConfirmDirectoryAndFileExist()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath))
            {
                Directory.CreateDirectory(CurrentDirectoryPath);
            }
            File.WriteAllText(this.CurrentFilePath, "");
        }

        public string GetCurrentPath()
        {
           return Directory.GetCurrentDirectory();
        }
    }
}
