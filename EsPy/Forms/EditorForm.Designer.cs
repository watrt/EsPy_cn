﻿namespace EsPy.Forms
{
    partial class EditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnComment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUncommet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnShowEol = new System.Windows.Forms.ToolStripMenuItem();
            this.mnShowWhitespace = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInterrupt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFind = new System.Windows.Forms.ToolStripMenuItem();
            this.cmReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmComment = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUncomment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowEOL = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowWhitespace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.scintilla = new EsPy.Components.ExScintilla();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.mnEdit,
            this.mnView,
            this.deviceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSave,
            this.mnSaveAs});
            this.FileMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.FileMenuItem.MergeIndex = 0;
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(51, 24);
            this.FileMenuItem.Text = "&文件";
            // 
            // mnSave
            // 
            this.mnSave.Enabled = false;
            this.mnSave.Image = ((System.Drawing.Image)(resources.GetObject("mnSave.Image")));
            this.mnSave.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.mnSave.MergeIndex = 3;
            this.mnSave.Name = "mnSave";
            this.mnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnSave.Size = new System.Drawing.Size(169, 26);
            this.mnSave.Text = "保存";
            this.mnSave.Click += new System.EventHandler(this.mnSave_Click);
            // 
            // mnSaveAs
            // 
            this.mnSaveAs.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.mnSaveAs.MergeIndex = 4;
            this.mnSaveAs.Name = "mnSaveAs";
            this.mnSaveAs.Size = new System.Drawing.Size(169, 26);
            this.mnSaveAs.Text = "另存为...";
            this.mnSaveAs.Click += new System.EventHandler(this.mnSaveAs_Click);
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
            this.toolStripMenuItem3,
            this.mnSelectAll,
            this.toolStripMenuItem7,
            this.mnFind,
            this.mnReplace,
            this.toolStripMenuItem8,
            this.mnComment,
            this.mnUncommet,
            this.toolStripMenuItem6});
            this.mnEdit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnEdit.MergeIndex = 1;
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
            this.mnUndo.Size = new System.Drawing.Size(201, 26);
            this.mnUndo.Text = "撒消";
            this.mnUndo.Click += new System.EventHandler(this.mnUndo_Click);
            // 
            // mnRedo
            // 
            this.mnRedo.Image = ((System.Drawing.Image)(resources.GetObject("mnRedo.Image")));
            this.mnRedo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnRedo.MergeIndex = 1;
            this.mnRedo.Name = "mnRedo";
            this.mnRedo.ShortcutKeyDisplayString = "Ctrl+Y";
            this.mnRedo.Size = new System.Drawing.Size(201, 26);
            this.mnRedo.Text = "重做";
            this.mnRedo.Click += new System.EventHandler(this.mnRedo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem2.MergeIndex = 2;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // mnCut
            // 
            this.mnCut.Image = ((System.Drawing.Image)(resources.GetObject("mnCut.Image")));
            this.mnCut.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnCut.MergeIndex = 3;
            this.mnCut.Name = "mnCut";
            this.mnCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.mnCut.Size = new System.Drawing.Size(201, 26);
            this.mnCut.Text = "剪切";
            this.mnCut.Click += new System.EventHandler(this.mnCut_Click);
            // 
            // mnCopy
            // 
            this.mnCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnCopy.Image")));
            this.mnCopy.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnCopy.MergeIndex = 4;
            this.mnCopy.Name = "mnCopy";
            this.mnCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.mnCopy.Size = new System.Drawing.Size(201, 26);
            this.mnCopy.Text = "复制";
            this.mnCopy.Click += new System.EventHandler(this.mnCopy_Click);
            // 
            // mnPaste
            // 
            this.mnPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnPaste.Image")));
            this.mnPaste.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnPaste.MergeIndex = 5;
            this.mnPaste.Name = "mnPaste";
            this.mnPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.mnPaste.Size = new System.Drawing.Size(201, 26);
            this.mnPaste.Text = "粘贴";
            this.mnPaste.Click += new System.EventHandler(this.mnPaste_Click);
            // 
            // mnDelete
            // 
            this.mnDelete.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnDelete.MergeIndex = 6;
            this.mnDelete.Name = "mnDelete";
            this.mnDelete.ShortcutKeyDisplayString = "Del";
            this.mnDelete.Size = new System.Drawing.Size(201, 26);
            this.mnDelete.Text = "删除";
            this.mnDelete.Click += new System.EventHandler(this.mnDelete_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem3.MergeIndex = 7;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 6);
            // 
            // mnSelectAll
            // 
            this.mnSelectAll.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnSelectAll.MergeIndex = 8;
            this.mnSelectAll.Name = "mnSelectAll";
            this.mnSelectAll.ShortcutKeyDisplayString = "Ctrl+A";
            this.mnSelectAll.Size = new System.Drawing.Size(201, 26);
            this.mnSelectAll.Text = "保存全部";
            this.mnSelectAll.Click += new System.EventHandler(this.mnSelectAll_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem7.MergeIndex = 9;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(198, 6);
            // 
            // mnFind
            // 
            this.mnFind.Enabled = false;
            this.mnFind.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnFind.MergeIndex = 10;
            this.mnFind.Name = "mnFind";
            this.mnFind.ShortcutKeyDisplayString = "Ctrl+F";
            this.mnFind.Size = new System.Drawing.Size(201, 26);
            this.mnFind.Text = "查找...";
            this.mnFind.Click += new System.EventHandler(this.mnFind_Click);
            // 
            // mnReplace
            // 
            this.mnReplace.Enabled = false;
            this.mnReplace.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnReplace.MergeIndex = 11;
            this.mnReplace.Name = "mnReplace";
            this.mnReplace.ShortcutKeyDisplayString = "Ctrl+H";
            this.mnReplace.Size = new System.Drawing.Size(201, 26);
            this.mnReplace.Text = "替换...";
            this.mnReplace.Click += new System.EventHandler(this.mnReplace_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem8.MergeIndex = 12;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(198, 6);
            // 
            // mnComment
            // 
            this.mnComment.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnComment.MergeIndex = 13;
            this.mnComment.Name = "mnComment";
            this.mnComment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.mnComment.Size = new System.Drawing.Size(201, 26);
            this.mnComment.Text = "注释";
            this.mnComment.Click += new System.EventHandler(this.mnComment_Click);
            // 
            // mnUncommet
            // 
            this.mnUncommet.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnUncommet.MergeIndex = 14;
            this.mnUncommet.Name = "mnUncommet";
            this.mnUncommet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnUncommet.Size = new System.Drawing.Size(201, 26);
            this.mnUncommet.Text = "取消注释";
            this.mnUncommet.Click += new System.EventHandler(this.mnUncommet_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem6.MergeIndex = 15;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(198, 6);
            // 
            // mnView
            // 
            this.mnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnShowEol,
            this.mnShowWhitespace});
            this.mnView.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnView.MergeIndex = 0;
            this.mnView.Name = "mnView";
            this.mnView.Size = new System.Drawing.Size(51, 24);
            this.mnView.Text = "&显示";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.MergeIndex = 2;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // mnShowEol
            // 
            this.mnShowEol.MergeIndex = 3;
            this.mnShowEol.Name = "mnShowEol";
            this.mnShowEol.Size = new System.Drawing.Size(144, 26);
            this.mnShowEol.Text = "显示换行";
            this.mnShowEol.Click += new System.EventHandler(this.mnShowEOL_Click);
            // 
            // mnShowWhitespace
            // 
            this.mnShowWhitespace.MergeIndex = 4;
            this.mnShowWhitespace.Name = "mnShowWhitespace";
            this.mnShowWhitespace.Size = new System.Drawing.Size(144, 26);
            this.mnShowWhitespace.Text = "显示控格";
            this.mnShowWhitespace.Click += new System.EventHandler(this.mnShowWhitespace_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.mnRun,
            this.mnInterrupt,
            this.mnUpload});
            this.deviceToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.deviceToolStripMenuItem.Text = "设备";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem10.MergeIndex = 2;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(191, 6);
            // 
            // mnRun
            // 
            this.mnRun.Image = global::EsPy.Properties.Resources.play1;
            this.mnRun.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnRun.MergeIndex = 3;
            this.mnRun.Name = "mnRun";
            this.mnRun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnRun.Size = new System.Drawing.Size(194, 26);
            this.mnRun.Text = "运行";
            this.mnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // mnInterrupt
            // 
            this.mnInterrupt.Image = global::EsPy.Properties.Resources.pause;
            this.mnInterrupt.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnInterrupt.MergeIndex = 4;
            this.mnInterrupt.Name = "mnInterrupt";
            this.mnInterrupt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnInterrupt.Size = new System.Drawing.Size(194, 26);
            this.mnInterrupt.Text = "中断执行";
            this.mnInterrupt.Click += new System.EventHandler(this.mnInterrupt_Click);
            // 
            // mnUpload
            // 
            this.mnUpload.Image = global::EsPy.Properties.Resources.upload1;
            this.mnUpload.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnUpload.MergeIndex = 5;
            this.mnUpload.Name = "mnUpload";
            this.mnUpload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnUpload.Size = new System.Drawing.Size(194, 26);
            this.mnUpload.Text = "上传";
            this.mnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUndo,
            this.cmRedo,
            this.toolStripSeparator4,
            this.cmCut,
            this.cmCopy,
            this.cmPaste,
            this.cmDelete,
            this.cmSelectAll,
            this.cmFind,
            this.cmReplace,
            this.toolStripMenuItem4,
            this.btnHelp,
            this.toolStripMenuItem5,
            this.cmComment,
            this.cmUncomment,
            this.toolStripMenuItem9,
            this.cmShowEOL,
            this.cmShowWhitespace,
            this.ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 446);
            // 
            // cmUndo
            // 
            this.cmUndo.Enabled = false;
            this.cmUndo.Image = ((System.Drawing.Image)(resources.GetObject("cmUndo.Image")));
            this.cmUndo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmUndo.MergeIndex = 0;
            this.cmUndo.Name = "cmUndo";
            this.cmUndo.ShortcutKeyDisplayString = "Ctrl+Z";
            this.cmUndo.Size = new System.Drawing.Size(199, 26);
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
            this.cmRedo.Size = new System.Drawing.Size(199, 26);
            this.cmRedo.Text = "重做";
            this.cmRedo.Click += new System.EventHandler(this.mnRedo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator4.MergeIndex = 2;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // cmCut
            // 
            this.cmCut.Enabled = false;
            this.cmCut.Image = ((System.Drawing.Image)(resources.GetObject("cmCut.Image")));
            this.cmCut.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmCut.MergeIndex = 3;
            this.cmCut.Name = "cmCut";
            this.cmCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.cmCut.Size = new System.Drawing.Size(199, 26);
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
            this.cmCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.cmCopy.Size = new System.Drawing.Size(199, 26);
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
            this.cmPaste.Size = new System.Drawing.Size(199, 26);
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
            this.cmDelete.Size = new System.Drawing.Size(199, 26);
            this.cmDelete.Text = "删除";
            this.cmDelete.Click += new System.EventHandler(this.mnDelete_Click);
            // 
            // cmSelectAll
            // 
            this.cmSelectAll.Enabled = false;
            this.cmSelectAll.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmSelectAll.MergeIndex = 8;
            this.cmSelectAll.Name = "cmSelectAll";
            this.cmSelectAll.ShortcutKeyDisplayString = "Ctrl+A";
            this.cmSelectAll.Size = new System.Drawing.Size(199, 26);
            this.cmSelectAll.Text = "保存全部";
            this.cmSelectAll.Click += new System.EventHandler(this.mnSelectAll_Click);
            // 
            // cmFind
            // 
            this.cmFind.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmFind.MergeIndex = 10;
            this.cmFind.Name = "cmFind";
            this.cmFind.ShortcutKeyDisplayString = "Ctrl+F";
            this.cmFind.Size = new System.Drawing.Size(199, 26);
            this.cmFind.Text = "查找...";
            this.cmFind.Click += new System.EventHandler(this.mnFind_Click);
            // 
            // cmReplace
            // 
            this.cmReplace.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmReplace.MergeIndex = 11;
            this.cmReplace.Name = "cmReplace";
            this.cmReplace.ShortcutKeyDisplayString = "Ctrl+H";
            this.cmReplace.Size = new System.Drawing.Size(199, 26);
            this.cmReplace.Text = "替换...";
            this.cmReplace.Click += new System.EventHandler(this.mnReplace_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem4.MergeIndex = 12;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 6);
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnHelp.Size = new System.Drawing.Size(199, 26);
            this.btnHelp.Text = "目录";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(196, 6);
            // 
            // cmComment
            // 
            this.cmComment.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmComment.MergeIndex = 13;
            this.cmComment.Name = "cmComment";
            this.cmComment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.cmComment.Size = new System.Drawing.Size(199, 26);
            this.cmComment.Text = "注释";
            this.cmComment.Click += new System.EventHandler(this.mnComment_Click);
            // 
            // cmUncomment
            // 
            this.cmUncomment.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmUncomment.MergeIndex = 14;
            this.cmUncomment.Name = "cmUncomment";
            this.cmUncomment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.cmUncomment.Size = new System.Drawing.Size(199, 26);
            this.cmUncomment.Text = "取消注释";
            this.cmUncomment.Click += new System.EventHandler(this.mnUncommet_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem9.MergeIndex = 15;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(196, 6);
            // 
            // cmShowEOL
            // 
            this.cmShowEOL.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmShowEOL.MergeIndex = 16;
            this.cmShowEOL.Name = "cmShowEOL";
            this.cmShowEOL.Size = new System.Drawing.Size(199, 26);
            this.cmShowEOL.Text = "显示换行";
            this.cmShowEOL.Click += new System.EventHandler(this.mnShowEOL_Click);
            // 
            // cmShowWhitespace
            // 
            this.cmShowWhitespace.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cmShowWhitespace.MergeIndex = 17;
            this.cmShowWhitespace.Name = "cmShowWhitespace";
            this.cmShowWhitespace.Size = new System.Drawing.Size(199, 26);
            this.cmShowWhitespace.Text = "显示空格";
            this.cmShowWhitespace.Click += new System.EventHandler(this.mnShowWhitespace_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winToolStripMenuItem,
            this.uToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.ToolStripMenuItem.Text = "转换换行";
            // 
            // winToolStripMenuItem
            // 
            this.winToolStripMenuItem.Name = "winToolStripMenuItem";
            this.winToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.winToolStripMenuItem.Text = "windows(CRLF)";
            this.winToolStripMenuItem.Click += new System.EventHandler(this.winToolStripMenuItem_Click);
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.uToolStripMenuItem.Text = "Unix(LF)";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator2,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator3,
            this.btnRun,
            this.btnPause,
            this.toolStripSeparator5,
            this.btnUpload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(848, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.mnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator1.Visible = false;
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(36, 36);
            this.btnUndo.Text = "撒消";
            this.btnUndo.Click += new System.EventHandler(this.mnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Enabled = false;
            this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(36, 36);
            this.btnRedo.Text = "重做";
            this.btnRedo.Click += new System.EventHandler(this.mnRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator2.Visible = false;
            // 
            // btnCut
            // 
            this.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCut.Enabled = false;
            this.btnCut.Image = ((System.Drawing.Image)(resources.GetObject("btnCut.Image")));
            this.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCut.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(36, 36);
            this.btnCut.Text = "剪切";
            this.btnCut.Click += new System.EventHandler(this.mnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(36, 36);
            this.btnCopy.Text = "复制";
            this.btnCopy.Click += new System.EventHandler(this.mnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Enabled = false;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(36, 36);
            this.btnPaste.Text = "粘贴";
            this.btnPaste.Click += new System.EventHandler(this.mnPaste_Click);
            // 
            // btnRun
            // 
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Enabled = false;
            this.btnRun.Image = global::EsPy.Properties.Resources.play1;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(36, 36);
            this.btnRun.Text = "运行 ";
            this.btnRun.ToolTipText = "运行 (Ctrl+R)";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Image = global::EsPy.Properties.Resources.pause;
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(36, 36);
            this.btnPause.Text = "中断(Ctrl+I)";
            this.btnPause.Click += new System.EventHandler(this.mnInterrupt_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpload.Enabled = false;
            this.btnUpload.Image = global::EsPy.Properties.Resources.upload1;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(36, 36);
            this.btnUpload.Text = "上传";
            this.btnUpload.ToolTipText = "上传到当前位置";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // scintilla
            // 
            this.scintilla.AutoCAutoHide = false;
            this.scintilla.AutoCChooseSingle = true;
            this.scintilla.AutoCMaxHeight = 9;
            this.scintilla.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintilla.CaretLineBackColorAlpha = 128;
            this.scintilla.ContextMenuStrip = this.contextMenuStrip1;
            this.scintilla.CshowStatus = true;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.EdgeColumn = 80;
            this.scintilla.EdgeMode = ScintillaNET.EdgeMode.Line;
            this.scintilla.EolMode = ScintillaNET.Eol.Lf;
            this.scintilla.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.scintilla.IndentWidth = 4;
            this.scintilla.Lexer = ScintillaNET.Lexer.Python;
            this.scintilla.Location = new System.Drawing.Point(0, 0);
            this.scintilla.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.scintilla.MouseDwellTime = 500;
            this.scintilla.Name = "scintilla";
            this.scintilla.ScrollWidth = 1;
            this.scintilla.Size = new System.Drawing.Size(848, 302);
            this.scintilla.TabIndex = 2;
            this.scintilla.SavePointLeft += new System.EventHandler<System.EventArgs>(this.scintilla_SavePointLeft);
            this.scintilla.SavePointReached += new System.EventHandler<System.EventArgs>(this.scintilla_SavePointReached);
            this.scintilla.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.UpdateUI);
            this.scintilla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scintilla_MouseDown);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 302);
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnSaveAs;
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
        private System.Windows.Forms.ToolStripMenuItem mnFind;
        private System.Windows.Forms.ToolStripMenuItem mnReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem cmUndo;
        private System.Windows.Forms.ToolStripMenuItem cmRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmCut;
        private System.Windows.Forms.ToolStripMenuItem cmCopy;
        private System.Windows.Forms.ToolStripMenuItem cmPaste;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripMenuItem cmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem cmFind;
        private System.Windows.Forms.ToolStripMenuItem cmReplace;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public Components.ExScintilla scintilla;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripButton btnRun;
        protected System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripMenuItem mnView;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnShowEol;
        private System.Windows.Forms.ToolStripMenuItem mnShowWhitespace;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnComment;
        private System.Windows.Forms.ToolStripMenuItem mnUncommet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem cmComment;
        private System.Windows.Forms.ToolStripMenuItem cmUncomment;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem cmShowEOL;
        private System.Windows.Forms.ToolStripMenuItem cmShowWhitespace;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnRun;
        private System.Windows.Forms.ToolStripMenuItem mnUpload;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem mnInterrupt;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
    }
}