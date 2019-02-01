namespace AirBosnia_UI.Reservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Putnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpolTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipDokumenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDokumenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime putnika:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(128, 10);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(257, 20);
            this.txtImePrezime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaID,
            this.Putnik,
            this.DatumRodenja,
            this.SpolTip,
            this.TipDokumenta,
            this.BrojDokumenta,
            this.BrojLeta});
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRezervacije.Location = new System.Drawing.Point(0, 53);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(768, 312);
            this.dgvRezervacije.TabIndex = 3;
            this.dgvRezervacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellDoubleClick);
            // 
            // RezervacijaID
            // 
            this.RezervacijaID.DataPropertyName = "RezervacijaID";
            this.RezervacijaID.HeaderText = "RezervacijaID";
            this.RezervacijaID.Name = "RezervacijaID";
            this.RezervacijaID.ReadOnly = true;
            this.RezervacijaID.Visible = false;
            // 
            // Putnik
            // 
            this.Putnik.DataPropertyName = "ImePrezime";
            this.Putnik.HeaderText = "Putnik";
            this.Putnik.Name = "Putnik";
            this.Putnik.ReadOnly = true;
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.DataPropertyName = "DatumRodjenjaPutnika";
            this.DatumRodenja.HeaderText = "Datum rođenja";
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.ReadOnly = true;
            // 
            // SpolTip
            // 
            this.SpolTip.DataPropertyName = "SpolTip";
            this.SpolTip.HeaderText = "Spol/Tip";
            this.SpolTip.Name = "SpolTip";
            this.SpolTip.ReadOnly = true;
            // 
            // TipDokumenta
            // 
            this.TipDokumenta.DataPropertyName = "TipDokumenta";
            this.TipDokumenta.HeaderText = "Tip dokumenta";
            this.TipDokumenta.Name = "TipDokumenta";
            this.TipDokumenta.ReadOnly = true;
            // 
            // BrojDokumenta
            // 
            this.BrojDokumenta.DataPropertyName = "BrojDokumenta";
            this.BrojDokumenta.HeaderText = "Broj dokumenta";
            this.BrojDokumenta.Name = "BrojDokumenta";
            this.BrojDokumenta.ReadOnly = true;
            // 
            // BrojLeta
            // 
            this.BrojLeta.DataPropertyName = "BrojLeta";
            this.BrojLeta.HeaderText = "Broj leta";
            this.BrojLeta.Name = "BrojLeta";
            this.BrojLeta.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Rezervacije na današnji dan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Dvostrukim klikom na rezervaciju otvorite detalje";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipDokumenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDokumenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLeta;
        private System.Windows.Forms.Label label2;
    }
}