using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace I_Wanna_辅助工具
{
    public partial class SmallJump : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public SmallJump()
        {
            InitializeComponent();
        }

        private void SmallJump_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 888, 0, Keys.X);
            label1.Text = "加载完成，按X键超小跳";
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:
                    if (m.WParam.ToString().Equals("888"))
                        SendKeys.Send("+");
                    break;
            }
            base.WndProc(ref m);
        }

        private void SmallJump_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 888);
        }

    }
}
