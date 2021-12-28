using EsPy.Dialogs;
using EsPy.Forms;
using EsPy.Units;
using EsPy.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EsPy
{
    public partial class MainForm : Form, IDeviceChange
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        IntPtr ClipboardViewer;

        FileSystemWatcher FileSystemWatcher = null;
        public string devuceid = "123456789";
        private DeserializeDockContent deserializeDockContent;
        public TerminalForm TerminalForm = null;
        public yunfile yunfile = null;
        //public ErrorListForm ErrorListForm = null;
        public MainForm()
        {
            InitializeComponent();
            Globals.MainForm = this;

            //Globals.PyClientStart();

            AutoScaleMode = AutoScaleMode.Dpi;

            this.Text = Application.ProductName + " " + Application.ProductVersion;
            this.SetSchema(this, null);

            ClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);


            this.FileSystemWatcher = new FileSystemWatcher();
            this.FileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite 
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            //this.FileSystemWatcher.Filter = "*.py";

            //// Add event handlers.
            //this.FileSystemWatcher.Changed += FileSystemWatcher_Changed;
            //this.FileSystemWatcher.Created += FileSystemWatcher_Changed;
            //this.FileSystemWatcher.Deleted += FileSystemWatcher_Changed;
            //this.FileSystemWatcher.Renamed += FileSystemWatcher_Changed;

            //// Begin watching.
            //this.FileSystemWatcher.EnableRaisingEvents = true;

            this.AllowDrop = true;
            
            this.DragEnter += MainForm_DragEnter;
            this.DragDrop += MainForm_DragDrop;
            this.DragOver += MainForm_DragOver;
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
        
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    string[] files = (string[])data;
                    foreach (string file in files)
                    {
                        IDocument doc = this.OpenFromFile(file, EditorForm.EditorFileFormats);
                        if (doc != null)
                        {
                            (doc as DockContent).Show(this.dockPanel1);
                        }
                    }
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if (e.Effect == DragDropEffects.Copy)
                {

                }
                else if (e.Effect == DragDropEffects.Move)
                {

                }
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (EditorForm.EditorFileFormats.Find(Path.GetExtension(file)) != null)
                        e.Effect = DragDropEffects.All;
                    else e.Effect = DragDropEffects.None;
                }
                return;
            }
            //else if (e.Data.GetDataPresent(DataFormats.Text))
            //{
            //    e.Effect = DragDropEffects.All;
            //}
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            foreach (IDocument doc in Application.OpenForms)
            {
                if (doc is IDocument && (doc as IDocument).FileName == e.FullPath)
                {

                    if (e.ChangeType == WatcherChangeTypes.Changed)
                    {
                        if (MessageBox.Show($"{e.FullPath}\r\n\r\n文件被修改!\r\n是否重新载入?", "重载", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            (doc as IDocument).LoadFromFile(e.FullPath);
                        }
                    }
                }
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;
            const int WM_DEVICECHANGE = 0x219;
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(ClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == ClipboardViewer)
                        ClipboardViewer = m.LParam;
                    else
                        SendMessage(ClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                case WM_DEVICECHANGE:
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is IDeviceChange)
                        {
                            (form as IDeviceChange).UpdateDevices();
                        }
                    }
                    this.UpdateDevices();

                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        public void UpdateDevices()
        {
           this.mnDevice.HideDropDown();
            if (!this.ComportIsExists)
            {
                this.Port = null;
                this.btnConnect.Enabled =
                    this.mnFileManager.Enabled =
                    this.btnDisconnect.Enabled =
                    this.btnReset.Enabled =
                    this.btnFileManager.Enabled = false;

            }
            else
            {
                this.mnPorts.Enabled = true;
                this.btnConnect.Enabled = true;
            }
            this.mnPorts.Enabled = true;
        }

        private void DisplayClipboardData()
        {
            try
            {
                IDataObject iData = new DataObject();
                iData = System.Windows.Forms.Clipboard.GetDataObject();

                if (this.dockPanel1.ActiveDocument != null && this.dockPanel1.ActiveDocument is IDocument)
                {
                    IDocument doc = this.dockPanel1.ActiveDocument as IDocument;
                    doc.CanPaste = iData.GetDataPresent(DataFormats.Text); //&& doc.CanPaste;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private string DockPanelConfigFile
        { get { return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config"); } }

        private string CurretPortName
        {
            get { return Properties.Settings.Default.PortName; }
            set
            {
                Properties.Settings.Default.PortName = value ?? "";
                this.toolStripStatusLabel2.Text = value ?? "未知";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.TerminalForm.PortOpen += TerminalForm_PortOpen;
            //this.TerminalForm.PortClose += TerminalForm_PortClose;

            string configFile = this.DockPanelConfigFile;
            if (!File.Exists(configFile))
            {

            }
            else
            {
                try
                {
                    deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
                    dockPanel1.LoadFromXml(configFile, this.deserializeDockContent);
                    
                }
                catch (Exception ex)
                {
                    Helpers.ErrorBox(ex.Message + "\r\n\r\n"+ "请重新启动程序!");
                    this.TerminalForm.Close();
                    this.Close();
                    return;
                }
            }

            this.CurretPortName = Properties.Settings.Default.PortName;

            if (this.TerminalForm == null)
            {
                this.TerminalForm = new TerminalForm();
                this.TerminalForm.Show(this.dockPanel1,DockState.DockBottom);
            }
            if (this.yunfile == null)
            {
                this.yunfile = new yunfile();
                this.yunfile.Show(this.dockPanel1, DockState.DockLeft);
            }
            //
            //if (!this.ComportIsExists)
            //{
            //    this.btnConnect.Enabled = false;
            //    MessageBox.Show($"Serialport \"{this.CurretPortName}\" does not exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
               this.btnConnect.Enabled = true;
            //}
            this.UpdateUI();
            //打开关联文件
            string command = Environment.CommandLine;//获取进程命令行参数
            string[] para = command.Split('\"');

            if (para.Length > 3)
            {
                string pathC = para[3];//获取打开的文件的路径
                //下面就可以自己编写代码使用这个pathC参数了
                //FileStream fs = new FileStream(pathC, FileMode.Open, FileAccess.Read);
                FileFormats ff = EditorForm.EditorFileFormats;
                OpenFromFile(pathC, ff);
                MessageBox.Show(pathC);
            }

        }

       
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<IDocument> docs = new List<IDocument>();
            List<string> files = new List<string>();
            
            foreach (DockContent dc in this.dockPanel1.Documents)
            {
                if (dc is IDocument)
                {
                    IDocument d = dc as IDocument;
                    if (d.Modified)
                    {
                        if(d.FileName == null || d.Modified)
                        {
                            docs.Add(d);
                            files.Add(d.FileName ?? "New");
                        }
                    }
                }
            }

            if (docs.Count > 0)
            {
                FileSavesDialog d = new FileSavesDialog();
                d.listBox1.Items.AddRange(files.ToArray());
                DialogResult res = d.ShowDialog();
                
                if (res == DialogResult.Yes)
                {
                    foreach (IDocument dd in docs)
                    {
                        dd.Save();
                    }
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }

            string configFile = this.DockPanelConfigFile;
            dockPanel1.SaveAsXml(configFile);        

            Properties.Settings.Default.Save();

            if (this.Port != null)
            {
                try
                {
                    this.Port.Close();
                    this.Port = null;
                }
                catch(Exception ex)
                {
                    Helpers.ErrorBox(ex);
                }
            }

            //if (Globals.PyClient != null)
            //    Globals.PyClient.Stop();
        }

        private bool CanConnect
        {
            get
            {
                return !String.IsNullOrEmpty(this.CurretPortName);
            }
        }

        private void UpdateUI()
        {
  
            this.mnTerminal.Enabled = this.TerminalForm == null;
            this.yunfileToolStripMenuItem.Enabled = this.yunfile == null;
            //this.JediState.Text = Globals.PyClient != null ? "Connected" : "Not connected";
        }

        private void SetSchema(object sender, System.EventArgs e)
        {
            
            if (true)
            {
                this.dockPanel1.Theme = this.vS2015BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2008, vS2015BlueTheme1);
            }      

            if (dockPanel1.Theme.ColorPalette != null)
            {
                statusStrip1.BackColor = dockPanel1.Theme.ColorPalette.MainWindowStatusBarDefault.Background;
                statusStrip1.ForeColor = dockPanel1.Theme.ColorPalette.MainWindowStatusBarDefault.HighlightText;
            }
        }

        private void EnableVSRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme)
        {
            visualStudioToolStripExtender1.SetStyle(menuStrip1, version, theme);
            visualStudioToolStripExtender1.SetStyle(toolStrip1, version, theme);
            visualStudioToolStripExtender1.SetStyle(statusStrip1, version, theme);
        }

        private void mnTerminal_Click(object sender, EventArgs e)
        {
            if (this.TerminalForm == null)
                this.TerminalForm = new TerminalForm();

            this.TerminalForm.Show(this.dockPanel1);
            this.UpdateUI();
        }

        private void yunfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.yunfile == null)
            {
                this.yunfile = new yunfile();
            }
            this.yunfile.Show(this.dockPanel1);
            this.UpdateUI();
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            string[] items = persistString.Split(',');

            persistString = items[0];

            if (persistString == typeof(TerminalForm).ToString())
            {
                if (this.TerminalForm != null)
                    return this.TerminalForm;
                this.TerminalForm = new TerminalForm();
                this.TerminalForm.IsHidden = false;
                if(this.TerminalForm.DockState == DockState.Document)
                    this.TerminalForm.DockState = DockState.DockRight;
                return this.TerminalForm;
            }

            //else if (persistString == typeof(ErrorListForm).ToString())
            //{
            //    if (this.ErrorListForm != null)
            //        return this.ErrorListForm;
            //    this.ErrorListForm = new ErrorListForm();
            //    this.ErrorListForm.IsHidden = false;
            //    return this.ErrorListForm;
            //}

            else if (persistString == typeof(EditorForm).ToString())
            {
                if (items.Length == 3 && File.Exists(items[1]))
                {                    
                    if (this.FindDocument(items[1]) == null)
                    {
                        EditorForm editor = new EditorForm(this);
                        editor.LoadFromFile(items[1]);                   
                        editor.scintilla.GotoPosition(int.Parse(items[2]));
                        editor.scintilla.SetSavePoint();
                        editor.IsHidden = false;
                        editor.Focus();
                        return editor;
                    }
                    return null;
                }
                else return null;
            }
            return null;
        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(this.menuStrip1);
            ToolStripManager.RevertMerge(this.toolStrip1);
            if (this.dockPanel1.ActiveContent != null)
            {
                if (this.dockPanel1.ActiveContent is IForm)
                {
                    IForm form = this.dockPanel1.ActiveContent as IForm;
                    if (form.ToolStrip != null)
                        ToolStripManager.Merge(form.ToolStrip, this.toolStrip1);
                    if (form.MenuStrip != null)
                        ToolStripManager.Merge(form.MenuStrip, this.menuStrip1);
                }
            }
            this.UpdateUI();
        }

        private void dockPanel1_ActiveDocumentChanged(object sender, EventArgs e)
        {
            if (this.dockPanel1.ActiveContent is IDocument)
            {
                IDocument doc = this.dockPanel1.ActiveDocument as IDocument;
                doc.CanPaste = Clipboard.ContainsText();
                this.FilePath.Text = doc.FileName;
                //doc.UpdateUI();
            }
            else
            {
                this.FilePath.Text = "";
            }
            this.UpdateUI();
        }
        
       public IDocument FindDocument(string fname)
        {
            foreach (DockContent dc in this.dockPanel1.Documents)
            {
                if (dc is IDocument)
                {
                    if ((dc as IDocument).FileName == fname)
                        return dc as IDocument;
                }
            }
            return null;
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            FileFormats ff = EditorForm.EditorFileFormats;
            IDocument[] items = this.OpenFromFile(ff);
            if (items != null)
            {
                foreach (DockContent item in items)
                {
                    item.Show(this.dockPanel1);
                }
            }
        }

        public IDocument OpenFromFile(string path, FileFormats file_formats)
        {
            string ext = Path.GetExtension(path).ToLower();
            foreach (FileFormat format in file_formats)
            {
                string[] items = format.Filter.Split('|')[1].Split(';');

                foreach (string item in items)
                {
                    if (item.Remove(0, 1) == ext)
                    {
                        foreach (DockContent dc in this.dockPanel1.Documents)
                        {
                            if (dc is IDocument)
                            {
                                IDocument d = dc as IDocument;
                                if (d.FileName == path)
                                {
                                    if (MessageBox.Show($"{path} 已经打开!\r\n\r\n是否要重新加载它?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        d.LoadFromFile(path);
                                        return d;
                                    }
                                }
                            }
                        }
                        IDocument doc = (IDocument)Activator.CreateInstance(format.EditorType, new object[] { this });
                        doc.LoadFromFile(path);
                        return doc;
                    }
                }
            }
            return null;
        }

        public IDocument[] OpenFromFile(FileFormats file_formats)
        {
            List<IDocument> list = new List<IDocument>();
            OpenFileDialog d = new OpenFileDialog();
            d.DefaultExt = file_formats.DefaultExt;
            d.Filter = file_formats.Filters;
            //d.FilterIndex = file_formats.Count;
            d.Multiselect = true;

            if (d.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in d.FileNames)
                {
                    IDocument item = null;
                    try
                    {
                        item = OpenFromFile(path, file_formats);
                        if (item != null)
                        {
                            list.Add(item);
                        }

                    }
                    catch(Exception)
                    {
                        if (item != null && item is IDisposable)
                        {
                            (item as IDisposable).Dispose();
                        }
                        item = null;
                    }
                }
                return list.ToArray();
            }
            return null;
        }

        private void NewFile(FileFormat ff)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.DefaultExt = ff.DefaultExt;
            d.Filter = ff.Filter;
            if (d.ShowDialog() == DialogResult.OK)
            {
                IDocument doc = this.FindDocument(d.FileName);
                if (doc != null)
                {

                }
                else
                {
                    doc = (IDocument)Activator.CreateInstance(ff.EditorType, new object[] { this });
                }
                File.WriteAllText(d.FileName, "");
                doc.LoadFromFile(d.FileName);
                (doc as DockContent).Show(this.dockPanel1);
            }
        }

        private void mnNewPython_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.Python);
        }

        private void mnNewHtml_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.Html);
        }

        private void mnNewCss_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.Css);
        }

        private void mnNewJs_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.Js);
        }

        private void mnNewJson_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.Json);
        }

        private void mnNewTxt_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.Txt);
        }

        private void mnNewOther_Click(object sender, EventArgs e)
        {
            NewFile(FileFormat.All);
        }

        private PySerial FPort = null;

        public PySerial Port
        {
            get { return this.FPort; }
            private set
            {
                if (this.FPort != null)
                {
                   // if(this.Port.IsOpen)
                        this.Port.Close();

                    this.FPort.PortOpen -= Port_PortOpen;
                    this.FPort.PortClose -= Port_PortClose;
                    this.FPort.DataReceived -= Port_DataReceived;
                    this.FPort.ErrorReceived -= Port_ErrorReceived;
                    this.FPort.PortBusy -= Port_PortBusy;
                    this.FPort.PortFree -= Port_PortFree;

                    foreach (DockContent dc in this.dockPanel1.Contents)
                    {
                        if (dc is IPort)
                        {
                            (dc as IPort).Port = null;
                        }
                    }
                    this.FPort = null;
                }

                this.FPort = value;
                if (this.FPort != null)
                {
                    if (this.FPort is SerialPort)
                    {
                        this.FPort.PortName = this.CurretPortName;
                        this.FPort.PortOpen += Port_PortOpen;
                        this.FPort.PortClose += Port_PortClose;
                        this.FPort.DataReceived += Port_DataReceived;
                        this.FPort.ErrorReceived += Port_ErrorReceived;
                        this.FPort.PortBusy += Port_PortBusy;
                        this.FPort.PortFree += Port_PortFree;
                    }
                    else
                    {
                        //Websocket
                    }

                    foreach (DockContent dc in this.dockPanel1.Contents)
                    {
                        if (dc is IPort)
                        {
                            (dc as IPort).Port = this.Port;
                        }
                    }
                }
            }
        }

        private Color ColorFree = Color.FromArgb(255, 0, 122, 204);
        private Color ColorBusy = Color.DarkOrange;

        private delegate void UpdateStatusEvent(bool busy);
        public void UpdateBusy(bool busy)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateStatusEvent(UpdateBusy), new object[] { busy });
            }
            else
            {
                if(busy)
                    this.statusStrip1.BackColor = this.ColorBusy;
                else this.statusStrip1.BackColor = this.ColorFree;

                this.mnFileManager.Enabled =
                    this.btnFileManager.Enabled = !busy;
            }
        }

        private void Port_PortFree(object sender, EventArgs e)
        {
            this.UpdateBusy(false);
        }

        private void Port_PortBusy(object sender, EventArgs e)
        {
            this.UpdateBusy(true);
           // this.UpdateBusy(false);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!CanConnect)
            {
                Helpers.ErrorBox("连接错误！");
                return;
            }

            if (!this.ComportIsExists)
            {
                //this.btnConnect.Enabled = false;
                MessageBox.Show($"串口 \"{this.CurretPortName}\" 不存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
                {
                this.Port = new PySerial();
                this.Port.BaudRate = Properties.Settings.Default.PyBaudRate;
                this.Port.LineSeparator = "\r\n"; // Properties.Settings.Default.PyPortLineSeparator;
                this.Port.WriteTimeout = Properties.Settings.Default.PyPortWriteTimeout;
                this.Port.ReadTimeout = Properties.Settings.Default.PyPortReadTmeout;
                this.Port.Open();
            }
            catch (Exception ex)
            {
                this.Port = null;
                Helpers.ErrorBox(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (this.Port != null)
            {
                try
                {
                    this.Port.Close();
                }
                catch (Exception ex)
                {
                    Helpers.ErrorBox(ex);
                }
                finally
                {
                    this.Port = null;
                }
            }
        }

        private void Port_ErrorReceived(object sender, string data)
        {
        }

        private void Port_DataReceived(object sender, string data)
        {
        }

        private void Port_PortOpen(object sender, EventArgs e)
        {
            this.mnPorts.Enabled = 
                this.btnConnect.Enabled = false;

            this.mnFileManager.Enabled =
               this.btnFileManager.Enabled =
                this.btnReset.Enabled =
                this.btnDisconnect.Enabled = true;
        }

        private void Port_PortClose(object sender, EventArgs e)
        {
            this.mnPorts.Enabled =
                this.btnConnect.Enabled = true;

            this.mnFileManager.Enabled =
               this.btnFileManager.Enabled =
                this.btnReset.Enabled =
                this.btnDisconnect.Enabled = false;

            this.statusStrip1.BackColor = this.ColorFree;
        }
      
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Port.SoftReset();
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            if (this.dockPanel1.ActiveContent is IDocument)
            {
                (this.dockPanel1.ActiveContent as IDocument).Save();
            }
        }

        private void mnSaveAs_Click(object sender, EventArgs e)
        {
            if (this.dockPanel1.ActiveContent is IDocument)
            {
                (this.dockPanel1.ActiveContent as IDocument).SaveAs();
            }
        }

        private void mnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DockContent dc in this.dockPanel1.Documents)
            {
                if (dc is IDocument)
                {
                    IDocument d = dc as IDocument;
                    if (d.Modified)
                    {
                        d.Save();
                    }
                }
            }
        }

        private void mnDevice_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripItem mi in this.mnPorts.DropDownItems)
            {
                if(mi is ToolStripMenuItem)
                    mi.Click -= Port_Click;
            }
            mnPorts.DropDownItems.Clear();
            mnPorts.DropDownItems.Clear();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            if (ports != null && ports.Length > 0)
            {
                foreach (string port in ports)
                {
                    ToolStripMenuItem mi = new ToolStripMenuItem();
                    mi.Text = port;
                    mi.Tag = port;
                    mi.Click += Port_Click;
                    if (this.CurretPortName != null && this.CurretPortName == port)
                    {
                        mi.Checked = true;
                    }
                    this.mnPorts.DropDownItems.Add(mi);
                }
            }
            else
            {
                ToolStripMenuItem mi = new ToolStripMenuItem();
                mi.Text = "空";
                mi.Enabled = false;
                this.mnPorts.DropDownItems.Add(mi);
            }
            //this.mnEspTool.Enabled = this.Port == null && this.ComportIsExists;
        }

        private bool ComportIsExists
        {
            get
            {
                foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
                {
                    if (this.CurretPortName == port)
                        return true;
                }
                return false;
            }
        }

        private void Port_Click(object sender, EventArgs e)
        {
            this.CurretPortName = (sender as ToolStripMenuItem).Tag.ToString();
            this.btnConnect.Enabled = this.ComportIsExists;
            this.UpdateUI();
        }

        public void btnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DockContent dc in this.dockPanel1.Documents)
            {
                if (dc is IDocument)
                {
                    IDocument doc = dc as IDocument;
                    if (doc.CanSave && doc.Modified)
                    {
                        doc.Save();
                    }
                }
            }
        }

        private void btnView_DropDownOpening(object sender, EventArgs e)
        {
            this.mnTerminal.Enabled = this.TerminalForm.DockState == DockState.Hidden;
            this.yunfileToolStripMenuItem.Enabled = this.yunfile.DockState == DockState.Hidden;
        }

        private void mnViewHelp_Click(object sender, EventArgs e)
        {
            
            string p = Path.Combine(Application.StartupPath, "Helps", "help.html");
            if (File.Exists(p))
                System.Diagnostics.Process.Start(p);
            else MessageBox.Show("找不到帮助文件!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mnWebREPL_Click(object sender, EventArgs e)
        {
            string p = Path.Combine(Application.StartupPath, "Tools", "webrepl", "webrepl.html");
            if (File.Exists(p))
                System.Diagnostics.Process.Start(p);
            else MessageBox.Show("帮助文件不出口!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnFlashing_Click(object sender, EventArgs e)
        {
            if (this.ComportIsExists)
            {
                EspToolDialog d = new EspToolDialog();
                d.PortName = this.CurretPortName;
                d.ShowDialog();
                d.Dispose();
            }
            else
            {
                MessageBox.Show("请选择通信串口端口！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnFileManager_Click(object sender, EventArgs e)
        {
            if (this.Port != null)
            {
                Globals.Terminal.Locked = true;
                this.Port.Sync(true);
                this.Port.Clean();
                PyFileManager d = new PyFileManager();
                d.Port = this.Port;
                d.ShowDialog();
                if (d.Pyfile != null)
                {
                    IDocument doc = this.OpenFromFile(d.Pyfile, EditorForm.EditorFileFormats);
                    if (doc != null)
                    {
                        (doc as DockContent).Show(this.dockPanel1);
                    }
                }
                d.Dispose();
                this.Port.Clean();
                this.Port.Sync(false);
                Globals.Terminal.Locked = false;
            }
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {
            About s = new About();
            s.ShowDialog();
            s.Dispose();

            //AboutDialog d = new AboutDialog();
            //d.ShowDialog();
            //d.Dispose();
        }

        //private void mnErrorList_Click(object sender, EventArgs e)
        //{
        //    if (this.ErrorListForm != null)
        //        this.ErrorListForm.Show(this.dockPanel1);
        //}

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            //UIChangedEventArgs ee = new UIChangedEventArgs();

            //ee.ChangedReson = UIChangedEventArgs.UIChangedReasons.FocusLost;

            //lock (this)
            //{
            //    foreach (DockContent dc in this.dockPanel1.Contents)
            //    {
            //        if (dc is IForm)
            //        {
            //            (dc as IForm).UIStateChanged(this, ee);
            //        }
            //    }
            //}
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDialog d = new SettingsDialog();
            d.ShowDialog();
            d.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ePS8266ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://docs.micropython.org/en/latest/esp32/quickref.html");
        }

        private void mnOpenFileFolder_Click(object sender, EventArgs e)
        {
            if (this.dockPanel1.ActiveDocument != null && this.dockPanel1.ActiveDocument is IDocument)
            {
                IDocument d = this.dockPanel1.ActiveDocument as IDocument;
                System.Diagnostics.Process.Start("explorer.exe", $"/select, \"{d.FileName}\"");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            mnOpenFileFolder.Enabled = this.dockPanel1.ActiveDocument != null && this.dockPanel1.ActiveDocument is IDocument;
        }

        private void btnTerminalClear_Click(object sender, EventArgs e)
        {
            if (this.TerminalForm != null)
            {
                this.TerminalForm.scintilla.Clean();
            }
        }

        private void myblog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.付坤.中国");
        }

        private void MainForm_DragDrop_1(object sender, DragEventArgs e)
        {
            MessageBox.Show("开发中...");
        }

        private void MainForm_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //更新例程
            Console.Write(post("http://www.xb6.cn/tools/code/randname.php"));
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //更新补全
            string keywords = post("http://www.xb6.cn/tools/espy_cn/keywords.php");
            if (keywords.Length > 10)
            {
                Properties.Settings.Default.keywords = keywords;
                MessageBox.Show("更新补全完成", "成功");
            }
            
        }
        private string post(string url,string postdate="")
        {
            postdate = this.devuceid + "&" + postdate;
            try
            {
                //获取提交的字节
                byte[] bs = Encoding.UTF8.GetBytes(postdate);
                //设置提交的相关参数
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = bs.Length;
                //提交请求数据
                Stream reqStream = req.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
                //接收返回的页面，必须的，不能省略
                WebResponse wr = req.GetResponse();
                System.IO.Stream respStream = wr.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(respStream, System.Text.Encoding.GetEncoding("utf-8"));
                string t = reader.ReadToEnd();
                wr.Close();
                return t;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("失败","获取失败");
                return "";
            }
        }
        private static string HttpDownloadFile(string url, string path)
        {
            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();

            //创建本地文件写入流
            Stream stream = new FileStream(path, FileMode.Create);

            byte[] bArr = new byte[1024];
            int size = responseStream.Read(bArr, 0, (int)bArr.Length);
            while (size > 0)
            {
                stream.Write(bArr, 0, size);
                size = responseStream.Read(bArr, 0, (int)bArr.Length);
            }
            stream.Close();
            responseStream.Close();
            return path;
        }

    }
}
