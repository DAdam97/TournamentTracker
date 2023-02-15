namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScore = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScore = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VSLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.Black;
            this.HeaderLabel.Location = new System.Drawing.Point(24, 25);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(129, 30);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.Black;
            this.TournamentNameLabel.Location = new System.Drawing.Point(159, 25);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(93, 30);
            this.TournamentNameLabel.TabIndex = 1;
            this.TournamentNameLabel.Text = "<name>";
            this.TournamentNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.ForeColor = System.Drawing.Color.Black;
            this.RoundLabel.Location = new System.Drawing.Point(24, 90);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(73, 30);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            this.RoundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.BackColor = System.Drawing.Color.MintCream;
            this.RoundDropDown.ForeColor = System.Drawing.Color.Black;
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(103, 90);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(168, 38);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(103, 155);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(168, 34);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.BackColor = System.Drawing.Color.MintCream;
            this.MatchUpListBox.ForeColor = System.Drawing.Color.Black;
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 30;
            this.MatchUpListBox.Location = new System.Drawing.Point(29, 210);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(242, 214);
            this.MatchUpListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.ForeColor = System.Drawing.Color.Black;
            this.TeamOneName.Location = new System.Drawing.Point(327, 210);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(129, 30);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<team one>";
            this.TeamOneName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TeamOneScore
            // 
            this.TeamOneScore.AutoSize = true;
            this.TeamOneScore.ForeColor = System.Drawing.Color.Black;
            this.TeamOneScore.Location = new System.Drawing.Point(327, 252);
            this.TeamOneScore.Name = "TeamOneScore";
            this.TeamOneScore.Size = new System.Drawing.Size(64, 30);
            this.TeamOneScore.TabIndex = 7;
            this.TeamOneScore.Text = "Score";
            this.TeamOneScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.BackColor = System.Drawing.Color.MintCream;
            this.TeamOneScoreValue.Location = new System.Drawing.Point(422, 249);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.BackColor = System.Drawing.Color.MintCream;
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(422, 389);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScore
            // 
            this.TeamTwoScore.AutoSize = true;
            this.TeamTwoScore.ForeColor = System.Drawing.Color.Black;
            this.TeamTwoScore.Location = new System.Drawing.Point(327, 392);
            this.TeamTwoScore.Name = "TeamTwoScore";
            this.TeamTwoScore.Size = new System.Drawing.Size(64, 30);
            this.TeamTwoScore.TabIndex = 10;
            this.TeamTwoScore.Text = "Score";
            this.TeamTwoScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.ForeColor = System.Drawing.Color.Black;
            this.TeamTwoName.Location = new System.Drawing.Point(327, 350);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(128, 30);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<team two>";
            this.TeamTwoName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.ForeColor = System.Drawing.Color.Black;
            this.VSLabel.Location = new System.Drawing.Point(402, 304);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(37, 30);
            this.VSLabel.TabIndex = 12;
            this.VSLabel.Text = "VS";
            this.VSLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreButton
            // 
            this.ScoreButton.BackColor = System.Drawing.Color.MintCream;
            this.ScoreButton.Location = new System.Drawing.Point(562, 299);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(125, 41);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(759, 467);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScore);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScore);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox MatchUpListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScore;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScore;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Label VSLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

