using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            try
            {
                Version thisVer = new Version(Application.ProductVersion);
                string thisVersionNumber = $"{thisVer.Major}.{thisVer.Minor}";
                string gitHubVersionNumber = thisVersionNumber;

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers.Add("User-Agent", "YTFC");
                        string json = webClient.DownloadString("https://api.github.com/repos/just-ero/YouTube-Frame-Count/releases/latest");
                        string tagEntry =
                            json.Split(',')
                            .Where(s => s.Contains("tag_name")).First()
                            .Replace("\"", "").Replace("v", "").Trim();
                        string tag = tagEntry.Split(':')[1];

                        gitHubVersionNumber = tag;
                    }
                }
                catch { }

                if (thisVersionNumber != gitHubVersionNumber) {
                    NewVersion.Text = $"New version (v{gitHubVersionNumber}) available!";
                    NewVersion.Visible = true;
                    NewVersion.LinkClicked += (s, e) => Process.Start("http://github.com/just-ero/YouTube-Frame-Count/releases/latest");
                }
            }
            catch { }
        }

        private void StartEnd_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox Tb = sender as TextBox;

            if (!(e.Control && e.KeyCode == Keys.V)) return;

            DebugExtractor Data = new DebugExtractor { DebugString = Clipboard.GetText() };
            if (Data.FormattedData == null) return;

            SavedData[Tb.Name] = Data.Seconds;
            SavedData["FPS"] = Data.FPS;
            SavedData["VideoID"] = Data.ID;

            Tb.Text = FormatToTime(Data.Seconds);

            if (String.IsNullOrEmpty(VideoLink.Text))
            {
                VideoLink.Text = $"youtu.be/{Data.ID}?t={(int)Data.Seconds}";
                VideoLink.Visible = true;
            }

            if (SavedData["EndTime"] < SavedData["StartTime"]) return;

            float delta = SavedData["EndTime"] - SavedData["StartTime"];

            SavedData["Delta"] = delta;
            DeltaTime.Text = FormatToTime(SavedData["Delta"] + (float)Offset.Value);

            Offset.Minimum = (decimal)-delta;
            Offset.Maximum = (decimal)(43200 - delta);
        }

        private void TimeFormat_CheckedChanged(object sender, EventArgs e)
        {
            TextBox[] tBoxes = { StartTime, EndTime, DeltaTime };
            float[] values = { SavedData["StartTime"], SavedData["EndTime"], SavedData["Delta"] + (float)Offset.Value };

            for (int i = 0; i < tBoxes.Length; ++i)
                if (!String.IsNullOrEmpty(tBoxes[i].Text))
                    tBoxes[i].Text = FormatToTime(values[i]);
        }

        private void About_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            SavedData["StartTime"] = SavedData["EndTime"] = SavedData["Delta"] = SavedData["FPS"] = 0;
            SavedData["VideoID"] = String.Empty;

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
                string msg =
                    File.ReadAllText("YTFC_custom.txt")
                    .Replace("$start$", StartTime.Text)
                    .Replace("$end$", EndTime.Text)
                    .Replace("$delta$", DeltaTime.Text)
                    .Replace("$fps$", SavedData["FPS"].ToString())
                    .Replace("$offset$", Offset.Value.ToString("0.000"));

                Clipboard.SetText(msg);
            }
        }

        private void CopyToClipboard_MouseUp(object sender, MouseEventArgs e)
        {
            CopyToClipboard.BackgroundImage = Properties.Resources.clipboard;
        }

        private void Offset_ValueChanged(object sender, EventArgs e)
        {
            if (SavedData["EndTime"] <= SavedData["StartTime"]) return;

            DeltaTime.Text = FormatToTime(SavedData["Delta"] + (float)Offset.Value);
        }

        private void VideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Process.Start($"http://{VideoLink.Text}");
        }

        private void ContextMenuCopyLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(VideoLink.Text);
        }

        private void ResetToZero_Click(object sender, EventArgs e)
        {
            Offset.Value = (decimal)0.000;
        }

        private Dictionary<string, dynamic> SavedData = new Dictionary<string, dynamic>
        {
            { "StartTime", 0f },
            { "EndTime", 0f },
            { "Delta", 0f },
            { "FPS", 0 },
            { "VideoID", String.Empty }
        };
    }
}
