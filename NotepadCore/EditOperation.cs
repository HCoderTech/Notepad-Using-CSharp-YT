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
    }
}
