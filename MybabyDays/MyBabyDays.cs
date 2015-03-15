/*********************************************************************************
   Copyright (c) 2011 -2015 hcenter.net

   This program is free software; you can redistribute it and/or modify 
   it under the terms of the BSD  License.

   You should have received a copy of the BSD License along with this program.  
 *********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.IO;



namespace MyBabyDays
{
    
    public partial class MyBabyDays : Form
    {
        [DllImport("Kernel32")]
        private static extern int GetPrivateProfileInt(string section, string key, int nDefault, string filePath);
        [DllImport("Kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("user32")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent); 

        public MyBabyDays()
        {
            //设置主窗体句柄
            pcurrentWin = this;

            //设置无任务栏程序
            this.ShowInTaskbar = false;
            //设置无边框窗体
            this.FormBorderStyle = FormBorderStyle.None;

            //设置透明 方法1
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            
            //设置嵌入桌面
            IntPtr hDeskTop = FindWindow("Progman", "Program Manager");
            SetParent(this.Handle, hDeskTop);

            //设置透明度
            //this.Opacity = 0.5;

            ////设置菜单
            MenuItem[] mnuItms = new MenuItem[4];
            mnuItms[0] = new MenuItem();
            mnuItms[0].Text = "设置";
            mnuItms[0].Click += new System.EventHandler(this.ShowSetting);

            mnuItms[1] = new MenuItem("-");

            mnuItms[2] = new MenuItem();
            mnuItms[2].Text = "关于";
            mnuItms[2].Click += new System.EventHandler(this.ShowAbout);
            //mnuItms[2].DefaultItem = true;

            mnuItms[3] = new MenuItem();
            mnuItms[3].Text = "退出";
            mnuItms[3].Click += new System.EventHandler(this.OnExit);
            //mnuItms[2].DefaultItem = true;

            ContextMenu notifyiconMnu = new ContextMenu(mnuItms);
            
            
            InitializeComponent();

            this.notifyIcon1.ContextMenu = notifyiconMnu;

            //读取配置
            LoadDefSetting();
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new Point(pos_x,pos_y);
            GetMyBabyDays();
        }

        private void GetMyBabyDays()
        {
            DateTime nowTime = DateTime.Now;
            DateTime oldTime = DateTime.Parse(mybaby_birthday);

            //days
            TimeSpan timeSpan = nowTime - oldTime;
            days = Math.Floor(timeSpan.TotalDays);
            //设置显示内容
            if (days < 365)
            {
                myBaby_days = msg_before + days.ToString().Trim() + msg_end;
                return;
            }

            //V1.1
            //TimeSpan timeSpan = (nowTime - DateTime.Parse(mybaby_birthday)).Year;
            //days = Math.Floor(timeSpan.TotalDays);
            int age = DateTime.Now.Year - DateTime.Parse("2011-03-21").Year;
            //设置显示内容
            msg_end = msg_end.TrimStart('天');
            myBaby_days = msg_before + age.ToString().Trim() + "岁" + msg_end.Trim();
           // MessageBox.Show(myBaby_days);
        }


        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
           // this.notifyIcon1.Visible = false;

           // myBaby_days = myExitString;

           // this.Refresh();

           // System.Timers.Timer exitTimer = new System.Timers.Timer();
           // exitTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
           // exitTimer.Interval = timeout;
           // exitTimer.Enabled = true;

            GetMyBabyDays();
            this.Refresh();

        }
        #region 读取ini信息
        private void LoadDefSetting()
        {
            string filePath=System.Environment.CurrentDirectory+"\\config.ini";
            string section="setting";

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath,false,Encoding.Default))
                {
                    int y = Screen.PrimaryScreen.WorkingArea.Width - 100;
                    sw.WriteLine("[setting]");
                    sw.WriteLine("pos_x=" + y.ToString());
                    sw.WriteLine("pos_y=0");
                    sw.WriteLine("msg_before=宝贝");
                    sw.WriteLine("msg_end=天了");
                    sw.WriteLine("birthday="+System.DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    sw.WriteLine("timeout=1000");
                    sw.WriteLine("Font=宋体");
                    sw.WriteLine("FontSize=36");
                    sw.WriteLine("FontColor=-65536");
                    sw.WriteLine("ExitString=Bye!");
                }
            }
            
            pos_x = GetPrivateProfileInt(section, "pos_x", 1, filePath);
            pos_y = GetPrivateProfileInt(section, "pos_y", 1, filePath);
            timeout = GetPrivateProfileInt(section, "Timeout", 1000, filePath);

            StringBuilder beforetem = new StringBuilder(512);
            int i = GetPrivateProfileString(section, "msg_before","", beforetem, 512, filePath);
            msg_before = beforetem.ToString();

            StringBuilder endtem = new StringBuilder(512);
            int j = GetPrivateProfileString(section, "msg_end", "",endtem, 512, filePath);
            msg_end = endtem.ToString();

            StringBuilder birthdaytem = new StringBuilder(64);
            int k = GetPrivateProfileString(section, "birthday", "",birthdaytem, 64, filePath);
            if (k != 0)
                mybaby_birthday = birthdaytem.ToString();
            else
                mybaby_birthday = System.DateTime.Now.Date.ToString("yyyy-MM-dd");

            StringBuilder exitstringtem = new StringBuilder(512);
            int nExitstring = GetPrivateProfileString(section, "ExitString", "", exitstringtem, 512, filePath);
            if (nExitstring != 0)
                myExitString = exitstringtem.ToString();
            else
                myExitString = "Love You My Baby!";

            //加载字体
            StringBuilder Fonttem = new StringBuilder(64);
            int nFontName = GetPrivateProfileString(section, "Font", "", Fonttem, 64, filePath);
            if (nFontName != 0)
                fontName = Fonttem.ToString();
            else
                fontName = "宋体";

            //字体大小
            fontSize = GetPrivateProfileInt(section, "FontSize", 20, filePath);

            //颜色
            //fontColor = GetPrivateProfileInt(section, "FontColor", 0, filePath);
            StringBuilder FontColortem = new StringBuilder(64);
            int nFontColor = GetPrivateProfileString(section, "FontColor", "", FontColortem, 64, filePath);
            if (nFontColor != 0)
                fontColor = FontColortem.ToString();
            else
                fontColor = "0";

        }
        #endregion

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.Close();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Color myColor=System.Drawing.Color.FromArgb(Convert.ToInt32(fontColor));

            SolidBrush myBrush = new SolidBrush(myColor);
           
            
            Font font = new Font(fontName, fontSize);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            e.Graphics.DrawString(myBaby_days, font, myBrush, PointF.Empty);
        }
        private void ShowSetting(object sender, EventArgs e)
        {
           // MessageBox.Show("sfwerewr");
            Setting set = new Setting(days.ToString(),this);


            if (set.ShowDialog() == DialogResult.OK)
            {
                LoadDefSetting();
                GetMyBabyDays();
                this.Refresh();
            }
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            MyBabyDaysAbout myAbout = new MyBabyDaysAbout();
            myAbout.ShowDialog();
        }
        private void OnExit(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;

            myBaby_days = myExitString;

            this.Refresh();

            System.Timers.Timer exitTimer = new System.Timers.Timer();
            exitTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            exitTimer.Interval = timeout;
            exitTimer.Enabled = true;
        }

    }
}