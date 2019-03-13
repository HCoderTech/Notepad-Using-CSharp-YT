using NotepadCore;
using NotepadCore.Functionality;
using System;

using System.Windows.Forms;

namespace Notepad.Forms
{
    public partial class FormFind : Form
    {
        MainForm mainForm;
        EditOperation editOpertion;
        FindNextSearch qry = new FindNextSearch();

        public RichTextBox Editor { get; internal set; }

        public FindNextSearch Qry
        {
            get
            {
                return qry;
            }

            set
            {
                qry = value;
            }
        }

        public FormFind(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            oDown.Checked = true;
            btnFindNext.Enabled = false;
            editOpertion = mainForm.EditOperation;
            qry.Success = false;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            btnFindNext.Enabled = (txtFind.Text.Length > 0) ? true : false;
            UpdateSearchQuery();
        }

        public void UpdateSearchQuery()
        {
            qry.SearchString = txtFind.Text;
            qry.Direction = oUp.Checked ? "UP" : "DOWN";
            qry.MatchCase = chkMatchCase.Checked;
            qry.Content = Editor.Text;
            qry.Position = Editor.SelectionStart;
        }

        private void chkMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchQuery();
        }

        private void oUp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchQuery();
        }

        private void FormFind_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            UpdateSearchQuery();
            FindNextResult result = editOpertion.FindNext(qry);
            if (result.SearchStatus)
                Editor.Select(result.SelectionStart, txtFind.Text.Length);
        }
    }
}
