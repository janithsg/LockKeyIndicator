using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockKeysIndicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                notifyIcon.Icon = Properties.Resources.a;
                notifyIcon.Text = "CapsLock is ON";
            }
            if (!Control.IsKeyLocked(Keys.CapsLock))
            {
                notifyIcon.Icon = Properties.Resources.b;
                notifyIcon.Text = "CapsLock is OFF";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            notifyIcon.Visible = true;
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
