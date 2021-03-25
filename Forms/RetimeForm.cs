using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            VideoLink.ContextMenuStrip = ContextMenu;

            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-Agent", "YTFC");

                string tagEntry = "\"tag_name\":";
                string repo = "/just-ero/YouTube-Frame-Count/releases/latest";
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

        private float EnteredStartTime, EnteredEndTime, DeltaNoOffset, DeltaOffset;
        private string StartVideoID, EndVideoID;
        private int EnteredFPS;

        private void StartEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.Control && e.KeyCode == Keys.V)) return;

            var DebugData = FormatDebugString(Clipboard.GetText());
            if (DebugData == null) return;

            if ((TextBox)sender == StartTime)
            {
                EnteredStartTime = DebugData["seconds"] - (DebugData["seconds"] % (1f / (float)DebugData["fps"]));
                StartVideoID = DebugData["vidID"];
                EnteredFPS = DebugData["fps"];

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
                EnteredFPS = DebugData["fps"];

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
                DeltaNoOffset = EnteredEndTime - EnteredStartTime;
                DeltaOffset = DeltaNoOffset + (float)Offset.Value;
                DeltaTime.Text = FormatToTime(DeltaOffset);

                Offset.Minimum = (decimal)-DeltaNoOffset;
                Offset.Maximum = (decimal)(43200 - DeltaNoOffset);
            }
        }

        private void TimeFormat_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] tBoxes = { StartTime, EndTime, DeltaTime };
            float[] values = { EnteredStartTime, EnteredEndTime, DeltaOffset };

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
            EnteredStartTime = EnteredEndTime = DeltaNoOffset = DeltaOffset = 0;

            StartTime.Clear();
            EndTime.Clear();
            DeltaTime.Clear();
            Offset.Value = (decimal)0.000;
            Offset.Minimum = 0;
            Offset.Maximum = 43200;
            VideoLink.Text = String.Empty;
            VideoLink.Visible = false;
        }

        private void CopyToClipboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrEmpty(DeltaTime.Text)) return;

            if (e.Button == MouseButtons.Left)
            {
                Clipboard.SetText(DeltaTime.Text);
            }
            else if (e.Button == MouseButtons.Right)
            {
                CopyToClipboard.BackgroundImage = Properties.Resources.mod;

                if (!File.Exists("YTFC_custom.txt")) File.WriteAllText("YTFC_custom.txt", "Mod note: Retimed to $delta$ (from $start$ to $end$ at $fps$ FPS).");
                string msg = File.ReadAllText("YTFC_custom.txt");

                if (msg.Contains("$start$")) msg = msg.Replace("$start$", StartTime.Text);
                if (msg.Contains("$end$")) msg = msg.Replace("$end$", EndTime.Text);
                if (msg.Contains("$delta$")) msg = msg.Replace("$delta$", DeltaTime.Text);
                if (msg.Contains("$fps$")) msg = msg.Replace("$fps$", EnteredFPS.ToString());
                if (msg.Contains("$offset$")) msg = msg.Replace("$offset$", Offset.Value.ToString("0.000"));

                Clipboard.SetText(msg);
            }
        }

        private void CopyToClipboard_MouseUp(object sender, MouseEventArgs e)
        {
            CopyToClipboard.BackgroundImage = Properties.Resources.clipboard;
        }

        private void Offset_ValueChanged(object sender, EventArgs e)
        {
            DeltaOffset = DeltaNoOffset + (float)Offset.Value;

            DeltaTime.Text = FormatToTime(DeltaOffset);
        }

        private void VideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Process.Start($"http://{VideoLink.Text}");
        }

        private void ContextMenuCopyLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(VideoLink.Text);
        }
    }
}
