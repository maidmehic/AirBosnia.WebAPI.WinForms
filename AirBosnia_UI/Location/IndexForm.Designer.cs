namespace AirBosnia_UI.Location
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLokacije = new System.Windows.Forms.DataGridView();
            this.GradID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).BeginInit();
            this.SuspendLayout();
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(236, 10);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 10;
            this.traziBtn.Text = "Pretraga";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(445, 10);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(82, 23);
            this.btnUredi.TabIndex = 9;
            this.btnUredi.Text = "Uredi grad";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(357, 10);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(82, 23);
            this.btnNovi.TabIndex = 8;
            this.btnNovi.Text = "Novi grad";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(60, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(170, 20);
            this.txtPretraga.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // dgvLokacije
            // 
            this.dgvLokacije.AllowUserToAddRows = false;
            this.dgvLokacije.AllowUserToDeleteRows = false;
            this.dgvLokacije.AllowUserToOrderColumns = true;
            this.dgvLokacije.AllowUserToResizeColumns = false;
            this.dgvLokacije.AllowUserToResizeRows = false;
            this.dgvLokacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLokacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradID,
            this.Naziv,
            this.Oznaka});
            this.dgvLokacije.Location = new System.Drawing.Point(13, 43);
            this.dgvLokacije.Name = "dgvLokacije";
            this.dgvLokacije.ReadOnly = true;
            this.dgvLokacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLokacije.Size = new System.Drawing.Size(514, 306);
            this.dgvLokacije.TabIndex = 11;
            // 
            // GradID
            // 
            this.GradID.DataPropertyName = "GradID";
            this.GradID.HeaderText = "GradID";
            this.GradID.Name = "GradID";
            this.GradID.ReadOnly = true;
            this.GradID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Oznaka
            // 
            this.Oznaka.DataPropertyName = "Oznaka";
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.ReadOnly = true;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 361);
            this.Controls.Add(this.dgvLokacije);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lokacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLokacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
    }
}