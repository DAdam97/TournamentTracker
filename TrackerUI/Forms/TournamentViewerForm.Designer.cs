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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.ddRound = new System.Windows.Forms.ComboBox();
            this.cbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lbMatchUp = new System.Windows.Forms.ListBox();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.tbTeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.tbTeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(25, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(129, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.Color.Black;
            this.lblTournamentName.Location = new System.Drawing.Point(159, 25);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(93, 30);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<name>";
            this.lblTournamentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.ForeColor = System.Drawing.Color.Black;
            this.lblRound.Location = new System.Drawing.Point(24, 90);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(73, 30);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ddRound
            // 
            this.ddRound.BackColor = System.Drawing.Color.MintCream;
            this.ddRound.ForeColor = System.Drawing.Color.Black;
            this.ddRound.FormattingEnabled = true;
            this.ddRound.Location = new System.Drawing.Point(103, 90);
            this.ddRound.Name = "ddRound";
            this.ddRound.Size = new System.Drawing.Size(168, 38);
            this.ddRound.TabIndex = 3;
            // 
            // cbUnplayedOnly
            // 
            this.cbUnplayedOnly.AutoSize = true;
            this.cbUnplayedOnly.ForeColor = System.Drawing.Color.Black;
            this.cbUnplayedOnly.Location = new System.Drawing.Point(103, 155);
            this.cbUnplayedOnly.Name = "cbUnplayedOnly";
            this.cbUnplayedOnly.Size = new System.Drawing.Size(168, 34);
            this.cbUnplayedOnly.TabIndex = 4;
            this.cbUnplayedOnly.Text = "Unplayed Only";
            this.cbUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lbMatchUp
            // 
            this.lbMatchUp.BackColor = System.Drawing.Color.MintCream;
            this.lbMatchUp.ForeColor = System.Drawing.Color.Black;
            this.lbMatchUp.FormattingEnabled = true;
            this.lbMatchUp.ItemHeight = 30;
            this.lbMatchUp.Location = new System.Drawing.Point(29, 210);
            this.lbMatchUp.Name = "lbMatchUp";
            this.lbMatchUp.Size = new System.Drawing.Size(242, 214);
            this.lbMatchUp.TabIndex = 5;
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.ForeColor = System.Drawing.Color.Black;
            this.lblTeamOneName.Location = new System.Drawing.Point(327, 210);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(129, 30);
            this.lblTeamOneName.TabIndex = 6;
            this.lblTeamOneName.Text = "<team one>";
            this.lblTeamOneName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.Black;
            this.lblTeamOneScore.Location = new System.Drawing.Point(327, 252);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(64, 30);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score";
            this.lblTeamOneScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTeamOneScoreValue
            // 
            this.tbTeamOneScoreValue.BackColor = System.Drawing.Color.MintCream;
            this.tbTeamOneScoreValue.Location = new System.Drawing.Point(422, 249);
            this.tbTeamOneScoreValue.Name = "tbTeamOneScoreValue";
            this.tbTeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.tbTeamOneScoreValue.TabIndex = 8;
            // 
            // tbTeamTwoScoreValue
            // 
            this.tbTeamTwoScoreValue.BackColor = System.Drawing.Color.MintCream;
            this.tbTeamTwoScoreValue.Location = new System.Drawing.Point(422, 389);
            this.tbTeamTwoScoreValue.Name = "tbTeamTwoScoreValue";
            this.tbTeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.tbTeamTwoScoreValue.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.Black;
            this.lblTeamTwoScore.Location = new System.Drawing.Point(327, 392);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(64, 30);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score";
            this.lblTeamTwoScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.ForeColor = System.Drawing.Color.Black;
            this.lblTeamTwoName.Location = new System.Drawing.Point(327, 350);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(128, 30);
            this.lblTeamTwoName.TabIndex = 9;
            this.lblTeamTwoName.Text = "<team two>";
            this.lblTeamTwoName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.ForeColor = System.Drawing.Color.Black;
            this.lblVS.Location = new System.Drawing.Point(402, 304);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(37, 30);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "VS";
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.MintCream;
            this.btnScore.Location = new System.Drawing.Point(562, 299);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(125, 41);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(759, 467);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.tbTeamTwoScoreValue);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoName);
            this.Controls.Add(this.tbTeamOneScoreValue);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOneName);
            this.Controls.Add(this.lbMatchUp);
            this.Controls.Add(this.cbUnplayedOnly);
            this.Controls.Add(this.ddRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox ddRound;
        private System.Windows.Forms.CheckBox cbUnplayedOnly;
        private System.Windows.Forms.ListBox lbMatchUp;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox tbTeamOneScoreValue;
        private System.Windows.Forms.TextBox tbTeamTwoScoreValue;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnScore;
    }
}

