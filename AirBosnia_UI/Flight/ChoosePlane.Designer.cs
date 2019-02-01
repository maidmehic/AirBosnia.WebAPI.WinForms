namespace AirBosnia_UI.Flight
{
    partial class ChoosePlane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePlane));
            this.traziBtn = new System.Windows.Forms.Button();
            this.avioniDgv = new System.Windows.Forms.DataGridView();
            this.AvionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedistaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avioniDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(288, 21);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 23);
            this.traziBtn.TabIndex = 11;
            this.traziBtn.Text = "Pretraga";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // avioniDgv
            // 
            this.avioniDgv.AllowUserToAddRows = false;
            this.avioniDgv.AllowUserToDeleteRows = false;
            this.avioniDgv.AllowUserToResizeColumns = false;
            this.avioniDgv.AllowUserToResizeRows = false;
            this.avioniDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.avioniDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avioniDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvionID,
            this.Naziv,
            this.Oznaka,
            this.BrojSjedista,
            this.BrojSjedistaE});
            this.avioniDgv.Location = new System.Drawing.Point(12, 66);
            this.avioniDgv.Name = "avioniDgv";
            this.avioniDgv.ReadOnly = true;
            this.avioniDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.avioniDgv.Size = new System.Drawing.Size(518, 263);
            this.avioniDgv.TabIndex = 10;
            this.avioniDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avioniDgv_CellDoubleClick);
            // 
            // AvionID
            // 
            this.AvionID.DataPropertyName = "AvionID";
            this.AvionID.HeaderText = "AvionID";
            this.AvionID.Name = "AvionID";
            this.AvionID.ReadOnly = true;
            this.AvionID.Visible = false;
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
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedistaBuss";
            this.BrojSjedista.HeaderText = "Broj sjedišta (B)";
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            // 
            // BrojSjedistaE
            // 
            this.BrojSjedistaE.DataPropertyName = "BrojSjedistaEco";
            this.BrojSjedistaE.HeaderText = "Broj sjedišta (E)";
            this.BrojSjedistaE.Name = "BrojSjedistaE";
            this.BrojSjedistaE.ReadOnly = true;
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(64, 23);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(218, 20);
            this.txtOznaka.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oznaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "*Dvostrukim klikom odaberite avion";
            // 
            // ChoosePlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.avioniDgv);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosePlane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odaberite avion";
            ((System.ComponentModel.ISupportInitialize)(this.avioniDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.DataGridView avioniDgv;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedistaE;
        private System.Windows.Forms.Label label2;
    }
}