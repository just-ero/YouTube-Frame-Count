using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTFC
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xFFF0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref m);
        }

        private void CreditsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://github.com");
    }
}
