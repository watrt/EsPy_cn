using EsPy.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPy.Dialogs
{
    public partial class chipconf : Form
    {
        public chipconf()
        {
            InitializeComponent();
        }
        public PySerial Port
        { get; set; }
        private void chipconf_Load(object sender, EventArgs e)
        {
            if (this.Port != null && this.Port.IsOpen)
            {
                ResultStatus res = this.Port.Getfreq();
                if (res.Result == ResultStatus.Statuses.Success)
                {
                    try
                    {
                        string freq=(int.Parse(res.ToString())/ 1000000).ToString();
                        Console.WriteLine(res.ToString());
                        comboBox1.Text = freq + "MHZ";
                    }
                    catch
                    {

                    }
                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Port != null && this.Port.IsOpen)
            {
                ResultStatus res = this.Port.Getwifi();
                if (res.Result == ResultStatus.Statuses.Success)
                {
                    wifiname.Items.Clear();
                    foreach(wificlient i in res.Data as List<wificlient>)
                    {
                        wifiname.Items.Add(i.getname);
                    }
                    Console.WriteLine(res.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
