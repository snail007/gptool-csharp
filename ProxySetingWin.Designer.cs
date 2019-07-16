namespace GoProxyTool
{
    partial class ProxySetingWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxySetingWin));
            this.lblInitInfo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTestProxy = new System.Windows.Forms.Button();
            this.combProxyList = new System.Windows.Forms.ComboBox();
            this.btnDisableProxy = new System.Windows.Forms.Button();
            this.btnSetProxy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInitInfo
            // 
            this.lblInitInfo.AutoSize = true;
            this.lblInitInfo.Location = new System.Drawing.Point(20, 22);
            this.lblInitInfo.Name = "lblInitInfo";
            this.lblInitInfo.Size = new System.Drawing.Size(11, 12);
            this.lblInitInfo.TabIndex = 14;
            this.lblInitInfo.Text = "*";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 369);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(11, 12);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "*";
            // 
            // btnTestProxy
            // 
            this.btnTestProxy.Location = new System.Drawing.Point(283, 17);
            this.btnTestProxy.Name = "btnTestProxy";
            this.btnTestProxy.Size = new System.Drawing.Size(75, 23);
            this.btnTestProxy.TabIndex = 12;
            this.btnTestProxy.Text = "测试代理";
            this.btnTestProxy.UseVisualStyleBackColor = true;
            // 
            // combProxyList
            // 
            this.combProxyList.FormattingEnabled = true;
            this.combProxyList.Location = new System.Drawing.Point(98, 48);
            this.combProxyList.Name = "combProxyList";
            this.combProxyList.Size = new System.Drawing.Size(153, 20);
            this.combProxyList.TabIndex = 11;
            // 
            // btnDisableProxy
            // 
            this.btnDisableProxy.Location = new System.Drawing.Point(133, 59);
            this.btnDisableProxy.Name = "btnDisableProxy";
            this.btnDisableProxy.Size = new System.Drawing.Size(75, 23);
            this.btnDisableProxy.TabIndex = 10;
            this.btnDisableProxy.Text = "取消代理";
            this.btnDisableProxy.UseVisualStyleBackColor = true;
            this.btnDisableProxy.Click += new System.EventHandler(this.btnDisableProxy_Click);
            // 
            // btnSetProxy
            // 
            this.btnSetProxy.Location = new System.Drawing.Point(52, 58);
            this.btnSetProxy.Name = "btnSetProxy";
            this.btnSetProxy.Size = new System.Drawing.Size(75, 24);
            this.btnSetProxy.TabIndex = 9;
            this.btnSetProxy.Text = "设置代理";
            this.btnSetProxy.UseVisualStyleBackColor = true;
            this.btnSetProxy.Click += new System.EventHandler(this.btnSetProxy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "IE代理网址：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "启动服务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "停止服务";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(276, 72);
            this.textBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "-P 服务地址\r\n";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 21);
            this.textBox3.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "-T 底层传输类型";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "-p 代理端口";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 21);
            this.textBox4.TabIndex = 31;
            this.textBox4.Text = "8090";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(6, 18);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(458, 243);
            this.textBox5.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "域名（或IP）";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "端口";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 136);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 21);
            this.textBox6.TabIndex = 35;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 256);
            this.listBox1.TabIndex = 36;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(146, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 226);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务端";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "-S 服务类型";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "http",
            "socks",
            "ss"});
            this.comboBox2.Location = new System.Drawing.Point(118, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 20);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.ComboBox2_SelectedValueChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(118, 190);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 21);
            this.textBox7.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "密码";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "aes-128-cfb",
            "aes-128-ctr",
            "aes-128-gcm",
            "aes-192-cfb",
            "aes-192-ctr",
            "aes-192-gcm",
            "aes-256-cfb",
            "aes-256-ctr",
            "aes-256-gcm",
            "bf-cfb",
            "cast5-cfb",
            "chacha20",
            "chacha20-ietf",
            "chacha20-ietf-poly1305",
            "des-cfb",
            "rc4-md5",
            "rc4-md5-6",
            "salsa20",
            "xchacha20"});
            this.comboBox4.Location = new System.Drawing.Point(118, 164);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(133, 20);
            this.comboBox4.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "加密方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.btnSetProxy);
            this.groupBox2.Controls.Add(this.btnDisableProxy);
            this.groupBox2.Location = new System.Drawing.Point(146, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 96);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户端";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblInitInfo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.combProxyList);
            this.groupBox3.Controls.Add(this.btnTestProxy);
            this.groupBox3.Location = new System.Drawing.Point(930, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 129);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "代理设置";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(409, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 352);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "调试窗口";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "生成配置";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "保存配置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(930, 396);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(393, 100);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "命令编辑器";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "显示调试窗口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除选中ToolStripMenuItem
            // 
            this.删除选中ToolStripMenuItem.Name = "删除选中ToolStripMenuItem";
            this.删除选中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除选中ToolStripMenuItem.Text = "删除选中";
            this.删除选中ToolStripMenuItem.Click += new System.EventHandler(this.删除选中ToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 23);
            this.button6.TabIndex = 44;
            this.button6.Text = "保存修改";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // ProxySetingWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 388);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProxySetingWin";
            this.Text = "goproxy tool 1.0    20190701";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProxySetingWin_FormClosing);
            this.Load += new System.EventHandler(this.ProxySetingWin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTestProxy;
        private System.Windows.Forms.ComboBox combProxyList;
        private System.Windows.Forms.Button btnDisableProxy;
        private System.Windows.Forms.Button btnSetProxy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中ToolStripMenuItem;
        private System.Windows.Forms.Button button6;
    }
}

