using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace I_Wanna_辅助工具
{
    public partial class JumpOppositeStab : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,    //虚拟键值
            byte bScan,// 一般为0
            int dwFlags,  //这里是整数类型  0 为按下，2为释放
            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public JumpOppositeStab()
        {
            InitializeComponent();
        }
        void MainJump(bool way)
        {

            if (way)
            {
                keybd_event((byte)Keys.Left, 0, 0, 0);
                System.Threading.Thread.Sleep(20);
                keybd_event((byte)Keys.ShiftKey, 0, 0, 0);
                System.Threading.Thread.Sleep(79);
                keybd_event((byte)Keys.ShiftKey, 0, 2, 0);
                System.Threading.Thread.Sleep(248);
                keybd_event((byte)Keys.Left, 0, 2, 0);
            }
            else
            {
                keybd_event((byte)Keys.Right, 0, 0, 0);
                System.Threading.Thread.Sleep(20);
                keybd_event((byte)Keys.ShiftKey, 0, 0, 0);
                System.Threading.Thread.Sleep(79);
                keybd_event((byte)Keys.ShiftKey, 0, 2, 0);
                System.Threading.Thread.Sleep(248);
                keybd_event((byte)Keys.Right, 0, 2, 0);
            }

        }

        private void JumpOppositeStab_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 111, 0, Keys.A);
            RegisterHotKey(this.Handle, 222, 0, Keys.S);
            label1.Text = "加载完成，按A向左跳，按S向右跳";
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:
                    if (m.WParam.ToString().Equals("111"))
                        MainJump(true);
                    else if (m.WParam.ToString().Equals("222"))
                        MainJump(false);
                    break;
            }
            base.WndProc(ref m);
        }

        private void JumpOppositeStab_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 111);
            UnregisterHotKey(this.Handle, 222);
        }
    }
}
