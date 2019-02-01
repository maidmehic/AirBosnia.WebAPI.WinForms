namespace AirBosnia_UI.SpecialOffer
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
            this.dgvPonude = new System.Windows.Forms.DataGridView();
            this.PonudaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odredište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evidentirao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPonude
            // 
            this.dgvPonude.AllowUserToAddRows = false;
            this.dgvPonude.AllowUserToDeleteRows = false;
            this.dgvPonude.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PonudaID,
            this.Polaziste,
            this.Odredište,
            this.BrojLeta,
            this.VrijemePolaska,
            this.Evidentirao});
            this.dgvPonude.Location = new System.Drawing.Point(12, 49);
            this.dgvPonude.MultiSelect = false;
            this.dgvPonude.Name = "dgvPonude";
            this.dgvPonude.ReadOnly = true;
            this.dgvPonude.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPonude.Size = new System.Drawing.Size(776, 268);
            this.dgvPonude.TabIndex = 0;
            // 
            // PonudaID
            // 
            this.PonudaID.DataPropertyName = "PosebnaPonudaID";
            this.PonudaID.HeaderText = "PonudaID";
            this.PonudaID.Name = "PonudaID";
            this.PonudaID.ReadOnly = true;
            this.PonudaID.Visible = false;
            // 
            // Polaziste
            // 
            this.Polaziste.DataPropertyName = "Polaziste";
            this.Polaziste.HeaderText = "Polazište";
            this.Polaziste.Name = "Polaziste";
            this.Polaziste.ReadOnly = true;
            // 
            // Odredište
            // 
            this.Odredište.DataPropertyName = "Odrediste";
            this.Odredište.HeaderText = "Odredište";
            this.Odredište.Name = "Odredište";
            this.Odredište.ReadOnly = true;
            // 
            // BrojLeta
            // 
            this.BrojLeta.DataPropertyName = "BrojLeta";
            this.BrojLeta.HeaderText = "Broj leta";
            this.BrojLeta.Name = "BrojLeta";
            this.BrojLeta.ReadOnly = true;
            // 
            // VrijemePolaska
            // 
            this.VrijemePolaska.DataPropertyName = "DatumVrijemePolaska";
            this.VrijemePolaska.HeaderText = "Termin polaska";
            this.VrijemePolaska.Name = "VrijemePolaska";
            this.VrijemePolaska.ReadOnly = true;
            // 
            // Evidentirao
            // 
            this.Evidentirao.DataPropertyName = "Evidentirao";
            this.Evidentirao.HeaderText = "Evidentirao";
            this.Evidentirao.Name = "Evidentirao";
            this.Evidentirao.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(67, 11);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(113, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(186, 10);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 24);
            this.btnTrazi.TabIndex = 6;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(657, 11);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(131, 23);
            this.btnNovi.TabIndex = 8;
            this.btnNovi.Text = "Nova ponuda";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(383, 10);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(131, 23);
            this.btnDetalji.TabIndex = 10;
            this.btnDetalji.Text = "Više detalja";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(520, 11);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(131, 23);
            this.btnUredi.TabIndex = 9;
            this.btnUredi.Text = "Uredi ponudu";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPonude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posebne ponude";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPonude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PonudaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odredište;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evidentirao;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnUredi;
    }
}