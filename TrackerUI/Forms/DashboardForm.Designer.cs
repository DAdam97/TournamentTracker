namespace TrackerUI.Forms
{
    partial class DashboardForm
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
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.ddExistingTournament = new System.Windows.Forms.ComboBox();
            this.lblLoadTournament = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(67, 295);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(309, 56);
            this.btnCreateTournament.TabIndex = 4;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.Location = new System.Drawing.Point(120, 197);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(203, 42);
            this.btnLoadTournament.TabIndex = 3;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // ddExistingTournament
            // 
            this.ddExistingTournament.FormattingEnabled = true;
            this.ddExistingTournament.Location = new System.Drawing.Point(67, 142);
            this.ddExistingTournament.Name = "ddExistingTournament";
            this.ddExistingTournament.Size = new System.Drawing.Size(309, 38);
            this.ddExistingTournament.TabIndex = 2;
            // 
            // lblLoadTournament
            // 
            this.lblLoadTournament.AutoSize = true;
            this.lblLoadTournament.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoadTournament.Location = new System.Drawing.Point(77, 93);
            this.lblLoadTournament.Name = "lblLoadTournament";
            this.lblLoadTournament.Size = new System.Drawing.Size(289, 32);
            this.lblLoadTournament.TabIndex = 1;
            this.lblLoadTournament.Text = "Load Existing Tournament";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeader.Location = new System.Drawing.Point(63, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(316, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament Dashboard";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(442, 375);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.ddExistingTournament);
            this.Controls.Add(this.lblLoadTournament);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.ComboBox ddExistingTournament;
        private System.Windows.Forms.Label lblLoadTournament;
        private System.Windows.Forms.Label lblHeader;
    }
}