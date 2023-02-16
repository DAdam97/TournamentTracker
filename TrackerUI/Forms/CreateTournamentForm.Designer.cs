namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.tbEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.ddSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.llblCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lblTeamsPlayers = new System.Windows.Forms.Label();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.lbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedPlayers = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(31, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(242, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Tournament";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.BackColor = System.Drawing.Color.MintCream;
            this.tbTournamentName.Location = new System.Drawing.Point(38, 151);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(282, 35);
            this.tbTournamentName.TabIndex = 10;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.Color.Black;
            this.lblTournamentName.Location = new System.Drawing.Point(33, 98);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(186, 30);
            this.lblTournamentName.TabIndex = 9;
            this.lblTournamentName.Text = "Tournament Name";
            this.lblTournamentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEntryFee
            // 
            this.tbEntryFee.BackColor = System.Drawing.Color.MintCream;
            this.tbEntryFee.Location = new System.Drawing.Point(173, 217);
            this.tbEntryFee.Name = "tbEntryFee";
            this.tbEntryFee.Size = new System.Drawing.Size(147, 35);
            this.tbEntryFee.TabIndex = 12;
            this.tbEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.ForeColor = System.Drawing.Color.Black;
            this.lblEntryFee.Location = new System.Drawing.Point(33, 217);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(103, 30);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee:";
            this.lblEntryFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ddSelectTeam
            // 
            this.ddSelectTeam.BackColor = System.Drawing.Color.MintCream;
            this.ddSelectTeam.ForeColor = System.Drawing.Color.Black;
            this.ddSelectTeam.FormattingEnabled = true;
            this.ddSelectTeam.Location = new System.Drawing.Point(38, 347);
            this.ddSelectTeam.Name = "ddSelectTeam";
            this.ddSelectTeam.Size = new System.Drawing.Size(282, 38);
            this.ddSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.ForeColor = System.Drawing.Color.Black;
            this.lblSelectTeam.Location = new System.Drawing.Point(33, 302);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(123, 30);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team";
            this.lblSelectTeam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // llblCreateNewTeam
            // 
            this.llblCreateNewTeam.AutoSize = true;
            this.llblCreateNewTeam.Location = new System.Drawing.Point(206, 302);
            this.llblCreateNewTeam.Name = "llblCreateNewTeam";
            this.llblCreateNewTeam.Size = new System.Drawing.Size(114, 30);
            this.llblCreateNewTeam.TabIndex = 15;
            this.llblCreateNewTeam.TabStop = true;
            this.llblCreateNewTeam.Text = "create new";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(87, 415);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(170, 45);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(87, 488);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(170, 43);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lblTeamsPlayers
            // 
            this.lblTeamsPlayers.AutoSize = true;
            this.lblTeamsPlayers.Location = new System.Drawing.Point(461, 98);
            this.lblTeamsPlayers.Name = "lblTeamsPlayers";
            this.lblTeamsPlayers.Size = new System.Drawing.Size(156, 30);
            this.lblTeamsPlayers.TabIndex = 18;
            this.lblTeamsPlayers.Text = "Teams / Players";
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Location = new System.Drawing.Point(461, 350);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(67, 30);
            this.lblPrizes.TabIndex = 19;
            this.lblPrizes.Text = "Prizes";
            // 
            // lbTournamentPlayers
            // 
            this.lbTournamentPlayers.FormattingEnabled = true;
            this.lbTournamentPlayers.ItemHeight = 30;
            this.lbTournamentPlayers.Location = new System.Drawing.Point(466, 131);
            this.lbTournamentPlayers.Name = "lbTournamentPlayers";
            this.lbTournamentPlayers.Size = new System.Drawing.Size(355, 184);
            this.lbTournamentPlayers.TabIndex = 20;
            // 
            // lbPrizes
            // 
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 30;
            this.lbPrizes.Location = new System.Drawing.Point(466, 383);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(355, 184);
            this.lbPrizes.TabIndex = 21;
            // 
            // btnDeleteSelectedPlayers
            // 
            this.btnDeleteSelectedPlayers.Location = new System.Drawing.Point(827, 131);
            this.btnDeleteSelectedPlayers.Name = "btnDeleteSelectedPlayers";
            this.btnDeleteSelectedPlayers.Size = new System.Drawing.Size(130, 75);
            this.btnDeleteSelectedPlayers.TabIndex = 22;
            this.btnDeleteSelectedPlayers.Text = "Delete Selected";
            this.btnDeleteSelectedPlayers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrize
            // 
            this.btnDeleteSelectedPrize.Location = new System.Drawing.Point(827, 383);
            this.btnDeleteSelectedPrize.Name = "btnDeleteSelectedPrize";
            this.btnDeleteSelectedPrize.Size = new System.Drawing.Size(130, 75);
            this.btnDeleteSelectedPrize.TabIndex = 23;
            this.btnDeleteSelectedPrize.Text = "Delete Selected";
            this.btnDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(334, 590);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(268, 43);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(988, 662);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeleteSelectedPrize);
            this.Controls.Add(this.btnDeleteSelectedPlayers);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.lbTournamentPlayers);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.lblTeamsPlayers);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.llblCreateNewTeam);
            this.Controls.Add(this.ddSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.tbEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox tbEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox ddSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel llblCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.Label lblTeamsPlayers;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox lbTournamentPlayers;
        private System.Windows.Forms.ListBox lbPrizes;
        private System.Windows.Forms.Button btnDeleteSelectedPlayers;
        private System.Windows.Forms.Button btnDeleteSelectedPrize;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}