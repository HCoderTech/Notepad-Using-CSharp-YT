using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.Forms
{
    public partial class FormReplace : Form
    {

      

        public FormReplace()
        {
            InitializeComponent();
        }

        private void FormReplace_Load(object sender, EventArgs e)
        {
           
        }

       

        private void DisableButtons()
        {
            if (txtFind.Text.Length == 0)
            {
                btnFind.Enabled =btnReplace.Enabled=btnReplaceAll.Enabled= false;
            }else
            {
                btnFind.Enabled = btnReplace.Enabled = btnReplaceAll.Enabled = true;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            DisableButtons();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
           
        }
    }
}
