/*********************************************************************************
   Copyright (c) 2011 -2015 hcenter.net

   This program is free software; you can redistribute it and/or modify 
   it under the terms of the BSD  License.

   You should have received a copy of the BSD License along with this program.  
 *********************************************************************************/
 
namespace MyBabyDays
{
    partial class Setting
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.FontSetting = new System.Windows.Forms.Button();
            this.ColorSetting = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textInfo = new System.Windows.Forms.GroupBox();
            this.exitDelayLabel = new System.Windows.Forms.Label();
            this.exitDelayText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.befoLabel = new System.Windows.Forms.Label();
            this.exitText = new System.Windows.Forms.TextBox();
            this.afterText = new System.Windows.Forms.TextBox();
            this.befoText = new System.Windows.Forms.TextBox();
            this.FontGroup = new System.Windows.Forms.GroupBox();
            this.viewLabel = new System.Windows.Forms.Label();
            this.displayPos = new System.Windows.Forms.GroupBox();
            this.Vpos_label = new System.Windows.Forms.Label();
            this.Hpos_label = new System.Windows.Forms.Label();
            this.V_top = new System.Windows.Forms.Button();
            this.H_right = new System.Windows.Forms.Button();
            this.V_botton = new System.Windows.Forms.Button();
            this.H_left = new System.Windows.Forms.Button();
            this.V_trackBar = new System.Windows.Forms.TrackBar();
            this.H_trackBar = new System.Windows.Forms.TrackBar();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.checkBoxAutoRun = new System.Windows.Forms.CheckBox();
            this.textInfo.SuspendLayout();
            this.FontGroup.SuspendLayout();
            this.displayPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FontSetting
            // 
            this.FontSetting.Location = new System.Drawing.Point(20, 116);
            this.FontSetting.Name = "FontSetting";
            this.FontSetting.Size = new System.Drawing.Size(75, 23);
            this.FontSetting.TabIndex = 0;
            this.FontSetting.Text = "设置字体";
            this.FontSetting.UseVisualStyleBackColor = true;
            this.FontSetting.Click += new System.EventHandler(this.FontSetting_Click);
            // 
            // ColorSetting
            // 
            this.ColorSetting.Location = new System.Drawing.Point(212, 116);
            this.ColorSetting.Name = "ColorSetting";
            this.ColorSetting.Size = new System.Drawing.Size(75, 23);
            this.ColorSetting.TabIndex = 1;
            this.ColorSetting.Text = "设置颜色";
            this.ColorSetting.UseVisualStyleBackColor = true;
            this.ColorSetting.Click += new System.EventHandler(this.ColorSetting_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 77);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textInfo
            // 
            this.textInfo.Controls.Add(this.exitDelayLabel);
            this.textInfo.Controls.Add(this.exitDelayText);
            this.textInfo.Controls.Add(this.dateTimePicker1);
            this.textInfo.Controls.Add(this.label1);
            this.textInfo.Controls.Add(this.exitLabel);
            this.textInfo.Controls.Add(this.afterLabel);
            this.textInfo.Controls.Add(this.befoLabel);
            this.textInfo.Controls.Add(this.exitText);
            this.textInfo.Controls.Add(this.afterText);
            this.textInfo.Controls.Add(this.befoText);
            this.textInfo.Location = new System.Drawing.Point(15, 12);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(343, 164);
            this.textInfo.TabIndex = 3;
            this.textInfo.TabStop = false;
            this.textInfo.Text = "信息设置";
            // 
            // exitDelayLabel
            // 
            this.exitDelayLabel.AutoSize = true;
            this.exitDelayLabel.Location = new System.Drawing.Point(8, 132);
            this.exitDelayLabel.Name = "exitDelayLabel";
            this.exitDelayLabel.Size = new System.Drawing.Size(77, 12);
            this.exitDelayLabel.TabIndex = 7;
            this.exitDelayLabel.Text = "退出延时ms：";
            // 
            // exitDelayText
            // 
            this.exitDelayText.Location = new System.Drawing.Point(91, 129);
            this.exitDelayText.Name = "exitDelayText";
            this.exitDelayText.Size = new System.Drawing.Size(246, 21);
            this.exitDelayText.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = " 出生日期 ：";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Location = new System.Drawing.Point(8, 103);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(77, 12);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "退出时文字：";
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(6, 74);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(77, 12);
            this.afterLabel.TabIndex = 4;
            this.afterLabel.Text = "日期后文字：";
            // 
            // befoLabel
            // 
            this.befoLabel.AutoSize = true;
            this.befoLabel.Location = new System.Drawing.Point(6, 45);
            this.befoLabel.Name = "befoLabel";
            this.befoLabel.Size = new System.Drawing.Size(77, 12);
            this.befoLabel.TabIndex = 3;
            this.befoLabel.Text = "日期前文字：";
            // 
            // exitText
            // 
            this.exitText.Location = new System.Drawing.Point(91, 100);
            this.exitText.Name = "exitText";
            this.exitText.Size = new System.Drawing.Size(246, 21);
            this.exitText.TabIndex = 2;
            // 
            // afterText
            // 
            this.afterText.Location = new System.Drawing.Point(91, 71);
            this.afterText.Name = "afterText";
            this.afterText.Size = new System.Drawing.Size(246, 21);
            this.afterText.TabIndex = 1;
            this.afterText.TextChanged += new System.EventHandler(this.afterText_TextChanged);
            // 
            // befoText
            // 
            this.befoText.Location = new System.Drawing.Point(91, 42);
            this.befoText.Name = "befoText";
            this.befoText.Size = new System.Drawing.Size(246, 21);
            this.befoText.TabIndex = 0;
            this.befoText.TextChanged += new System.EventHandler(this.befoText_TextChanged);
            // 
            // FontGroup
            // 
            this.FontGroup.Controls.Add(this.viewLabel);
            this.FontGroup.Controls.Add(this.FontSetting);
            this.FontGroup.Controls.Add(this.ColorSetting);
            this.FontGroup.Controls.Add(this.richTextBox1);
            this.FontGroup.Location = new System.Drawing.Point(15, 185);
            this.FontGroup.Name = "FontGroup";
            this.FontGroup.Size = new System.Drawing.Size(343, 147);
            this.FontGroup.TabIndex = 4;
            this.FontGroup.TabStop = false;
            this.FontGroup.Text = "字体设置";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(18, 17);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(41, 12);
            this.viewLabel.TabIndex = 3;
            this.viewLabel.Text = "预览：";
            // 
            // displayPos
            // 
            this.displayPos.Controls.Add(this.Vpos_label);
            this.displayPos.Controls.Add(this.Hpos_label);
            this.displayPos.Controls.Add(this.V_top);
            this.displayPos.Controls.Add(this.H_right);
            this.displayPos.Controls.Add(this.V_botton);
            this.displayPos.Controls.Add(this.H_left);
            this.displayPos.Controls.Add(this.V_trackBar);
            this.displayPos.Controls.Add(this.H_trackBar);
            this.displayPos.Location = new System.Drawing.Point(15, 338);
            this.displayPos.Name = "displayPos";
            this.displayPos.Size = new System.Drawing.Size(343, 107);
            this.displayPos.TabIndex = 5;
            this.displayPos.TabStop = false;
            this.displayPos.Text = "显示位置调整";
            // 
            // Vpos_label
            // 
            this.Vpos_label.AutoSize = true;
            this.Vpos_label.Location = new System.Drawing.Point(2, 64);
            this.Vpos_label.Name = "Vpos_label";
            this.Vpos_label.Size = new System.Drawing.Size(83, 12);
            this.Vpos_label.TabIndex = 4;
            this.Vpos_label.Text = "垂直位置调整:";
            // 
            // Hpos_label
            // 
            this.Hpos_label.AutoSize = true;
            this.Hpos_label.Location = new System.Drawing.Point(4, 26);
            this.Hpos_label.Name = "Hpos_label";
            this.Hpos_label.Size = new System.Drawing.Size(83, 12);
            this.Hpos_label.TabIndex = 3;
            this.Hpos_label.Text = "水平位置调整:";
            // 
            // V_top
            // 
            this.V_top.Location = new System.Drawing.Point(297, 59);
            this.V_top.Name = "V_top";
            this.V_top.Size = new System.Drawing.Size(27, 23);
            this.V_top.TabIndex = 2;
            this.V_top.Text = "+";
            this.V_top.UseVisualStyleBackColor = true;
            this.V_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.V_top_MouseDown);
            this.V_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.V_top_MouseUp);
            // 
            // H_right
            // 
            this.H_right.Location = new System.Drawing.Point(297, 21);
            this.H_right.Name = "H_right";
            this.H_right.Size = new System.Drawing.Size(27, 23);
            this.H_right.TabIndex = 2;
            this.H_right.Text = "+";
            this.H_right.UseVisualStyleBackColor = true;
            this.H_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H_right_MouseDown);
            this.H_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.H_right_MouseUp);
            // 
            // V_botton
            // 
            this.V_botton.Location = new System.Drawing.Point(93, 59);
            this.V_botton.Name = "V_botton";
            this.V_botton.Size = new System.Drawing.Size(27, 23);
            this.V_botton.TabIndex = 1;
            this.V_botton.Text = "-";
            this.V_botton.UseVisualStyleBackColor = true;
            this.V_botton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.V_botton_MouseDown);
            this.V_botton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.V_botton_MouseUp);
            // 
            // H_left
            // 
            this.H_left.Location = new System.Drawing.Point(93, 21);
            this.H_left.Name = "H_left";
            this.H_left.Size = new System.Drawing.Size(27, 23);
            this.H_left.TabIndex = 1;
            this.H_left.Text = "-";
            this.H_left.UseVisualStyleBackColor = true;
            this.H_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H_left_MouseDown);
            this.H_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.H_left_MouseUp);
            // 
            // V_trackBar
            // 
            this.V_trackBar.Location = new System.Drawing.Point(130, 59);
            this.V_trackBar.Name = "V_trackBar";
            this.V_trackBar.Size = new System.Drawing.Size(157, 45);
            this.V_trackBar.TabIndex = 0;
            this.V_trackBar.ValueChanged += new System.EventHandler(this.V_trackBar_ValueChanged);
            // 
            // H_trackBar
            // 
            this.H_trackBar.Location = new System.Drawing.Point(130, 21);
            this.H_trackBar.Name = "H_trackBar";
            this.H_trackBar.Size = new System.Drawing.Size(157, 45);
            this.H_trackBar.TabIndex = 0;
            this.H_trackBar.ValueChanged += new System.EventHandler(this.H_trackBar_ValueChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(68, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保 存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(233, 473);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "取 消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // checkBoxAutoRun
            // 
            this.checkBoxAutoRun.AutoSize = true;
            this.checkBoxAutoRun.Location = new System.Drawing.Point(35, 451);
            this.checkBoxAutoRun.Name = "checkBoxAutoRun";
            this.checkBoxAutoRun.Size = new System.Drawing.Size(108, 16);
            this.checkBoxAutoRun.TabIndex = 7;
            this.checkBoxAutoRun.Text = "开机时自动运行";
            this.checkBoxAutoRun.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 508);
            this.Controls.Add(this.checkBoxAutoRun);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.displayPos);
            this.Controls.Add(this.FontGroup);
            this.Controls.Add(this.textInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.textInfo.ResumeLayout(false);
            this.textInfo.PerformLayout();
            this.FontGroup.ResumeLayout(false);
            this.FontGroup.PerformLayout();
            this.displayPos.ResumeLayout(false);
            this.displayPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button FontSetting;
        private System.Windows.Forms.Button ColorSetting;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox textInfo;
        private System.Windows.Forms.TextBox befoText;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Label befoLabel;
        private System.Windows.Forms.TextBox exitText;
        private System.Windows.Forms.TextBox afterText;
        private System.Windows.Forms.GroupBox FontGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label exitDelayLabel;
        private System.Windows.Forms.TextBox exitDelayText;
        private System.Windows.Forms.GroupBox displayPos;
        private System.Windows.Forms.Button H_right;
        private System.Windows.Forms.Button H_left;
        private System.Windows.Forms.TrackBar H_trackBar;
        private System.Windows.Forms.Button V_top;
        private System.Windows.Forms.Button V_botton;
        private System.Windows.Forms.TrackBar V_trackBar;
        private System.Windows.Forms.Label Vpos_label;
        private System.Windows.Forms.Label Hpos_label;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;

        //天数
        private string days;
        private int pos_x;
        private int pos_y;
        private int timeout;
        private string msg_before;
        private string msg_end;
        private string mybaby_birthday;
        //private string myBaby_days;
        private string myExitString;

        private string fontName;
        private int fontSize;
        private string fontColor;

        //配置文件路径
        private string filePath;
        private string section;

        //主窗体
        private MyBabyDays pParentForm;

        //位移计时器
        System.Timers.Timer H_left_Timer;
        System.Timers.Timer H_right_Timer;
        System.Timers.Timer V_botton_Timer;
        System.Timers.Timer V_top_Timer;
        private System.Windows.Forms.CheckBox checkBoxAutoRun;
    }
}