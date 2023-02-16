namespace TrackerUI.Forms
{
    partial class CreatePrizeForm
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
            this.lblCreatePrize = new System.Windows.Forms.Label();
            this.lblPlaceNumber = new System.Windows.Forms.Label();
            this.lblPrizeAmount = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblPrizePercentage = new System.Windows.Forms.Label();
            this.tbPlaceNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreatePrize
            // 
            this.lblCreatePrize.AutoSize = true;
            this.lblCreatePrize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCreatePrize.Location = new System.Drawing.Point(25, 25);
            this.lblCreatePrize.Name = "lblCreatePrize";
            this.lblCreatePrize.Size = new System.Drawing.Size(141, 32);
            this.lblCreatePrize.TabIndex = 0;
            this.lblCreatePrize.Text = "Create Prize";
            // 
            // lblPlaceNumber
            // 
            this.lblPlaceNumber.AutoSize = true;
            this.lblPlaceNumber.Location = new System.Drawing.Point(63, 81);
            this.lblPlaceNumber.Name = "lblPlaceNumber";
            this.lblPlaceNumber.Size = new System.Drawing.Size(144, 30);
            this.lblPlaceNumber.TabIndex = 1;
            this.lblPlaceNumber.Text = "Place Number";
            // 
            // lblPrizeAmount
            // 
            this.lblPrizeAmount.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lblPrizeAmount.AutoSize = true;
            this.lblPrizeAmount.Location = new System.Drawing.Point(63, 179);
            this.lblPrizeAmount.Name = "lblPrizeAmount";
            this.lblPrizeAmount.Size = new System.Drawing.Size(139, 30);
            this.lblPrizeAmount.TabIndex = 2;
            this.lblPrizeAmount.Text = "Prize Amount";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(63, 130);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(124, 30);
            this.lblPlaceName.TabIndex = 3;
            this.lblPlaceName.Text = "Place Name";
            // 
            // lblPrizePercentage
            // 
            this.lblPrizePercentage.AutoSize = true;
            this.lblPrizePercentage.Location = new System.Drawing.Point(63, 292);
            this.lblPrizePercentage.Name = "lblPrizePercentage";
            this.lblPrizePercentage.Size = new System.Drawing.Size(167, 30);
            this.lblPrizePercentage.TabIndex = 4;
            this.lblPrizePercentage.Text = "Prize Percentage";
            // 
            // tbPlaceNumber
            // 
            this.tbPlaceNumber.Location = new System.Drawing.Point(270, 79);
            this.tbPlaceNumber.Name = "tbPlaceNumber";
            this.tbPlaceNumber.Size = new System.Drawing.Size(176, 35);
            this.tbPlaceNumber.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 35);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 35);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 35);
            this.textBox3.TabIndex = 8;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(194, 233);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(60, 30);
            this.lblOr.TabIndex = 9;
            this.lblOr.Text = "- or -";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(155, 365);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(181, 39);
            this.btnCreatePrize.TabIndex = 10;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(494, 437);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbPlaceNumber);
            this.Controls.Add(this.lblPrizePercentage);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblPrizeAmount);
            this.Controls.Add(this.lblPlaceNumber);
            this.Controls.Add(this.lblCreatePrize);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Prize Creaton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreatePrize;
        private System.Windows.Forms.Label lblPlaceNumber;
        private System.Windows.Forms.Label lblPrizeAmount;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblPrizePercentage;
        private System.Windows.Forms.TextBox tbPlaceNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}