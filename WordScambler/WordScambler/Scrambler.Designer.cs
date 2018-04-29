namespace WordScambler
{
    partial class Scrambler
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.RbtHard = new System.Windows.Forms.RadioButton();
            this.RbtMedium = new System.Windows.Forms.RadioButton();
            this.RbtEasy = new System.Windows.Forms.RadioButton();
            this.LblWord = new System.Windows.Forms.Label();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.BtnInput = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Firebrick;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(691, 6);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 38);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.RbtHard);
            this.groupBox1.Controls.Add(this.RbtMedium);
            this.groupBox1.Controls.Add(this.RbtEasy);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(237, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(271, 147);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // StartButton
            // 
            this.StartButton.ForeColor = System.Drawing.Color.Firebrick;
            this.StartButton.Location = new System.Drawing.Point(83, 87);
            this.StartButton.Margin = new System.Windows.Forms.Padding(1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(93, 37);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RbtHard
            // 
            this.RbtHard.AutoSize = true;
            this.RbtHard.Location = new System.Drawing.Point(189, 32);
            this.RbtHard.Margin = new System.Windows.Forms.Padding(2);
            this.RbtHard.Name = "RbtHard";
            this.RbtHard.Size = new System.Drawing.Size(61, 23);
            this.RbtHard.TabIndex = 2;
            this.RbtHard.TabStop = true;
            this.RbtHard.Text = "Hard";
            this.RbtHard.UseVisualStyleBackColor = true;
            // 
            // RbtMedium
            // 
            this.RbtMedium.AutoSize = true;
            this.RbtMedium.Location = new System.Drawing.Point(83, 32);
            this.RbtMedium.Margin = new System.Windows.Forms.Padding(2);
            this.RbtMedium.Name = "RbtMedium";
            this.RbtMedium.Size = new System.Drawing.Size(83, 23);
            this.RbtMedium.TabIndex = 1;
            this.RbtMedium.TabStop = true;
            this.RbtMedium.Text = "Medium";
            this.RbtMedium.UseVisualStyleBackColor = true;
            // 
            // RbtEasy
            // 
            this.RbtEasy.AutoSize = true;
            this.RbtEasy.Location = new System.Drawing.Point(5, 32);
            this.RbtEasy.Margin = new System.Windows.Forms.Padding(2);
            this.RbtEasy.Name = "RbtEasy";
            this.RbtEasy.Size = new System.Drawing.Size(60, 23);
            this.RbtEasy.TabIndex = 0;
            this.RbtEasy.TabStop = true;
            this.RbtEasy.Text = "Easy";
            this.RbtEasy.UseVisualStyleBackColor = true;
            // 
            // LblWord
            // 
            this.LblWord.BackColor = System.Drawing.Color.Transparent;
            this.LblWord.Font = new System.Drawing.Font("Rockwell Condensed", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblWord.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.LblWord.Location = new System.Drawing.Point(173, 49);
            this.LblWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblWord.Name = "LblWord";
            this.LblWord.Size = new System.Drawing.Size(416, 162);
            this.LblWord.TabIndex = 21;
            this.LblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(308, 226);
            this.TxtInput.Margin = new System.Windows.Forms.Padding(2);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(143, 20);
            this.TxtInput.TabIndex = 22;
            // 
            // BtnInput
            // 
            this.BtnInput.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInput.Location = new System.Drawing.Point(336, 281);
            this.BtnInput.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(74, 31);
            this.BtnInput.TabIndex = 23;
            this.BtnInput.Text = "Submit";
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackgroundImage = global::WordScambler.Properties.Resources.speaker;
            this.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStart.Location = new System.Drawing.Point(605, 6);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(66, 38);
            this.BtnStart.TabIndex = 24;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackgroundImage = global::WordScambler.Properties.Resources.mute_speaker;
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStop.Location = new System.Drawing.Point(605, 6);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(66, 38);
            this.BtnStop.TabIndex = 25;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Scrambler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WordScambler.Properties.Resources.WordUnscrambler;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.ControlBox = false;
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnInput);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.LblWord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scrambler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrambler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtHard;
        private System.Windows.Forms.RadioButton RbtMedium;
        private System.Windows.Forms.RadioButton RbtEasy;
        private System.Windows.Forms.Label LblWord;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
    }
}