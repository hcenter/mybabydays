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
using System.Text.RegularExpressions;
using System.Timers;
using Microsoft.Win32;

namespace MyBabyDays
{
    public partial class Setting : Form
    {
        [DllImport("Kernel32")]
        private static extern int GetPrivateProfileInt(string section, string key, int nDefault, string filePath);
        [DllImport("Kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("Kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);
        public Setting(string babydays,MyBabyDays pparentForm1)
        {
            InitializeComponent();
            days = babydays;
            this.richTextBox1.Text = this.befoText.Text + days + this.afterText.Text;
            pParentForm = pparentForm1;
        }

        private void FontSetting_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            
            fontDialog.Font = new Font(fontName, fontSize);
            fontDialog.AllowScriptChange = false;
            fontDialog.ShowColor = false;
            fontDialog.ShowEffects = false;
            fontDialog.ShowHelp = false;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Font = fontDialog.Font;
                WritePrivateProfileString(section, "Font", fontDialog.Font.Name.ToString(), filePath);
                WritePrivateProfileString(section, "FontSize", fontDialog.Font.Size.ToString(), filePath);
              
            }　

        }

        private void ColorSetting_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = richTextBox1.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Int32 colorarg = colorDialog.Color.ToArgb();
                richTextBox1.ForeColor = System.Drawing.Color.FromArgb(colorarg);
                WritePrivateProfileString(section, "FontColor", colorarg.ToString(), filePath);
            }


        }
        #region 读取配置文件信息
        private void LoadDefSetting()
        {
            
            pos_x = GetPrivateProfileInt(section, "pos_x", 1, filePath);
            pos_y = GetPrivateProfileInt(section, "pos_y", 1, filePath);
            timeout = GetPrivateProfileInt(section, "Timeout", 1000, filePath);

            StringBuilder beforetem = new StringBuilder(512);
            int i = GetPrivateProfileString(section, "msg_before", "", beforetem, 512, filePath);
            msg_before = beforetem.ToString();

            StringBuilder endtem = new StringBuilder(512);
            int j = GetPrivateProfileString(section, "msg_end", "", endtem, 512, filePath);
            msg_end = endtem.ToString();

            StringBuilder birthdaytem = new StringBuilder(64);
            int k = GetPrivateProfileString(section, "birthday", "", birthdaytem, 64, filePath);
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

        private void Setting_Load(object sender, EventArgs e)
        {
            //日期格式化

            filePath = System.Environment.CurrentDirectory + "\\config.ini";
            section = "setting";

            LoadDefSetting();

            //设置字体和颜色
            Font font = new Font(fontName, fontSize);
            this.richTextBox1.Font = font;
            this.richTextBox1.ForeColor=System.Drawing.Color.FromArgb(Convert.ToInt32(fontColor));

            this.befoText.Text = msg_before;
            this.afterText.Text = msg_end;
            this.exitText.Text = myExitString;
            this.exitDelayText.Text = timeout.ToString();

            DateTime mybabybirthday = Convert.ToDateTime(mybaby_birthday);
            this.dateTimePicker1.Value = mybabybirthday;

            //设置trackbar初始位置
            this.H_trackBar.Minimum = 0;
            this.H_trackBar.Maximum = Screen.PrimaryScreen.WorkingArea.Width;
            this.H_trackBar.TickFrequency = 200;
            this.H_trackBar.Value = pos_x;
            

            this.V_trackBar.Minimum = 0;
            this.V_trackBar.Maximum = Screen.PrimaryScreen.WorkingArea.Height-30;
            this.V_trackBar.TickFrequency = 100;
            this.V_trackBar.Value = pos_y;

            //开机自动运行状态
            if (QueryAutoRunStat())
            {
                this.checkBoxAutoRun.Checked = true;
            }
            else
            {
                this.checkBoxAutoRun.Checked = false;
            }

        }
        #region 判断是否是数字
        private bool isnumber(string num)
        {
            Regex regexisnum = new Regex("^[0-9]*$");
            
            return regexisnum.IsMatch(num);
        }
        #endregion

        #region 保存设置
        private void btn_save_Click(object sender, EventArgs e)
        {
            //出生日期
            WritePrivateProfileString(section, "birthday", this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), filePath);
            //前缀
            //if(this.befoText.Text!="")
                WritePrivateProfileString(section, "msg_before", this.befoText.Text, filePath);
            //后缀
            //if(this.afterText.Text!="")
                WritePrivateProfileString(section, "msg_end", this.afterText.Text, filePath);
            //退出文字
            //if(this.exitText.Text!="")
                WritePrivateProfileString(section, "ExitString", this.exitText.Text, filePath);
            //延时时间
            if ((this.exitDelayText.Text != "")&&isnumber(this.exitDelayText.Text))
            {
                WritePrivateProfileString(section, "timeout", this.exitDelayText.Text, filePath);
            }

            WritePrivateProfileString(section, "pos_x", pParentForm.Location.X.ToString(), filePath);
            WritePrivateProfileString(section, "pos_y", pParentForm.Location.Y.ToString(), filePath);

            //保存开机启动
            SetAutoRunStat(this.checkBoxAutoRun.Checked);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        #endregion

        #region 取消
        private void btn_cancel_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Screen.PrimaryScreen.WorkingArea.Width.ToString() + "\n" + Screen.PrimaryScreen.WorkingArea.Height.ToString());

            //恢复窗体初始位置
            pParentForm.Location = new Point(pos_x, pos_y);

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
        #endregion

        #region 同步更新文本
        private void DaysTextChange()
        {
            this.richTextBox1.Text = this.befoText.Text + days + this.afterText.Text;
        }

        #endregion
        #region 左移
        private void H_left_MouseDown(object sender, MouseEventArgs e)
        {
            H_left_Timer = new System.Timers.Timer();
            H_left_Timer.Elapsed += new ElapsedEventHandler(OnTimedH_left_Event);
            H_left_Timer.Interval = 100;
            H_left_Timer.Enabled = true;
        }

        private void H_left_MouseUp(object sender, MouseEventArgs e)
        {
            H_left_Timer.Enabled = false;
        }
        #endregion

        #region 右移
        private void H_right_MouseDown(object sender, MouseEventArgs e)
        {
            H_right_Timer = new System.Timers.Timer();
            H_right_Timer.Elapsed += new ElapsedEventHandler(OnTimedH_right_Event);
            H_right_Timer.Interval = 100;
            H_right_Timer.Enabled = true;
        }

        private void H_right_MouseUp(object sender, MouseEventArgs e)
        {
            H_right_Timer.Enabled = false;
        }
        #endregion

        #region 下移
        private void V_botton_MouseDown(object sender, MouseEventArgs e)
        {
            V_botton_Timer = new System.Timers.Timer();
            V_botton_Timer.Elapsed += new ElapsedEventHandler(OnTimedV_botton_Event);
            V_botton_Timer.Interval = 100;
            V_botton_Timer.Enabled = true;
        }

        private void V_botton_MouseUp(object sender, MouseEventArgs e)
        {
            V_botton_Timer.Enabled = false;
        }
        #endregion

        #region 上移
        private void V_top_MouseDown(object sender, MouseEventArgs e)
        {
            V_top_Timer = new System.Timers.Timer();
            V_top_Timer.Elapsed += new ElapsedEventHandler(OnTimedV_top_Event);
            V_top_Timer.Interval = 100;
            V_top_Timer.Enabled = true;
        }

        private void V_top_MouseUp(object sender, MouseEventArgs e)
        {
            V_top_Timer.Enabled = false;
        }
        #endregion

        #region 位置处理计时器
        private void OnTimedH_left_Event(object source, ElapsedEventArgs e)
        {
            pParentForm.Location = new Point(pParentForm.Location.X - 1, pParentForm.Location.Y);
        }
        private void OnTimedH_right_Event(object source, ElapsedEventArgs e)
        {
            pParentForm.Location = new Point(pParentForm.Location.X + 1, pParentForm.Location.Y);
        }
        private void OnTimedV_botton_Event(object source, ElapsedEventArgs e)
        {
            pParentForm.Location = new Point(pParentForm.Location.X, pParentForm.Location.Y - 1);
        }
        private void OnTimedV_top_Event(object source, ElapsedEventArgs e)
        {
            pParentForm.Location = new Point(pParentForm.Location.X, pParentForm.Location.Y + 1);
        }

        #endregion

        #region 显示文本变化
        private void befoText_TextChanged(object sender, EventArgs e)
        {
            DaysTextChange();
        }

        private void afterText_TextChanged(object sender, EventArgs e)
        {
            DaysTextChange();
        }
        #endregion

        #region 拖动位置标尺
        private void H_trackBar_ValueChanged(object sender, EventArgs e)
        {
            pParentForm.Location = new Point(this.H_trackBar.Value, pParentForm.Location.Y);
        }

        private void V_trackBar_ValueChanged(object sender, EventArgs e)
        {
            pParentForm.Location = new Point(pParentForm.Location.X,this.V_trackBar.Value);
        }
        #endregion

        #region 查询开机自动启动

        private bool QueryAutoRunStat()
        {
            string[] subkeyNames;
            RegistryKey AutoRunReg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);    
            //RegistryKey software = hkml.OpenSubKey(SOFTWAREtest);    
            subkeyNames = AutoRunReg.GetValueNames();    
            //取得该项下所有键值的名称的序列，并传递给预定的数组中    
            foreach (string keyName in subkeyNames)    
            {
                if (keyName == "MyBabyDays")
                {
                    AutoRunReg.Close();
                    return true;
                }
            }
            AutoRunReg.Close();    
            return false;    

        }
        #endregion

        #region 设置自动启动状态
        private bool SetAutoRunStat(bool bAutoRun)
        {
            QueryAutoRunStat();
            //MessageBox.Show(Application.ExecutablePath.ToString());
            Microsoft.Win32.RegistryKey AutoRunReg;
            AutoRunReg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (bAutoRun)
            {
                AutoRunReg.SetValue("MyBabyDays", Application.ExecutablePath.ToString(),RegistryValueKind.String);
                //Registry.LocalMachine.CreateSubKey(@"SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN").SetValue("MyBabyDays", Application.StartupPath + "\\MyBabyDays.exe",RegistryValueKind.String);
            }
            else
            {
                AutoRunReg.DeleteValue("MyBabyDays", false);
                //Registry.LocalMachine.DeleteValue(@"SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\RUN\MyBabyDays");
            }
            AutoRunReg.Close();
            return true;
        }
        #endregion

    }
}