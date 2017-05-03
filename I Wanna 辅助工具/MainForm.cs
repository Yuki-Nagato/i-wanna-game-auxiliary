using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace I_Wanna_辅助工具
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int GetWindowText(IntPtr hwnd, StringBuilder IpString, int cch);

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKeepFire_Click(object sender, EventArgs e)
        {
            KeepFire fm = new KeepFire();
            fm.Show();
        }
        public static bool IsIWannaActived()
        {
            IntPtr hwnd = GetForegroundWindow();
            StringBuilder Head=new StringBuilder("                ");
            GetWindowText(hwnd, Head, 16);
            string fh=Head.ToString();
            if (fh.StartsWith("i wanna")||fh.StartsWith("     ")||fh.StartsWith("I wanna"))
            {
                return true;
            }
                else
            {
                return false;
            }
        }

        private void btnSmallJump_Click(object sender, EventArgs e)
        {
            SmallJump sj = new SmallJump();
            sj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JumpOppositeStab fm = new JumpOppositeStab();
            fm.Show();
        }

        private void btnKeepJump_Click(object sender, EventArgs e)
        {
            KeepJump kj = new KeepJump();
            kj.Show();
        }
    }
}
