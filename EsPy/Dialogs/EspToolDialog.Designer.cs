namespace EsPy.Dialogs
{
    partial class EspToolDialog
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
            this.tbPython = new System.Windows.Forms.TextBox();
            this.btnPython = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEsptool = new System.Windows.Forms.TextBox();
            this.btnEsptool = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirmware = new System.Windows.Forms.TextBox();
            this.btnFirmware = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbParams = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMac = new System.Windows.Forms.Button();
            this.btnFlashID = new System.Windows.Forms.Button();
            this.btnChipID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "python.exe";
            // 
            // tbPython
            // 
            this.tbPython.Location = new System.Drawing.Point(100, 53);
            this.tbPython.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPython.Name = "tbPython";
            this.tbPython.Size = new System.Drawing.Size(668, 25);
            this.tbPython.TabIndex = 2;
            // 
            // btnPython
            // 
            this.btnPython.Location = new System.Drawing.Point(777, 51);
            this.btnPython.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(31, 27);
            this.btnPython.TabIndex = 3;
            this.btnPython.Text = "...";
            this.btnPython.UseVisualStyleBackColor = true;
            this.btnPython.Click += new System.EventHandler(this.btnPython_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "esptool.py";
            // 
            // tbEsptool
            // 
            this.tbEsptool.Location = new System.Drawing.Point(100, 83);
            this.tbEsptool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEsptool.Name = "tbEsptool";
            this.tbEsptool.Size = new System.Drawing.Size(668, 25);
            this.tbEsptool.TabIndex = 4;
            // 
            // btnEsptool
            // 
            this.btnEsptool.Location = new System.Drawing.Point(777, 81);
            this.btnEsptool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEsptool.Name = "btnEsptool";
            this.btnEsptool.Size = new System.Drawing.Size(31, 27);
            this.btnEsptool.TabIndex = 5;
            this.btnEsptool.Text = "...";
            this.btnEsptool.UseVisualStyleBackColor = true;
            this.btnEsptool.Click += new System.EventHandler(this.btnEsptool_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "固件位置：";
            // 
            // tbFirmware
            // 
            this.tbFirmware.Location = new System.Drawing.Point(100, 136);
            this.tbFirmware.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFirmware.Name = "tbFirmware";
            this.tbFirmware.Size = new System.Drawing.Size(668, 25);
            this.tbFirmware.TabIndex = 6;
            // 
            // btnFirmware
            // 
            this.btnFirmware.Location = new System.Drawing.Point(777, 134);
            this.btnFirmware.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFirmware.Name = "btnFirmware";
            this.btnFirmware.Size = new System.Drawing.Size(31, 27);
            this.btnFirmware.TabIndex = 7;
            this.btnFirmware.Text = "...";
            this.btnFirmware.UseVisualStyleBackColor = true;
            this.btnFirmware.Click += new System.EventHandler(this.btnFirmware_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(16, 315);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(815, 237);
            this.textBox4.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnErase.Location = new System.Drawing.Point(485, 561);
            this.btnErase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(180, 27);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "1. 擦除...";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWrite.Location = new System.Drawing.Point(667, 560);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(165, 27);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "2. 写入...";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(640, 608);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "确定";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(748, 608);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::EsPy.Properties.Resources.eraseflash1;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label4.Size = new System.Drawing.Size(848, 53);
            this.label4.TabIndex = 10;
            this.label4.Text = "         ESP固件下载工具";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbParams);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbDevice);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPython);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEsptool);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFirmware);
            this.groupBox1.Controls.Add(this.btnPython);
            this.groupBox1.Controls.Add(this.btnEsptool);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnFirmware);
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(816, 240);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label11
            // 
            this.label11.Image = global::EsPy.Properties.Resources.info;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(620, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 27);
            this.label11.TabIndex = 20;
            this.label11.Text = "       编辑你的设备";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbParams
            // 
            this.tbParams.Location = new System.Drawing.Point(100, 209);
            this.tbParams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbParams.Name = "tbParams";
            this.tbParams.Size = new System.Drawing.Size(707, 25);
            this.tbParams.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Image = global::EsPy.Properties.Resources.Warning;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(504, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "   确保所选择的端口是关闭的!";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(96, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "默认位置: YourPython\\Lib\\site-packages\\esptool.py";
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(100, 168);
            this.cbDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(369, 23);
            this.cbDevice.TabIndex = 8;
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
            this.cbDevice.Validating += new System.ComponentModel.CancelEventHandler(this.cbBaudrate_Validating);
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(100, 22);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(137, 23);
            this.cbPort.TabIndex = 0;
            this.cbPort.Validating += new System.ComponentModel.CancelEventHandler(this.cbBaudrate_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "参数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "设备：";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbBaudrate.Location = new System.Drawing.Point(332, 22);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(137, 23);
            this.cbBaudrate.TabIndex = 1;
            this.cbBaudrate.Validating += new System.ComponentModel.CancelEventHandler(this.cbBaudrate_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "端口：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "波特率：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMac
            // 
            this.btnMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMac.Location = new System.Drawing.Point(32, 560);
            this.btnMac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(99, 27);
            this.btnMac.TabIndex = 0;
            this.btnMac.Text = "MAC";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // btnFlashID
            // 
            this.btnFlashID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFlashID.Location = new System.Drawing.Point(139, 561);
            this.btnFlashID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFlashID.Name = "btnFlashID";
            this.btnFlashID.Size = new System.Drawing.Size(99, 27);
            this.btnFlashID.TabIndex = 1;
            this.btnFlashID.Text = "Flash ID";
            this.btnFlashID.UseVisualStyleBackColor = true;
            this.btnFlashID.Click += new System.EventHandler(this.btnFlashID_Click);
            // 
            // btnChipID
            // 
            this.btnChipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChipID.Location = new System.Drawing.Point(245, 561);
            this.btnChipID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChipID.Name = "btnChipID";
            this.btnChipID.Size = new System.Drawing.Size(99, 27);
            this.btnChipID.TabIndex = 2;
            this.btnChipID.Text = "Chip ID";
            this.btnChipID.UseVisualStyleBackColor = true;
            this.btnChipID.Click += new System.EventHandler(this.btnChipID_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(32, 594);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(816, 1);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(32, 601);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(295, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/espressif/esptool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(32, 623);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(319, 15);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://micropython.org/download#esp8266";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // EspToolDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 648);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChipID);
            this.Controls.Add(this.btnFlashID);
            this.Controls.Add(this.btnMac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EspToolDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "esp工具";
            this.Load += new System.EventHandler(this.EspToolDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPython;
        private System.Windows.Forms.Button btnPython;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEsptool;
        private System.Windows.Forms.Button btnEsptool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirmware;
        private System.Windows.Forms.Button btnFirmware;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMac;
        private System.Windows.Forms.Button btnFlashID;
        private System.Windows.Forms.Button btnChipID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbParams;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}