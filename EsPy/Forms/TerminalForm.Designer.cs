namespace EsPy.Forms
{
    partial class TerminalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

         

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClean = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnShowEol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnShowWhitespace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.osToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmSoftReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmClean = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowEOL = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowWhitespace = new System.Windows.Forms.ToolStripMenuItem();
            this.scintilla = new EsPy.Components.Terminal();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEdit,
            this.mnView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(885, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // mnEdit
            // 
            this.mnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUndo,
            this.mnRedo,
            this.toolStripMenuItem2,
            this.mnCut,
            this.mnCopy,
            this.mnPaste,
            this.mnDelete,
            this.mnClean,
            this.toolStripMenuItem3,
            this.mnSelectAll,
            this.toolStripMenuItem7});
            this.mnEdit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnEdit.Name = "mnEdit";
            this.mnEdit.Size = new System.Drawing.Size(51, 24);
            this.mnEdit.Text = "&编辑";
            // 
            // mnUndo
            // 
            this.mnUndo.Image = ((System.Drawing.Image)(resources.GetObject("mnUndo.Image")));
            this.mnUndo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnUndo.MergeIndex = 0;
            this.mnUndo.Name = "mnUndo";
            this.mnUndo.ShortcutKeyDisplayString = "Ctrl+Z";
            this.mnUndo.Size = new System.Drawing.Size(170, 26);
            this.mnUndo.Text = "撒消";
            // 
            // mnRedo
            // 
            this.mnRedo.Image = ((System.Drawing.Image)(resources.GetObject("mnRedo.Image")));
            this.mnRedo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnRedo.MergeIndex = 1;
            this.mnRedo.Name = "mnRedo";
            this.mnRedo.ShortcutKeyDisplayString = "Ctrl+Y";
            this.mnRedo.Size = new System.Drawing.Size(170, 26);
            this.mnRedo.Text = "重做";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem2.MergeIndex = 2;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // mnCut
            // 
            this.mnCut.Image = ((System.Drawing.Image)(resources.GetObject("mnCut.Image")));
            this.mnCut.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnCut.MergeIndex = 3;
            this.mnCut.Name = "mnCut";
            this.mnCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.mnCut.Size = new System.Drawing.Size(170, 26);
            this.mnCut.Text = "剪切";
            // 
            // mnCopy
            // 
            this.mnCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnCopy.Image")));
            this.mnCopy.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnCopy.MergeIndex = 4;
            this.mnCopy.Name = "mnCopy";
            this.mnCopy.ShortcutKeyDisplayString = "";
            this.mnCopy.Size = new System.Drawing.Size(170, 26);
            this.mnCopy.Text = "复制";
            // 
            // mnPaste
            // 
            this.mnPaste.Enabled = false;
            this.mnPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnPaste.Image")));
            this.mnPaste.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnPaste.MergeIndex = 5;
            this.mnPaste.Name = "mnPaste";
            this.mnPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.mnPaste.Size = new System.Drawing.Size(170, 26);
            this.mnPaste.Text = "粘贴";
            // 
            // mnDelete
            // 
            this.mnDelete.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnDelete.MergeIndex = 6;
            this.mnDelete.Name = "mnDelete";
            this.mnDelete.ShortcutKeyDisplayString = "Del";
            this.mnDelete.Size = new System.Drawing.Size(170, 26);
            this.mnDelete.Text = "删除";
            // 
            // mnClean
            // 
            this.mnClean.Image = ((System.Drawing.Image)(resources.GetObject("mnClean.Image")));
            this.mnClean.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnClean.MergeIndex = 7;
            this.mnClean.Name = "mnClean";
            this.mnClean.Size = new System.Drawing.Size(170, 26);
            this.mnClean.Text = "清屏";
            this.mnClean.Click += new System.EventHandler(this.mnClean_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem3.MergeIndex = 8;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // mnSelectAll
            // 
            this.mnSelectAll.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnSelectAll.MergeIndex = 9;
            this.mnSelectAll.Name = "mnSelectAll";
            this.mnSelectAll.ShortcutKeyDisplayString = "";
            this.mnSelectAll.Size = new System.Drawing.Size(170, 26);
            this.mnSelectAll.Text = "全部保存";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem7.MergeIndex = 10;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(167, 6);
            // 
            // mnView
            // 
            this.mnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.mnShowEol,
            this.mnShowWhitespace});
            this.mnView.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnView.Name = "mnView";
            this.mnView.Size = new System.Drawing.Size(51, 24);
            this.mnView.Text = "&显示";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(141, 6);
            // 
            // mnShowEol
            // 
            this.mnShowEol.Name = "mnShowEol";
            this.mnShowEol.Size = new System.Drawing.Size(144, 26);
            this.mnShowEol.Text = "显示换行";
            this.mnShowEol.Click += new System.EventHandler(this.mnShowEol_Click);
            // 
            // mnShowWhitespace
            // 
            this.mnShowWhitespace.Name = "mnShowWhitespace";
            this.mnShowWhitespace.Size = new System.Drawing.Size(144, 26);
            this.mnShowWhitespace.Text = "显示空格";
            this.mnShowWhitespace.Click += new System.EventHandler(this.mnShowWhitespace_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::EsPy.Properties.Resources.editclear;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.mnClean_Click);
            // 
            // osToolStripMenuItem
            // 
            this.osToolStripMenuItem.Name = "osToolStripMenuItem";
            this.osToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.osToolStripMenuItem.Text = "os";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmSoftReset,
            this.toolStripSeparator5,
            this.cmUndo,
            this.cmRedo,
            this.toolStripSeparator4,
            this.cmCut,
            this.cmCopy,
            this.cmPaste,
            this.cmDelete,
            this.cmClean,
            this.toolStripSeparator1,
            this.cmSelectAll,
            this.toolStripSeparator3,
            this.advancedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 288);
            // 
            // cmSoftReset
            // 
            this.cmSoftReset.Enabled = false;
            this.cmSoftReset.Name = "cmSoftReset";
            this.cmSoftReset.Size = new System.Drawing.Size(168, 26);
            this.cmSoftReset.Text = "软复位";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(165, 6);
            // 
            // cmUndo
            // 
            this.cmUndo.Enabled = false;
            this.cmUndo.Image = ((System.Drawing.Image)(resources.GetObject("cmUndo.Image")));
            this.cmUndo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmUndo.MergeIndex = 0;
            this.cmUndo.Name = "cmUndo";
            this.cmUndo.ShortcutKeyDisplayString = "Ctrl+Z";
            this.cmUndo.Size = new System.Drawing.Size(168, 26);
            this.cmUndo.Text = "撒消";
            this.cmUndo.Click += new System.EventHandler(this.mnUndo_Click);
            // 
            // cmRedo
            // 
            this.cmRedo.Enabled = false;
            this.cmRedo.Image = ((System.Drawing.Image)(resources.GetObject("cmRedo.Image")));
            this.cmRedo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmRedo.MergeIndex = 1;
            this.cmRedo.Name = "cmRedo";
            this.cmRedo.ShortcutKeyDisplayString = "Ctrl+Y";
            this.cmRedo.Size = new System.Drawing.Size(168, 26);
            this.cmRedo.Text = "重做";
            this.cmRedo.Click += new System.EventHandler(this.mnRedo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator4.MergeIndex = 2;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // cmCut
            // 
            this.cmCut.Enabled = false;
            this.cmCut.Image = ((System.Drawing.Image)(resources.GetObject("cmCut.Image")));
            this.cmCut.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmCut.MergeIndex = 3;
            this.cmCut.Name = "cmCut";
            this.cmCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.cmCut.Size = new System.Drawing.Size(168, 26);
            this.cmCut.Text = "剪切";
            this.cmCut.Click += new System.EventHandler(this.mnCut_Click);
            // 
            // cmCopy
            // 
            this.cmCopy.Enabled = false;
            this.cmCopy.Image = ((System.Drawing.Image)(resources.GetObject("cmCopy.Image")));
            this.cmCopy.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmCopy.MergeIndex = 4;
            this.cmCopy.Name = "cmCopy";
            this.cmCopy.ShortcutKeyDisplayString = "";
            this.cmCopy.Size = new System.Drawing.Size(168, 26);
            this.cmCopy.Text = "复制";
            this.cmCopy.Click += new System.EventHandler(this.mnCopy_Click);
            // 
            // cmPaste
            // 
            this.cmPaste.Enabled = false;
            this.cmPaste.Image = ((System.Drawing.Image)(resources.GetObject("cmPaste.Image")));
            this.cmPaste.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmPaste.MergeIndex = 5;
            this.cmPaste.Name = "cmPaste";
            this.cmPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.cmPaste.Size = new System.Drawing.Size(168, 26);
            this.cmPaste.Text = "粘贴";
            this.cmPaste.Click += new System.EventHandler(this.mnPaste_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Enabled = false;
            this.cmDelete.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmDelete.MergeIndex = 6;
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.ShortcutKeyDisplayString = "Del";
            this.cmDelete.Size = new System.Drawing.Size(168, 26);
            this.cmDelete.Text = "删除";
            this.cmDelete.Click += new System.EventHandler(this.mnDelete_Click);
            // 
            // cmClean
            // 
            this.cmClean.Image = global::EsPy.Properties.Resources.editclear;
            this.cmClean.Name = "cmClean";
            this.cmClean.Size = new System.Drawing.Size(168, 26);
            this.cmClean.Text = "清屏";
            this.cmClean.Click += new System.EventHandler(this.mnClean_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // cmSelectAll
            // 
            this.cmSelectAll.Enabled = false;
            this.cmSelectAll.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmSelectAll.MergeIndex = 8;
            this.cmSelectAll.Name = "cmSelectAll";
            this.cmSelectAll.ShortcutKeyDisplayString = "";
            this.cmSelectAll.Size = new System.Drawing.Size(168, 26);
            this.cmSelectAll.Text = "保存全部";
            this.cmSelectAll.Click += new System.EventHandler(this.mnSelectAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowEOL,
            this.cmShowWhitespace});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.advancedToolStripMenuItem.Text = "高级";
            // 
            // cmShowEOL
            // 
            this.cmShowEOL.Name = "cmShowEOL";
            this.cmShowEOL.Size = new System.Drawing.Size(144, 26);
            this.cmShowEOL.Text = "显示换行";
            this.cmShowEOL.Click += new System.EventHandler(this.mnShowEol_Click);
            // 
            // cmShowWhitespace
            // 
            this.cmShowWhitespace.Name = "cmShowWhitespace";
            this.cmShowWhitespace.Size = new System.Drawing.Size(144, 26);
            this.cmShowWhitespace.Text = "显示空格";
            this.cmShowWhitespace.Click += new System.EventHandler(this.mnShowWhitespace_Click);
            // 
            // scintilla
            // 
            this.scintilla.AutoCAutoHide = false;
            this.scintilla.AutoCChooseSingle = true;
            this.scintilla.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintilla.ContextMenuStrip = this.contextMenuStrip1;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.EolMode = ScintillaNET.Eol.Cr;
            this.scintilla.ExtraAscent = 3;
            this.scintilla.ExtraDescent = 3;
            this.scintilla.IndentationGuides = ScintillaNET.IndentView.LookForward;
            this.scintilla.IndentWidth = 4;
            this.scintilla.Lexer = ScintillaNET.Lexer.Python;
            this.scintilla.Location = new System.Drawing.Point(0, 0);
            this.scintilla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scintilla.MouseDwellTime = 500;
            this.scintilla.Name = "scintilla";
            this.scintilla.Port = null;
            this.scintilla.ReadOnly = true;
            this.scintilla.Size = new System.Drawing.Size(885, 302);
            this.scintilla.TabIndex = 2;
            this.scintilla.TabWidth = 2;
            this.scintilla.ViewWhitespace = ScintillaNET.WhitespaceMode.VisibleAlways;
            this.scintilla.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.scintilla_CharAdded);
            this.scintilla.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.terminal_UpdateUI);
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 302);
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TerminalForm";
            this.Text = "终端";
            this.Activated += new System.EventHandler(this.TerminalForm_Activated);
            this.Load += new System.EventHandler(this.TerminalForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public Components.Terminal scintilla;
        private System.Windows.Forms.ToolStripMenuItem mnEdit;
        private System.Windows.Forms.ToolStripMenuItem mnUndo;
        private System.Windows.Forms.ToolStripMenuItem mnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnCut;
        private System.Windows.Forms.ToolStripMenuItem mnCopy;
        private System.Windows.Forms.ToolStripMenuItem mnPaste;
        private System.Windows.Forms.ToolStripMenuItem mnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnClean;
        private System.Windows.Forms.ToolStripMenuItem osToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnView;
        private System.Windows.Forms.ToolStripMenuItem mnShowEol;
        private System.Windows.Forms.ToolStripMenuItem mnShowWhitespace;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmSoftReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cmUndo;
        private System.Windows.Forms.ToolStripMenuItem cmRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmCut;
        private System.Windows.Forms.ToolStripMenuItem cmCopy;
        private System.Windows.Forms.ToolStripMenuItem cmPaste;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripMenuItem cmClean;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmShowEOL;
        private System.Windows.Forms.ToolStripMenuItem cmShowWhitespace;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}