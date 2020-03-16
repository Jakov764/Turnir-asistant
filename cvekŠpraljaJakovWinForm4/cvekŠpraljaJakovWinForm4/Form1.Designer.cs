namespace cvekŠpraljaJakovWinForm4
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
            this.izradiNagraduLabel = new System.Windows.Forms.Label();
            this.mjestoLabel = new System.Windows.Forms.Label();
            this.mjestoTxt = new System.Windows.Forms.TextBox();
            this.imeMjestaTxt = new System.Windows.Forms.TextBox();
            this.imeMjestaLabel = new System.Windows.Forms.Label();
            this.iznosTxt = new System.Windows.Forms.TextBox();
            this.iznosLAbel = new System.Windows.Forms.Label();
            this.iliLabel = new System.Windows.Forms.Label();
            this.postotakTxt = new System.Windows.Forms.TextBox();
            this.postotakLabel = new System.Windows.Forms.Label();
            this.izradiNagraduBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izradiNagraduLabel
            // 
            this.izradiNagraduLabel.AutoSize = true;
            this.izradiNagraduLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izradiNagraduLabel.Location = new System.Drawing.Point(33, 13);
            this.izradiNagraduLabel.Name = "izradiNagraduLabel";
            this.izradiNagraduLabel.Size = new System.Drawing.Size(170, 33);
            this.izradiNagraduLabel.TabIndex = 0;
            this.izradiNagraduLabel.Text = "Izradi Nagradu";
            // 
            // mjestoLabel
            // 
            this.mjestoLabel.AutoSize = true;
            this.mjestoLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mjestoLabel.Location = new System.Drawing.Point(36, 101);
            this.mjestoLabel.Name = "mjestoLabel";
            this.mjestoLabel.Size = new System.Drawing.Size(51, 23);
            this.mjestoLabel.TabIndex = 1;
            this.mjestoLabel.Text = "Mjesto";
            // 
            // mjestoTxt
            // 
            this.mjestoTxt.Location = new System.Drawing.Point(183, 106);
            this.mjestoTxt.Name = "mjestoTxt";
            this.mjestoTxt.Size = new System.Drawing.Size(183, 20);
            this.mjestoTxt.TabIndex = 2;
            // 
            // imeMjestaTxt
            // 
            this.imeMjestaTxt.Location = new System.Drawing.Point(183, 144);
            this.imeMjestaTxt.Name = "imeMjestaTxt";
            this.imeMjestaTxt.Size = new System.Drawing.Size(183, 20);
            this.imeMjestaTxt.TabIndex = 4;
            // 
            // imeMjestaLabel
            // 
            this.imeMjestaLabel.AutoSize = true;
            this.imeMjestaLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeMjestaLabel.Location = new System.Drawing.Point(36, 139);
            this.imeMjestaLabel.Name = "imeMjestaLabel";
            this.imeMjestaLabel.Size = new System.Drawing.Size(80, 23);
            this.imeMjestaLabel.TabIndex = 3;
            this.imeMjestaLabel.Text = "Ime mjesta";
            // 
            // iznosTxt
            // 
            this.iznosTxt.Location = new System.Drawing.Point(183, 187);
            this.iznosTxt.Name = "iznosTxt";
            this.iznosTxt.Size = new System.Drawing.Size(183, 20);
            this.iznosTxt.TabIndex = 6;
            this.iznosTxt.TextChanged += new System.EventHandler(this.iznosTxt_TextChanged);
            // 
            // iznosLAbel
            // 
            this.iznosLAbel.AutoSize = true;
            this.iznosLAbel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iznosLAbel.Location = new System.Drawing.Point(36, 182);
            this.iznosLAbel.Name = "iznosLAbel";
            this.iznosLAbel.Size = new System.Drawing.Size(100, 23);
            this.iznosLAbel.TabIndex = 5;
            this.iznosLAbel.Text = "Iznos nagrade";
            // 
            // iliLabel
            // 
            this.iliLabel.AutoSize = true;
            this.iliLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iliLabel.Location = new System.Drawing.Point(167, 246);
            this.iliLabel.Name = "iliLabel";
            this.iliLabel.Size = new System.Drawing.Size(36, 23);
            this.iliLabel.TabIndex = 7;
            this.iliLabel.Text = "-ili-";
            // 
            // postotakTxt
            // 
            this.postotakTxt.Location = new System.Drawing.Point(183, 311);
            this.postotakTxt.Name = "postotakTxt";
            this.postotakTxt.Size = new System.Drawing.Size(183, 20);
            this.postotakTxt.TabIndex = 9;
            // 
            // postotakLabel
            // 
            this.postotakLabel.AutoSize = true;
            this.postotakLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postotakLabel.Location = new System.Drawing.Point(36, 306);
            this.postotakLabel.Name = "postotakLabel";
            this.postotakLabel.Size = new System.Drawing.Size(121, 23);
            this.postotakLabel.TabIndex = 8;
            this.postotakLabel.Text = "Postotak nagrade";
            // 
            // izradiNagraduBtn
            // 
            this.izradiNagraduBtn.Location = new System.Drawing.Point(78, 385);
            this.izradiNagraduBtn.Name = "izradiNagraduBtn";
            this.izradiNagraduBtn.Size = new System.Drawing.Size(176, 34);
            this.izradiNagraduBtn.TabIndex = 10;
            this.izradiNagraduBtn.Text = "Izradi Nagradu";
            this.izradiNagraduBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(391, 490);
            this.Controls.Add(this.izradiNagraduBtn);
            this.Controls.Add(this.postotakTxt);
            this.Controls.Add(this.postotakLabel);
            this.Controls.Add(this.iliLabel);
            this.Controls.Add(this.iznosTxt);
            this.Controls.Add(this.iznosLAbel);
            this.Controls.Add(this.imeMjestaTxt);
            this.Controls.Add(this.imeMjestaLabel);
            this.Controls.Add(this.mjestoTxt);
            this.Controls.Add(this.mjestoLabel);
            this.Controls.Add(this.izradiNagraduLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label izradiNagraduLabel;
        private System.Windows.Forms.Label mjestoLabel;
        private System.Windows.Forms.TextBox mjestoTxt;
        private System.Windows.Forms.TextBox imeMjestaTxt;
        private System.Windows.Forms.Label imeMjestaLabel;
        private System.Windows.Forms.TextBox iznosTxt;
        private System.Windows.Forms.Label iznosLAbel;
        private System.Windows.Forms.Label iliLabel;
        private System.Windows.Forms.TextBox postotakTxt;
        private System.Windows.Forms.Label postotakLabel;
        private System.Windows.Forms.Button izradiNagraduBtn;
    }
}

