using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD_Assignment1
{
  public  class CustomReader
    {

        private readonly string _filePath;

        public CustomReader(string filePath)
        {
            this._filePath = filePath;
        }

        public string ReadAllText()
        {
            //var path = Path.IsPathRooted(_filePath)
            //  ? _filePath
            //  : Path.GetRelativePath(Directory.GetCurrentDirectory(), _filePath);

            //if (!File.Exists(path))
            //{
            //    throw new ArgumentException($"Could not find file at path: {path}");
            //}

            // Load the file
            var fileData = File.ReadAllText(Directory.GetCurrentDirectory()+_filePath);

            return fileData;
        }
    }
}
