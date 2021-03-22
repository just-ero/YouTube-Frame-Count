
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
            this.VideoLink = new System.Windows.Forms.LinkLabel();
            this.DeltaTime = new System.Windows.Forms.TextBox();
            this.DeltaTimeLabel = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.Separator = new System.Windows.Forms.Panel();
            this.TimeFormat = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearAll = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.NewVersion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // VideoLink
            // 
            this.VideoLink.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.VideoLink.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoLink.Location = new System.Drawing.Point(6, 121);
            this.VideoLink.Name = "VideoLink";
            this.VideoLink.Size = new System.Drawing.Size(223, 18);
            this.VideoLink.TabIndex = 2;
            this.VideoLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VideoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VideoLink_LinkClicked);
            // 
            // DeltaTime
            // 
            this.DeltaTime.Location = new System.Drawing.Point(49, 93);
            this.DeltaTime.MaxLength = 17;
            this.DeltaTime.Name = "DeltaTime";
            this.DeltaTime.ReadOnly = true;
            this.DeltaTime.Size = new System.Drawing.Size(150, 26);
            this.DeltaTime.TabIndex = 3;
            this.DeltaTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeltaTimeLabel
            // 
            this.DeltaTimeLabel.Location = new System.Drawing.Point(3, 95);
            this.DeltaTimeLabel.Name = "DeltaTimeLabel";
            this.DeltaTimeLabel.Size = new System.Drawing.Size(172, 22);
            this.DeltaTimeLabel.TabIndex = 0;
            this.DeltaTimeLabel.Text = "Delta:";
            this.DeltaTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(79, 55);
            this.EndTime.MaxLength = 17;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Size = new System.Drawing.Size(150, 26);
            this.EndTime.TabIndex = 5;
            this.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartEnd_KeyDown);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.Location = new System.Drawing.Point(8, 57);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(197, 22);
            this.EndTimeLabel.TabIndex = 0;
            this.EndTimeLabel.Text = "End time:";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartTime
            // 
            this.StartTime.Location = new System.Drawing.Point(79, 25);
            this.StartTime.MaxLength = 17;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Size = new System.Drawing.Size(150, 26);
            this.StartTime.TabIndex = 7;
            this.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartEnd_KeyDown);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.Location = new System.Drawing.Point(3, 27);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(202, 22);
            this.StartTimeLabel.TabIndex = 0;
            this.StartTimeLabel.Text = "Start time:";
            this.StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Separator.Location = new System.Drawing.Point(6, 86);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(223, 2);
            this.Separator.TabIndex = 8;
            // 
            // TimeFormat
            // 
            this.TimeFormat.Appearance = System.Windows.Forms.Appearance.Button;
            this.TimeFormat.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TimeFormat.Location = new System.Drawing.Point(176, 6);
            this.TimeFormat.Name = "TimeFormat";
            this.TimeFormat.Size = new System.Drawing.Size(16, 16);
            this.TimeFormat.TabIndex = 5;
            this.TimeFormat.UseVisualStyleBackColor = false;
            this.TimeFormat.CheckedChanged += new System.EventHandler(this.TimeFormat_CheckedChanged);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Tomato;
            this.ClearAll.Location = new System.Drawing.Point(195, 6);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(16, 16);
            this.ClearAll.TabIndex = 6;
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.CornflowerBlue;
            this.About.Location = new System.Drawing.Point(214, 6);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(16, 16);
            this.About.TabIndex = 9;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.BackgroundImage = global::YTFC.Properties.Resources.clipboard;
            this.CopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyToClipboard.Location = new System.Drawing.Point(202, 92);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(28, 28);
            this.CopyToClipboard.TabIndex = 4;
            this.CopyToClipboard.Tag = "";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
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
            // 
            // RetimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(237, 148);
            this.Controls.Add(this.About);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.TimeFormat);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.DeltaTime);
            this.Controls.Add(this.VideoLink);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.DeltaTimeLabel);
            this.Controls.Add(this.NewVersion);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel VideoLink;
        private System.Windows.Forms.TextBox DeltaTime;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.TextBox StartTime;
        private System.Windows.Forms.Panel Separator;
        private System.Windows.Forms.Label DeltaTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.CheckBox TimeFormat;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.LinkLabel NewVersion;
    }
}

