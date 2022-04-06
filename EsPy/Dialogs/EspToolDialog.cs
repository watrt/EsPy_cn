using EsPy.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPy.Dialogs
{
    public partial class EspToolDialog : Form
    {
        string esp32flashexe = "Tools/esptool.exe";
        string esp32tool = "";
        private System.Diagnostics.Process proc;
        public EspToolDialog()
        {
            InitializeComponent();

            this.BaudRate = Properties.Settings.Default.EspToolBaud;
            this.cbBaudrate.Text = this.BaudRate.ToString();

            this.tbFirmware.Text = Properties.Settings.Default.FrimwareBin;

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            if (ports != null)
            {
                this.cbPort.Items.AddRange(ports);
            }

            //this.FlashMode.SelectedIndex = Properties.Settings.Default.EspFlashMode;
        }

        public string PortName
        {
            get
            {
                if (this.cbPort.SelectedItem != null)
                    return this.cbPort.SelectedItem.ToString();

                return "";
            }
            set
            {
                this.cbPort.Text = value;
            }
        }




        private void btnFirmware_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "firmware.bin|*.bin";
            if (this.tbFirmware.Text != "" && Directory.Exists(Path.GetDirectoryName(this.tbFirmware.Text)))
                d.InitialDirectory = Path.GetDirectoryName(this.tbFirmware.Text);

            if (d.ShowDialog() == DialogResult.OK)
            {
                this.tbFirmware.Text = d.FileName;
            }
            d.Dispose();
        }




        private string Run(string cmd, string args)
        {
            if (this.cbPort.SelectedItem == null)
            {
                Helpers.WarningBox("没有选择串口!");
                return "";
            }

            string portname = this.cbPort.SelectedItem.ToString();
            if (Utility.Helpers.PortIsOpen(portname))
            {
                Helpers.ErrorBox($"{portname} 已经打开了！");
                return "";
            }


            string res = ""; // "Please wait...\r\n";

            this.Enabled = false;
            Globals.MainForm.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                this.textBox4.Text = args + "\r\n\r\n";
                this.textBox4.Text += "请等待...\r\n\r\n";
                proc = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo inf = new System.Diagnostics.ProcessStartInfo(
                    cmd, "" + args);
                inf.RedirectStandardOutput = true;
                inf.RedirectStandardError = true;

                inf.UseShellExecute = false;
                inf.CreateNoWindow = true;

                //System.Diagnostics.Process proc = new System.Diagnostics.Process();
                //proc.OutputDataReceived += Proc_OutputDataReceived;
                //proc.ErrorDataReceived += Proc_ErrorDataReceived;
                proc.StartInfo = inf;
                proc.OutputDataReceived -= new DataReceivedEventHandler(ProcessOutDataReceived);
                proc.Start();
                proc.OutputDataReceived += new DataReceivedEventHandler(ProcessOutDataReceived);
                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();
                //res = proc.StandardOutput.ReadToEnd();
                //this.textBox4.Text = res;
                //res += proc.StandardError.ReadToEnd();
                //proc.WaitForExit();
                //while (!proc.HasExited)
                //{
                //    Thread.Sleep(100);
                //}

                //proc.Close();
                //proc.Dispose();

                //for (int i = 1; i < res.Length;)
                //{
                //    if (res[i] < 10)
                //    {
                //        res = res.Remove(i - 1, 2);
                //        i--;
                //    }
                //    else i++;
                //}

                return res;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.Enabled = true;
                Globals.MainForm.Cursor = Cursors.Default;
            }
        }

        private void ProcessOutDataReceived(object sender, DataReceivedEventArgs e)
        {
            Application.DoEvents();
            if (this.textBox4.InvokeRequired)
            {
                this.textBox4.Invoke(new Action(() =>
               {
                   this.textBox4.AppendText(e.Data + "\r\n");
               }));
            }
            else
            {
                if (textBox4.Disposing)
                {
                    this.textBox4.AppendText(e.Data + "\r\n");
                }
                
            }
        }


        //public delegate void DataReceivedEventHandler(string data);
        // private void UpdateUI(string data)
        // {
        //     if (this.InvokeRequired)
        //     {
        //         this.Invoke(new DataReceivedEventHandler(this.UpdateUI), new object[] { data });
        //     }
        //     else
        //     {
        //         if (data != null)
        //         {
        //             this.textBox4.Text = data;
        //             this.textBox4.Invalidate();
        //         }
        //     }
        // }
        // private void Proc_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        // {
        //     this.UpdateUI(e.Data);
        // }

        // private void Proc_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        // {
        //     this.UpdateUI(e.Data);
        // }

        private void btnMac_Click(object sender, EventArgs e)
        {
            if (this.CheckPaths(false))
            {
                string args = String.Format(" -p {0} -b {1} read_mac", this.PortName, this.BaudRate);
                this.textBox4.Text = this.Run(esp32flashexe, args);
            }
        }

        private void btnFlashID_Click(object sender, EventArgs e)
        {
            if (this.CheckPaths(false))
            {
                string args = String.Format(" -p {0} -b {1} flash_id", this.PortName, this.BaudRate);
                this.textBox4.Text = this.Run(esp32flashexe, args);
            }
        }

        private void btnChipID_Click(object sender, EventArgs e)
        {
            if (this.CheckPaths(false))
            {
                string args = String.Format(" -p {0} -b {1} chip_id", this.PortName, this.BaudRate);
                Console.WriteLine("", args);
                this.textBox4.Text = this.Run(esp32flashexe, args);
            }
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            if (this.CheckPaths(false))
            {
                if (MessageBox.Show("确定擦除设备?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string args = String.Format(" -p {0} -b {1} erase_flash", this.PortName, this.BaudRate);
                    this.textBox4.Text = "请等待...\r\n\r\n";
                    Application.DoEvents();
                    this.textBox4.Text += this.Run(esp32flashexe, args);
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (this.CheckPaths())
            {
                if (MessageBox.Show("你确定写入设备吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    //string args = String.Format("\"{0}\" -p {1} -b {2} write_flash --verify --flash_size=detect 0 \"{3}\"", this.esp32tool, this.PortName, this.BaudRate, this.tbFirmware.Text);
                    //string args = String.Format("\"{0}\" -p {1} -b {2} write_flash -fm {3} -ff 20m -fs detect 0x0000 \"{4}\"",
                    //    this.esp32tool,
                    //    this.PortName,
                    //    this.BaudRate,
                    //    this.FlashMode.Text,
                    //    this.tbFirmware.Text);

                    //string args = String.Format("\"{0}\" -p {1} -b {2} write_flash -fm {3} -fs detect 0x0000 \"{4}\"",
                    //    this.esp32tool,
                    //    this.PortName,
                    //    this.BaudRate,
                    //    this.FlashMode.Text,
                    //    this.tbFirmware.Text);

                    if (this.tbParams.Text.Length > 0)
                    {
                        string args = this.tbParams.Text.Replace("$PORT", this.PortName);
                        args = args.Replace("$BAUDRATE", this.BaudRate.ToString());
                        args = args.Replace("$FIRMWARE", this.tbFirmware.Text);
                        //args = " \"" + this.esp32tool + "\" " + args;

                        this.textBox4.Text = args + "\r\n\r\n";
                        this.textBox4.Text += "请等待...\r\n\r\n";

                        Application.DoEvents();
                        this.textBox4.Text += this.Run(esp32flashexe, args);
                    }

                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (this.CheckPaths())
            {
                //string args = String.Format("\"{0}\" -p \"{1}\" -b {2} verify_flash 0x40000 \"{3}\"", this.esp32tool, this.PortName, this.BaudRate, this.tbFirmware.Text);
                string args = String.Format(" -p \"{0}\" -b {1} verify_flash 0x00000 \"{2}\"", this.PortName, this.BaudRate, this.tbFirmware.Text);
                this.textBox4.Text = this.Run(esp32flashexe, args);
            }
        }

        private int BaudRate
        { get; set; }

        private bool CheckPaths(bool firmware = true)
        {
            string err = "";


            if (firmware && !File.Exists(this.tbFirmware.Text))
                err += "firmware.bin 位置不正确!\r\n";

            if (err != "")
            {
                Helpers.ErrorBox(err);
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //if (this.CheckPaths(false))
            {
                Properties.Settings.Default.PythonExe = "";
                Properties.Settings.Default.EspToolPy = this.esp32tool;
                Properties.Settings.Default.FrimwareBin = this.tbFirmware.Text;
                Properties.Settings.Default.EspToolBaud = this.BaudRate;
                Properties.Settings.Default.EspToolDeviceIndex = this.cbDevice.SelectedIndex;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cbBaudrate_Validating(object sender, CancelEventArgs e)
        {
            int baud = 0;
            if (!int.TryParse(this.cbBaudrate.Text, out baud))
            {
                this.cbBaudrate.BackColor = Color.Red;
                this.cbBaudrate.ForeColor = Color.White;
                Helpers.ErrorBox("波特率无效的值!\r\n");
                e.Cancel = true;
            }

            this.cbBaudrate.BackColor = Color.White;
            this.cbBaudrate.ForeColor = Color.Black;

            this.BaudRate = baud;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel2.Text);
        }

        private void EspToolDialog_Load(object sender, EventArgs e)
        {
            this.cbDevice.Items.Clear();
            this.tbParams.Text = "";

            Devices d = Devices.LoadFromFile(Globals.DevicesFile);
            if (d != null)
            {
                this.cbDevice.Items.AddRange(d.ToArray());
                if (this.cbDevice.Items.Count > Properties.Settings.Default.EspToolDeviceIndex)
                {
                    this.cbDevice.SelectedIndex = Properties.Settings.Default.EspToolDeviceIndex;
                }
            }
        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbDevice.SelectedItem is Device)
            {
                this.tbParams.Text = (this.cbDevice.SelectedItem as Device).Cmd;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeviceEditorDialog d = new DeviceEditorDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                int i = this.cbDevice.SelectedIndex;
                this.cbDevice.Items.Clear();
                this.tbParams.Text = "";

                Devices de = Devices.LoadFromFile(Globals.DevicesFile);
                if (de != null)
                {
                    this.cbDevice.Items.AddRange(de.ToArray());
                    if (this.cbDevice.Items.Count > i)
                    {
                        this.cbDevice.SelectedIndex = i;
                    }
                }
            }
            d.Dispose();
        }

        private void EspToolDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            string portname = this.cbPort.SelectedItem.ToString();
            if (Utility.Helpers.PortIsOpen(portname))
            {
                proc.Close();
                proc.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}