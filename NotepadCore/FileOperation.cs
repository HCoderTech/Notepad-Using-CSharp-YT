using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCore
{
    public class FileOperation
    {
        private string filename;
        private bool isFileSaved;
        private string fileLocation;

        public string Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }

        public bool IsFileSaved
        {
            get
            {
                return isFileSaved;
            }

            set
            {
                isFileSaved = value;
            }
        }

        public string FileLocation
        {
            get
            {
                return fileLocation;
            }

            set
            {
                fileLocation = value;
            }
        }

        public void InitializeNewFile()
        {
            this.Filename = "Untitled.txt";
            this.IsFileSaved = true;
        }

        public void SaveFile(string fileLocation, string[] lines)
        {
            this.FileLocation = fileLocation;
            Stream stream = File.Open(FileLocation, FileMode.OpenOrCreate, FileAccess.Write);
            using(StreamWriter streamwriter=new StreamWriter(stream))
            {
                foreach(string line in lines)
                {
                    streamwriter.WriteLine(line);
                }
            }
            UpdateFileStatus();
        }

        public string OpenFile(string fileLocation)
        {
            string content;
            this.FileLocation = fileLocation;
            Stream stream = File.Open(fileLocation, FileMode.Open, FileAccess.ReadWrite);
            using (StreamReader streamReader = new StreamReader(stream))
            {
                content = streamReader.ReadToEnd();
            }
            UpdateFileStatus();
            return content;
        }

        private void UpdateFileStatus()
        {
            string filename = FileLocation.Substring(FileLocation.LastIndexOf("\\") + 1);
            this.Filename = filename;
            this.IsFileSaved = true;
        }
    }
}
