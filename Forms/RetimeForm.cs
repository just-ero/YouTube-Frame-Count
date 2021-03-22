using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace YTFC
{
    public partial class RetimeForm : Form
    {
        public RetimeForm()
        {
            InitializeComponent();
            CopyToClipboard.Tag = false;

            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-Agent", "refunct-tas");

                string tagEntry = "\"tag_name\":";
                string repo = "/oberien/refunct-tas/releases/latest";
                string json = webClient.DownloadString("https://api.github.com/repos" + repo);
                string newVersion = json.Substring(json.IndexOf(tagEntry) + tagEntry.Length + 2, 3);

                Version ver = new Version(Application.ProductVersion);
                string oldVersion = $"{ver.Major}.{ver.Minor}";

                if (oldVersion != newVersion) {
                    NewVersion.Text = $"New version (v{newVersion}) available!";
                    NewVersion.Visible = true;
                    NewVersion.LinkClicked += (object s, LinkLabelLinkClickedEventArgs e) => Process.Start("http://github.com" + repo);
                }
            }
            catch { }
        }

        private float EnteredStartTime, EnteredEndTime, CalculatedDelta;
        private string StartVideoID, EndVideoID;

        private void StartEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Control && e.KeyCode == Keys.V)) return;

            var DebugData = FormatDebugString(Clipboard.GetText());
            if (DebugData == null) return;

            if ((TextBox)sender == StartTime)
            {
                EnteredStartTime = DebugData["seconds"] - (DebugData["seconds"] % (1f / (float)DebugData["fps"]));
                StartVideoID = DebugData["vidID"];

                if (!String.IsNullOrEmpty(EndVideoID) && StartVideoID != EndVideoID) return;
                if (String.IsNullOrEmpty(VideoLink.Text))
                {
                    VideoLink.Text = $"youtu.be/{StartVideoID}?t={(int)DebugData["seconds"]}";
                    VideoLink.Visible = true;
                }

                StartTime.Text = FormatToTime(EnteredStartTime);
            }
            else if ((TextBox)sender == EndTime)
            {
                EnteredEndTime = DebugData["seconds"] - (DebugData["seconds"] % (1f / (float)DebugData["fps"]));
                EndVideoID = DebugData["vidID"];

                if (!String.IsNullOrEmpty(StartVideoID) && StartVideoID != EndVideoID) return;
                if (String.IsNullOrEmpty(VideoLink.Text))
                {
                    VideoLink.Text = $"youtu.be/{EndVideoID}?t={(int)DebugData["seconds"]}";
                    VideoLink.Visible = true;
                }

                EndTime.Text = FormatToTime(EnteredEndTime);
            }

            if (new[] { StartTime.Text, EndTime.Text }.All(text => !String.IsNullOrEmpty(text)))
            {
                CalculatedDelta = EnteredEndTime - EnteredStartTime;
                DeltaTime.Text = FormatToTime(CalculatedDelta);
            }
        }

        private void TimeFormat_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] tBoxes = { StartTime, EndTime, DeltaTime };
            float[] values = { EnteredStartTime, EnteredEndTime, CalculatedDelta };

            for (int i = 0; i < tBoxes.Length; ++i)
                if (!String.IsNullOrEmpty(tBoxes[i].Text))
                    tBoxes[i].Text = FormatToTime(values[i]);
        }

        private void About_Click(object sender, EventArgs e)
        {
            new AboutWindow { Location = new Point(Location.X + Width, Location.Y), StartPosition = FormStartPosition.Manual }
            .ShowDialog();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            EnteredStartTime = EnteredEndTime = CalculatedDelta = 0;

            StartTime.Clear();
            EndTime.Clear();
            DeltaTime.Clear();
            VideoLink.Text = String.Empty;
            VideoLink.Visible = false;
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DeltaTime.Text)) return;

            if ((bool)(CopyToClipboard.Tag = !(bool)CopyToClipboard.Tag))
            {
                Clipboard.SetText(DeltaTime.Text);
                CopyToClipboard.BackgroundImage = Properties.Resources.mod;

                return;
            }
            else
            {
                try
                {
                    Clipboard.SetText(DeltaTime.Text);
                }
                catch { }

                CopyToClipboard.BackgroundImage = Properties.Resources.clipboard;

                return;
            }
        }

        private void VideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start($"http://{VideoLink.Text}");
    }
}
