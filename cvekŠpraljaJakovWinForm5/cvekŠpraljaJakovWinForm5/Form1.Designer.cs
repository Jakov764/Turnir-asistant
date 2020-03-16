namespace cvekŠpraljaJakovWinForm5
{
    partial class Form1
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
            this.nadzornaPlocaLabel = new System.Windows.Forms.Label();
            this.ucitajLabel = new System.Windows.Forms.Label();
            this.turniriCmb = new System.Windows.Forms.ComboBox();
            this.ucitajBtn = new System.Windows.Forms.Button();
            this.izradiTurnirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nadzornaPlocaLabel
            // 
            this.nadzornaPlocaLabel.AutoSize = true;
            this.nadzornaPlocaLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadzornaPlocaLabel.Location = new System.Drawing.Point(49, 26);
            this.nadzornaPlocaLabel.Name = "nadzornaPlocaLabel";
            this.nadzornaPlocaLabel.Size = new System.Drawing.Size(179, 33);
            this.nadzornaPlocaLabel.TabIndex = 0;
            this.nadzornaPlocaLabel.Text = "Nadzorna Ploča";
            this.nadzornaPlocaLabel.Click += new System.EventHandler(this.nadzornaPlocaLabel_Click);
            // 
            // ucitajLabel
            // 
            this.ucitajLabel.AutoSize = true;
            this.ucitajLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucitajLabel.Location = new System.Drawing.Point(65, 87);
            this.ucitajLabel.Name = "ucitajLabel";
            this.ucitajLabel.Size = new System.Drawing.Size(147, 23);
            this.ucitajLabel.TabIndex = 1;
            this.ucitajLabel.Text = "Učitaj Postojeći Turnir";
            this.ucitajLabel.Click += new System.EventHandler(this.ucitajLabel_Click);
            // 
            // turniriCmb
            // 
            this.turniriCmb.FormattingEnabled = true;
            this.turniriCmb.Location = new System.Drawing.Point(67, 134);
            this.turniriCmb.Name = "turniriCmb";
            this.turniriCmb.Size = new System.Drawing.Size(143, 21);
            this.turniriCmb.TabIndex = 2;
            // 
            // ucitajBtn
            // 
            this.ucitajBtn.Location = new System.Drawing.Point(90, 161);
            this.ucitajBtn.Name = "ucitajBtn";
            this.ucitajBtn.Size = new System.Drawing.Size(90, 34);
            this.ucitajBtn.TabIndex = 3;
            this.ucitajBtn.Text = "Učitaj Turnir";
            this.ucitajBtn.UseVisualStyleBackColor = true;
            // 
            // izradiTurnirBtn
            // 
            this.izradiTurnirBtn.Location = new System.Drawing.Point(51, 220);
            this.izradiTurnirBtn.Name = "izradiTurnirBtn";
            this.izradiTurnirBtn.Size = new System.Drawing.Size(173, 55);
            this.izradiTurnirBtn.TabIndex = 4;
            this.izradiTurnirBtn.Text = "Izradi turnir";
            this.izradiTurnirBtn.UseVisualStyleBackColor = true;
            this.izradiTurnirBtn.Click += new System.EventHandler(this.izradiTurnirBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(279, 335);
            this.Controls.Add(this.izradiTurnirBtn);
            this.Controls.Add(this.ucitajBtn);
            this.Controls.Add(this.turniriCmb);
            this.Controls.Add(this.ucitajLabel);
            this.Controls.Add(this.nadzornaPlocaLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadzornaPlocaLabel;
        private System.Windows.Forms.Label ucitajLabel;
        private System.Windows.Forms.ComboBox turniriCmb;
        private System.Windows.Forms.Button ucitajBtn;
        private System.Windows.Forms.Button izradiTurnirBtn;
    }
}

