namespace AirBosnia_UI.SpecialOffer
{
    partial class ChooseFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFlight));
            this.dgvLetovi = new System.Windows.Forms.DataGridView();
            this.LetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLetovi)).BeginInit();
            this.SuspendLayout();
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
            this.dgvLetovi.Location = new System.Drawing.Point(11, 39);
            this.dgvLetovi.Name = "dgvLetovi";
            this.dgvLetovi.ReadOnly = true;
            this.dgvLetovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLetovi.Size = new System.Drawing.Size(895, 328);
            this.dgvLetovi.TabIndex = 5;
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
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(317, 10);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 8;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(66, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(245, 20);
            this.txtPretraga.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broj leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Dvostrukim klikom odaberite let";
            // 
            // ChooseFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLetovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odaberite let";
            this.Load += new System.EventHandler(this.ChooseFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLetovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLetovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemeDolaska;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}