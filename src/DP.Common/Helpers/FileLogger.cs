using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DP.Common.Helpers
{
    public class FileLogger
    {
        private readonly FileStream _fileStream;
        private readonly StreamWriter _streamWriter;

        // Constructor
        public FileLogger(string filename)
        {
            _fileStream = new FileStream(filename, FileMode.Create);
            _streamWriter = new StreamWriter(_fileStream);
        }

        // Member Function which is used in the Delegate
        public void LogInformational(string s)
        {
            _streamWriter.WriteLine(s);
        }

        public void Close()
        {
            _streamWriter.Close();
            _fileStream.Close();
        }
    }
}
