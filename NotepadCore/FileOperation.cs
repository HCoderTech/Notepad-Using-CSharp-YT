using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCore
{
    public class FileOperation
    {
        private string filename;
        private bool isFileSaved;

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

        public void InitializeNewFile()
        {
            this.Filename = "Untitled.txt";
            this.IsFileSaved = true;
        }

        public void SaveFile(string fileName, string[] lines)
        {

        }
    }
}
