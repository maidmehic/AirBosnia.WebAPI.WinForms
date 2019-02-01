namespace AirBosnia_UI.Flight
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdabirAviona = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrSjedistaA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOznakaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDatumPolaska1 = new System.Windows.Forms.DateTimePicker();
            this.txtBrojLeta = new System.Windows.Forms.TextBox();
            this.txtDatumDolaska = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOdrediste = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPolaziste = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEkoDjeca = new System.Windows.Forms.TextBox();
            this.txtEkoOdrasli = new System.Windows.Forms.TextBox();
            this.txtBussDjeca = new System.Windows.Forms.TextBox();
            this.txtBussOdrasli = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUkloniClana = new System.Windows.Forms.Button();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.dgvPosada = new System.Windows.Forms.DataGridView();
            this.ClanPosadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcesiraj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.cbPosPonuda = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdabirAviona);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBrSjedistaA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOznakaA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNazivA);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avion";
            // 
            // btnOdabirAviona
            // 
            this.btnOdabirAviona.Location = new System.Drawing.Point(242, 101);
            this.btnOdabirAviona.Name = "btnOdabirAviona";
            this.btnOdabirAviona.Size = new System.Drawing.Size(94, 26);
            this.btnOdabirAviona.TabIndex = 6;
            this.btnOdabirAviona.Text = "Odaberite avion";
            this.btnOdabirAviona.UseVisualStyleBackColor = true;
            this.btnOdabirAviona.Click += new System.EventHandler(this.btnOdabirAviona_Click);
            this.btnOdabirAviona.Validating += new System.ComponentModel.CancelEventHandler(this.btnOdabirAviona_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj sjedišta:";
            // 
            // txtBrSjedistaA
            // 
            this.txtBrSjedistaA.Location = new System.Drawing.Point(196, 75);
            this.txtBrSjedistaA.Name = "txtBrSjedistaA";
            this.txtBrSjedistaA.ReadOnly = true;
            this.txtBrSjedistaA.Size = new System.Drawing.Size(178, 20);
            this.txtBrSjedistaA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oznaka:";
            // 
            // txtOznakaA
            // 
            this.txtOznakaA.Location = new System.Drawing.Point(196, 49);
            this.txtOznakaA.Name = "txtOznakaA";
            this.txtOznakaA.ReadOnly = true;
            this.txtOznakaA.Size = new System.Drawing.Size(178, 20);
            this.txtOznakaA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // txtNazivA
            // 
            this.txtNazivA.Location = new System.Drawing.Point(196, 23);
            this.txtNazivA.Name = "txtNazivA";
            this.txtNazivA.ReadOnly = true;
            this.txtNazivA.Size = new System.Drawing.Size(178, 20);
            this.txtNazivA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDatumPolaska1);
            this.groupBox2.Controls.Add(this.txtBrojLeta);
            this.groupBox2.Controls.Add(this.txtDatumDolaska);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbOdrediste);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbPolaziste);
            this.groupBox2.Location = new System.Drawing.Point(13, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o letu";
            // 
            // txtDatumPolaska1
            // 
            this.txtDatumPolaska1.CustomFormat = "             dd. MMM. yyyy  HH:mm";
            this.txtDatumPolaska1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatumPolaska1.Location = new System.Drawing.Point(340, 36);
            this.txtDatumPolaska1.Name = "txtDatumPolaska1";
            this.txtDatumPolaska1.Size = new System.Drawing.Size(200, 20);
            this.txtDatumPolaska1.TabIndex = 11;
            this.txtDatumPolaska1.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumPolaska1_Validating);
            // 
            // txtBrojLeta
            // 
            this.txtBrojLeta.Location = new System.Drawing.Point(90, 88);
            this.txtBrojLeta.Name = "txtBrojLeta";
            this.txtBrojLeta.Size = new System.Drawing.Size(159, 20);
            this.txtBrojLeta.TabIndex = 10;
            this.txtBrojLeta.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojLeta_Validating_1);
            // 
            // txtDatumDolaska
            // 
            this.txtDatumDolaska.CustomFormat = "             dd. MMM. yyyy  HH:mm";
            this.txtDatumDolaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDatumDolaska.Location = new System.Drawing.Point(340, 89);
            this.txtDatumDolaska.Name = "txtDatumDolaska";
            this.txtDatumDolaska.Size = new System.Drawing.Size(200, 20);
            this.txtDatumDolaska.TabIndex = 9;
            this.txtDatumDolaska.Validating += new System.ComponentModel.CancelEventHandler(this.txtDatumDolaska_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Datum i vrijeme dolaska";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datum i vrijeme polaska";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Broj leta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Odredište:";
            // 
            // cmbOdrediste
            // 
            this.cmbOdrediste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdrediste.FormattingEnabled = true;
            this.cmbOdrediste.Location = new System.Drawing.Point(90, 60);
            this.cmbOdrediste.Name = "cmbOdrediste";
            this.cmbOdrediste.Size = new System.Drawing.Size(159, 21);
            this.cmbOdrediste.TabIndex = 2;
            this.cmbOdrediste.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbOdrediste_Format);
            this.cmbOdrediste.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOdrediste_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Polazište:";
            // 
            // cmbPolaziste
            // 
            this.cmbPolaziste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPolaziste.FormattingEnabled = true;
            this.cmbPolaziste.Location = new System.Drawing.Point(90, 33);
            this.cmbPolaziste.Name = "cmbPolaziste";
            this.cmbPolaziste.Size = new System.Drawing.Size(159, 21);
            this.cmbPolaziste.TabIndex = 0;
            this.cmbPolaziste.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbPolaziste_Format);
            this.cmbPolaziste.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPolaziste_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtEkoDjeca);
            this.groupBox3.Controls.Add(this.txtEkoOdrasli);
            this.groupBox3.Controls.Add(this.txtBussDjeca);
            this.groupBox3.Controls.Add(this.txtBussOdrasli);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cijena";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Djeca:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Odrasli:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Djeca:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Odrasli:";
            // 
            // txtEkoDjeca
            // 
            this.txtEkoDjeca.Location = new System.Drawing.Point(380, 63);
            this.txtEkoDjeca.Name = "txtEkoDjeca";
            this.txtEkoDjeca.Size = new System.Drawing.Size(159, 20);
            this.txtEkoDjeca.TabIndex = 5;
            this.txtEkoDjeca.Validating += new System.ComponentModel.CancelEventHandler(this.txtEkoDjeca_Validating);
            // 
            // txtEkoOdrasli
            // 
            this.txtEkoOdrasli.Location = new System.Drawing.Point(380, 37);
            this.txtEkoOdrasli.Name = "txtEkoOdrasli";
            this.txtEkoOdrasli.Size = new System.Drawing.Size(159, 20);
            this.txtEkoOdrasli.TabIndex = 4;
            this.txtEkoOdrasli.Validating += new System.ComponentModel.CancelEventHandler(this.txtEkoOdrasli_Validating);
            // 
            // txtBussDjeca
            // 
            this.txtBussDjeca.Location = new System.Drawing.Point(90, 63);
            this.txtBussDjeca.Name = "txtBussDjeca";
            this.txtBussDjeca.Size = new System.Drawing.Size(159, 20);
            this.txtBussDjeca.TabIndex = 3;
            this.txtBussDjeca.Validating += new System.ComponentModel.CancelEventHandler(this.txtBussDjeca_Validating);
            // 
            // txtBussOdrasli
            // 
            this.txtBussOdrasli.Location = new System.Drawing.Point(90, 37);
            this.txtBussOdrasli.Name = "txtBussOdrasli";
            this.txtBussOdrasli.Size = new System.Drawing.Size(159, 20);
            this.txtBussOdrasli.TabIndex = 2;
            this.txtBussOdrasli.Validating += new System.ComponentModel.CancelEventHandler(this.txtBussOdrasli_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ekonomska klasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bussiness klasa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUkloniClana);
            this.groupBox4.Controls.Add(this.btnDodajClana);
            this.groupBox4.Controls.Add(this.dgvPosada);
            this.groupBox4.Location = new System.Drawing.Point(13, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 236);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Članovi posade";
            // 
            // btnUkloniClana
            // 
            this.btnUkloniClana.Location = new System.Drawing.Point(335, 16);
            this.btnUkloniClana.Name = "btnUkloniClana";
            this.btnUkloniClana.Size = new System.Drawing.Size(93, 23);
            this.btnUkloniClana.TabIndex = 2;
            this.btnUkloniClana.Text = "Ukloni člana";
            this.btnUkloniClana.UseVisualStyleBackColor = true;
            this.btnUkloniClana.Click += new System.EventHandler(this.btnUkloniClana_Click);
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Location = new System.Drawing.Point(447, 16);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(93, 23);
            this.btnDodajClana.TabIndex = 1;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            this.btnDodajClana.Validating += new System.ComponentModel.CancelEventHandler(this.btnDodajClana_Validating);
            // 
            // dgvPosada
            // 
            this.dgvPosada.AllowUserToAddRows = false;
            this.dgvPosada.AllowUserToDeleteRows = false;
            this.dgvPosada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanPosadeID,
            this.Ime,
            this.Prezime,
            this.DatumRodenja,
            this.Telefon,
            this.Pozicija});
            this.dgvPosada.Location = new System.Drawing.Point(7, 45);
            this.dgvPosada.Name = "dgvPosada";
            this.dgvPosada.ReadOnly = true;
            this.dgvPosada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosada.Size = new System.Drawing.Size(555, 182);
            this.dgvPosada.TabIndex = 0;
            // 
            // ClanPosadeID
            // 
            this.ClanPosadeID.DataPropertyName = "ClanPosadeID";
            this.ClanPosadeID.HeaderText = "ClanPosadeID";
            this.ClanPosadeID.Name = "ClanPosadeID";
            this.ClanPosadeID.ReadOnly = true;
            this.ClanPosadeID.Visible = false;
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
            // DatumRodenja
            // 
            this.DatumRodenja.DataPropertyName = "DatumRodenja";
            this.DatumRodenja.HeaderText = "Datum rođenja";
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Pozicija
            // 
            this.Pozicija.DataPropertyName = "Pozicija";
            this.Pozicija.HeaderText = "Pozicija";
            this.Pozicija.Name = "Pozicija";
            this.Pozicija.ReadOnly = true;
            // 
            // btnProcesiraj
            // 
            this.btnProcesiraj.Location = new System.Drawing.Point(159, 651);
            this.btnProcesiraj.Name = "btnProcesiraj";
            this.btnProcesiraj.Size = new System.Drawing.Size(275, 23);
            this.btnProcesiraj.TabIndex = 4;
            this.btnProcesiraj.Text = "Procesiraj";
            this.btnProcesiraj.UseVisualStyleBackColor = true;
            this.btnProcesiraj.Click += new System.EventHandler(this.btnProcesiraj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(387, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Let rezervisan za posebnu ponudu:";
            // 
            // cbPosPonuda
            // 
            this.cbPosPonuda.AutoSize = true;
            this.cbPosPonuda.Location = new System.Drawing.Point(566, 12);
            this.cbPosPonuda.Name = "cbPosPonuda";
            this.cbPosPonuda.Size = new System.Drawing.Size(15, 14);
            this.cbPosPonuda.TabIndex = 13;
            this.cbPosPonuda.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(593, 684);
            this.Controls.Add(this.cbPosPonuda);
            this.Controls.Add(this.btnProcesiraj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi let";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdabirAviona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrSjedistaA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOznakaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDatumPolaska;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOdrediste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPolaziste;
        private System.Windows.Forms.DateTimePicker txtDatumDolaska;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEkoDjeca;
        private System.Windows.Forms.TextBox txtEkoOdrasli;
        private System.Windows.Forms.TextBox txtBussDjeca;
        private System.Windows.Forms.TextBox txtBussOdrasli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPosada;
        private System.Windows.Forms.Button btnUkloniClana;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClanPosadeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
        private System.Windows.Forms.Button btnProcesiraj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtBrojLeta;
        private System.Windows.Forms.DateTimePicker txtDatumPolaska1;
        private System.Windows.Forms.CheckBox cbPosPonuda;
        private System.Windows.Forms.Label label15;
    }
}