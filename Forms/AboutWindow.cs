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

        private void CreditsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://github.com/just-ero/YouTube-Frame-Count");
    }
}
