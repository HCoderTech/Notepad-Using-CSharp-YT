﻿using NotepadCore;
using System.Windows.Forms;
using System;

namespace Notepad
{
    public partial class MainForm : Form
    {
        FileOperation fileOperation;
        EditOperation editOperation;
        Timer timer;
        public MainForm()
        {
            InitializeComponent();
            fileOperation = new FileOperation();
            editOperation = new EditOperation();
            fileOperation.InitializeNewFile();
            this.Text = fileOperation.Filename;
            timer = new Timer();
            timer.Tick += Mytimer_Tick;
            timer.Interval = 500;
            //time t1 --> My name
            //time t2 --> My name is Sara
        }

        private void Mytimer_Tick(object sender,EventArgs e)
        {
            timer.Stop();
            editOperation.Add_UndoRedo(txtArea.Text);
            UpdateView();
        }
        private void newFileMenu_Click(object sender, System.EventArgs e)
        {
            //New File Menuitem Click
            //If the file is saved Initialize new file status
            //if the file is not saved ask to save the file
            if (fileOperation.IsFileSaved)
            {
                //new file status
                txtArea.Text = "";
                fileOperation.InitializeNewFile();
                UpdateView();
            }else
            {
                DialogResult result=MessageBox.Show("Do you need save changes to " + fileOperation.Filename, "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (fileOperation.Filename.Contains("Untitled"))
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Text(*.txt)|*.txt";
                        if (newFileSave.ShowDialog() == DialogResult.OK)
                        {
                            fileOperation.SaveFile(newFileSave.FileName, txtArea.Lines);
                            UpdateView();
                        }
                    }else
                    {
                        fileOperation.SaveFile(fileOperation.FileLocation, txtArea.Lines);
                        UpdateView();
                    }

                }else if (result == DialogResult.No)
                {
                    txtArea.Text = "";
                    fileOperation.InitializeNewFile();
                    UpdateView();
                }


            }

        }

        private void UpdateView()
        {
            this.Text=!fileOperation.IsFileSaved?fileOperation.Filename+"*":fileOperation.Filename;
            undoEditMenu.Enabled = editOperation.CanUndo() ? true : false;
            redoEditMenu.Enabled = editOperation.CanRedo() ? true : false;
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            fileOperation.IsFileSaved = false;
            if (editOperation.TxtAreaTextChangeRequired)
            {
                timer.Start();
            }else
            {
                editOperation.TxtAreaTextChangeRequired = false;
            }
            UpdateView();
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt";
            openFile.InitialDirectory = "D:";
            openFile.Title = "Open File";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtArea.TextChanged -= txtArea_TextChanged;
                txtArea.Text = fileOperation.OpenFile(openFile.FileName);
                txtArea.TextChanged += txtArea_TextChanged;
                UpdateView();
            }
        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            if (!fileOperation.IsFileSaved)
            {
                if (!this.Text.Contains("Untitled.txt"))
                {
                    fileOperation.SaveFile(fileOperation.FileLocation, txtArea.Lines);
                    UpdateView();
                }else
                {
                    SaveFile();
                }
            }
        }

        private void SaveFile()
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.Filter = "Text(*.txt)|*.txt";
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                fileOperation.SaveFile(fileSave.FileName, txtArea.Lines);
                UpdateView();
            }
        }

        private void saveasFileMenu_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            cutEditMenu.Enabled = txtArea.SelectedText.Length > 0 ? true : false;
            copyEditMenu.Enabled = txtArea.SelectedText.Length > 0 ? true : false;
            pasteEditMenu.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
        }

        private void editMenu_MouseEnter(object sender, EventArgs e)
        {
            editMenu_Click(sender, e);
        }

        private void cutEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.Cut();
            pasteEditMenu.Enabled = true;
        }

        private void copyEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.Copy();
            pasteEditMenu.Enabled = true;
        }

        private void pasteEditMenu_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            txtArea.Paste();
        }

        private void selectallEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.SelectAll();
        }

        private void deleteEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.Text = txtArea.Text.Remove(txtArea.SelectionStart, txtArea.SelectionLength);
        }

        private void timedateEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.Text = txtArea.Text.Insert(txtArea.SelectionStart, editOperation.DateTime_Now());
        }

        private void undoEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.Text = editOperation.UndoClicked();
            UpdateView();
        }

        private void redoEditMenu_Click(object sender, EventArgs e)
        {
            txtArea.Text = editOperation.RedoClicked();
            UpdateView();
        }
    }
}
