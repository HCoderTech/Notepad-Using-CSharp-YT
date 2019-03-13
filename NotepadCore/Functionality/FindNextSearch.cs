using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCore.Functionality
{
    public class FindNextSearch
    {
        string searchString;
        string direction;
        bool matchCase;
        string content;
        int position;
        bool success;

        public string SearchString
        {
            get
            {
                return searchString;
            }

            set
            {
                searchString = value;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }

            set
            {
                direction = value;
            }
        }

        public bool MatchCase
        {
            get
            {
                return matchCase;
            }

            set
            {
                matchCase = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public int Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public bool Success
        {
            get
            {
                return success;
            }

            set
            {
                success = value;
            }
        }
    }
}
