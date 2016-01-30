namespace xj2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.IO.Ports;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using xj2.Properties;

    public class Form1 : Form
    {
        private int bfb;
        public Bitmap bit;
        private byte[] buf;
        private Button button12;
        private Button button14;
        private Button button15;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonkai;
        private Button buttonleft;
        private Button buttonOpen;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonup;
        private char[] c;
        private NumericUpDown cinum;
        public byte ckb;
        private bool ckhcheckok;
        private bool ckisok;
        public byte ckjc;
        public byte ckjcmi;
        private System.Windows.Forms.Timer cktime;
        private ComboBox comboBox2;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private int count;
        private ToolStripMenuItem englishToolStripMenuItem;
        public int fa;
        private int fd;
        private int fen;
        private int FM;
        private int Fm1;
        private FontDialog fontDialog1;
        public int hangchengh;
        public int hangchengw;
        private int hi;
        private int hj;
        private int hx;
        private int hy;
        private int Ii;
        private bool isci;
        private bool isdking;
        private bool ispause;
        private byte jia;
        private byte jian;
        private int Kk;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        public List<line> li;
        public List<line> lic;
        public List<byte> lists;
        public List<short> listx;
        public List<short> listy;
        public List<line> liy;
        private bool lsbool;
        private double lsd1;
        private int lsd2;
        public int lsint;
        public int maxh;
        public int maxw;
        private int maxx;
        private int maxy;
        private int miao;
        public int min;
        private int minx;
        private int miny;
        private int n;
        private NumberFormatInfo nfi;
        private byte NR;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxX;
        private PictureBox pictureBoxY;
        private int Pref_x;
        private int Pref_y;
        private ProgressBar progressBar1;
        public int px;
        public int py;
        private int qdx;
        private int qdy;
        private int R;
        private Random ran;
        private string sdss;
        private SerialPort serialPort1;
        private int shi;
        private int STEP;
        public int stime;
        private Thread thread;
        private int time;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown trackBarStrong;
        private NumericUpDown trackBarTime;
        private System.Windows.Forms.Timer updata;
        private int V;
        private string wz;
        private string wz2;
        private byte X_F;
        private int Xe;
        private int xpo;
        private int XS;
        private int Xx;
        private byte Y_F;
        private int Ye;
        private int yhfd;
        private int[] yhsz;
        private int ymaxx;
        private int ymaxy;
        private int yminx;
        private int yminy;
        private int ypo;
        private int YS;
        private string yuan;
        public int yuyan;
        private int yxx;
        private int yxy;
        private int Yy;
        public int ztime;
        private ToolStripMenuItem русскийToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ContextMenuStrip 定位;
        private ToolStripMenuItem 左上ToolStripMenuItem;
        private ToolStripMenuItem 左中ToolStripMenuItem;
        private ToolStripMenuItem 简体ToolStripMenuItem;
        private ToolStripMenuItem 繁体ToolStripMenuItem;
        private ToolStripMenuItem 重新连接ToolStripMenuItem;
        private NotifyIcon 阿灿的世界;
        private ToolStripMenuItem 阿灿的世界ToolStripMenuItem;

        public Form1()
        {
            int num;
            this.li = new List<line>();
            this.liy = new List<line>();
            this.lic = new List<line>();
            this.buf = new byte[] { 0x23, 1, 0, 0, 0, 0, 0, 0, 0, 0, 10 };
            this.listx = new List<short>();
            this.listy = new List<short>();
            this.lists = new List<byte>();
            this.lsint = 0;
            this.px = 0;
            this.py = 0;
            this.ztime = 0;
            this.stime = 0;
            this.ckjc = 0;
            this.ckjcmi = 0x56;
            this.ckb = 0xde;
            this.ran = new Random();
            this.ispause = false;
            this.ckisok = false;
            this.ckhcheckok = false;
            this.isdking = false;
            this.maxh = 890;
            this.maxw = 890;
            this.min = 10;
            this.fa = 240;
            this.hangchengw = 330;
            this.hangchengh = 230;
            this.sdss = "http://hjk.hk";
            this.wz = "锫锩锨镭锫锨";
            this.jia = 6;
            this.jian = 6;
            this.fd = 160;
            this.yhfd = 100;
            this.yhsz = new int[] { 
                0x1a, 0x49, 0x8e, 230, 0x151, 480, 680, 890, 0x465, 0x574, 0x669, 0x77b, 0x8a3, 0x9e9, 0xb19, 0xc93, 
                0xe11, 0xf68
             };
            this.count = 1;
            this.c = new char[] { 'ͺ', '', '', '\udb53', '' };
            this.yuan = "G90\r\nG21\r\nG0 X3.2 Y65.8\r\n\r\nM03\r\nG1F26.000000\r\nG02 X5.4628 Y64.8627 I0. J-3.2001\r\nG02 X6.4 Y62.6001 I-2.2625 J-2.2626\r\nG02 X5.4627 Y60.3373 I-3.2002 J0.\r\nG02 X3.2 Y59.4 I-2.2627 J2.2627\r\nG02 X0.9373 Y60.3373 I0. J3.1999\r\nG02 X-0. Y62.6001 I2.2629 J2.2629\r\nG02 X0.9372 Y64.8627 I3.1997 J0.\r\nG02 X3.2 Y65.8 I2.2628 J-2.2629\r\nG1  X3.2 Y65.8\r\nM05\r\n\r\nG0 X0.000 Y0.000\r\nM05\r\nM02\r\n";
            this.STEP = 1;
            this.Xx = 0;
            this.Yy = 0;
            this.Ii = 0;
            this.Kk = 0;
            this.components = null;
            this.nfi = new NumberFormatInfo();
            this.nfi.NumberGroupSeparator = ".";
            string name = Thread.CurrentThread.CurrentUICulture.Name;
            string str2 = regedit.read("yuyan");
            if (str2 == null)
            {
                string str = name.Split(new char[] { '-' })[0];
                if (str.Equals("en"))
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
                    regedit.write("yuyan", "en");
                }
                else if (str.Equals("ru"))
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru");
                    regedit.write("yuyan", "ru");
                }
                else if ((name.Equals("zh-CN") || name.Equals("zh-Hans")) || name.Equals("zh-SG"))
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
                    regedit.write("yuyan", "zh-CN");
                }
                else if (((name.Equals("zh-TW") || name.Equals("zh-Hant")) || name.Equals("zh-MO")) || name.Equals("zh-HK"))
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-HK");
                    regedit.write("yuyan", "zh-HK");
                }
                else if (str.Equals("zh"))
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
                    regedit.write("yuyan", "zh-CN");
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
                    regedit.write("yuyan", "en");
                }
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(str2);
            }
            name = Thread.CurrentThread.CurrentUICulture.Name;
            if (name.Equals("ru"))
            {
                this.yuyan = 3;
            }
            else if (name.Equals("en"))
            {
                this.yuyan = 2;
            }
            else
            {
                this.yuyan = 1;
            }
            this.InitializeComponent();
            base.KeyPreview = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            for (num = 0; num < this.c.Length; num++)
            {
                this.c[num] = (char) ((this.c[num] + '\x0002') ^ 0x9543);
            }
            char[] chArray = new char[this.wz.Length];
            for (num = 0; num < this.wz.Length; num++)
            {
                chArray[num] = (char) (this.wz[num] ^ 0x9543);
            }
            this.wz2 = new string(chArray);
            if (this.yuyan == 1)
            {
                this.Text = new string(this.c);
            }
            else if (this.yuyan == 2)
            {
                this.Text = "Acan Mini laser engraving";
            }
            else if (this.yuyan == 3)
            {
                this.Text = "Acan Мини лазерная гравировка";
            }
            this.thread = new Thread(new ThreadStart(this.startcheckck));
            this.thread.Start();
            new Thread(new ThreadStart(gx.jcgx)).Start();
        }

        private void ApplyResource()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            foreach (Control control in base.Controls)
            {
                manager.ApplyResources(control, control.Name);
            }
        }

        private void bianjie(ref List<line> l)
        {
            this.minx = 0x895440;
            this.miny = 0x895440;
            this.maxx = -9000000;
            this.maxy = -9000000;
            foreach (line line in l)
            {
                if ((line.lx == 0) || (line.lx == 1))
                {
                    if (line.x < this.minx)
                    {
                        this.minx = line.x;
                    }
                    if (line.x > this.maxx)
                    {
                        this.maxx = line.x;
                    }
                    if (line.y < this.miny)
                    {
                        this.miny = line.y;
                    }
                    if (line.y > this.maxy)
                    {
                        this.maxy = line.y;
                    }
                }
            }
            foreach (line line in l)
            {
                if ((line.lx == 0) || (line.lx == 1))
                {
                    line.y = this.maxy - line.y;
                    line.x -= this.minx;
                }
            }
            this.maxx -= this.minx;
            this.maxy -= this.miny;
            this.minx = 0;
            this.miny = 0;
        }

        private void bianjie2(List<line> l)
        {
            this.minx = 0x895440;
            this.miny = 0x895440;
            this.maxx = -9000000;
            this.maxy = -9000000;
            foreach (line line in l)
            {
                if ((line.lx == 0) || (line.lx == 1))
                {
                    if (line.x < this.minx)
                    {
                        this.minx = line.x;
                    }
                    if (line.x > this.maxx)
                    {
                        this.maxx = line.x;
                    }
                    if (line.y < this.miny)
                    {
                        this.miny = line.y;
                    }
                    if (line.y > this.maxy)
                    {
                        this.maxy = line.y;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 150;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 5;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 3;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 180;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 110;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.ispause = true;
            this.updata.Enabled = false;
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 0;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button15_MouseUp(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 0xfd;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button18_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 8;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#d00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button18_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 1;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#d00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button19_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "gcode files |*.cnc;*.nc|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.gcode(dialog.FileName);
                if (this.checksize())
                {
                    this.bianjie2(this.li);
                }
                this.xs();
                this.upxian();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x66;
            this.buf[2] = 0;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x66;
            this.buf[2] = 0xff;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button22_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 50;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#w00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button22_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button23_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 8;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#w00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button23_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button24_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 1;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#w00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button24_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button25_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 50;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#a00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button25_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button26_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 8;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#a00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button26_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button27_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 1;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#a00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button27_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.upt();
            this.ispause = false;
            if (!this.isdking)
            {
                if (this.cinum.Value != 1M)
                {
                    this.ci();
                    this.jisuanfc();
                    this.isci = true;
                    this.progressBar1.Maximum = this.lic.Count;
                }
                else
                {
                    this.isci = false;
                    this.jisuanf();
                    this.progressBar1.Maximum = this.li.Count;
                }
                this.isdking = true;
                this.updata.Enabled = true;
                this.time = 0;
                this.label3.Text = "0:0:0";
                this.progressBar1.Value = 0;
                this.lsint = 0;
                this.setxy();
                this.setspdpi();
                this.setwt();
                if (this.isci)
                {
                    this.dkc();
                }
                else
                {
                    this.dk();
                }
            }
            else
            {
                this.updata.Enabled = true;
                if (this.isci)
                {
                    this.dkc();
                }
                else
                {
                    this.dk();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 60;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.buf[1] = 0x6a;
            this.buf[2] = 0xff;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 8;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#s00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 50;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#s00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 14;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 8;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void buttonkai_Click(object sender, EventArgs e)
        {
            if (this.buf[2] == 0xfc)
            {
                this.buf[2] = 250;
            }
            else
            {
                this.buf[2] = 0xfc;
            }
            this.buf[1] = 0x6a;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
            }
        }

        private void buttonleft_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 1;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#s00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void buttonleft_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.lsint = 0;
            this.isdking = false;
            this.updata.Enabled = false;
            this.progressBar1.Value = 0;
            this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
            this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#T00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(15);
            this.guiling();
        }

        private void buttonup_MouseDown(object sender, MouseEventArgs e)
        {
            this.buf[1] = 0x70;
            this.buf[2] = 50;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#d00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(5);
        }

        private void buttonup_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.WriteLine("#t00000000");
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        public bool checksize()
        {
            if ((this.maxy > this.maxh) || (this.maxx > this.maxw))
            {
                float bs = ((float) this.maxw) / ((float) this.maxx);
                float num2 = this.maxy * bs;
                if (num2 > this.maxh)
                {
                    bs = ((float) this.maxh) / ((float) this.maxy);
                }
                this.ResizeImage(bs);
                return true;
            }
            return false;
        }

        private void ci()
        {
            this.lic.Clear();
            int num = (int) this.cinum.Value;
            int num2 = 0;
            bool flag = false;
            int num3 = 0;
            int num4 = 0;
            int num7 = 0;
            int num8 = this.li.Count - 1;
            for (int i = 0; i < this.li.Count; i++)
            {
                int num5;
                int num6;
                line line;
                if (this.li[i].lx == 1)
                {
                    flag = true;
                }
                if (i == num8)
                {
                    num4 = num3;
                    num3 = i + 1;
                    if ((num3 != num4) && flag)
                    {
                        flag = false;
                        line = new line {
                            lx = this.li[num4].lx,
                            x = this.li[num4].x,
                            y = this.li[num4].y
                        };
                        this.lic.Add(line);
                        num2 = num3 - num4;
                        num2--;
                        num2 *= num;
                        num5 = num4 + 1;
                        num6 = num3 - 1;
                        num7 = 0;
                        while (num2 != 0)
                        {
                            if (num7 == 0)
                            {
                                line = new line {
                                    lx = 1,
                                    x = this.li[num5].x,
                                    y = this.li[num5].y
                                };
                                this.lic.Add(line);
                                if (num5 == (num3 - 1))
                                {
                                    num7 = 1;
                                    num5--;
                                }
                                else
                                {
                                    num5++;
                                }
                                num2--;
                            }
                            else
                            {
                                line = new line {
                                    lx = 1,
                                    x = this.li[num5].x,
                                    y = this.li[num5].y
                                };
                                this.lic.Add(line);
                                if (num5 == num4)
                                {
                                    num7 = 0;
                                    num5++;
                                }
                                else
                                {
                                    num5--;
                                }
                                num2--;
                            }
                        }
                    }
                }
                if (this.li[i].lx == 0)
                {
                    num4 = num3;
                    num3 = i;
                    if ((num3 != num4) && flag)
                    {
                        flag = false;
                        line = new line {
                            lx = this.li[num4].lx,
                            x = this.li[num4].x,
                            y = this.li[num4].y
                        };
                        this.lic.Add(line);
                        num2 = num3 - num4;
                        num2--;
                        num2 *= num;
                        num5 = num4 + 1;
                        num6 = num3 - 1;
                        num7 = 0;
                        while (num2 != 0)
                        {
                            if (num7 == 0)
                            {
                                line = new line {
                                    lx = 1,
                                    x = this.li[num5].x,
                                    y = this.li[num5].y
                                };
                                this.lic.Add(line);
                                if (num5 == (num3 - 1))
                                {
                                    num7 = 1;
                                    num5--;
                                }
                                else
                                {
                                    num5++;
                                }
                                num2--;
                            }
                            else
                            {
                                line = new line {
                                    lx = 1,
                                    x = this.li[num5].x,
                                    y = this.li[num5].y
                                };
                                this.lic.Add(line);
                                if (num5 == num4)
                                {
                                    num7 = 0;
                                    num5++;
                                }
                                else
                                {
                                    num5--;
                                }
                                num2--;
                            }
                        }
                    }
                }
            }
        }

        public void ckcheckfs()
        {
            this.buf[1] = 0x6c;
            this.buf[2] = 0x6a;
            this.ckjc = (byte) this.ran.Next(5, 0x65);
            this.buf[3] = this.ckjc;
            this.buf[4] = (byte) this.ran.Next(1, 200);
            this.buf[5] = (byte) this.ran.Next(1, 0xc9);
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void cktime_Tick(object sender, EventArgs e)
        {
            this.context();
        }

        private void context()
        {
            if (this.yuyan == 1)
            {
                if (!this.serialPort1.IsOpen)
                {
                    this.label1.Text = "未连接";
                }
                else if (this.ckisok)
                {
                    this.label1.Text = "已连接";
                    this.cktime.Enabled = false;
                }
                else
                {
                    this.label1.Text = "连接失败";
                }
            }
            else if (this.yuyan == 2)
            {
                if (!this.serialPort1.IsOpen)
                {
                    this.label1.Text = "Not connected";
                }
                else if (this.ckisok)
                {
                    this.label1.Text = "Connected";
                    this.cktime.Enabled = false;
                }
                else
                {
                    this.label1.Text = "Connection Fail";
                }
            }
            else if (this.yuyan == 3)
            {
                if (!this.serialPort1.IsOpen)
                {
                    this.label1.Text = "Не подключен";
                }
                else if (this.ckisok)
                {
                    this.label1.Text = "соединение успешно";
                    this.cktime.Enabled = false;
                }
                else
                {
                    this.label1.Text = "Отказ";
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dk()
        {
            if (this.li.Count > this.lsint)
            {
                if (this.li[this.lsint].lx == 0)
                {
                    this.buf[1] = 0x6b;
                }
                else
                {
                    this.buf[1] = 0x71;
                    this.lsd2 = this.li[this.lsint].time / this.V;
                    this.lsd2 = 0x10000 - this.lsd2;
                }
                this.buf[2] = BitConverter.GetBytes(this.li[this.lsint].x)[1];
                this.buf[3] = BitConverter.GetBytes(this.li[this.lsint].x)[0];
                this.buf[4] = BitConverter.GetBytes(this.li[this.lsint].y)[1];
                this.buf[5] = BitConverter.GetBytes(this.li[this.lsint].y)[0];
                this.buf[6] = BitConverter.GetBytes(this.lsd2)[1];
                this.buf[7] = BitConverter.GetBytes(this.lsd2)[0];
                this.buf[8] = (byte) (255M - this.trackBarStrong.Value);
                if (this.serialPort1.IsOpen && this.ckisok)
                {
                    this.serialPort1.Write(this.buf, 0, 11);
                }
                this.lsint++;
            }
            else
            {
                this.lsint = 0;
                this.isdking = false;
                this.updata.Enabled = false;
                this.progressBar1.Value = this.progressBar1.Maximum;
                this.guiling();
            }
        }

        private void dkc()
        {
            if (this.lic.Count > this.lsint)
            {
                if (this.lic[this.lsint].lx == 0)
                {
                    this.buf[1] = 0x6b;
                }
                else
                {
                    this.buf[1] = 0x71;
                    this.lsd2 = this.lic[this.lsint].time / this.V;
                    this.lsd2 = 0x10000 - this.lsd2;
                }
                this.buf[2] = BitConverter.GetBytes(this.lic[this.lsint].x)[1];
                this.buf[3] = BitConverter.GetBytes(this.lic[this.lsint].x)[0];
                this.buf[4] = BitConverter.GetBytes(this.lic[this.lsint].y)[1];
                this.buf[5] = BitConverter.GetBytes(this.lic[this.lsint].y)[0];
                this.buf[6] = BitConverter.GetBytes(this.lsd2)[1];
                this.buf[7] = BitConverter.GetBytes(this.lsd2)[0];
                this.buf[8] = (byte) (255M - this.trackBarStrong.Value);
                if (this.serialPort1.IsOpen && this.ckisok)
                {
                    this.serialPort1.Write(this.buf, 0, 11);
                }
                this.lsint++;
            }
            else
            {
                this.lsint = 0;
                this.isdking = false;
                this.updata.Enabled = false;
                this.progressBar1.Value = this.progressBar1.Maximum;
                this.guiling();
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            this.ApplyResource();
            this.pictureBox1.Location = new Point(this.pictureBox2.Location.X + 0x17, this.pictureBox2.Location.Y + 0x17);
            this.pictureBoxX.Location = this.pictureBox1.Location;
            this.pictureBoxY.Location = this.pictureBox1.Location;
            regedit.write("yuyan", "en");
            this.yuyan = 2;
            this.context();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.buf[1] = 0x54;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            regedit.write("strong", this.trackBarStrong.Value.ToString());
            regedit.write("time", this.trackBarTime.Value.ToString());
            regedit.write("speed", this.comboBox2.SelectedIndex.ToString());
            regedit.write("ci", this.cinum.Value.ToString());
            Process.GetCurrentProcess().Kill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.jisuanmax(1);
            this.pictureBox2.Image = Resources.A402c;
            this.gcode2();
            if (this.checksize())
            {
                this.bianjie2(this.li);
            }
            this.xs();
            this.pictureBox1.Location = new Point(this.pictureBox2.Location.X + 0x17, this.pictureBox2.Location.Y + 0x17);
            this.pictureBoxX.Location = this.pictureBox1.Location;
            this.pictureBoxY.Location = this.pictureBox1.Location;
            this.upxian();
            decimal num = Convert.ToDecimal(regedit.read("time"));
            if (num == 0M)
            {
                num = 15M;
            }
            this.trackBarTime.Value = num;
            num = Convert.ToDecimal(regedit.read("strong"));
            if (num == 0M)
            {
                num = 255M;
            }
            this.trackBarStrong.Value = num;
            num = Convert.ToDecimal(regedit.read("ci"));
            if (num == 0M)
            {
                num = 1M;
            }
            this.cinum.Value = num;
            string str = regedit.read("speed");
            if (str == null)
            {
                this.comboBox2.SelectedIndex = 1;
            }
            else
            {
                this.lsint = Convert.ToInt32(str);
                this.comboBox2.SelectedIndex = this.lsint;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(base.Size.Width - 0x1d8, base.Size.Height - 0x34);
        }

        private void gcode(string lj)
        {
            line line;
            this.liy.Clear();
            using (StreamReader reader = new StreamReader(lj, Encoding.Default))
            {
                char[] separator = new char[] { 'X', ' ', 'Y', 'F' };
                char[] chArray2 = new char[] { 'X', ' ', 'F' };
                char[] chArray3 = new char[] { 'Y', ' ', 'F' };
                char[] chArray4 = new char[] { 'X', ' ', 'Y', 'F', 'I', 'J' };
                char[] chArray5 = new char[] { 'X', ' ', 'Y', 'F', 'R' };
                while (reader.Peek() >= 0)
                {
                    float num;
                    int num2;
                    string[] strArray;
                    string source = reader.ReadLine().Replace(',', '.');
                    if (source.StartsWith("G01 ") || source.StartsWith("G1 "))
                    {
                        if (source.Contains<char>('X'))
                        {
                            if (source.Contains<char>('Y'))
                            {
                                line = new line {
                                    lx = 1
                                };
                                strArray = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                num = float.Parse(strArray[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                num = float.Parse(strArray[2], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.y = num2;
                                this.liy.Add(line);
                            }
                            else
                            {
                                line = new line {
                                    lx = 1
                                };
                                num = float.Parse(source.Split(chArray2, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                line.y = this.liy[this.liy.Count - 1].y;
                                this.liy.Add(line);
                            }
                        }
                        else if (source.Contains<char>('Y'))
                        {
                            line = new line {
                                lx = 1
                            };
                            num = float.Parse(source.Split(chArray3, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            line.y = num2;
                            line.x = this.liy[this.liy.Count - 1].x;
                            this.liy.Add(line);
                        }
                    }
                    else if (source.StartsWith("G02 ") || source.StartsWith("G2 "))
                    {
                        if (source.Contains<char>('R'))
                        {
                            line = new line {
                                lx = 1
                            };
                            strArray = source.Split(chArray5, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            line.x = this.hx;
                            line.y = this.hy;
                            this.liy.Add(line);
                        }
                        else
                        {
                            strArray = source.Split(chArray4, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            num = float.Parse(strArray[4], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hj = num2;
                            this.qdx = this.liy[this.liy.Count - 1].x;
                            this.qdy = this.liy[this.liy.Count - 1].y;
                            this.yxx = this.qdx + this.hi;
                            this.yxy = this.qdy + this.hj;
                            this.NR = 0;
                            this.yhcb(this.qdx - this.yxx, this.qdy - this.yxy, this.hx - this.yxx, this.hy - this.yxy);
                        }
                    }
                    else if (source.StartsWith("G03 ") || source.StartsWith("G3 "))
                    {
                        if (source.Contains<char>('R'))
                        {
                            line = new line {
                                lx = 1
                            };
                            strArray = source.Split(chArray5, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            line.x = this.hx;
                            line.y = this.hy;
                            this.liy.Add(line);
                        }
                        else
                        {
                            strArray = source.Split(chArray4, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            num = float.Parse(strArray[4], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hj = num2;
                            this.qdx = this.liy[this.liy.Count - 1].x;
                            this.qdy = this.liy[this.liy.Count - 1].y;
                            this.yxx = this.qdx + this.hi;
                            this.yxy = this.qdy + this.hj;
                            this.NR = 1;
                            this.yhcb(this.qdx - this.yxx, this.qdy - this.yxy, this.hx - this.yxx, this.hy - this.yxy);
                        }
                    }
                    else if (source.StartsWith("G00") || source.StartsWith("G0 "))
                    {
                        if (source.Contains<char>('X'))
                        {
                            if (source.Contains<char>('Y'))
                            {
                                line = new line {
                                    lx = 0
                                };
                                strArray = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                num = float.Parse(strArray[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                num = float.Parse(strArray[2], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.y = num2;
                                this.liy.Add(line);
                            }
                            else
                            {
                                line = new line {
                                    lx = 0
                                };
                                num = float.Parse(source.Split(chArray2, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                line.y = this.liy[this.liy.Count - 1].y;
                                this.liy.Add(line);
                            }
                        }
                        else if (source.Contains<char>('Y'))
                        {
                            line = new line {
                                lx = 0
                            };
                            num = float.Parse(source.Split(chArray3, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            line.y = num2;
                            line.x = this.liy[this.liy.Count - 1].x;
                            this.liy.Add(line);
                        }
                    }
                    else if (source.Contains<char>('X'))
                    {
                        if (this.liy.Count > 0)
                        {
                            if (source.Contains<char>('Y'))
                            {
                                line = new line {
                                    lx = this.liy[this.liy.Count - 1].lx
                                };
                                strArray = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                num = float.Parse(strArray[0], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                num = float.Parse(strArray[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.y = num2;
                                this.liy.Add(line);
                            }
                            else
                            {
                                line = new line {
                                    lx = this.liy[this.liy.Count - 1].lx
                                };
                                num = float.Parse(source.Split(chArray2, StringSplitOptions.RemoveEmptyEntries)[0], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                line.y = this.liy[this.liy.Count - 1].y;
                                this.liy.Add(line);
                            }
                        }
                    }
                    else if (source.Contains<char>('Y') && (this.liy.Count > 0))
                    {
                        line = new line {
                            lx = this.liy[this.liy.Count - 1].lx
                        };
                        num = float.Parse(source.Split(chArray3, StringSplitOptions.RemoveEmptyEntries)[0], this.nfi) * this.fd;
                        num2 = (int) Math.Round((double) num);
                        line.y = num2;
                        line.x = this.liy[this.liy.Count - 1].x;
                        this.liy.Add(line);
                    }
                }
            }
            if (this.liy.Count > 0)
            {
                while (this.liy[this.liy.Count - 1].lx == 0)
                {
                    if ((this.liy[this.liy.Count - 1].x == 0) || (this.liy[this.liy.Count - 1].y == 0))
                    {
                        this.liy.RemoveAt(this.liy.Count - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                this.bianjie(ref this.liy);
                this.ymaxx = this.maxx;
                this.ymaxy = this.maxy;
                this.yminx = this.minx;
                this.yminy = this.miny;
                this.li.Clear();
                foreach (line line2 in this.liy)
                {
                    line = new line {
                        lx = line2.lx,
                        x = line2.x,
                        y = line2.y
                    };
                    this.li.Add(line);
                }
            }
        }

        private void gcode2()
        {
            line line;
            this.liy.Clear();
            using (StringReader reader = new StringReader(this.yuan))
            {
                char[] separator = new char[] { 'X', ' ', 'Y', 'F' };
                char[] chArray2 = new char[] { 'X', ' ', 'F' };
                char[] chArray3 = new char[] { 'Y', ' ', 'F' };
                char[] chArray4 = new char[] { 'X', ' ', 'Y', 'F', 'I', 'J' };
                char[] chArray5 = new char[] { 'X', ' ', 'Y', 'F', 'R' };
                while (reader.Peek() >= 0)
                {
                    float num;
                    int num2;
                    string[] strArray;
                    string source = reader.ReadLine().Replace(',', '.');
                    if (source.StartsWith("G01 ") || source.StartsWith("G1 "))
                    {
                        if (source.Contains<char>('X'))
                        {
                            if (source.Contains<char>('Y'))
                            {
                                line = new line {
                                    lx = 1
                                };
                                strArray = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                num = float.Parse(strArray[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                num = float.Parse(strArray[2], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.y = num2;
                                this.liy.Add(line);
                            }
                            else
                            {
                                line = new line {
                                    lx = 1
                                };
                                num = float.Parse(source.Split(chArray2, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                line.y = this.liy[this.liy.Count - 1].y;
                                this.liy.Add(line);
                            }
                        }
                        else if (source.Contains<char>('Y'))
                        {
                            line = new line {
                                lx = 1
                            };
                            num = float.Parse(source.Split(chArray3, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            line.y = num2;
                            line.x = this.liy[this.liy.Count - 1].x;
                            this.liy.Add(line);
                        }
                    }
                    else if (source.StartsWith("G02 ") || source.StartsWith("G2 "))
                    {
                        if (source.Contains<char>('R'))
                        {
                            line = new line {
                                lx = 1
                            };
                            strArray = source.Split(chArray5, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            line.x = this.hx;
                            line.y = this.hy;
                            this.liy.Add(line);
                        }
                        else
                        {
                            strArray = source.Split(chArray4, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            num = float.Parse(strArray[4], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hj = num2;
                            this.qdx = this.liy[this.liy.Count - 1].x;
                            this.qdy = this.liy[this.liy.Count - 1].y;
                            this.yxx = this.qdx + this.hi;
                            this.yxy = this.qdy + this.hj;
                            this.NR = 0;
                            this.yhcb(this.qdx - this.yxx, this.qdy - this.yxy, this.hx - this.yxx, this.hy - this.yxy);
                        }
                    }
                    else if (source.StartsWith("G03 ") || source.StartsWith("G3 "))
                    {
                        if (source.Contains<char>('R'))
                        {
                            line = new line {
                                lx = 1
                            };
                            strArray = source.Split(chArray5, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            line.x = this.hx;
                            line.y = this.hy;
                            this.liy.Add(line);
                        }
                        else
                        {
                            strArray = source.Split(chArray4, StringSplitOptions.RemoveEmptyEntries);
                            this.xpo = this.liy[this.liy.Count - 1].x;
                            this.ypo = this.liy[this.liy.Count - 1].y;
                            num = float.Parse(strArray[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hx = num2;
                            num = float.Parse(strArray[2], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hy = num2;
                            num = float.Parse(strArray[3], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hi = num2;
                            num = float.Parse(strArray[4], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            this.hj = num2;
                            this.qdx = this.liy[this.liy.Count - 1].x;
                            this.qdy = this.liy[this.liy.Count - 1].y;
                            this.yxx = this.qdx + this.hi;
                            this.yxy = this.qdy + this.hj;
                            this.NR = 1;
                            this.yhcb(this.qdx - this.yxx, this.qdy - this.yxy, this.hx - this.yxx, this.hy - this.yxy);
                        }
                    }
                    else if (source.StartsWith("G00") || source.StartsWith("G0 "))
                    {
                        if (source.Contains<char>('X'))
                        {
                            if (source.Contains<char>('Y'))
                            {
                                line = new line {
                                    lx = 0
                                };
                                strArray = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                num = float.Parse(strArray[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                num = float.Parse(strArray[2], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.y = num2;
                                this.liy.Add(line);
                            }
                            else
                            {
                                line = new line {
                                    lx = 0
                                };
                                num = float.Parse(source.Split(chArray2, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                line.y = this.liy[this.liy.Count - 1].y;
                                this.liy.Add(line);
                            }
                        }
                        else if (source.Contains<char>('Y'))
                        {
                            line = new line {
                                lx = 0
                            };
                            num = float.Parse(source.Split(chArray3, StringSplitOptions.RemoveEmptyEntries)[1], this.nfi) * this.fd;
                            num2 = (int) Math.Round((double) num);
                            line.y = num2;
                            line.x = this.liy[this.liy.Count - 1].x;
                            this.liy.Add(line);
                        }
                    }
                    else if (source.Contains<char>('X'))
                    {
                        if (this.liy.Count > 0)
                        {
                            if (source.Contains<char>('Y'))
                            {
                                line = new line {
                                    lx = this.liy[this.liy.Count - 1].lx
                                };
                                strArray = source.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                num = float.Parse(strArray[0], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                num = float.Parse(strArray[1], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.y = num2;
                                this.liy.Add(line);
                            }
                            else
                            {
                                line = new line {
                                    lx = this.liy[this.liy.Count - 1].lx
                                };
                                num = float.Parse(source.Split(chArray2, StringSplitOptions.RemoveEmptyEntries)[0], this.nfi) * this.fd;
                                num2 = (int) Math.Round((double) num);
                                line.x = num2;
                                line.y = this.liy[this.liy.Count - 1].y;
                                this.liy.Add(line);
                            }
                        }
                    }
                    else if (source.Contains<char>('Y') && (this.liy.Count > 0))
                    {
                        line = new line {
                            lx = this.liy[this.liy.Count - 1].lx
                        };
                        num = float.Parse(source.Split(chArray3, StringSplitOptions.RemoveEmptyEntries)[0], this.nfi) * this.fd;
                        num2 = (int) Math.Round((double) num);
                        line.y = num2;
                        line.x = this.liy[this.liy.Count - 1].x;
                        this.liy.Add(line);
                    }
                }
            }
            if (this.liy.Count > 0)
            {
                while (this.liy[this.liy.Count - 1].lx == 0)
                {
                    if ((this.liy[this.liy.Count - 1].x == 0) || (this.liy[this.liy.Count - 1].y == 0))
                    {
                        this.liy.RemoveAt(this.liy.Count - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                this.bianjie(ref this.liy);
                this.ymaxx = this.maxx;
                this.ymaxy = this.maxy;
                this.yminx = this.minx;
                this.yminy = this.miny;
                this.li.Clear();
                foreach (line line2 in this.liy)
                {
                    line = new line {
                        lx = line2.lx,
                        x = line2.x,
                        y = line2.y
                    };
                    this.li.Add(line);
                }
            }
        }

        private void guiling()
        {
            this.buf[1] = 0x47;
            int num = this.px * 0x20;
            this.buf[2] = BitConverter.GetBytes(num)[1];
            this.buf[3] = BitConverter.GetBytes(num)[0];
            num = this.py * 0x20;
            this.buf[4] = BitConverter.GetBytes(num)[1];
            this.buf[5] = BitConverter.GetBytes(num)[0];
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.label1 = new Label();
            this.serialPort1 = new SerialPort(this.components);
            this.label5 = new Label();
            this.label12 = new Label();
            this.cktime = new System.Windows.Forms.Timer(this.components);
            this.buttonleft = new Button();
            this.fontDialog1 = new FontDialog();
            this.label4 = new Label();
            this.label19 = new Label();
            this.阿灿的世界 = new NotifyIcon(this.components);
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.重新连接ToolStripMenuItem = new ToolStripMenuItem();
            this.阿灿的世界ToolStripMenuItem = new ToolStripMenuItem();
            this.englishToolStripMenuItem = new ToolStripMenuItem();
            this.繁体ToolStripMenuItem = new ToolStripMenuItem();
            this.русскийToolStripMenuItem = new ToolStripMenuItem();
            this.简体ToolStripMenuItem = new ToolStripMenuItem();
            this.trackBarStrong = new NumericUpDown();
            this.trackBarTime = new NumericUpDown();
            this.label2 = new Label();
            this.panel1 = new Panel();
            this.定位 = new ContextMenuStrip(this.components);
            this.左上ToolStripMenuItem = new ToolStripMenuItem();
            this.左中ToolStripMenuItem = new ToolStripMenuItem();
            this.中ToolStripMenuItem = new ToolStripMenuItem();
            this.pictureBoxY = new PictureBox();
            this.pictureBoxX = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new Label();
            this.button21 = new Button();
            this.button20 = new Button();
            this.button5 = new Button();
            this.button6 = new Button();
            this.button15 = new Button();
            this.button14 = new Button();
            this.button12 = new Button();
            this.button4 = new Button();
            this.buttonkai = new Button();
            this.buttonup = new Button();
            this.buttonStop = new Button();
            this.buttonStart = new Button();
            this.buttonOpen = new Button();
            this.button18 = new Button();
            this.button19 = new Button();
            this.button22 = new Button();
            this.button23 = new Button();
            this.button24 = new Button();
            this.button25 = new Button();
            this.button26 = new Button();
            this.button27 = new Button();
            this.panel2 = new Panel();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label18 = new Label();
            this.comboBox2 = new ComboBox();
            this.label9 = new Label();
            this.label10 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            this.cinum = new NumericUpDown();
            this.label11 = new Label();
            this.label13 = new Label();
            this.label14 = new Label();
            this.updata = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new ProgressBar();
            this.label3 = new Label();
            this.contextMenuStrip1.SuspendLayout();
            this.trackBarStrong.BeginInit();
            this.trackBarTime.BeginInit();
            this.panel1.SuspendLayout();
            this.定位.SuspendLayout();
            ((ISupportInitialize) this.pictureBoxY).BeginInit();
            ((ISupportInitialize) this.pictureBoxX).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            this.panel2.SuspendLayout();
            this.numericUpDown1.BeginInit();
            this.cinum.BeginInit();
            base.SuspendLayout();
            manager.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = SystemColors.MenuHighlight;
            this.label1.Name = "label1";
            this.serialPort1.BaudRate = 0x9600;
            this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            manager.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = SystemColors.Desktop;
            this.label5.Name = "label5";
            manager.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = SystemColors.Desktop;
            this.label12.Name = "label12";
            this.cktime.Enabled = true;
            this.cktime.Interval = 250;
            this.cktime.Tick += new EventHandler(this.cktime_Tick);
            manager.ApplyResources(this.buttonleft, "buttonleft");
            this.buttonleft.ForeColor = Color.Crimson;
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.MouseDown += new MouseEventHandler(this.buttonleft_MouseDown);
            this.buttonleft.MouseUp += new MouseEventHandler(this.buttonleft_MouseUp);
            this.fontDialog1.Font = new Font("宋体", 25.8f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            manager.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            manager.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = SystemColors.Desktop;
            this.label19.Name = "label19";
            this.阿灿的世界.ContextMenuStrip = this.contextMenuStrip1;
            manager.ApplyResources(this.阿灿的世界, "阿灿的世界");
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.重新连接ToolStripMenuItem, this.阿灿的世界ToolStripMenuItem, this.englishToolStripMenuItem, this.繁体ToolStripMenuItem, this.русскийToolStripMenuItem, this.简体ToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            manager.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.重新连接ToolStripMenuItem.Name = "重新连接ToolStripMenuItem";
            manager.ApplyResources(this.重新连接ToolStripMenuItem, "重新连接ToolStripMenuItem");
            this.重新连接ToolStripMenuItem.Click += new EventHandler(this.重新连接ToolStripMenuItem_Click);
            this.阿灿的世界ToolStripMenuItem.Name = "阿灿的世界ToolStripMenuItem";
            manager.ApplyResources(this.阿灿的世界ToolStripMenuItem, "阿灿的世界ToolStripMenuItem");
            this.阿灿的世界ToolStripMenuItem.Click += new EventHandler(this.阿灿的世界ToolStripMenuItem_Click);
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            manager.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new EventHandler(this.englishToolStripMenuItem_Click);
            this.繁体ToolStripMenuItem.Name = "繁体ToolStripMenuItem";
            manager.ApplyResources(this.繁体ToolStripMenuItem, "繁体ToolStripMenuItem");
            this.繁体ToolStripMenuItem.Click += new EventHandler(this.繁体ToolStripMenuItem_Click);
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            manager.ApplyResources(this.русскийToolStripMenuItem, "русскийToolStripMenuItem");
            this.русскийToolStripMenuItem.Click += new EventHandler(this.русскийToolStripMenuItem_Click);
            this.简体ToolStripMenuItem.Name = "简体ToolStripMenuItem";
            manager.ApplyResources(this.简体ToolStripMenuItem, "简体ToolStripMenuItem");
            this.简体ToolStripMenuItem.Click += new EventHandler(this.简体ToolStripMenuItem_Click);
            manager.ApplyResources(this.trackBarStrong, "trackBarStrong");
            int[] bits = new int[4];
            bits[0] = 0xff;
            this.trackBarStrong.Maximum = new decimal(bits);
            this.trackBarStrong.Name = "trackBarStrong";
            bits = new int[4];
            bits[0] = 0xeb;
            this.trackBarStrong.Value = new decimal(bits);
            this.trackBarTime.DecimalPlaces = 2;
            bits = new int[4];
            bits[0] = 1;
            bits[3] = 0x10000;
            this.trackBarTime.Increment = new decimal(bits);
            manager.ApplyResources(this.trackBarTime, "trackBarTime");
            bits = new int[4];
            bits[0] = 50;
            this.trackBarTime.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 1;
            this.trackBarTime.Minimum = new decimal(bits);
            this.trackBarTime.Name = "trackBarTime";
            bits = new int[4];
            bits[0] = 10;
            this.trackBarTime.Value = new decimal(bits);
            this.trackBarTime.ValueChanged += new EventHandler(this.timeup_ValueChanged);
            manager.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = SystemColors.Desktop;
            this.label2.Name = "label2";
            manager.ApplyResources(this.panel1, "panel1");
            this.panel1.ContextMenuStrip = this.定位;
            this.panel1.Controls.Add(this.pictureBoxY);
            this.panel1.Controls.Add(this.pictureBoxX);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Name = "panel1";
            this.定位.Items.AddRange(new ToolStripItem[] { this.左上ToolStripMenuItem, this.左中ToolStripMenuItem, this.中ToolStripMenuItem });
            this.定位.Name = "定位";
            manager.ApplyResources(this.定位, "定位");
            this.左上ToolStripMenuItem.Name = "左上ToolStripMenuItem";
            manager.ApplyResources(this.左上ToolStripMenuItem, "左上ToolStripMenuItem");
            this.左上ToolStripMenuItem.Click += new EventHandler(this.左上ToolStripMenuItem_Click);
            this.左中ToolStripMenuItem.Name = "左中ToolStripMenuItem";
            manager.ApplyResources(this.左中ToolStripMenuItem, "左中ToolStripMenuItem");
            this.左中ToolStripMenuItem.Click += new EventHandler(this.左中ToolStripMenuItem_Click);
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            manager.ApplyResources(this.中ToolStripMenuItem, "中ToolStripMenuItem");
            this.中ToolStripMenuItem.Click += new EventHandler(this.中ToolStripMenuItem_Click);
            manager.ApplyResources(this.pictureBoxY, "pictureBoxY");
            this.pictureBoxY.Name = "pictureBoxY";
            this.pictureBoxY.TabStop = false;
            manager.ApplyResources(this.pictureBoxX, "pictureBoxX");
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.TabStop = false;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = Resources.ac;
            manager.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            manager.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = Resources.A402c;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.timer1.Enabled = true;
            this.timer1.Interval = 0x1388;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            manager.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = SystemColors.Desktop;
            this.label8.Name = "label8";
            manager.ApplyResources(this.button21, "button21");
            this.button21.ForeColor = Color.Crimson;
            this.button21.Name = "button21";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new EventHandler(this.button21_Click);
            manager.ApplyResources(this.button20, "button20");
            this.button20.ForeColor = Color.Crimson;
            this.button20.Name = "button20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new EventHandler(this.button20_Click);
            manager.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = Color.Crimson;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new MouseEventHandler(this.button5_MouseUp);
            manager.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = Color.Crimson;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseUp += new MouseEventHandler(this.button6_MouseUp);
            manager.ApplyResources(this.button15, "button15");
            this.button15.ForeColor = Color.Crimson;
            this.button15.Image = Resources.q;
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseDown += new MouseEventHandler(this.button15_MouseDown);
            this.button15.MouseUp += new MouseEventHandler(this.button15_MouseUp);
            manager.ApplyResources(this.button14, "button14");
            this.button14.ForeColor = SystemColors.HotTrack;
            this.button14.Image = Resources.zt;
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new EventHandler(this.button14_Click);
            manager.ApplyResources(this.button12, "button12");
            this.button12.ForeColor = Color.Crimson;
            this.button12.Image = Resources.r2;
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new EventHandler(this.button12_Click);
            manager.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = Color.Crimson;
            this.button4.Image = Resources.g;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click_1);
            manager.ApplyResources(this.buttonkai, "buttonkai");
            this.buttonkai.ForeColor = Color.Crimson;
            this.buttonkai.Image = Resources.r1;
            this.buttonkai.Name = "buttonkai";
            this.buttonkai.UseVisualStyleBackColor = true;
            this.buttonkai.Click += new EventHandler(this.buttonkai_Click);
            manager.ApplyResources(this.buttonup, "buttonup");
            this.buttonup.ForeColor = Color.Crimson;
            this.buttonup.Image = Resources.sang;
            this.buttonup.Name = "buttonup";
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.MouseDown += new MouseEventHandler(this.buttonup_MouseDown);
            this.buttonup.MouseUp += new MouseEventHandler(this.buttonup_MouseUp);
            manager.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.ForeColor = SystemColors.HotTrack;
            this.buttonStop.Image = Resources.tz;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new EventHandler(this.buttonStop_Click);
            manager.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.ForeColor = SystemColors.HotTrack;
            this.buttonStart.Image = Resources.ks;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new EventHandler(this.button3_Click);
            this.buttonOpen.BackColor = Color.Transparent;
            manager.ApplyResources(this.buttonOpen, "buttonOpen");
            this.buttonOpen.FlatAppearance.BorderColor = Color.Red;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.buttonOpen.ForeColor = SystemColors.HotTrack;
            this.buttonOpen.Image = Resources.wj;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new EventHandler(this.button2_Click);
            manager.ApplyResources(this.button18, "button18");
            this.button18.ForeColor = Color.Crimson;
            this.button18.Image = Resources.sang;
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseDown += new MouseEventHandler(this.button18_MouseDown);
            this.button18.MouseUp += new MouseEventHandler(this.button18_MouseUp);
            manager.ApplyResources(this.button19, "button19");
            this.button19.ForeColor = Color.Crimson;
            this.button19.Image = Resources.sang;
            this.button19.Name = "button19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseDown += new MouseEventHandler(this.button19_MouseDown);
            this.button19.MouseUp += new MouseEventHandler(this.button19_MouseUp);
            manager.ApplyResources(this.button22, "button22");
            this.button22.ForeColor = Color.Crimson;
            this.button22.Name = "button22";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.MouseDown += new MouseEventHandler(this.button22_MouseDown);
            this.button22.MouseUp += new MouseEventHandler(this.button22_MouseUp);
            manager.ApplyResources(this.button23, "button23");
            this.button23.ForeColor = Color.Crimson;
            this.button23.Name = "button23";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.MouseDown += new MouseEventHandler(this.button23_MouseDown);
            this.button23.MouseUp += new MouseEventHandler(this.button23_MouseUp);
            manager.ApplyResources(this.button24, "button24");
            this.button24.ForeColor = Color.Crimson;
            this.button24.Name = "button24";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.MouseDown += new MouseEventHandler(this.button24_MouseDown);
            this.button24.MouseUp += new MouseEventHandler(this.button24_MouseUp);
            manager.ApplyResources(this.button25, "button25");
            this.button25.ForeColor = Color.Crimson;
            this.button25.Image = Resources.xia;
            this.button25.Name = "button25";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.MouseDown += new MouseEventHandler(this.button25_MouseDown);
            this.button25.MouseUp += new MouseEventHandler(this.button25_MouseUp);
            manager.ApplyResources(this.button26, "button26");
            this.button26.ForeColor = Color.Crimson;
            this.button26.Image = Resources.xia;
            this.button26.Name = "button26";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.MouseDown += new MouseEventHandler(this.button26_MouseDown);
            this.button26.MouseUp += new MouseEventHandler(this.button26_MouseUp);
            manager.ApplyResources(this.button27, "button27");
            this.button27.ForeColor = Color.Crimson;
            this.button27.Image = Resources.xia;
            this.button27.Name = "button27";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.MouseDown += new MouseEventHandler(this.button27_MouseDown);
            this.button27.MouseUp += new MouseEventHandler(this.button27_MouseUp);
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonkai);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Controls.Add(this.buttonup);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.buttonleft);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            manager.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            manager.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = SystemColors.Desktop;
            this.label6.Name = "label6";
            manager.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = SystemColors.Desktop;
            this.label7.Name = "label7";
            manager.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = SystemColors.Desktop;
            this.label18.Name = "label18";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] { manager.GetString("comboBox2.Items"), manager.GetString("comboBox2.Items1"), manager.GetString("comboBox2.Items2"), manager.GetString("comboBox2.Items3"), manager.GetString("comboBox2.Items4") });
            manager.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            manager.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = SystemColors.Desktop;
            this.label9.Name = "label9";
            manager.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = SystemColors.Desktop;
            this.label10.Name = "label10";
            this.numericUpDown1.DecimalPlaces = 2;
            manager.ApplyResources(this.numericUpDown1, "numericUpDown1");
            bits = new int[4];
            bits[0] = 400;
            this.numericUpDown1.Maximum = new decimal(bits);
            this.numericUpDown1.Name = "numericUpDown1";
            bits = new int[4];
            bits[0] = 1;
            this.numericUpDown1.Value = new decimal(bits);
            this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
            manager.ApplyResources(this.cinum, "cinum");
            bits = new int[4];
            bits[0] = 1;
            this.cinum.Minimum = new decimal(bits);
            this.cinum.Name = "cinum";
            bits = new int[4];
            bits[0] = 1;
            this.cinum.Value = new decimal(bits);
            manager.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = SystemColors.Desktop;
            this.label11.Name = "label11";
            manager.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = SystemColors.Desktop;
            this.label13.Name = "label13";
            manager.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = SystemColors.Desktop;
            this.label14.Name = "label14";
            this.updata.Interval = 990;
            this.updata.Tick += new EventHandler(this.updata_Tick);
            manager.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            manager.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            base.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.White;
            manager.ApplyResources(this, "$this");
            base.Controls.Add(this.label3);
            base.Controls.Add(this.progressBar1);
            base.Controls.Add(this.label14);
            base.Controls.Add(this.label13);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.cinum);
            base.Controls.Add(this.numericUpDown1);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.comboBox2);
            base.Controls.Add(this.label18);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.button14);
            base.Controls.Add(this.trackBarTime);
            base.Controls.Add(this.trackBarStrong);
            base.Controls.Add(this.buttonStop);
            base.Controls.Add(this.buttonStart);
            base.Controls.Add(this.label12);
            base.Controls.Add(this.buttonOpen);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label1);
            base.Name = "Form1";
            base.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
            base.Load += new EventHandler(this.Form1_Load);
            base.SizeChanged += new EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.trackBarStrong.EndInit();
            this.trackBarTime.EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.定位.ResumeLayout(false);
            ((ISupportInitialize) this.pictureBoxY).EndInit();
            ((ISupportInitialize) this.pictureBoxX).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.numericUpDown1.EndInit();
            this.cinum.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void jisuanf()
        {
            double num;
            int num2;
            long num3;
            long num4;
            long num5;
            long num6;
            this.V = (int) (this.trackBarTime.Value * this.fd);
            if (this.li[0].lx == 1)
            {
                num5 = Math.Abs((int) (this.li[0].x - (this.px * 0x20)));
                num6 = Math.Abs((int) (this.li[0].y - (this.py * 0x20)));
                num = (num5 * num5) + (num6 * num6);
                num4 = (int) Math.Sqrt(num);
                num3 = num5 + num6;
                if (num3 == 0L)
                {
                    this.li[0].time = 0;
                }
                else
                {
                    num2 = (int) ((num4 * 0x177000L) / num3);
                    this.li[0].time = num2;
                }
            }
            for (int i = 1; i < this.li.Count; i++)
            {
                if (this.li[i].lx == 1)
                {
                    num5 = Math.Abs((int) (this.li[i].x - this.li[i - 1].x));
                    num6 = Math.Abs((int) (this.li[i].y - this.li[i - 1].y));
                    num = (num5 * num5) + (num6 * num6);
                    num4 = (int) Math.Sqrt(num);
                    num3 = num5 + num6;
                    if (num3 == 0L)
                    {
                        this.li[i].time = 0;
                    }
                    else
                    {
                        num2 = (int) ((num4 * 0x177000L) / num3);
                        this.li[i].time = num2;
                    }
                }
            }
        }

        private void jisuanfc()
        {
            double num;
            int num2;
            long num3;
            long num4;
            long num5;
            long num6;
            this.V = (int) (this.trackBarTime.Value * this.fd);
            if (this.lic[0].lx == 1)
            {
                num5 = Math.Abs((int) (this.lic[0].x - (this.px * 0x20)));
                num6 = Math.Abs((int) (this.lic[0].y - (this.py * 0x20)));
                num = (num5 * num5) + (num6 * num6);
                num4 = (int) Math.Sqrt(num);
                num3 = num5 + num6;
                if (num3 == 0L)
                {
                    this.lic[0].time = 0;
                }
                else
                {
                    num2 = (int) ((num4 * 0x177000L) / num3);
                    this.lic[0].time = num2;
                }
            }
            for (int i = 1; i < this.lic.Count; i++)
            {
                if (this.lic[i].lx == 1)
                {
                    num5 = Math.Abs((int) (this.lic[i].x - this.lic[i - 1].x));
                    num6 = Math.Abs((int) (this.lic[i].y - this.lic[i - 1].y));
                    num = (num5 * num5) + (num6 * num6);
                    num4 = (int) Math.Sqrt(num);
                    num3 = num5 + num6;
                    if (num3 == 0L)
                    {
                        this.lic[i].time = 0;
                    }
                    else
                    {
                        num2 = (int) ((num4 * 0x177000L) / num3);
                        this.lic[i].time = num2;
                    }
                }
            }
        }

        private void jisuanmax(int b)
        {
            float num = 0.00625f * b;
            this.maxh = (int) (((float) this.hangchengh) / num);
            this.maxw = (int) (((float) this.hangchengw) / num);
        }

        private byte Line_determing(int x2, int y2)
        {
            byte num = 0;
            if ((x2 > 0) && (y2 > 0))
            {
                num = 1;
            }
            if ((x2 < 0) && (y2 > 0))
            {
                num = 2;
            }
            if ((x2 < 0) && (y2 < 0))
            {
                num = 3;
            }
            if ((x2 > 0) && (y2 < 0))
            {
                num = 4;
            }
            if ((x2 > 0) && (y2 == 0))
            {
                num = 5;
            }
            if ((x2 == 0) && (y2 > 0))
            {
                num = 6;
            }
            if ((x2 < 0) && (y2 == 0))
            {
                num = 7;
            }
            if ((x2 == 0) && (y2 < 0))
            {
                num = 8;
            }
            return num;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.lsbool)
            {
                float num = (int) (this.numericUpDown1.Value * 160M);
                float bs = num / ((float) this.maxx);
                float num3 = this.maxy * bs;
                if ((num > this.maxw) || (num3 > this.maxh))
                {
                    if (num3 > this.maxh)
                    {
                        bs = ((float) this.maxh) / ((float) this.ymaxy);
                        this.ResizeImage(bs);
                    }
                    else
                    {
                        bs = ((float) this.maxw) / ((float) this.ymaxx);
                        this.ResizeImage(bs);
                    }
                }
                else
                {
                    bs = num / ((float) this.ymaxx);
                    this.ResizeImage(bs);
                }
                this.bianjie2(this.li);
                this.xs();
                this.upxian();
            }
            this.lsbool = true;
        }

        public void openck(string s)
        {
            try
            {
                this.serialPort1.Close();
                this.serialPort1.PortName = s;
                this.serialPort1.Open();
            }
            catch
            {
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                this.upt();
                this.ispause = false;
                if (!this.isdking)
                {
                    if (this.cinum.Value != 1M)
                    {
                        this.ci();
                        this.jisuanfc();
                        this.isci = true;
                        this.progressBar1.Maximum = this.lic.Count;
                    }
                    else
                    {
                        this.isci = false;
                        this.jisuanf();
                        this.progressBar1.Maximum = this.li.Count;
                    }
                    this.isdking = true;
                    this.updata.Enabled = true;
                    this.time = 0;
                    this.label3.Text = "0:0:0";
                    this.progressBar1.Value = 0;
                    this.lsint = 0;
                    this.setxy();
                    this.setspdpi();
                    this.setwt();
                    if (this.isci)
                    {
                        this.dkc();
                    }
                    else
                    {
                        this.dk();
                    }
                }
                else
                {
                    this.updata.Enabled = true;
                    if (this.isci)
                    {
                        this.dkc();
                    }
                    else
                    {
                        this.dk();
                    }
                }
            }
            if (keyData == Keys.F2)
            {
                this.lsint = 0;
                this.isdking = false;
                this.updata.Enabled = false;
                this.progressBar1.Value = 0;
                this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
                this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
                if (this.serialPort1.IsOpen && this.ckisok)
                {
                    this.serialPort1.WriteLine("#T00000000");
                    while (this.serialPort1.BytesToWrite > 0)
                    {
                    }
                }
                Thread.Sleep(15);
                this.guiling();
            }
            if (!this.isdking)
            {
                if (keyData == Keys.Up)
                {
                    this.py--;
                    if (this.py <= 0)
                    {
                        this.py = 0;
                    }
                    this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
                    this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
                    this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
                    return true;
                }
                if (keyData == Keys.Down)
                {
                    this.py++;
                    if (this.py >= this.pictureBox1.Image.Height)
                    {
                        this.py = this.pictureBox1.Image.Height;
                    }
                    this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
                    this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
                    this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
                    return true;
                }
                if (keyData == Keys.Left)
                {
                    this.px--;
                    if (this.px <= 0)
                    {
                        this.px = 0;
                    }
                    this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
                    this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
                    this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
                    return true;
                }
                if (keyData == Keys.Right)
                {
                    this.px++;
                    if (this.px >= this.pictureBox1.Image.Width)
                    {
                        this.px = this.pictureBox1.Image.Width;
                    }
                    this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
                    this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
                    this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void ResizeImage(float bs)
        {
            for (int i = 0; i < this.li.Count; i++)
            {
                int x = this.liy[i].x;
                this.li[i].x = (int) (x * bs);
                x = this.liy[i].y;
                this.li[i].y = (int) (x * bs);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte num = 0;
            if ((this.serialPort1.IsOpen && this.ckisok) && this.isdking)
            {
                num = (byte) this.serialPort1.ReadByte();
                if ((num == 0x99) && !this.ispause)
                {
                    if (this.isci)
                    {
                        this.dkc();
                    }
                    else
                    {
                        this.dk();
                    }
                }
            }
        }

        private void setspdpi()
        {
            byte num = 3;
            switch (this.comboBox2.SelectedIndex)
            {
                case 0:
                    num = 1;
                    break;

                case 1:
                    num = 2;
                    break;

                case 2:
                    num = 3;
                    break;

                case 3:
                    num = 5;
                    break;

                case 4:
                    num = 10;
                    break;

                default:
                    num = 3;
                    break;
            }
            this.buf[1] = 0x59;
            this.buf[2] = num;
            this.buf[3] = 0;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(15);
            this.buf[1] = 0x6f;
            this.buf[2] = 1;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(15);
        }

        public void setwt()
        {
            this.buf[1] = 0x68;
            this.buf[2] = 10;
            this.jia = 6;
            this.jian = 6;
            this.buf[3] = this.jia;
            this.buf[4] = this.jian;
            this.buf[5] = 5;
            this.buf[6] = 5;
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(15);
        }

        public void setxy()
        {
            this.buf[1] = 0x53;
            int num = this.px * 0x20;
            this.buf[2] = BitConverter.GetBytes(num)[1];
            this.buf[3] = BitConverter.GetBytes(num)[0];
            num = this.py * 0x20;
            this.buf[4] = BitConverter.GetBytes(num)[1];
            this.buf[5] = BitConverter.GetBytes(num)[0];
            if (this.serialPort1.IsOpen && this.ckisok)
            {
                this.serialPort1.Write(this.buf, 0, 11);
                while (this.serialPort1.BytesToWrite > 0)
                {
                }
            }
            Thread.Sleep(15);
        }

        public void startcheckck()
        {
            while (!this.ckisok)
            {
                if (this.ckisok)
                {
                    continue;
                }
                foreach (string str in SerialPort.GetPortNames())
                {
                    if (!this.isdking)
                    {
                        this.openck(str);
                    }
                    if (!this.isdking)
                    {
                        this.ckcheckfs();
                    }
                    Thread.Sleep(70);
                    if ((!this.isdking && this.serialPort1.IsOpen) && (this.serialPort1.BytesToRead > 0))
                    {
                        this.ckb = (byte) this.serialPort1.ReadByte();
                    }
                    if (this.ckb == (this.ckjc ^ this.ckjcmi))
                    {
                        this.ckhcheckok = true;
                    }
                    else
                    {
                        this.ckhcheckok = false;
                    }
                    if (this.ckhcheckok)
                    {
                        this.ckhcheckok = false;
                        this.ckisok = true;
                        break;
                    }
                    this.ckisok = false;
                }
                Thread.Sleep(170);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void timeup_ValueChanged(object sender, EventArgs e)
        {
            this.upt();
        }

        private void updata_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value = this.lsint;
            this.time++;
            this.shi = this.time / 0xe10;
            this.fen = (this.time % 0xe10) / 60;
            this.miao = this.time % 60;
            this.label3.Text = string.Concat(new object[] { this.shi.ToString(), ':', this.fen.ToString(), ':', this.miao.ToString() });
        }

        private void upt()
        {
            this.V = (int) (this.trackBarTime.Value * this.fd);
        }

        private void upxian()
        {
            this.px = this.minx;
            this.py = this.miny;
            this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
            this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
            this.pictureBoxX.Size = new Size(1, this.pictureBox1.Image.Height);
            this.pictureBoxY.Size = new Size(this.pictureBox1.Image.Width, 1);
            this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
        }

        private byte weizhi(int XS, int YS)
        {
            byte num = 1;
            if (this.NR == 1)
            {
                if ((XS > 0) && (YS >= 0))
                {
                    num = 1;
                }
                if ((XS <= 0) && (YS > 0))
                {
                    num = 2;
                }
                if ((XS < 0) && (YS <= 0))
                {
                    num = 3;
                }
                if ((XS >= 0) && (YS < 0))
                {
                    num = 4;
                }
            }
            if (this.NR == 0)
            {
                if ((XS >= 0) && (YS > 0))
                {
                    num = 5;
                }
                if ((XS < 0) && (YS >= 0))
                {
                    num = 6;
                }
                if ((XS <= 0) && (YS < 0))
                {
                    num = 7;
                }
                if ((XS > 0) && (YS <= 0))
                {
                    num = 8;
                }
            }
            return num;
        }

        private void X_MZ()
        {
            if (this.X_F == 1)
            {
                this.xpo++;
            }
            else
            {
                this.xpo--;
            }
        }

        private void x_zm()
        {
            if (this.X_F == 1)
            {
                this.Pref_x++;
            }
            else
            {
                this.Pref_x--;
            }
            this.bit.SetPixel(this.Pref_x, this.Pref_y, Color.Black);
        }

        private void xoy1()
        {
            this.X_F = 1;
            this.Y_F = 1;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                if (this.Fm1 >= 0)
                {
                    this.Fm1 -= this.Ye;
                    this.x_zm();
                }
                else
                {
                    this.Fm1 += this.Xe;
                    this.y_zm();
                }
                this.n--;
            }
        }

        private void xoy1y()
        {
            if (this.FM >= 0)
            {
                this.XS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 0;
                this.X_MZ();
            }
            else if (this.FM < 0)
            {
                this.YS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 1;
                this.Y_MZ();
            }
        }

        private void xoy2()
        {
            this.X_F = 0;
            this.Y_F = 1;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                if (this.Fm1 >= 0)
                {
                    this.n--;
                    this.Fm1 -= this.Ye;
                    this.x_zm();
                }
                else
                {
                    this.n--;
                    this.Fm1 += this.Xe;
                    this.y_zm();
                }
            }
        }

        private void xoy2y()
        {
            if (this.FM >= 0)
            {
                this.YS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 0;
                this.Y_MZ();
            }
            else
            {
                this.XS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 0;
                this.X_MZ();
            }
        }

        private void xoy3()
        {
            this.X_F = 0;
            this.Y_F = 0;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                if (this.Fm1 >= 0)
                {
                    this.n--;
                    this.Fm1 -= this.Ye;
                    this.x_zm();
                }
                else
                {
                    this.n--;
                    this.Fm1 += this.Xe;
                    this.y_zm();
                }
            }
        }

        private void xoy3y()
        {
            if (this.FM >= 0)
            {
                this.XS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 1;
                this.X_MZ();
            }
            else
            {
                this.YS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 0;
                this.Y_MZ();
            }
        }

        private void xoy4()
        {
            this.X_F = 1;
            this.Y_F = 0;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                if (this.Fm1 >= 0)
                {
                    this.Fm1 -= this.Ye;
                    this.x_zm();
                }
                else
                {
                    this.Fm1 += this.Xe;
                    this.y_zm();
                }
                this.n--;
            }
        }

        private void xoy4y()
        {
            if (this.FM >= 0)
            {
                this.YS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 1;
                this.Y_MZ();
            }
            else
            {
                this.XS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 1;
                this.X_MZ();
            }
        }

        private void xoy5()
        {
            this.X_F = 1;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                this.n--;
                this.x_zm();
            }
        }

        private void xoy5y()
        {
            if (this.FM >= 0)
            {
                this.YS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 0;
                this.Y_MZ();
            }
            else
            {
                this.XS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 1;
                this.X_MZ();
            }
        }

        private void xoy6()
        {
            this.Y_F = 1;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                this.n--;
                this.y_zm();
            }
        }

        private void xoy6y()
        {
            if (this.FM >= 0)
            {
                this.XS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 1;
                this.X_MZ();
            }
            else
            {
                this.YS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 1;
                this.Y_MZ();
            }
        }

        private void xoy7()
        {
            this.X_F = 0;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                this.n--;
                this.x_zm();
            }
        }

        private void xoy7y()
        {
            if (this.FM >= 0)
            {
                this.YS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 1;
                this.Y_MZ();
            }
            else
            {
                this.XS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 0;
                this.X_MZ();
            }
        }

        private void xoy8()
        {
            this.Y_F = 0;
            while (this.n != 0)
            {
                if ((((this.Pref_x > 0x5aa0) || (this.Pref_x < 0)) || (this.Pref_y > 0x5bcc)) || (this.Pref_y < 0))
                {
                    break;
                }
                this.n--;
                this.y_zm();
            }
        }

        private void xoy8y()
        {
            if (this.FM >= 0)
            {
                this.XS -= this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.X_F = 0;
                this.X_MZ();
            }
            else
            {
                this.YS += this.STEP;
                this.FM = ((this.XS * this.XS) + (this.YS * this.YS)) - this.R;
                this.Y_F = 0;
                this.Y_MZ();
            }
        }

        private void xs()
        {
            int num3 = 0;
            int num4 = 0;
            this.bit = new Bitmap((this.maxx / 0x20) + 10, (this.maxy / 0x20) + 10);
            Graphics graphics = Graphics.FromImage(this.bit);
            Pen pen = new Pen(Brushes.Black, 1f);
            graphics.Clear(Color.White);
            foreach (line line in this.li)
            {
                if (line.lx == 0)
                {
                    num3 = line.x / 0x20;
                    num4 = line.y / 0x20;
                }
                else if (line.lx == 1)
                {
                    int num = line.x / 0x20;
                    int num2 = line.y / 0x20;
                    graphics.DrawLine(pen, num3, num4, num, num2);
                    num3 = num;
                    num4 = num2;
                }
            }
            this.pictureBox1.Image = this.bit;
            this.lsint = 0;
            this.lsbool = false;
            this.numericUpDown1.Value = (decimal) (((float) this.maxx) / 160f);
        }

        private void Y_MZ()
        {
            if (this.Y_F == 1)
            {
                this.ypo++;
            }
            else
            {
                this.ypo--;
            }
        }

        private void y_zm()
        {
            if (this.Y_F == 1)
            {
                this.Pref_y++;
            }
            else
            {
                this.Pref_y--;
            }
            this.bit.SetPixel(this.Pref_x, this.Pref_y, Color.Black);
        }

        private void yhcb(int xs, int ys, int xe, int ye)
        {
            line line;
            bool flag;
            byte num2 = 0;
            int num3 = 0;
            this.XS = xs;
            this.YS = ys;
            this.FM = 0;
            byte num = this.weizhi(this.XS, this.YS);
            this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
            this.XS = Math.Abs(this.XS);
            this.YS = Math.Abs(this.YS);
            xe = Math.Abs(xe);
            ye = Math.Abs(ye);
            this.R = (this.XS * this.XS) + (this.YS * this.YS);
            if (this.R > 0x22551000)
            {
                this.yhfd = this.yhsz[0x11];
            }
            else if (this.R > 0x1de84000)
            {
                this.yhfd = this.yhsz[0x11];
            }
            else if (this.R > 0x19c99000)
            {
                this.yhfd = this.yhsz[0x10];
            }
            else if (this.R > 0x15f90000)
            {
                this.yhfd = this.yhsz[15];
            }
            else if (this.R > 0x12769000)
            {
                this.yhfd = this.yhsz[14];
            }
            else if (this.R > 0xf424000)
            {
                this.yhfd = this.yhsz[13];
            }
            else if (this.R > 0xc5c1000)
            {
                this.yhfd = this.yhsz[12];
            }
            else if (this.R > 0x9c40000)
            {
                this.yhfd = this.yhsz[11];
            }
            else if (this.R > 0x77a1000)
            {
                this.yhfd = this.yhsz[10];
            }
            else if (this.R > 0x57e4000)
            {
                this.yhfd = this.yhsz[9];
            }
            else if (this.R > 0x3d09000)
            {
                this.yhfd = this.yhsz[8];
            }
            else if (this.R > 0x2710000)
            {
                this.yhfd = this.yhsz[7];
            }
            else if (this.R > 0x15f9000)
            {
                this.yhfd = this.yhsz[6];
            }
            else if (this.R > 0x9c4000)
            {
                this.yhfd = this.yhsz[5];
            }
            else if (this.R > 0x271000)
            {
                this.yhfd = this.yhsz[4];
            }
            else if (this.R > 0x9c400)
            {
                this.yhfd = this.yhsz[3];
            }
            else if (this.R > 0x27100)
            {
                this.yhfd = this.yhsz[2];
            }
            else if (this.R > 0x1900)
            {
                this.yhfd = this.yhsz[1];
            }
            else
            {
                this.yhfd = this.yhsz[0];
            }
            goto Label_079B;
        Label_0436:
            this.n--;
            if (this.n == 0)
            {
                line = new line {
                    lx = 1,
                    x = this.hx,
                    y = this.hy
                };
                this.liy.Add(line);
                return;
            }
            if (this.NR == 1)
            {
                if ((num == 1) && (this.XS == 0))
                {
                    num = 2;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
                if ((num == 2) && (this.YS == 0))
                {
                    num = 3;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
                if ((num == 3) && (this.XS == 0))
                {
                    num = 4;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
                if ((num == 4) && (this.YS == 0))
                {
                    num = 1;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
            }
            if (this.NR == 0)
            {
                if ((num == 5) && (this.YS == 0))
                {
                    num = 8;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
                if ((num == 8) && (this.XS == 0))
                {
                    num = 7;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
                if ((num == 7) && (this.YS == 0))
                {
                    num = 6;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
                if ((num == 6) && (this.XS == 0))
                {
                    num = 5;
                    num2 = (byte) (num2 + 1);
                    this.n = Math.Abs((int) (xe - this.XS)) + Math.Abs((int) (ye - this.YS));
                }
            }
            if (num2 > 3)
            {
                line = new line {
                    lx = 1,
                    x = this.hx,
                    y = this.hy
                };
                this.liy.Add(line);
                return;
            }
            num3++;
            if (num3 == this.yhfd)
            {
                num3 = 0;
                line = new line {
                    lx = 1,
                    x = this.xpo,
                    y = this.ypo
                };
                this.liy.Add(line);
            }
        Label_079B:
            flag = true;
            switch (num)
            {
                case 1:
                    this.xoy1y();
                    goto Label_0436;

                case 2:
                    this.xoy2y();
                    goto Label_0436;

                case 3:
                    this.xoy3y();
                    goto Label_0436;

                case 4:
                    this.xoy4y();
                    goto Label_0436;

                case 5:
                    this.xoy5y();
                    goto Label_0436;

                case 6:
                    this.xoy6y();
                    goto Label_0436;

                case 7:
                    this.xoy7y();
                    goto Label_0436;

                case 8:
                    this.xoy8y();
                    goto Label_0436;

                default:
                    goto Label_0436;
            }
        }

        private void zxcb(int x1, int y1)
        {
            this.Xe = x1;
            this.Ye = y1;
            this.Fm1 = 0;
            this.Xe -= this.Pref_x;
            this.Ye -= this.Pref_y;
            byte num = this.Line_determing(this.Xe, this.Ye);
            this.Xe = Math.Abs(this.Xe);
            this.Ye = Math.Abs(this.Ye);
            this.n = this.Xe + this.Ye;
            switch (num)
            {
                case 1:
                    this.xoy1();
                    break;

                case 2:
                    this.xoy2();
                    break;

                case 3:
                    this.xoy3();
                    break;

                case 4:
                    this.xoy4();
                    break;

                case 5:
                    this.xoy5();
                    break;

                case 6:
                    this.xoy6();
                    break;

                case 7:
                    this.xoy7();
                    break;

                case 8:
                    this.xoy8();
                    break;
            }
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru");
            this.ApplyResource();
            this.pictureBox1.Location = new Point(this.pictureBox2.Location.X + 0x17, this.pictureBox2.Location.Y + 0x17);
            this.pictureBoxX.Location = this.pictureBox1.Location;
            this.pictureBoxY.Location = this.pictureBox1.Location;
            regedit.write("yuyan", "ru");
            this.yuyan = 3;
            this.context();
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.px = (this.minx + this.maxx) / 0x40;
            this.py = (this.miny + this.maxy) / 0x40;
            this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
            this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
            this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
        }

        private void 左上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.px = this.minx;
            this.py = this.miny;
            this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
            this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
            this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
        }

        private void 左中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.px = (this.minx + this.maxx) / 0x40;
            this.py = this.miny;
            this.pictureBoxX.Location = new Point(this.px + this.pictureBox1.Location.X, this.pictureBox1.Location.Y);
            this.pictureBoxY.Location = new Point(this.pictureBox1.Location.X, this.py + this.pictureBox1.Location.Y);
            this.label4.Text = "X=" + this.px.ToString() + " Y=" + this.py.ToString();
        }

        private void 简体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
            this.ApplyResource();
            this.pictureBox1.Location = new Point(this.pictureBox2.Location.X + 0x17, this.pictureBox2.Location.Y + 0x17);
            this.pictureBoxX.Location = this.pictureBox1.Location;
            this.pictureBoxY.Location = this.pictureBox1.Location;
            regedit.write("yuyan", "zh-CN");
            this.yuyan = 1;
            this.context();
        }

        private void 繁体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-HK");
            this.ApplyResource();
            this.pictureBox1.Location = new Point(this.pictureBox2.Location.X + 0x17, this.pictureBox2.Location.Y + 0x17);
            this.pictureBoxX.Location = this.pictureBox1.Location;
            this.pictureBoxY.Location = this.pictureBox1.Location;
            regedit.write("yuyan", "zh-HK");
            this.yuyan = 1;
            this.context();
        }

        private void 重新连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.thread.IsAlive)
            {
                this.cktime.Enabled = true;
                this.ckisok = false;
                this.ckhcheckok = false;
                this.thread = new Thread(new ThreadStart(this.startcheckck));
                this.thread.Start();
            }
        }

        private void 阿灿的世界ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://" + this.wz2);
        }
    }
}

