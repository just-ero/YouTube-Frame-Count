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
            CopyToClipboard.Tag = false;

            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-Agent", "refunct-tas");

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
                    if (!File.Exists("YTFCMessage.txt")) File.WriteAllText("YTFCMessage.txt", "Mod note: Retimed to $delta$ (from $start$ to $end$ at $fps$ FPS).");
                    string clip = File.ReadAllText("YTFCMessage.txt");

                    if (clip.Contains("$start$")) clip = clip.Replace("$start$", StartTime.Text);
                    if (clip.Contains("$end$")) clip = clip.Replace("$end$", EndTime.Text);
                    if (clip.Contains("$delta$")) clip = clip.Replace("$delta$", DeltaTime.Text);
                    if (clip.Contains("$fps$")) clip = clip.Replace("$fps$", EnteredFPS.ToString());
                    if (clip.Contains("$offset$")) clip = clip.Replace("$offset$", Offset.Value.ToString("0.000"));

                    Clipboard.SetText(clip);
                }
                catch { }

                CopyToClipboard.BackgroundImage = Properties.Resources.clipboard;

                return;
            }
        }

        private void Offset_ValueChanged(object sender, EventArgs e)
        {
            DeltaOffset = DeltaNoOffset + (float)Offset.Value;

            DeltaTime.Text = FormatToTime(DeltaOffset);
        }

        private void VideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start($"http://{VideoLink.Text}");
    }
}
