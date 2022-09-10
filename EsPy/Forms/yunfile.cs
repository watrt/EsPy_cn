using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using EsPy.Utility;

namespace EsPy.Forms
{
    public partial class yunfile :DockContent, IForm
    {
        public string devuceid = "123456789";
        private MainForm pf;
        public yunfile(MainForm f1)
        {
            InitializeComponent();
            this.HideOnClose = true;
            this.pf = f1;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public ToolStrip ToolStrip
        {
            get
            {
                //return this.toolStrip1;
                return null;
            }
        }

        public ToolStrip MenuStrip
        { get { return this.menuStrip1; } }

        private void yunfile_Load(object sender, EventArgs e)
        {
            try
            {
                string yun = post("http://www.xb6.cn/tools/espy_cn/yunpan.php");
                DataTable dt = new DataTable();
                dt = JsonConvert.DeserializeObject<DataTable>(yun);
                foreach (DataRow l in dt.Rows)
                {
                    //Console.WriteLine(l.Table.Columns.Contains("info"));
                    int icon = l["type"].ToString() == "dir" ? 0 : 1;
                    TreeNode s = new TreeNode(l["name"].ToString(), icon, icon);
                    if (l["type"].ToString() == "dir")
                    {

                    }
                    if (l.Table.Columns.Contains("id"))
                        s.Tag = l["path"].ToString();
                    if (l.Table.Columns.Contains("info"))
                        s.ToolTipText = l["info"].ToString();
                    treeView1.Nodes.Add(s);

                }
            }catch(Exception er)
            {
                MessageBox.Show("获取云盘数据失败","失败");
            }
            
        }
        private string post(string url, string postdate = "")
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
                //MessageBox.Show("失败", "获取失败");
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

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ImageIndex == 0)
            {
                try
                {
                    string yun = post("http://www.xb6.cn/tools/espy_cn/yunpan.php?path=" + e.Node.Tag);
                    DataTable dt = new DataTable();
                    dt = JsonConvert.DeserializeObject<DataTable>(yun);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("目录下没有文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        e.Node.Nodes.Clear();
                    }
                    foreach (DataRow l in dt.Rows)
                    {
                        Console.WriteLine(l.Table.Columns.Contains("info"));
                        int icon = l["type"].ToString() == "dir" ? 0 : 1;
                        TreeNode s = new TreeNode(l["name"].ToString(), icon, icon);
                        if (l["type"].ToString() == "dir")
                        {

                        }
                        if (l.Table.Columns.Contains("id"))
                            s.Tag = l["path"].ToString();
                        if (l.Table.Columns.Contains("info"))
                            s.ToolTipText = l["info"].ToString();
                        e.Node.Nodes.Add(s);
                        e.Node.Expand();
                        //treeView1.Nodes.Add(s);

                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("获取云盘数据失败", "失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    string Filepath = System.AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.Workpath + "\\" + e.Node.Text;
                    HttpDownloadFile("http://www.xb6.cn/tools/espy_cn/" + e.Node.Tag, Filepath);
                    //Console.WriteLine("http://www.xb6.cn/tools/espy_cn/yunpan.php?id=" + e.Node.Tag);

                    if (Filepath.Substring(Filepath.Length-2, 2) == "py")
                    {
                        FileFormats ff = EditorForm.EditorFileFormats;
                        IDocument doc = pf.OpenFromFile(Filepath, ff);
                        if (doc != null)
                        {
                            (doc as DockContent).Show(pf.dockPanel1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("已下载到:"+ Filepath + "\n文件类型不支持编辑！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }


                }catch(Exception err)
                {
                    MessageBox.Show("获取文件失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


                //MessageBox.Show("开发中..."+ Filepath);
        }
    }
}
