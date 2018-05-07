using NotepadCore.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadCore
{
    public class EditOperation
    {
        private UndoRedoClass data;
        private bool txtAreaTextChangeRequired=true;
        public EditOperation()
        {
            data = new UndoRedoClass();
        }

        public bool TxtAreaTextChangeRequired
        {
            get
            {
                return txtAreaTextChangeRequired;
            }

            set
            {
                txtAreaTextChangeRequired = value;
            }
        }

        public string DateTime_Now()
        {
            return DateTime.Now.ToString();
        }

        public string UndoClicked()
        {
            TxtAreaTextChangeRequired = false;
            return data.Undo();
        }

        public string RedoClicked()
        {
            TxtAreaTextChangeRequired = false;
            return data.Redo();
        }

        public void Add_UndoRedo(string item)
        {
            data.AddItem(item);
        }

        public bool CanUndo()
        {
            return data.CanUndo();
        }

        public bool CanRedo()
        {
            return data.CanRedo();
        }

        public FindNextResult FindNext(FindNextSearch search)
        {
            FindNextResult result = new FindNextResult();
            int position=-1;
            StringComparison s = search.MatchCase ? StringComparison.CurrentCulture :
                StringComparison.CurrentCultureIgnoreCase;
            if (search.Direction == "UP")
            {
                position = search.Content.Substring(0, search.Position)
                    .LastIndexOf(search.SearchString, s);
                search.Success = position >= 0 ? true : false;
                result.SearchStatus = search.Success;
            }else
            {
                int start = search.Success ? search.Position + search.SearchString.Length :
                    search.Position;
                position = start + search.Content
                    .Substring(start, search.Content.Length - start)
                    .IndexOf(search.SearchString, s);
                search.Success = position - start >= 0 ? true : false;
                result.SearchStatus = search.Success;
            }
            result.SelectionStart = result.SearchStatus ? position : -1;
            return result;
        }
    }
}
