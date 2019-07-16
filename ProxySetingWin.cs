using GoProxyTool.Properties;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
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

namespace GoProxyTool
{
    public partial class ProxySetingWin : Form
    {
        public Process process = null;
        public ProxySetingWin()
        {
            InitializeComponent();
            

        }
        


        private void btnSetProxy_Click(object sender, EventArgs e)
        {
            //string proxyStr = combProxyList.Text.Trim();
            string proxyStr = "http://127.0.0.1:" + textBox4.Text;
            IEProxySetting.SetProxy(proxyStr, null);
            var currentProxy = GetProxyServer();
            if (currentProxy == proxyStr && GetProxyStatus())
            {
                lblInfo.Text = "设置代理：" + proxyStr + "成功！";
                lblInfo.ForeColor = Color.Green;
            }
            else
            {
                if (!GetProxyStatus())
                {
                    lblInfo.Text = "设置代理：" + proxyStr + "代理未启用！";

                }
                else
                {
                    lblInfo.Text = "设置代理：" + proxyStr + "失败，正在使用" + currentProxy + "代理，请重试！";

                }
                lblInfo.ForeColor = Color.Red;
            }
            ShowProxyInfo();
        }

        private void ProxySetingWin_Load(object sender, EventArgs e)
        {
            InitConfig();
            comboBox2.SelectedIndex = 0;
            string proxyPath = workPath + "\\" + appName;
            //MessageBox.Show(proxyPath);
            if (!File.Exists(proxyPath))

            {
                MessageBox.Show("请将本程序放到proxy.exe程序所在的目录下!");
                //执行读写操作
                System.Environment.Exit(0);
            }
            else
            {
                ShowProxyInfo();
                InitProxyData();
                button2.Enabled = false;
            }
            
        }

        /// <summary>
        /// 获取正在使用的代理
        /// </summary>
        /// <returns></returns>
        private string GetProxyServer()
        {
            //打开注册表 
            RegistryKey regKey = Registry.CurrentUser;
            string SubKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            RegistryKey optionKey = regKey.OpenSubKey(SubKeyPath, true);             //更改健值，设置代理， 
            string actualProxy = optionKey.GetValue("ProxyServer").ToString();
            regKey.Close();
            return actualProxy;
        }

        private bool GetProxyStatus()
        {
            //打开注册表 
            RegistryKey regKey = Registry.CurrentUser;
            string SubKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            RegistryKey optionKey = regKey.OpenSubKey(SubKeyPath, true);             //更改健值，设置代理， 
            int actualProxyStatus = Convert.ToInt32(optionKey.GetValue("ProxyEnable"));
            regKey.Close();
            return actualProxyStatus == 1 ? true : false;
        }

        private void ShowProxyInfo()
        {
            if (!GetProxyStatus())
            {
                lblInitInfo.Text = "代理未启用：";
            }
            else
            {
                lblInitInfo.Text = "当前使用的代理是：" + GetProxyServer();
            }
        }

        private void InitProxyData()
        {
            List<string> proxyList = new List<string>{
               "http://127.0.0.1:8090","http://proxy.compaq.com:8080"
           };
            combProxyList.DataSource = proxyList;
            combProxyList.SelectedIndex = 0;
        }

        private void InitParentMethodData()
        {
            List<string> ssMethodList = new List<string>{
                //"http://127.0.0.1:8090","http://proxy.compaq.com:8080"
                "",
                "aes-128-cfb" ,
                "aes-128-ctr" ,
                "aes-128-gcm" ,
                "aes-192-cfb" ,
                "aes-192-ctr" ,
                "aes-192-gcm" ,
                "aes-256-cfb" ,
                "aes-256-ctr" ,
                "aes-256-gcm" ,
                "bf-cfb" ,
                "cast5-cfb" ,
                "chacha20" ,
                "chacha20-ietf" ,
                "chacha20-ietf-poly1305" ,
                "des-cfb" ,
                "rc4-md5" ,
                "rc4-md5-6" ,
                "salsa20" ,
                "xchacha20"
            };
            List<string> httpMethodList = new List<string>{
                "",
                "aes-128-cfb",
                "aes-128-ctr",
                "aes-192-cfb",
                "aes-192-ctr",
                "aes-256-cfb",
                "aes-256-ctr",
                "bf-cfb",
                "cast5-cfb",
                "chacha20",
                "chacha20-ietf",
                "des-cfb",
                "rc4-md5",
                "rc4-md5-6"
            };
            List<string> socksMethodList = new List<string>{
                "",
                "aes-128-cfb",
                "aes-128-ctr",
                "aes-192-cfb",
                "aes-192-ctr",
                "aes-256-cfb",
                "aes-256-ctr",
                "bf-cfb",
                "cast5-cfb",
                "chacha20",
                "chacha20-ietf",
                "des-cfb",
                "rc4-md5",
                "rc4-md5-6"
            };
            List<string> httpTypeList = new List<string>{
                "ws",
                "wss"
            };
            List<string> ssTypeList = new List<string>{
                "tcp"
            };
            List<string> socksTypeList = new List<string>{
                "ws",
                "wss"
            };

            if (comboBox2.Text == "http")
            {
                comboBox4.DataSource = httpMethodList;
                comboBox4.SelectedIndex = 0;

                comboBox1.DataSource = httpTypeList;
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox2.Text == "ss")
            {
                comboBox4.DataSource = ssMethodList;
                comboBox4.SelectedIndex = 0;

                comboBox1.DataSource = ssTypeList;
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox2.Text == "socks")
            {
                comboBox4.DataSource = socksMethodList;
                comboBox4.SelectedIndex = 0;

                comboBox1.DataSource = socksTypeList;
                comboBox1.SelectedIndex = 0;
            }


        }

        private void btnDisableProxy_Click(object sender, EventArgs e)
        {
            if (IEProxySetting.UnsetProxy())
            {
                MessageBox.Show("取消完成！");
            }
            else
            {
                MessageBox.Show("取消失败！");
            }

            if (!GetProxyStatus())
            {
                lblInfo.Text = "取消代理完成！";
                lblInfo.ForeColor = Color.Green;
            }
            else
            {
                lblInfo.Text = "取消失败，正在使用代理" + GetProxyServer();
                lblInfo.ForeColor = Color.Red;
            }
            ShowProxyInfo();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择程序";
            dialog.Filter = "文件(*.exe)|*.exe";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //textBox2.Text = dialog.FileName;
                //textBox4.Text = System.IO.Path.GetDirectoryName(dialog.FileName) + "\\Converter\\" + dialog.SafeFileName;
            }
        }
        string appName = "proxy.exe";
        string workPath = System.IO.Directory.GetCurrentDirectory();
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";//ip
            textBox6.Text = "8880";
            comboBox2.Text = "http";
            //comboBox1.Text = e.server_mode;
            //comboBox4.Text = e.method;
            textBox7.Text = "";
        }
            
        
        private string StrMake(string parameter, string str)
        {
            if (parameter.Contains("="))
            {
                if (str == "")
                {
                    return "";
                }
                else
                {
                    return " " + parameter + "\"" + str + "\"";
                }
            }
            else
            {
                if (str == "")
                {
                    return "";
                }
                else
                {
                    return " " + parameter + " \"" + str + "\"";
                }
            }
            
        }
        private string StrMakeWithEqual(string parameter, string str)
        {
            if (str == "")
            {
                return "";
            }
            else
            {
                return " " + parameter + "\"" + str + "\"";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //生成配置
            string parent_ws_method = "--parent-ws-method=";
            string parent_ws_password = "--parent-ws-password=";
            string local_ws_method = "--local-ws-method=";
            string local_ws_password = "--local-ws-password=";
            string parent_ss_method = "--parent-ss-method=";
            string parent_ss_password = "--parent-ss-password=";
            string local_ss_method = "--ss-method=";
            string local_ss_password = "--ss-key=";
            string sps = "sps";
            switch (comboBox2.Text)
            {
                case "http":
                    textBox1.Text = appName + " " + sps + StrMake("-t", "tcp") + StrMake("-p", ":" + textBox4.Text) + StrMake("-T", comboBox1.Text) + StrMake("-P", textBox3.Text + ":" + textBox6.Text) + StrMake(parent_ws_method, comboBox4.Text) + StrMake(parent_ws_password, textBox7.Text);
                    break;
                case "ss":
                    textBox1.Text = appName + " " + sps + StrMake("-t", "tcp") + StrMake("-p", ":" + textBox4.Text) + StrMake("-T", comboBox1.Text) + StrMake("-P", textBox3.Text + ":" + textBox6.Text) + StrMake(parent_ss_method, comboBox4.Text) + StrMake(parent_ss_password, textBox7.Text);
                    break;
                case "socks":
                    textBox1.Text = appName + " " + sps + StrMake("-t", "tcp") + StrMake("-p", ":" + textBox4.Text) + StrMake("-T", comboBox1.Text) + StrMake("-P", textBox3.Text + ":" + textBox6.Text) + StrMake(parent_ws_method, comboBox4.Text) + StrMake(parent_ws_password, textBox7.Text);
                    break;
            }


            OutPutForm_Shown(textBox1.Text);
            //executeCmd(textBox2.Text);
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void OutPutForm_Shown(string CMDcommand)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = ".";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            //Process.Start("cmd.exe");
            //process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            //process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.Start();



            process.StandardInput.WriteLine(CMDcommand);//执行CMD命令

            //process.StandardInput.WriteLine("exit");


            //process.BeginOutputReadLine();
            //process.BeginErrorReadLine();
            //using (StreamWriter sw = new StreamWriter("output.log"))
            //{
            // sw.WriteLine(process.StandardOutput.ReadToEnd());
            //}


        }
        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                StringBuilder sb = new StringBuilder(this.textBox5.Text);
                this.textBox5.Text = sb.AppendLine(outLine.Data).ToString();
                this.textBox5.SelectionStart = this.textBox5.Text.Length;//每次刷新显示最后输出字符
                this.textBox5.ScrollToCaret();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (process != null)
            {
                ProcessEx.KillProcessTreeById(process.Id);
                process.Close();
            }
            button1.Enabled = true;
            button2.Enabled = false;
            textBox5.AppendText("进程已结束。。。" + "\r\n");
        }

        private void ProxySetingWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null)
            {
                try
                {
                    ProcessEx.KillProcessTreeById(process.Id);
                    process.Close();
                }
                catch
                {
                    ;
                }  
            }
            System.Environment.Exit(0);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "显示调试窗口")
            {
                this.Size = new Size(903, 517);
                button3.Text = "隐藏调试窗口";
            }
            else if (button3.Text == "隐藏调试窗口")
            {
                this.Size = new Size(425, 517);
                button3.Text = "显示调试窗口";
            }
            
        }

        private void ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            InitParentMethodData();
        }

        public class ConfigsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string server { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int server_port { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string server_type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string server_mode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string method { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string password { get; set; }
        }

        public class GoProxyCongfigs
        {
            public int index { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ConfigsItem> configs { get; set; }
        }
        public List<ConfigsItem> configs = new List<ConfigsItem>();
        public GoProxyCongfigs rb;
        public int mainIndex = 0;
        public int maxIndex = 0;
        public string jsonconfigpath = @"ui_config.json";
        //读取json文件
        private void InitConfig()
        {
            configs.Clear();
            listBox1.Items.Clear();
            //读取文件
            string jsonfile = jsonconfigpath;

            if (!File.Exists(jsonfile))
            {
                //File.Create(con_file_path);
                int index = 0;
                ConfigsItem configsItem = new ConfigsItem();
                configsItem.server = "your.domain or ip";//ip
                configsItem.server_port = 8880;
                configsItem.server_type = "http";
                configsItem.server_mode = "ws";
                configsItem.method = "aes-256-cfb";
                configsItem.password = "abc";
                configs.Add(configsItem);
                Writejson(index, configs, jsonconfigpath);
                configs.Clear();
            }

            //把模型数据写到文件 
            


            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                string json = file.ReadToEnd();
                rb = JsonConvert.DeserializeObject<GoProxyCongfigs>(json);
                mainIndex = rb.index;
                maxIndex = rb.configs.Count() - 1;
                int n = 0;
                foreach (ConfigsItem e in rb.configs)
                {
                    if(n==mainIndex)
                    {
                        textBox3.Text = e.server;//ip
                        textBox6.Text = e.server_port.ToString();
                        comboBox2.Text = e.server_type;
                        comboBox1.Text = e.server_mode;
                        comboBox4.Text = e.method;
                        textBox7.Text = e.password;
                        
                    }
                    listBox1.Items.Add(e.server +":"+ e.server_port.ToString() + "\n");
                    // MessageBox.Show(n.ToString());
                    n++;
                    configs.Add(e);
                }
                
            }
            
            //Writejson(configs, @"config0000.json");

        }

        
        private void Button5_Click(object sender, EventArgs e)
        {
            ConfigsItem configsItem = new ConfigsItem();
            configsItem.server = textBox3.Text;//ip
            configsItem.server_port = Convert.ToInt32(textBox6.Text);
            configsItem.server_type = comboBox2.Text;
            configsItem.server_mode = comboBox1.Text;
            configsItem.method = comboBox4.Text;
            configsItem.password = textBox7.Text;

            configs.Add(configsItem);
            int index = maxIndex + 1;

            Writejson(index, configs, jsonconfigpath);
            InitConfig();

        }
        public void Writejson(int index,List<ConfigsItem> configs,string path)
        {
            //子集
            //Hashtable device = new Hashtable();
            //device.Add("id", "001111");
            //device.Add("name", "相机");
            //device.Add("ip", "192.168.1.1");


            GoProxyCongfigs lot = new GoProxyCongfigs(); //实体模型类 
            //lot.Name = "lotname";
            //lot.Address = "wenzhou";
            lot.index = index;
            lot.configs = configs; //注意是子集
            //lot.Doors = "4";

            //序列化 
            string js1 = JsonConvert.SerializeObject(lot);
            //string js2 = JsonConvert.SerializeObject(device);

            //反序列化 
            GoProxyCongfigs debc1 = JsonConvert.DeserializeObject<GoProxyCongfigs>(js1);
            //LotModel debc2 = JsonConvert.DeserializeObject<LotModel>(js2);

            //找到服务器物理路径 
            //string serverAppPath = Request.PhysicalApplicationPath.ToString(); 
            //string serverAppPath = @"d:\";
            //构成配置文件路径 
            //string con_file_path = @"" + serverAppPath + @"config.json";
            string con_file_path =  path;

            if (!File.Exists(con_file_path))
            {
                //File.Create(con_file_path);
                File.Create(con_file_path).Close();
            }

            //把模型数据写到文件 
            using (StreamWriter sw = new StreamWriter(con_file_path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;

                //构建Json.net的写入流 
                JsonWriter writer = new JsonTextWriter(sw);
                //把模型数据序列化并写入Json.net的JsonWriter流中 
                serializer.Serialize(writer, lot);
                //ser.Serialize(writer, ht); 
                writer.Close();
                sw.Close();
            }
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mainIndex = listBox1.SelectedIndex;
            ConfigsItem cf = rb.configs[listBox1.SelectedIndex];
            textBox3.Text = cf.server;//ip
            textBox6.Text = cf.server_port.ToString();
            comboBox2.Text = cf.server_type;
            comboBox1.Text = cf.server_mode;
            comboBox4.Text = cf.method;
            textBox7.Text = cf.password;

            int index = mainIndex;
            //Color vColor = Color.Gainsboro;
            //Graphics devcolor = listBox1.CreateGraphics();
            //vColor = Color.Lime;
            //devcolor.FillRectangle(new SolidBrush(vColor), listBox1.GetItemRectangle(index));
            //devcolor.DrawString(listBox1.Items[index].ToString(), listBox1.Font, new SolidBrush(listBox1.ForeColor), listBox1.GetItemRectangle(index));
            
            Writejson(index, configs, jsonconfigpath);

            InitConfig();

        }

        private void 删除选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //listBox1.Items.Remove(listBox1.SelectedItems[listBox1.SelectedIndex]);
            configs.RemoveAt(listBox1.SelectedIndex);

            int index = listBox1.SelectedIndex-1;
            //Color vColor = Color.Gainsboro;
            //Graphics devcolor = listBox1.CreateGraphics();
            //vColor = Color.Lime;
            //devcolor.FillRectangle(new SolidBrush(vColor), listBox1.GetItemRectangle(index));
            //devcolor.DrawString(listBox1.Items[index].ToString(), listBox1.Font, new SolidBrush(listBox1.ForeColor), listBox1.GetItemRectangle(index));
            if (index <= 0)
            {
                index = 0;
                textBox3.Text = "";//ip
                textBox6.Text = "8090";
                comboBox2.Text = "http";
                //comboBox1.Text = e.server_mode;
                comboBox4.Text = "";
                textBox7.Text = "";
            }
            
            Writejson(index, configs, jsonconfigpath);
            InitConfig();
        }

        private void ListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int posindex = listBox1.IndexFromPoint(new Point(e.X, e.Y));
                listBox1.ContextMenuStrip = null;
                if (posindex >= 0 && posindex < listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = posindex;
                    contextMenuStrip1.Show(listBox1, new Point(e.X, e.Y));
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ConfigsItem configsItem = new ConfigsItem();
            configsItem.server = textBox3.Text;//ip
            configsItem.server_port = Convert.ToInt32(textBox6.Text);
            configsItem.server_type = comboBox2.Text;
            configsItem.server_mode = comboBox1.Text;
            configsItem.method = comboBox4.Text;
            configsItem.password = textBox7.Text;

            configs[mainIndex]=configsItem;
            int index = mainIndex;

            Writejson(index, configs, jsonconfigpath);
            InitConfig();
        }
    }
}
