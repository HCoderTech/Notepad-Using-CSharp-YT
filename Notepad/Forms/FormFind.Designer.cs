namespace Notepad.Forms
{
    partial class FormFind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gDirection = new System.Windows.Forms.GroupBox();
            this.oDown = new System.Windows.Forms.RadioButton();
            this.oUp = new System.Windows.Forms.RadioButton();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.gDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(108, 31);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(160, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(302, 29);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(84, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gDirection
            // 
            this.gDirection.Controls.Add(this.oDown);
            this.gDirection.Controls.Add(this.oUp);
            this.gDirection.Location = new System.Drawing.Point(151, 58);
            this.gDirection.Name = "gDirection";
            this.gDirection.Size = new System.Drawing.Size(136, 57);
            this.gDirection.TabIndex = 4;
            this.gDirection.TabStop = false;
            this.gDirection.Text = "Direction";
            // 
            // oDown
            // 
            this.oDown.AutoSize = true;
            this.oDown.Location = new System.Drawing.Point(64, 20);
            this.oDown.Name = "oDown";
            this.oDown.Size = new System.Drawing.Size(53, 17);
            this.oDown.TabIndex = 1;
            this.oDown.TabStop = true;
            this.oDown.Text = "Down";
            this.oDown.UseVisualStyleBackColor = true;
            // 
            // oUp
            // 
            this.oUp.AutoSize = true;
            this.oUp.Location = new System.Drawing.Point(7, 20);
            this.oUp.Name = "oUp";
            this.oUp.Size = new System.Drawing.Size(39, 17);
            this.oUp.TabIndex = 0;
            this.oUp.TabStop = true;
            this.oUp.Text = "Up";
            this.oUp.UseVisualStyleBackColor = true;
            this.oUp.CheckedChanged += new System.EventHandler(this.oUp_CheckedChanged);
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(13, 97);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 5;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            this.chkMatchCase.CheckedChanged += new System.EventHandler(this.chkMatchCase_CheckedChanged);
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 141);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.gDirection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Name = "FormFind";
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFind_FormClosing);
            this.gDirection.ResumeLayout(false);
            this.gDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gDirection;
        private System.Windows.Forms.RadioButton oDown;
        private System.Windows.Forms.RadioButton oUp;
        private System.Windows.Forms.CheckBox chkMatchCase;
    }
}