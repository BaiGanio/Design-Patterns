using System;
using System.IO;

namespace DataSaviour
{
    // Concrete components provide default implementations for the
    // operations. There might be several variations of these
    // classes in a program.
    class LocalFileDataSource : IDataSource
    {
        private readonly string _docPath =
             Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public LocalFileDataSource(string file) 
        {
            _docPath += $"\\{file}";
        }

        public string ReadData()
        {
            return File.ReadAllText(_docPath);
        }

        public void WriteData(string data)
        {
            /* Will overwrite the text in the existing file. If the file doesn't exist, it will create it. */
            //File.WriteAllText(_docPath, data);
            /* Add text to existing file */
            File.AppendAllText(_docPath, data + Environment.NewLine);
        }
    }
}
