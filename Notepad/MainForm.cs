using NotepadCore;
using System.Windows.Forms;
using System;

namespace Notepad
{
    public partial class MainForm : Form
    {
        FileOperation fileOperation;
        public MainForm()
        {
            InitializeComponent();
            fileOperation = new FileOperation();
            fileOperation.InitializeNewFile();
            this.Text = fileOperation.Filename;
        }

        private void newFileMenu_Click(object sender, System.EventArgs e)
        {
            //New File Menuitem Click
            //If the file is saved Initialize new file status
            //if the file is not saved ask to save the file
            if (fileOperation.IsFileSaved)
            {
                //new file status
                fileOperation.InitializeNewFile();
                txtArea.Text = "";
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
                        fileOperation.SaveFile(fileOperation.Filename, txtArea.Lines);
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
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            fileOperation.IsFileSaved = false;
            UpdateView();
        }
    }
}
