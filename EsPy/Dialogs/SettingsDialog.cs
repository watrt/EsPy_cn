using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPy.Dialogs
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            this.tbPythonPath.Text = Properties.Settings.Default.PythonExe;
            this.ShowServer.Checked = Properties.Settings.Default.ShowPyServer;
            this.cbBaudrate.Text = Properties.Settings.Default.PyBaudRate.ToString();
            this.workpath.Text = Properties.Settings.Default.Workpath;
            this.spacing.Value = Properties.Settings.Default.ExtraAscent;
            this.InsertMatchedChars.Checked = Properties.Settings.Default.InsertMatchedChars;
            this.fontsize.Value = Properties.Settings.Default.fontsize;
        }

        private void btnPythonPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "python.exe|python.exe";
            if (d.ShowDialog() == DialogResult.OK)
            {
                this.tbPythonPath.Text = d.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PythonExe = tbPythonPath.Text;
            Properties.Settings.Default.ShowPyServer = this.ShowServer.Checked;
            Properties.Settings.Default.PyBaudRate= int.Parse(cbBaudrate.Text);
            Properties.Settings.Default.Workpath = workpath.Text;
            Properties.Settings.Default.ExtraAscent = Properties.Settings.Default.ExtraDescent = int.Parse(this.spacing.Value.ToString());
            Properties.Settings.Default.InsertMatchedChars= this.InsertMatchedChars.Checked;
            Properties.Settings.Default.fontsize = int.Parse(this.fontsize.Value.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bat = Path.Combine(Application.StartupPath, "pip.bat");
            if (File.Exists(bat))
            {
                Process.Start(bat);
            }
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            

        }

        private void btnworkpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                this.workpath.Text = d.SelectedPath;
            }
        }
    }
}
