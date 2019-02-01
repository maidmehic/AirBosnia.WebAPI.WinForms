namespace AirBosnia_UI.Employee
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtBrUgovora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPozicija = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtusr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(111, 13);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtBrUgovora
            // 
            this.txtBrUgovora.Location = new System.Drawing.Point(111, 144);
            this.txtBrUgovora.Name = "txtBrUgovora";
            this.txtBrUgovora.Size = new System.Drawing.Size(200, 20);
            this.txtBrUgovora.TabIndex = 5;
            this.txtBrUgovora.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrUgovora_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj ugovora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(111, 39);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prezime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum rođenja:";
            // 
            // txtDatumRodenja
            // 
            this.txtDatumRodenja.CustomFormat = "   dd. MMM. yyyy ";
            this.txtDatumRodenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatumRodenja.Location = new System.Drawing.Point(111, 170);
            this.txtDatumRodenja.Name = "txtDatumRodenja";
            this.txtDatumRodenja.Size = new System.Drawing.Size(200, 20);
            this.txtDatumRodenja.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grad:";
            // 
            // cmbGrad
            // 
            this.cmbGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(111, 117);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(200, 21);
            this.cmbGrad.TabIndex = 4;
            this.cmbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrad_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Spol:";
            // 
            // cmbPozicija
            // 
            this.cmbPozicija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozicija.FormattingEnabled = true;
            this.cmbPozicija.Location = new System.Drawing.Point(111, 196);
            this.cmbPozicija.Name = "cmbPozicija";
            this.cmbPozicija.Size = new System.Drawing.Size(200, 21);
            this.cmbPozicija.TabIndex = 7;
            this.cmbPozicija.SelectedIndexChanged += new System.EventHandler(this.cmbPozicija_SelectedIndexChanged);
            this.cmbPozicija.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPozicija_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pozicija:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(236, 298);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtusr
            // 
            this.txtusr.Enabled = false;
            this.txtusr.Location = new System.Drawing.Point(111, 246);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(200, 20);
            this.txtusr.TabIndex = 10;
            this.txtusr.Validating += new System.ComponentModel.CancelEventHandler(this.txtusr_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Korisničko ime:";
            // 
            // txtpass
            // 
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(111, 272);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(200, 20);
            this.txtpass.TabIndex = 11;
            this.txtpass.Validating += new System.ComponentModel.CancelEventHandler(this.txtpass_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Lozinka:";
            // 
            // rbMuski
            // 
            this.rbMuski.AutoSize = true;
            this.rbMuski.Location = new System.Drawing.Point(111, 223);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(53, 17);
            this.rbMuski.TabIndex = 8;
            this.rbMuski.TabStop = true;
            this.rbMuski.Text = "Muški";
            this.rbMuski.UseVisualStyleBackColor = true;
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(179, 223);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(57, 17);
            this.rbZenski.TabIndex = 9;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            this.rbZenski.Validating += new System.ComponentModel.CancelEventHandler(this.rbZenski_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(111, 91);
            this.txtTelefon.Mask = "+000000000000000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 22;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 344);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.rbZenski);
            this.Controls.Add(this.rbMuski);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtusr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbPozicija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDatumRodenja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrUgovora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zaposlenik";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtBrUgovora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDatumRodenja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPozicija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtusr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}