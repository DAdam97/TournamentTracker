namespace TrackerUI.Forms
{
    partial class CreateTeamForm
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblSelectTeamMembers = new System.Windows.Forms.Label();
            this.ddSelectTeamMembers = new System.Windows.Forms.ComboBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.gbAddNewMember = new System.Windows.Forms.GroupBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.lbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.gbAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(25, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(147, 32);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Team";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.BackColor = System.Drawing.Color.MintCream;
            this.tbTournamentName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTournamentName.Location = new System.Drawing.Point(30, 113);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(368, 35);
            this.tbTournamentName.TabIndex = 12;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTeamName.ForeColor = System.Drawing.Color.Black;
            this.lblTeamName.Location = new System.Drawing.Point(25, 80);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(124, 30);
            this.lblTeamName.TabIndex = 11;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSelectTeamMembers
            // 
            this.lblSelectTeamMembers.AutoSize = true;
            this.lblSelectTeamMembers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectTeamMembers.ForeColor = System.Drawing.Color.Black;
            this.lblSelectTeamMembers.Location = new System.Drawing.Point(26, 181);
            this.lblSelectTeamMembers.Name = "lblSelectTeamMembers";
            this.lblSelectTeamMembers.Size = new System.Drawing.Size(216, 30);
            this.lblSelectTeamMembers.TabIndex = 13;
            this.lblSelectTeamMembers.Text = "Select Team Members";
            this.lblSelectTeamMembers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ddSelectTeamMembers
            // 
            this.ddSelectTeamMembers.FormattingEnabled = true;
            this.ddSelectTeamMembers.Location = new System.Drawing.Point(31, 214);
            this.ddSelectTeamMembers.Name = "ddSelectTeamMembers";
            this.ddSelectTeamMembers.Size = new System.Drawing.Size(367, 38);
            this.ddSelectTeamMembers.TabIndex = 14;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(134, 273);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(161, 40);
            this.btnAddMember.TabIndex = 15;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // gbAddNewMember
            // 
            this.gbAddNewMember.Controls.Add(this.btnCreateMember);
            this.gbAddNewMember.Controls.Add(this.tbPhoneNumber);
            this.gbAddNewMember.Controls.Add(this.lblPhoneNumber);
            this.gbAddNewMember.Controls.Add(this.tbEmail);
            this.gbAddNewMember.Controls.Add(this.lblEmail);
            this.gbAddNewMember.Controls.Add(this.tbLastName);
            this.gbAddNewMember.Controls.Add(this.lblLastName);
            this.gbAddNewMember.Controls.Add(this.tbFirstName);
            this.gbAddNewMember.Controls.Add(this.lblFirstName);
            this.gbAddNewMember.Location = new System.Drawing.Point(30, 352);
            this.gbAddNewMember.Name = "gbAddNewMember";
            this.gbAddNewMember.Size = new System.Drawing.Size(383, 305);
            this.gbAddNewMember.TabIndex = 16;
            this.gbAddNewMember.TabStop = false;
            this.gbAddNewMember.Text = "Add New Member";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BackColor = System.Drawing.Color.MintCream;
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(165, 182);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(203, 35);
            this.tbPhoneNumber.TabIndex = 22;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 185);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(154, 30);
            this.lblPhoneNumber.TabIndex = 21;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.MintCream;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(165, 138);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 35);
            this.tbEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(12, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 30);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.MintCream;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLastName.Location = new System.Drawing.Point(165, 94);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(203, 35);
            this.tbLastName.TabIndex = 20;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(12, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 30);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.MintCream;
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFirstName.Location = new System.Drawing.Point(165, 50);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(203, 35);
            this.tbFirstName.TabIndex = 18;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(12, 53);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 30);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(76, 244);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(214, 40);
            this.btnCreateMember.TabIndex = 17;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // lbTournamentPlayers
            // 
            this.lbTournamentPlayers.FormattingEnabled = true;
            this.lbTournamentPlayers.ItemHeight = 30;
            this.lbTournamentPlayers.Location = new System.Drawing.Point(440, 113);
            this.lbTournamentPlayers.Name = "lbTournamentPlayers";
            this.lbTournamentPlayers.Size = new System.Drawing.Size(368, 544);
            this.lbTournamentPlayers.TabIndex = 17;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(303, 672);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(256, 40);
            this.btnCreateTeam.TabIndex = 23;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(851, 735);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.lbTournamentPlayers);
            this.Controls.Add(this.gbAddNewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.ddSelectTeamMembers);
            this.Controls.Add(this.lblSelectTeamMembers);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.gbAddNewMember.ResumeLayout(false);
            this.gbAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblSelectTeamMembers;
        private System.Windows.Forms.ComboBox ddSelectTeamMembers;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.GroupBox gbAddNewMember;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.ListBox lbTournamentPlayers;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}