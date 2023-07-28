using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsPy.Units
{
    class wificlient
    {
        public string ssid = "";
        public string bssid = "";
        public int channel = 0;
        public int RSSI = 0;    //信号强度
        public int security = 0;  //安全类型
        public bool hidden = false; //隐藏网络
        public wificlient(string c_ssid,string c_bssid, int c_channel, int c_security, Boolean c_hidden)
        {
            this.ssid = c_ssid;
            this.bssid = c_bssid;
            this.channel = c_channel;
            this.security = c_security;
            this.hidden = c_hidden;
        }
        public string getname
        {
            get { return this.ssid; }
        }
        public int getrssi
        {
            get { return this.RSSI; }
        }
    }
}
