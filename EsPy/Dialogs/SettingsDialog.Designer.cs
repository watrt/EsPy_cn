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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Python:";
            // 
            // tbPythonPath
            // 
            this.tbPythonPath.Location = new System.Drawing.Point(21, 85);
            this.tbPythonPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPythonPath.Name = "tbPythonPath";
            this.tbPythonPath.Size = new System.Drawing.Size(669, 25);
            this.tbPythonPath.TabIndex = 0;
            // 
            // btnPythonPath
            // 
            this.btnPythonPath.Location = new System.Drawing.Point(698, 83);
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
            this.button2.Location = new System.Drawing.Point(524, 262);
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
            this.button3.Location = new System.Drawing.Point(633, 262);
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
            this.ShowServer.Location = new System.Drawing.Point(21, 212);
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
            this.cbBaudrate.Location = new System.Drawing.Point(21, 154);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(137, 23);
            this.cbBaudrate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "串口速度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "工作目录:";
            // 
            // workpath
            // 
            this.workpath.Location = new System.Drawing.Point(20, 37);
            this.workpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.workpath.Name = "workpath";
            this.workpath.Size = new System.Drawing.Size(669, 25);
            this.workpath.TabIndex = 10;
            // 
            // btnworkpath
            // 
            this.btnworkpath.Location = new System.Drawing.Point(697, 37);
            this.btnworkpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnworkpath.Name = "btnworkpath";
            this.btnworkpath.Size = new System.Drawing.Size(33, 27);
            this.btnworkpath.TabIndex = 11;
            this.btnworkpath.Text = "...";
            this.btnworkpath.UseVisualStyleBackColor = true;
            this.btnworkpath.Click += new System.EventHandler(this.btnworkpath_Click);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 302);
            this.Controls.Add(this.btnworkpath);
            this.Controls.Add(this.workpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBaudrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShowServer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPythonPath);
            this.Controls.Add(this.tbPythonPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
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
    }
}