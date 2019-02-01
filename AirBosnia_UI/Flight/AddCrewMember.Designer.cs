namespace AirBosnia_UI.Flight
{
    partial class AddCrewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCrewMember));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.ZaposlenikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traziBtn = new System.Windows.Forms.Button();
            this.pretragaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
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
            this.Pozicija,
            this.Spol,
            this.BrojUgovora});
            this.dgvZaposlenici.Location = new System.Drawing.Point(9, 53);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(843, 387);
            this.dgvZaposlenici.TabIndex = 15;
            this.dgvZaposlenici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaposlenici_CellDoubleClick);
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
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(329, 12);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(123, 23);
            this.traziBtn.TabIndex = 14;
            this.traziBtn.Text = "Pretraga";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // pretragaTxt
            // 
            this.pretragaTxt.Location = new System.Drawing.Point(86, 14);
            this.pretragaTxt.Name = "pretragaTxt";
            this.pretragaTxt.Size = new System.Drawing.Size(237, 20);
            this.pretragaTxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "*Dvostrukim klikom odaberite člana posade";
            // 
            // AddCrewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.pretragaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCrewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Član posade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.TextBox pretragaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUgovora;
        private System.Windows.Forms.Label label2;
    }
}