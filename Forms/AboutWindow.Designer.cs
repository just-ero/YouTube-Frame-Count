
namespace YTFC
{
    partial class AboutWindow
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
            System.Windows.Forms.Label Instructions;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            System.Windows.Forms.Label InstructionsHeader;
            System.Windows.Forms.Label GrayExplanation;
            System.Windows.Forms.Label UIHeader;
            System.Windows.Forms.Button GrayButton;
            System.Windows.Forms.Button RedButton;
            System.Windows.Forms.Label RedExplanation;
            System.Windows.Forms.Label ClipboardExplanation;
            System.Windows.Forms.Label CustomMessageHeader;
            System.Windows.Forms.Label CustomMessage;
            System.Windows.Forms.Button ClipboardButton;
            System.Windows.Forms.Panel CustomMessageBox;
            System.Windows.Forms.Label Parameters;
            System.Windows.Forms.Panel UIBox;
            System.Windows.Forms.Panel InstructionsBox;
            this.CreditsLabel = new System.Windows.Forms.LinkLabel();
            Instructions = new System.Windows.Forms.Label();
            InstructionsHeader = new System.Windows.Forms.Label();
            GrayExplanation = new System.Windows.Forms.Label();
            UIHeader = new System.Windows.Forms.Label();
            GrayButton = new System.Windows.Forms.Button();
            RedButton = new System.Windows.Forms.Button();
            RedExplanation = new System.Windows.Forms.Label();
            ClipboardExplanation = new System.Windows.Forms.Label();
            CustomMessageHeader = new System.Windows.Forms.Label();
            CustomMessage = new System.Windows.Forms.Label();
            ClipboardButton = new System.Windows.Forms.Button();
            CustomMessageBox = new System.Windows.Forms.Panel();
            Parameters = new System.Windows.Forms.Label();
            UIBox = new System.Windows.Forms.Panel();
            InstructionsBox = new System.Windows.Forms.Panel();
            CustomMessageBox.SuspendLayout();
            UIBox.SuspendLayout();
            InstructionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            Instructions.AutoSize = true;
            Instructions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Instructions.Location = new System.Drawing.Point(5, 25);
            Instructions.Name = "Instructions";
            Instructions.Size = new System.Drawing.Size(278, 60);
            Instructions.TabIndex = 0;
            Instructions.Text = resources.GetString("Instructions.Text");
            // 
            // InstructionsHeader
            // 
            InstructionsHeader.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            InstructionsHeader.Location = new System.Drawing.Point(1, 1);
            InstructionsHeader.Name = "InstructionsHeader";
            InstructionsHeader.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            InstructionsHeader.Size = new System.Drawing.Size(292, 90);
            InstructionsHeader.TabIndex = 0;
            InstructionsHeader.Text = "Instructions";
            // 
            // GrayExplanation
            // 
            GrayExplanation.AutoSize = true;
            GrayExplanation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GrayExplanation.Location = new System.Drawing.Point(29, 25);
            GrayExplanation.Name = "GrayExplanation";
            GrayExplanation.Size = new System.Drawing.Size(243, 15);
            GrayExplanation.TabIndex = 0;
            GrayExplanation.Text = ": time format (\'0:00.000\' or \'0m 00s 000ms\')";
            // 
            // UIHeader
            // 
            UIHeader.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UIHeader.Location = new System.Drawing.Point(1, 1);
            UIHeader.Name = "UIHeader";
            UIHeader.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            UIHeader.Size = new System.Drawing.Size(292, 105);
            UIHeader.TabIndex = 0;
            UIHeader.Text = "UI Elements";
            // 
            // GrayButton
            // 
            GrayButton.BackColor = System.Drawing.SystemColors.ControlDark;
            GrayButton.Enabled = false;
            GrayButton.Location = new System.Drawing.Point(15, 25);
            GrayButton.Name = "GrayButton";
            GrayButton.Size = new System.Drawing.Size(16, 16);
            GrayButton.TabIndex = 0;
            GrayButton.TabStop = false;
            GrayButton.UseVisualStyleBackColor = false;
            // 
            // RedButton
            // 
            RedButton.BackColor = System.Drawing.Color.Tomato;
            RedButton.Enabled = false;
            RedButton.Location = new System.Drawing.Point(15, 46);
            RedButton.Name = "RedButton";
            RedButton.Size = new System.Drawing.Size(16, 16);
            RedButton.TabIndex = 0;
            RedButton.TabStop = false;
            RedButton.UseVisualStyleBackColor = false;
            // 
            // RedExplanation
            // 
            RedExplanation.AutoSize = true;
            RedExplanation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RedExplanation.Location = new System.Drawing.Point(29, 46);
            RedExplanation.Name = "RedExplanation";
            RedExplanation.Size = new System.Drawing.Size(97, 15);
            RedExplanation.TabIndex = 0;
            RedExplanation.Text = ": clear all entries";
            // 
            // ClipboardExplanation
            // 
            ClipboardExplanation.AutoSize = true;
            ClipboardExplanation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ClipboardExplanation.Location = new System.Drawing.Point(29, 72);
            ClipboardExplanation.Name = "ClipboardExplanation";
            ClipboardExplanation.Size = new System.Drawing.Size(243, 30);
            ClipboardExplanation.TabIndex = 0;
            ClipboardExplanation.Text = ": copy delta to clipboard (right-click will copy\r\n  the formatted custom message)" +
    "";
            // 
            // CustomMessageHeader
            // 
            CustomMessageHeader.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CustomMessageHeader.Location = new System.Drawing.Point(1, 1);
            CustomMessageHeader.Name = "CustomMessageHeader";
            CustomMessageHeader.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            CustomMessageHeader.Size = new System.Drawing.Size(292, 105);
            CustomMessageHeader.TabIndex = 0;
            CustomMessageHeader.Text = "Custom Message";
            // 
            // CustomMessage
            // 
            CustomMessage.AutoSize = true;
            CustomMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CustomMessage.Location = new System.Drawing.Point(5, 25);
            CustomMessage.Name = "CustomMessage";
            CustomMessage.Size = new System.Drawing.Size(285, 45);
            CustomMessage.TabIndex = 0;
            CustomMessage.Text = "Define some custom text in your YTFC_custom file.\r\nCopy this message by right-cli" +
    "cking the clipboard.\r\nYou can use these parameters in the file:";
            // 
            // ClipboardButton
            // 
            ClipboardButton.BackgroundImage = global::YTFC.Properties.Resources.clipboard;
            ClipboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClipboardButton.Enabled = false;
            ClipboardButton.Location = new System.Drawing.Point(6, 67);
            ClipboardButton.Name = "ClipboardButton";
            ClipboardButton.Size = new System.Drawing.Size(25, 25);
            ClipboardButton.TabIndex = 0;
            ClipboardButton.TabStop = false;
            ClipboardButton.Tag = "";
            ClipboardButton.UseVisualStyleBackColor = true;
            // 
            // CustomMessageBox
            // 
            CustomMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            CustomMessageBox.Controls.Add(Parameters);
            CustomMessageBox.Controls.Add(CustomMessage);
            CustomMessageBox.Controls.Add(CustomMessageHeader);
            CustomMessageBox.Location = new System.Drawing.Point(7, 108);
            CustomMessageBox.Name = "CustomMessageBox";
            CustomMessageBox.Size = new System.Drawing.Size(296, 109);
            CustomMessageBox.TabIndex = 0;
            // 
            // Parameters
            // 
            Parameters.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Parameters.ForeColor = System.Drawing.SystemColors.Highlight;
            Parameters.Location = new System.Drawing.Point(5, 85);
            Parameters.Name = "Parameters";
            Parameters.Size = new System.Drawing.Size(296, 15);
            Parameters.TabIndex = 0;
            Parameters.Text = "$start$, $end$, $delta$, $fps$, and $offset$";
            Parameters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UIBox
            // 
            UIBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            UIBox.Controls.Add(ClipboardButton);
            UIBox.Controls.Add(RedButton);
            UIBox.Controls.Add(GrayButton);
            UIBox.Controls.Add(ClipboardExplanation);
            UIBox.Controls.Add(RedExplanation);
            UIBox.Controls.Add(GrayExplanation);
            UIBox.Controls.Add(UIHeader);
            UIBox.Location = new System.Drawing.Point(7, 223);
            UIBox.Name = "UIBox";
            UIBox.Size = new System.Drawing.Size(296, 109);
            UIBox.TabIndex = 0;
            // 
            // InstructionsBox
            // 
            InstructionsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            InstructionsBox.Controls.Add(Instructions);
            InstructionsBox.Controls.Add(InstructionsHeader);
            InstructionsBox.Location = new System.Drawing.Point(7, 8);
            InstructionsBox.Name = "InstructionsBox";
            InstructionsBox.Size = new System.Drawing.Size(296, 94);
            InstructionsBox.TabIndex = 0;
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLabel.Location = new System.Drawing.Point(159, 337);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(146, 28);
            this.CreditsLabel.TabIndex = 1;
            this.CreditsLabel.TabStop = true;
            this.CreditsLabel.Text = "YouTube Frame Count (v1.1)\r\nCreated by Ero";
            this.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CreditsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreditsLabel_LinkClicked);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(311, 371);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(InstructionsBox);
            this.Controls.Add(UIBox);
            this.Controls.Add(CustomMessageBox);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.Padding = new System.Windows.Forms.Padding(7, 7, 3, 6);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About & Help";
            CustomMessageBox.ResumeLayout(false);
            CustomMessageBox.PerformLayout();
            UIBox.ResumeLayout(false);
            UIBox.PerformLayout();
            InstructionsBox.ResumeLayout(false);
            InstructionsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel CreditsLabel;
    }
}