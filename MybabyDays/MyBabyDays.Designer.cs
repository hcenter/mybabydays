/*********************************************************************************
   Copyright (c) 2011 -2015 hcenter.net

   This program is free software; you can redistribute it and/or modify 
   it under the terms of the BSD  License.

   You should have received a copy of the BSD License along with this program.  
 *********************************************************************************/

namespace MyBabyDays
{
    partial class MyBabyDays
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBabyDays));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MyBaby";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MyBabyDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 141);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBabyDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBabyDays";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.NotifyIcon notifyIcon1;

        private double days;

        private int pos_x;
        private int pos_y;
        private int timeout;
        private string msg_before;
        private string msg_end;
        private string mybaby_birthday;
        private string myBaby_days;
        private string myExitString;

        private string fontName;
        private int fontSize;
        private string fontColor;

        public static MyBabyDays pcurrentWin = null;
        
    }
}

