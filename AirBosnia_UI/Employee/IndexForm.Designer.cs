namespace AirBosnia_UI.Employee
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.traziBtn = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.pretragaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.ZaposlenikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(460, 12);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(123, 23);
            this.traziBtn.TabIndex = 10;
            this.traziBtn.Text = "Pretraga";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(918, 9);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(138, 23);
            this.btnUredi.TabIndex = 9;
            this.btnUredi.Text = "Uredi zaposlenika";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(772, 9);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(140, 23);
            this.btnNovi.TabIndex = 8;
            this.btnNovi.Text = "Novi zaposlenik";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // pretragaTxt
            // 
            this.pretragaTxt.Location = new System.Drawing.Point(90, 12);
            this.pretragaTxt.Name = "pretragaTxt";
            this.pretragaTxt.Size = new System.Drawing.Size(237, 20);
            this.pretragaTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime i prezime:";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZaposlenikID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Telefon,
            this.DatumRodenja,
            this.Grad,
            this.Pozicija,
            this.Spol,
            this.BrojUgovora,
            this.Status});
            this.dgvZaposlenici.Location = new System.Drawing.Point(13, 51);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(1043, 387);
            this.dgvZaposlenici.TabIndex = 11;
            // 
            // ZaposlenikID
            // 
            this.ZaposlenikID.DataPropertyName = "ZaposlenikID";
            this.ZaposlenikID.HeaderText = "ZaposlenikID";
            this.ZaposlenikID.Name = "ZaposlenikID";
            this.ZaposlenikID.ReadOnly = true;
            this.ZaposlenikID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.DataPropertyName = "DatumRodenja";
            this.DatumRodenja.HeaderText = "Datum rođenja";
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Pozicija
            // 
            this.Pozicija.DataPropertyName = "Pozicija";
            this.Pozicija.HeaderText = "Pozicija";
            this.Pozicija.Name = "Pozicija";
            this.Pozicija.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // BrojUgovora
            // 
            this.BrojUgovora.DataPropertyName = "BrojUgovora";
            this.BrojUgovora.HeaderText = "Broj ugovora";
            this.BrojUgovora.Name = "BrojUgovora";
            this.BrojUgovora.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Aktivan";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(333, 12);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 21);
            this.cmbTip.TabIndex = 12;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.pretragaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.TextBox pretragaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUgovora;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.ComboBox cmbTip;
    }
}