using Solid.Models.Contracts;
using Solid.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private int messegesAppended;
        public FileAppender()
        {
            messegesAppended = 0;
        }

        public FileAppender(ILayout layout, Level level, IFile file)
            :this()
        {
            Layout = layout;
            Level = level;
            File = file;
        }

        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public IFile File { get; private set; }

        public void Append(IError error)
        {
            string formattedMessage = this.File.Write(this.Layout, error) + Environment.NewLine;

            System.IO.File.AppendAllText(this.File.Path, formattedMessage);

            this.messegesAppended++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {this.messegesAppended}, File size {this.File.Size}";
        }
    }
}
