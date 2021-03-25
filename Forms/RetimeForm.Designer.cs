
namespace YTFC
{
    partial class RetimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label DeltaTimeLabel;
            System.Windows.Forms.Label EndTimeLabel;
            System.Windows.Forms.Label StartTimeLabel;
            System.Windows.Forms.Panel Separator;
            System.Windows.Forms.Label OffsetLabel;
            this.VideoLink = new System.Windows.Forms.LinkLabel();
            this.DeltaTime = new System.Windows.Forms.TextBox();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.TimeFormat = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearAll = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.NewVersion = new System.Windows.Forms.LinkLabel();
            this.Offset = new System.Windows.Forms.NumericUpDown();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuCopyLink = new System.Windows.Forms.ToolStripMenuItem();
            DeltaTimeLabel = new System.Windows.Forms.Label();
            EndTimeLabel = new System.Windows.Forms.Label();
            StartTimeLabel = new System.Windows.Forms.Label();
            Separator = new System.Windows.Forms.Panel();
            OffsetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Offset)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeltaTimeLabel
            // 
            DeltaTimeLabel.Location = new System.Drawing.Point(3, 95);
            DeltaTimeLabel.Name = "DeltaTimeLabel";
            DeltaTimeLabel.Size = new System.Drawing.Size(194, 22);
            DeltaTimeLabel.TabIndex = 0;
            DeltaTimeLabel.Text = "Delta:";
            DeltaTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(DeltaTimeLabel, "Difference between start and end.");
            // 
            // EndTimeLabel
            // 
            EndTimeLabel.Location = new System.Drawing.Point(8, 57);
            EndTimeLabel.Name = "EndTimeLabel";
            EndTimeLabel.Size = new System.Drawing.Size(219, 22);
            EndTimeLabel.TabIndex = 0;
            EndTimeLabel.Text = "End time:";
            EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartTimeLabel
            // 
            StartTimeLabel.Location = new System.Drawing.Point(3, 27);
            StartTimeLabel.Name = "StartTimeLabel";
            StartTimeLabel.Size = new System.Drawing.Size(224, 22);
            StartTimeLabel.TabIndex = 0;
            StartTimeLabel.Text = "Start time:";
            StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Separator
            // 
            Separator.BackColor = System.Drawing.SystemColors.ControlDark;
            Separator.Location = new System.Drawing.Point(6, 86);
            Separator.Name = "Separator";
            Separator.Size = new System.Drawing.Size(223, 2);
            Separator.TabIndex = 0;
            // 
            // OffsetLabel
            // 
            OffsetLabel.Font = new System.Drawing.Font("Arial", 10F);
            OffsetLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            OffsetLabel.Location = new System.Drawing.Point(45, 125);
            OffsetLabel.Name = "OffsetLabel";
            OffsetLabel.Size = new System.Drawing.Size(152, 19);
            OffsetLabel.TabIndex = 11;
            OffsetLabel.Text = "Offset:";
            OffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(OffsetLabel, "Optional offset (plus or minus) to the delta.");
            // 
            // VideoLink
            // 
            this.VideoLink.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.VideoLink.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoLink.Location = new System.Drawing.Point(6, 146);
            this.VideoLink.Name = "VideoLink";
            this.VideoLink.Size = new System.Drawing.Size(223, 18);
            this.VideoLink.TabIndex = 10;
            this.VideoLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToolTip.SetToolTip(this.VideoLink, "Timestamped link to the video.");
            this.VideoLink.Visible = false;
            this.VideoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VideoLink_LinkClicked);
            // 
            // DeltaTime
            // 
            this.DeltaTime.Location = new System.Drawing.Point(49, 93);
            this.DeltaTime.MaxLength = 17;
            this.DeltaTime.Name = "DeltaTime";
            this.DeltaTime.ReadOnly = true;
            this.DeltaTime.Size = new System.Drawing.Size(150, 26);
            this.DeltaTime.TabIndex = 7;
            this.DeltaTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip.SetToolTip(this.DeltaTime, "Difference between start and end.");
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(79, 55);
            this.EndTime.MaxLength = 17;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Size = new System.Drawing.Size(150, 26);
            this.EndTime.TabIndex = 6;
            this.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartEnd_KeyDown);
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(79, 25);
            this.StartTime.MaxLength = 17;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Size = new System.Drawing.Size(150, 26);
            this.StartTime.TabIndex = 5;
            this.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartEnd_KeyDown);
            // 
            // TimeFormat
            // 
            this.TimeFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.TimeFormat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TimeFormat.Location = new System.Drawing.Point(176, 6);
            this.TimeFormat.Name = "TimeFormat";
            this.TimeFormat.Size = new System.Drawing.Size(16, 16);
            this.TimeFormat.TabIndex = 2;
            this.ToolTip.SetToolTip(this.TimeFormat, "Click to change the time format.");
            this.TimeFormat.UseVisualStyleBackColor = false;
            this.TimeFormat.CheckedChanged += new System.EventHandler(this.TimeFormat_CheckedChanged);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Tomato;
            this.ClearAll.Location = new System.Drawing.Point(195, 6);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(16, 16);
            this.ClearAll.TabIndex = 3;
            this.ToolTip.SetToolTip(this.ClearAll, "Clear and reset all fields.");
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.CornflowerBlue;
            this.About.Location = new System.Drawing.Point(214, 6);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(16, 16);
            this.About.TabIndex = 4;
            this.ToolTip.SetToolTip(this.About, "Help & About");
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // NewVersion
            // 
            this.NewVersion.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.NewVersion.AutoSize = true;
            this.NewVersion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewVersion.LinkColor = System.Drawing.Color.Green;
            this.NewVersion.Location = new System.Drawing.Point(5, 6);
            this.NewVersion.Name = "NewVersion";
            this.NewVersion.Size = new System.Drawing.Size(0, 15);
            this.NewVersion.TabIndex = 1;
            this.NewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.NewVersion, "Click to download the new version!");
            this.NewVersion.Visible = false;
            // 
            // Offset
            // 
            this.Offset.BackColor = System.Drawing.SystemColors.Control;
            this.Offset.DecimalPlaces = 3;
            this.Offset.Font = new System.Drawing.Font("Arial", 10F);
            this.Offset.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Offset.Location = new System.Drawing.Point(92, 123);
            this.Offset.Maximum = new decimal(new int[] {
            43200,
            0,
            0,
            0});
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(107, 23);
            this.Offset.TabIndex = 9;
            this.ToolTip.SetToolTip(this.Offset, "Optional offset (plus or minus) to the delta.");
            this.Offset.ValueChanged += new System.EventHandler(this.Offset_ValueChanged);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.BackgroundImage = global::YTFC.Properties.Resources.clipboard;
            this.CopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyToClipboard.Location = new System.Drawing.Point(202, 92);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(28, 28);
            this.CopyToClipboard.TabIndex = 8;
            this.CopyToClipboard.Tag = "";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CopyToClipboard_MouseDown);
            this.CopyToClipboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CopyToClipboard_MouseUp);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuCopyLink});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // ContextMenuCopyLink
            // 
            this.ContextMenuCopyLink.Name = "ContextMenuCopyLink";
            this.ContextMenuCopyLink.Size = new System.Drawing.Size(180, 22);
            this.ContextMenuCopyLink.Text = "Copy Link";
            this.ContextMenuCopyLink.Click += new System.EventHandler(this.ContextMenuCopyLink_Click);
            // 
            // RetimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(237, 154);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.About);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.TimeFormat);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(Separator);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.DeltaTime);
            this.Controls.Add(this.VideoLink);
            this.Controls.Add(StartTimeLabel);
            this.Controls.Add(EndTimeLabel);
            this.Controls.Add(DeltaTimeLabel);
            this.Controls.Add(this.NewVersion);
            this.Controls.Add(OffsetLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RetimeForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Frame Count";
            ((System.ComponentModel.ISupportInitialize)(this.Offset)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel VideoLink;
        private System.Windows.Forms.TextBox DeltaTime;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.TextBox StartTime;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.CheckBox TimeFormat;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.LinkLabel NewVersion;
        private System.Windows.Forms.NumericUpDown Offset;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCopyLink;
    }
}

