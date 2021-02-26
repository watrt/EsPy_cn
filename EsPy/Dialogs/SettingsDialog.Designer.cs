namespace EsPy.Dialogs
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPythonPath = new System.Windows.Forms.TextBox();
            this.btnPythonPath = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ShowServer = new System.Windows.Forms.CheckBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workpath = new System.Windows.Forms.TextBox();
            this.btnworkpath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontsize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spacing = new System.Windows.Forms.NumericUpDown();
            this.InsertMatchedChars = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacing)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Python:";
            // 
            // tbPythonPath
            // 
            this.tbPythonPath.Location = new System.Drawing.Point(23, 106);
            this.tbPythonPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPythonPath.Name = "tbPythonPath";
            this.tbPythonPath.Size = new System.Drawing.Size(621, 25);
            this.tbPythonPath.TabIndex = 0;
            // 
            // btnPythonPath
            // 
            this.btnPythonPath.Location = new System.Drawing.Point(652, 105);
            this.btnPythonPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPythonPath.Name = "btnPythonPath";
            this.btnPythonPath.Size = new System.Drawing.Size(33, 27);
            this.btnPythonPath.TabIndex = 1;
            this.btnPythonPath.Text = "...";
            this.btnPythonPath.UseVisualStyleBackColor = true;
            this.btnPythonPath.Click += new System.EventHandler(this.btnPythonPath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(606, 366);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ShowServer
            // 
            this.ShowServer.AutoSize = true;
            this.ShowServer.Location = new System.Drawing.Point(21, 374);
            this.ShowServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShowServer.Name = "ShowServer";
            this.ShowServer.Size = new System.Drawing.Size(196, 19);
            this.ShowServer.TabIndex = 2;
            this.ShowServer.Text = "显示Py服务器(需要重启)";
            this.ShowServer.UseVisualStyleBackColor = true;
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
            this.cbBaudrate.Location = new System.Drawing.Point(22, 161);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(137, 23);
            this.cbBaudrate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "串口速度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "工作目录:";
            // 
            // workpath
            // 
            this.workpath.Location = new System.Drawing.Point(22, 58);
            this.workpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.workpath.Name = "workpath";
            this.workpath.Size = new System.Drawing.Size(622, 25);
            this.workpath.TabIndex = 10;
            // 
            // btnworkpath
            // 
            this.btnworkpath.Location = new System.Drawing.Point(652, 56);
            this.btnworkpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnworkpath.Name = "btnworkpath";
            this.btnworkpath.Size = new System.Drawing.Size(33, 27);
            this.btnworkpath.TabIndex = 11;
            this.btnworkpath.Text = "...";
            this.btnworkpath.UseVisualStyleBackColor = true;
            this.btnworkpath.Click += new System.EventHandler(this.btnworkpath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontsize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.spacing);
            this.groupBox1.Controls.Add(this.InsertMatchedChars);
            this.groupBox1.Location = new System.Drawing.Point(21, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 133);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑器设置";
            // 
            // fontsize
            // 
            this.fontsize.Location = new System.Drawing.Point(107, 72);
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(120, 25);
            this.fontsize.TabIndex = 16;
            this.fontsize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "字体大小：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "行距：";
            // 
            // spacing
            // 
            this.spacing.Location = new System.Drawing.Point(107, 30);
            this.spacing.Name = "spacing";
            this.spacing.Size = new System.Drawing.Size(120, 25);
            this.spacing.TabIndex = 13;
            this.spacing.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // InsertMatchedChars
            // 
            this.InsertMatchedChars.AutoSize = true;
            this.InsertMatchedChars.Location = new System.Drawing.Point(501, 36);
            this.InsertMatchedChars.Name = "InsertMatchedChars";
            this.InsertMatchedChars.Size = new System.Drawing.Size(164, 19);
            this.InsertMatchedChars.TabIndex = 0;
            this.InsertMatchedChars.Text = "自动闭合括号、引号";
            this.InsertMatchedChars.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPythonPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnworkpath);
            this.groupBox2.Controls.Add(this.btnPythonPath);
            this.groupBox2.Controls.Add(this.workpath);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbBaudrate);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 199);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工作环境：";
            // 
            // label9
            // 
            this.label9.Image = global::EsPy.Properties.Resources.Warning;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(340, 371);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "   设置重启后生效！";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 426);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowServer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacing)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPythonPath;
        private System.Windows.Forms.Button btnPythonPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ShowServer;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workpath;
        private System.Windows.Forms.Button btnworkpath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spacing;
        private System.Windows.Forms.CheckBox InsertMatchedChars;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown fontsize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}