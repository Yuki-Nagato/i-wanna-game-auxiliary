using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace I_Wanna_辅助工具
{
    public partial class KeepJump : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public KeepJump()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainForm.IsIWannaActived())
            {
                SendKeys.Send("+");
            }
        }

        private void WhenSDown_CheckedChanged(object sender, EventArgs e)
        {
            if (WhenSDown.Checked)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                RegisterHotKey(this.Handle, 100, 0, Keys.S);
            }
            else
            {
                checkBox1.Enabled = true;
                UnregisterHotKey(this.Handle, 100);
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:
                    if (m.WParam.ToString().Equals("100"))
                        checkBox1.Checked = !checkBox1.Checked;
                    break;
            }
            base.WndProc(ref m);
        }

        private void KeepJump_Load(object sender, EventArgs e)
        {
            WhenSDown.Checked = true;
        }
    }
}
