using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPy.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.label1.Text = Application.ProductName;
            this.label2.Text = "版本：v" + Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.linkLabel1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(this.linkLabel1.Text);
        }
    }
}
