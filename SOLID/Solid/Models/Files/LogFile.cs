using Solid.Models.Contracts;
using Solid.Models.Enumerations;
using Solid.Models.IOManagement;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Solid.Models.Files
{
    class LogFile : IFile
    {
        private const string currentDirectory = "\\logs\\";
        private const string currentFile = "log.txt";
        private const string dateFormat = "M/dd/yyyy h:mm:ss tt";

        private string currentPath;
        private IIOManager IOManager;
        public LogFile()
        {
            this.IOManager = new IOManager(currentDirectory, currentFile);
            this.currentPath = this.IOManager.GetCurrentPath();
            this.IOManager.ConfirmDirectoryAndFileExist();
            this.Path = currentPath + currentDirectory + currentFile;
        }
        public string Path { get  ; private set; }

        public int Size => GetFileSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedMessage = String.Format(format, dateTime
                .ToString(dateFormat, CultureInfo.InvariantCulture)
                , level.ToString()
                , message);
            return formattedMessage;
        }

        private int GetFileSize()
        {
            string text = File.ReadAllText(this.Path);
            int size = text.ToCharArray()
                .Where(c => Char.IsLetter(c))
                .Sum(c => (int)c);
            return size;
        }
               
    }
}
