namespace Notepad
{
    partial class MainForm
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
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.findnextEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectallEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timedateEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordwrapFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbarViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewhelpHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutnotepadHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.statusContent = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menubar.SuspendLayout();
            this.statusContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.viewMenu,
            this.viewhelpHelpMenu});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(748, 24);
            this.menubar.TabIndex = 0;
            this.menubar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu,
            this.saveFileMenu,
            this.saveasFileMenu,
            this.toolStripSeparator1,
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newFileMenu
            // 
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenu.Size = new System.Drawing.Size(155, 22);
            this.newFileMenu.Text = "New";
            this.newFileMenu.Click += new System.EventHandler(this.newFileMenu_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(155, 22);
            this.openFileMenu.Text = "Open...";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(155, 22);
            this.saveFileMenu.Text = "Save";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // saveasFileMenu
            // 
            this.saveasFileMenu.Name = "saveasFileMenu";
            this.saveasFileMenu.Size = new System.Drawing.Size(155, 22);
            this.saveasFileMenu.Text = "Save As...";
            this.saveasFileMenu.Click += new System.EventHandler(this.saveasFileMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(155, 22);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoEditMenu,
            this.toolStripSeparator3,
            this.cutEditMenu,
            this.copyEditMenu,
            this.pasteEditMenu,
            this.deleteEditMenu,
            this.toolStripSeparator4,
            this.findEditMenu,
            this.findnextEditMenu,
            this.replaceEditMenu,
            this.gotoEditMenu,
            this.toolStripSeparator5,
            this.selectallEditMenu,
            this.timedateEditMenu,
            this.redoEditMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            this.editMenu.MouseEnter += new System.EventHandler(this.editMenu_MouseEnter);
            // 
            // undoEditMenu
            // 
            this.undoEditMenu.Enabled = false;
            this.undoEditMenu.Name = "undoEditMenu";
            this.undoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoEditMenu.Size = new System.Drawing.Size(174, 22);
            this.undoEditMenu.Text = "Undo";
            this.undoEditMenu.Click += new System.EventHandler(this.undoEditMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // cutEditMenu
            // 
            this.cutEditMenu.Enabled = false;
            this.cutEditMenu.Name = "cutEditMenu";
            this.cutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutEditMenu.Size = new System.Drawing.Size(174, 22);
            this.cutEditMenu.Text = "Cut";
            this.cutEditMenu.Click += new System.EventHandler(this.cutEditMenu_Click);
            // 
            // copyEditMenu
            // 
            this.copyEditMenu.Enabled = false;
            this.copyEditMenu.Name = "copyEditMenu";
            this.copyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyEditMenu.Size = new System.Drawing.Size(174, 22);
            this.copyEditMenu.Text = "Copy";
            this.copyEditMenu.Click += new System.EventHandler(this.copyEditMenu_Click);
            // 
            // pasteEditMenu
            // 
            this.pasteEditMenu.Enabled = false;
            this.pasteEditMenu.Name = "pasteEditMenu";
            this.pasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteEditMenu.Size = new System.Drawing.Size(174, 22);
            this.pasteEditMenu.Text = "Paste";
            this.pasteEditMenu.Click += new System.EventHandler(this.pasteEditMenu_Click);
            // 
            // deleteEditMenu
            // 
            this.deleteEditMenu.Name = "deleteEditMenu";
            this.deleteEditMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteEditMenu.Size = new System.Drawing.Size(174, 22);
            this.deleteEditMenu.Text = "Delete";
            this.deleteEditMenu.Click += new System.EventHandler(this.deleteEditMenu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // findEditMenu
            // 
            this.findEditMenu.Name = "findEditMenu";
            this.findEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findEditMenu.Size = new System.Drawing.Size(174, 22);
            this.findEditMenu.Text = "Find...";
            this.findEditMenu.Click += new System.EventHandler(this.findEditMenu_Click);
            // 
            // findnextEditMenu
            // 
            this.findnextEditMenu.Name = "findnextEditMenu";
            this.findnextEditMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findnextEditMenu.Size = new System.Drawing.Size(174, 22);
            this.findnextEditMenu.Text = "Find Next";
            this.findnextEditMenu.Click += new System.EventHandler(this.findnextEditMenu_Click);
            // 
            // replaceEditMenu
            // 
            this.replaceEditMenu.Name = "replaceEditMenu";
            this.replaceEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceEditMenu.Size = new System.Drawing.Size(174, 22);
            this.replaceEditMenu.Text = "Replace...";
            this.replaceEditMenu.Click += new System.EventHandler(this.replaceEditMenu_Click);
            // 
            // gotoEditMenu
            // 
            this.gotoEditMenu.Name = "gotoEditMenu";
            this.gotoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gotoEditMenu.Size = new System.Drawing.Size(174, 22);
            this.gotoEditMenu.Text = "Go To...";
            this.gotoEditMenu.Click += new System.EventHandler(this.gotoEditMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(171, 6);
            // 
            // selectallEditMenu
            // 
            this.selectallEditMenu.Name = "selectallEditMenu";
            this.selectallEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectallEditMenu.Size = new System.Drawing.Size(174, 22);
            this.selectallEditMenu.Text = "Select All";
            this.selectallEditMenu.Click += new System.EventHandler(this.selectallEditMenu_Click);
            // 
            // timedateEditMenu
            // 
            this.timedateEditMenu.Name = "timedateEditMenu";
            this.timedateEditMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timedateEditMenu.Size = new System.Drawing.Size(174, 22);
            this.timedateEditMenu.Text = "Time/Date";
            this.timedateEditMenu.Click += new System.EventHandler(this.timedateEditMenu_Click);
            // 
            // redoEditMenu
            // 
            this.redoEditMenu.Enabled = false;
            this.redoEditMenu.Name = "redoEditMenu";
            this.redoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoEditMenu.Size = new System.Drawing.Size(174, 22);
            this.redoEditMenu.Text = "Redo";
            this.redoEditMenu.Click += new System.EventHandler(this.redoEditMenu_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordwrapFormatMenu,
            this.fontFormatMenu});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(57, 20);
            this.formatMenu.Text = "Format";
            // 
            // wordwrapFormatMenu
            // 
            this.wordwrapFormatMenu.CheckOnClick = true;
            this.wordwrapFormatMenu.Name = "wordwrapFormatMenu";
            this.wordwrapFormatMenu.Size = new System.Drawing.Size(134, 22);
            this.wordwrapFormatMenu.Text = "Word Wrap";
            this.wordwrapFormatMenu.CheckedChanged += new System.EventHandler(this.wordwrapFormatMenu_CheckedChanged);
            // 
            // fontFormatMenu
            // 
            this.fontFormatMenu.Name = "fontFormatMenu";
            this.fontFormatMenu.Size = new System.Drawing.Size(134, 22);
            this.fontFormatMenu.Text = "Font...";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbarViewMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "View";
            // 
            // statusbarViewMenu
            // 
            this.statusbarViewMenu.CheckOnClick = true;
            this.statusbarViewMenu.Name = "statusbarViewMenu";
            this.statusbarViewMenu.Size = new System.Drawing.Size(126, 22);
            this.statusbarViewMenu.Text = "Status Bar";
            this.statusbarViewMenu.CheckedChanged += new System.EventHandler(this.statusbarViewMenu_CheckedChanged);
            // 
            // viewhelpHelpMenu
            // 
            this.viewhelpHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutnotepadHelpMenu});
            this.viewhelpHelpMenu.Name = "viewhelpHelpMenu";
            this.viewhelpHelpMenu.Size = new System.Drawing.Size(44, 20);
            this.viewhelpHelpMenu.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutnotepadHelpMenu
            // 
            this.aboutnotepadHelpMenu.Name = "aboutnotepadHelpMenu";
            this.aboutnotepadHelpMenu.Size = new System.Drawing.Size(156, 22);
            this.aboutnotepadHelpMenu.Text = "About Notepad";
            // 
            // txtArea
            // 
            this.txtArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArea.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(0, 24);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(748, 387);
            this.txtArea.TabIndex = 1;
            this.txtArea.Text = "";
            this.txtArea.SelectionChanged += new System.EventHandler(this.txtArea_SelectionChanged);
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // statusContent
            // 
            this.statusContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusContent.Location = new System.Drawing.Point(0, 389);
            this.statusContent.Name = "statusContent";
            this.statusContent.Size = new System.Drawing.Size(748, 22);
            this.statusContent.TabIndex = 2;
            this.statusContent.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(62, 17);
            this.status.Text = "Ln 1, Col 1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 411);
            this.Controls.Add(this.statusContent);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.Name = "MainForm";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.statusContent.ResumeLayout(false);
            this.statusContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveasFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewhelpHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem undoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem cutEditMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEditMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteEditMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteEditMenu;
        private System.Windows.Forms.ToolStripMenuItem findEditMenu;
        private System.Windows.Forms.ToolStripMenuItem findnextEditMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceEditMenu;
        private System.Windows.Forms.ToolStripMenuItem gotoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem selectallEditMenu;
        private System.Windows.Forms.ToolStripMenuItem timedateEditMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem wordwrapFormatMenu;
        private System.Windows.Forms.ToolStripMenuItem fontFormatMenu;
        private System.Windows.Forms.ToolStripMenuItem statusbarViewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutnotepadHelpMenu;
        private System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.ToolStripMenuItem redoEditMenu;
        private System.Windows.Forms.StatusStrip statusContent;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

