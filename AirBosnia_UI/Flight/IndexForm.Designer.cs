namespace AirBosnia_UI.Flight
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
            this.btnNovi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.dgvLetovi = new System.Windows.Forms.DataGridView();
            this.LetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLetovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(776, 13);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(131, 23);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi let";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj leta:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(72, 13);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(245, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(404, 12);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // dgvLetovi
            // 
            this.dgvLetovi.AllowUserToAddRows = false;
            this.dgvLetovi.AllowUserToDeleteRows = false;
            this.dgvLetovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLetovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLetovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LetID,
            this.BrojLeta,
            this.Polaziste,
            this.Odrediste,
            this.Avion,
            this.DatumVrijemePolaska,
            this.DatumVrijemeDolaska});
            this.dgvLetovi.Location = new System.Drawing.Point(12, 69);
            this.dgvLetovi.Name = "dgvLetovi";
            this.dgvLetovi.ReadOnly = true;
            this.dgvLetovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLetovi.Size = new System.Drawing.Size(895, 328);
            this.dgvLetovi.TabIndex = 4;
            this.dgvLetovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLetovi_CellDoubleClick);
            // 
            // LetID
            // 
            this.LetID.DataPropertyName = "LetID";
            this.LetID.HeaderText = "LetID";
            this.LetID.Name = "LetID";
            this.LetID.ReadOnly = true;
            this.LetID.Visible = false;
            // 
            // BrojLeta
            // 
            this.BrojLeta.DataPropertyName = "BrojLeta";
            this.BrojLeta.HeaderText = "Broj leta";
            this.BrojLeta.Name = "BrojLeta";
            this.BrojLeta.ReadOnly = true;
            // 
            // Polaziste
            // 
            this.Polaziste.DataPropertyName = "polaziste";
            this.Polaziste.HeaderText = "Polazište";
            this.Polaziste.Name = "Polaziste";
            this.Polaziste.ReadOnly = true;
            // 
            // Odrediste
            // 
            this.Odrediste.DataPropertyName = "odrediste";
            this.Odrediste.HeaderText = "Odredište";
            this.Odrediste.Name = "Odrediste";
            this.Odrediste.ReadOnly = true;
            // 
            // Avion
            // 
            this.Avion.DataPropertyName = "avion";
            this.Avion.HeaderText = "Avion";
            this.Avion.Name = "Avion";
            this.Avion.ReadOnly = true;
            // 
            // DatumVrijemePolaska
            // 
            this.DatumVrijemePolaska.DataPropertyName = "DatumVrijemePolaska";
            this.DatumVrijemePolaska.HeaderText = "Datum i vrijeme polaska";
            this.DatumVrijemePolaska.Name = "DatumVrijemePolaska";
            this.DatumVrijemePolaska.ReadOnly = true;
            // 
            // DatumVrijemeDolaska
            // 
            this.DatumVrijemeDolaska.DataPropertyName = "DatumVrijemeDolaska";
            this.DatumVrijemeDolaska.HeaderText = "Datum i vrijeme dolaska";
            this.DatumVrijemeDolaska.Name = "DatumVrijemeDolaska";
            this.DatumVrijemeDolaska.ReadOnly = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(323, 13);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(75, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(639, 13);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(131, 23);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi let";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(502, 12);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(131, 23);
            this.btnDetalji.TabIndex = 7;
            this.btnDetalji.Text = "Više detalja";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Dvostrukim klikom pregledajte izvještaj o rezervacijama na letu";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dgvLetovi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled letova";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLetovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvLetovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemeDolaska;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Label label2;
    }
}