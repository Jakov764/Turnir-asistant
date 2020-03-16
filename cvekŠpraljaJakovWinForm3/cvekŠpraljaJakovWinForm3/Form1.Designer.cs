namespace cvekŠpraljaJakovWinForm3
{
    partial class ime
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
            this.izradiTimLabel = new System.Windows.Forms.Label();
            this.imeTImaLabel = new System.Windows.Forms.Label();
            this.imeTxt = new System.Windows.Forms.TextBox();
            this.odaberiTimLabel = new System.Windows.Forms.Label();
            this.odaberiTimCmb = new System.Windows.Forms.ComboBox();
            this.dodajClanaBtn = new System.Windows.Forms.Button();
            this.napraviLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prezimeTxt = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.brojTelefonaTxt = new System.Windows.Forms.TextBox();
            this.brojTelefonaLabel = new System.Windows.Forms.Label();
            this.izradiClanaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.igraciList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izradiTimLabel
            // 
            this.izradiTimLabel.AutoSize = true;
            this.izradiTimLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izradiTimLabel.Location = new System.Drawing.Point(34, 9);
            this.izradiTimLabel.Name = "izradiTimLabel";
            this.izradiTimLabel.Size = new System.Drawing.Size(117, 33);
            this.izradiTimLabel.TabIndex = 0;
            this.izradiTimLabel.Text = "Izradi Tim";
            // 
            // imeTImaLabel
            // 
            this.imeTImaLabel.AutoSize = true;
            this.imeTImaLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeTImaLabel.Location = new System.Drawing.Point(37, 59);
            this.imeTImaLabel.Name = "imeTImaLabel";
            this.imeTImaLabel.Size = new System.Drawing.Size(68, 23);
            this.imeTImaLabel.TabIndex = 1;
            this.imeTImaLabel.Text = "Ime Tima";
            // 
            // imeTxt
            // 
            this.imeTxt.Location = new System.Drawing.Point(40, 85);
            this.imeTxt.Name = "imeTxt";
            this.imeTxt.Size = new System.Drawing.Size(169, 20);
            this.imeTxt.TabIndex = 2;
            // 
            // odaberiTimLabel
            // 
            this.odaberiTimLabel.AutoSize = true;
            this.odaberiTimLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odaberiTimLabel.Location = new System.Drawing.Point(37, 122);
            this.odaberiTimLabel.Name = "odaberiTimLabel";
            this.odaberiTimLabel.Size = new System.Drawing.Size(138, 23);
            this.odaberiTimLabel.TabIndex = 3;
            this.odaberiTimLabel.Text = "Odaberi Člana Ekipe";
            // 
            // odaberiTimCmb
            // 
            this.odaberiTimCmb.FormattingEnabled = true;
            this.odaberiTimCmb.Location = new System.Drawing.Point(40, 148);
            this.odaberiTimCmb.Name = "odaberiTimCmb";
            this.odaberiTimCmb.Size = new System.Drawing.Size(169, 21);
            this.odaberiTimCmb.TabIndex = 4;
            // 
            // dodajClanaBtn
            // 
            this.dodajClanaBtn.Location = new System.Drawing.Point(55, 184);
            this.dodajClanaBtn.Name = "dodajClanaBtn";
            this.dodajClanaBtn.Size = new System.Drawing.Size(135, 34);
            this.dodajClanaBtn.TabIndex = 5;
            this.dodajClanaBtn.Text = "Dodaj člana";
            this.dodajClanaBtn.UseVisualStyleBackColor = true;
            // 
            // napraviLabel
            // 
            this.napraviLabel.AutoSize = true;
            this.napraviLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napraviLabel.Location = new System.Drawing.Point(36, 234);
            this.napraviLabel.Name = "napraviLabel";
            this.napraviLabel.Size = new System.Drawing.Size(125, 23);
            this.napraviLabel.TabIndex = 6;
            this.napraviLabel.Text = "Dodaj novog člana";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.izradiClanaBtn);
            this.groupBox1.Controls.Add(this.brojTelefonaTxt);
            this.groupBox1.Controls.Add(this.brojTelefonaLabel);
            this.groupBox1.Controls.Add(this.emailTxt);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.prezimeTxt);
            this.groupBox1.Controls.Add(this.prezimeLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.imeLabel);
            this.groupBox1.Location = new System.Drawing.Point(40, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeLabel.Location = new System.Drawing.Point(6, 27);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(31, 15);
            this.imeLabel.TabIndex = 0;
            this.imeLabel.Text = "Ime:";
            this.imeLabel.Click += new System.EventHandler(this.imeLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            // 
            // prezimeTxt
            // 
            this.prezimeTxt.Location = new System.Drawing.Point(96, 50);
            this.prezimeTxt.Name = "prezimeTxt";
            this.prezimeTxt.Size = new System.Drawing.Size(114, 20);
            this.prezimeTxt.TabIndex = 3;
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeLabel.Location = new System.Drawing.Point(6, 53);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(56, 15);
            this.prezimeLabel.TabIndex = 2;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(96, 76);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(114, 20);
            this.emailTxt.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(6, 79);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 15);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // brojTelefonaTxt
            // 
            this.brojTelefonaTxt.Location = new System.Drawing.Point(96, 102);
            this.brojTelefonaTxt.Name = "brojTelefonaTxt";
            this.brojTelefonaTxt.Size = new System.Drawing.Size(114, 20);
            this.brojTelefonaTxt.TabIndex = 11;
            // 
            // brojTelefonaLabel
            // 
            this.brojTelefonaLabel.AutoSize = true;
            this.brojTelefonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojTelefonaLabel.Location = new System.Drawing.Point(6, 105);
            this.brojTelefonaLabel.Name = "brojTelefonaLabel";
            this.brojTelefonaLabel.Size = new System.Drawing.Size(79, 15);
            this.brojTelefonaLabel.TabIndex = 10;
            this.brojTelefonaLabel.Text = "Broj telefona:";
            // 
            // izradiClanaBtn
            // 
            this.izradiClanaBtn.Location = new System.Drawing.Point(47, 145);
            this.izradiClanaBtn.Name = "izradiClanaBtn";
            this.izradiClanaBtn.Size = new System.Drawing.Size(113, 38);
            this.izradiClanaBtn.TabIndex = 12;
            this.izradiClanaBtn.Text = "Izradi člana";
            this.izradiClanaBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kreiraj Tim";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // igraciList
            // 
            this.igraciList.FormattingEnabled = true;
            this.igraciList.Location = new System.Drawing.Point(302, 77);
            this.igraciList.Name = "igraciList";
            this.igraciList.Size = new System.Drawing.Size(245, 407);
            this.igraciList.TabIndex = 9;
            // 
            // ime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(621, 624);
            this.Controls.Add(this.igraciList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.napraviLabel);
            this.Controls.Add(this.dodajClanaBtn);
            this.Controls.Add(this.odaberiTimCmb);
            this.Controls.Add(this.odaberiTimLabel);
            this.Controls.Add(this.imeTxt);
            this.Controls.Add(this.imeTImaLabel);
            this.Controls.Add(this.izradiTimLabel);
            this.Name = "ime";
            this.Text = "Ime:";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label izradiTimLabel;
        private System.Windows.Forms.Label imeTImaLabel;
        private System.Windows.Forms.TextBox imeTxt;
        private System.Windows.Forms.Label odaberiTimLabel;
        private System.Windows.Forms.ComboBox odaberiTimCmb;
        private System.Windows.Forms.Button dodajClanaBtn;
        private System.Windows.Forms.Label napraviLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox prezimeTxt;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Button izradiClanaBtn;
        private System.Windows.Forms.TextBox brojTelefonaTxt;
        private System.Windows.Forms.Label brojTelefonaLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox igraciList;
    }
}

