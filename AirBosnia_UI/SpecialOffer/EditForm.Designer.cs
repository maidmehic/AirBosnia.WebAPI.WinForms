namespace AirBosnia_UI.SpecialOffer
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBrDana = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSmjestaj = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdaberiDolazak = new System.Windows.Forms.Button();
            this.txtPolazisteD = new System.Windows.Forms.TextBox();
            this.txtPolazakD = new System.Windows.Forms.TextBox();
            this.txtDolazakD = new System.Windows.Forms.TextBox();
            this.txtDolazisteD = new System.Windows.Forms.TextBox();
            this.txtBrLetaD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdaberiPolazak = new System.Windows.Forms.Button();
            this.txtPolazisteP = new System.Windows.Forms.TextBox();
            this.txtPolazakP = new System.Windows.Forms.TextBox();
            this.txtDolazakP = new System.Windows.Forms.TextBox();
            this.txtDolazisteP = new System.Windows.Forms.TextBox();
            this.txtBrLetaP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(530, 412);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(103, 48);
            this.btnZavrsi.TabIndex = 21;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(441, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Informacije o putovanju";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(362, 268);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(271, 138);
            this.txtNapomena.TabIndex = 19;
            this.txtNapomena.Text = "";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(99, 438);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(113, 20);
            this.txtCijena.TabIndex = 18;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cijena:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Broj dana:";
            // 
            // txtBrDana
            // 
            this.txtBrDana.Location = new System.Drawing.Point(99, 412);
            this.txtBrDana.Name = "txtBrDana";
            this.txtBrDana.Size = new System.Drawing.Size(113, 20);
            this.txtBrDana.TabIndex = 15;
            this.txtBrDana.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrDana_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Informacije o smještaju";
            // 
            // txtSmjestaj
            // 
            this.txtSmjestaj.Location = new System.Drawing.Point(38, 268);
            this.txtSmjestaj.Name = "txtSmjestaj";
            this.txtSmjestaj.Size = new System.Drawing.Size(271, 138);
            this.txtSmjestaj.TabIndex = 13;
            this.txtSmjestaj.Text = "";
            this.txtSmjestaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSmjestaj_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOdaberiDolazak);
            this.groupBox2.Controls.Add(this.txtPolazisteD);
            this.groupBox2.Controls.Add(this.txtPolazakD);
            this.groupBox2.Controls.Add(this.txtDolazakD);
            this.groupBox2.Controls.Add(this.txtDolazisteD);
            this.groupBox2.Controls.Add(this.txtBrLetaD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(362, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 194);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dolazak";
            // 
            // btnOdaberiDolazak
            // 
            this.btnOdaberiDolazak.Location = new System.Drawing.Point(123, 151);
            this.btnOdaberiDolazak.Name = "btnOdaberiDolazak";
            this.btnOdaberiDolazak.Size = new System.Drawing.Size(82, 23);
            this.btnOdaberiDolazak.TabIndex = 21;
            this.btnOdaberiDolazak.Text = "Odaberite let";
            this.btnOdaberiDolazak.UseVisualStyleBackColor = true;
            this.btnOdaberiDolazak.Click += new System.EventHandler(this.btnOdaberiDolazak_Click);
            this.btnOdaberiDolazak.Validating += new System.ComponentModel.CancelEventHandler(this.btnOdaberiDolazak_Validating);
            // 
            // txtPolazisteD
            // 
            this.txtPolazisteD.Location = new System.Drawing.Point(92, 47);
            this.txtPolazisteD.Name = "txtPolazisteD";
            this.txtPolazisteD.ReadOnly = true;
            this.txtPolazisteD.Size = new System.Drawing.Size(148, 20);
            this.txtPolazisteD.TabIndex = 20;
            // 
            // txtPolazakD
            // 
            this.txtPolazakD.Location = new System.Drawing.Point(92, 99);
            this.txtPolazakD.Name = "txtPolazakD";
            this.txtPolazakD.ReadOnly = true;
            this.txtPolazakD.Size = new System.Drawing.Size(148, 20);
            this.txtPolazakD.TabIndex = 19;
            // 
            // txtDolazakD
            // 
            this.txtDolazakD.Location = new System.Drawing.Point(92, 125);
            this.txtDolazakD.Name = "txtDolazakD";
            this.txtDolazakD.ReadOnly = true;
            this.txtDolazakD.Size = new System.Drawing.Size(148, 20);
            this.txtDolazakD.TabIndex = 18;
            // 
            // txtDolazisteD
            // 
            this.txtDolazisteD.Location = new System.Drawing.Point(92, 73);
            this.txtDolazisteD.Name = "txtDolazisteD";
            this.txtDolazisteD.ReadOnly = true;
            this.txtDolazisteD.Size = new System.Drawing.Size(148, 20);
            this.txtDolazisteD.TabIndex = 17;
            // 
            // txtBrLetaD
            // 
            this.txtBrLetaD.Location = new System.Drawing.Point(92, 21);
            this.txtBrLetaD.Name = "txtBrLetaD";
            this.txtBrLetaD.ReadOnly = true;
            this.txtBrLetaD.Size = new System.Drawing.Size(148, 20);
            this.txtBrLetaD.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dolazak:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Polazak:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Odredište:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Polazište:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Broj leta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdaberiPolazak);
            this.groupBox1.Controls.Add(this.txtPolazisteP);
            this.groupBox1.Controls.Add(this.txtPolazakP);
            this.groupBox1.Controls.Add(this.txtDolazakP);
            this.groupBox1.Controls.Add(this.txtDolazisteP);
            this.groupBox1.Controls.Add(this.txtBrLetaP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 194);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Polazak";
            // 
            // btnOdaberiPolazak
            // 
            this.btnOdaberiPolazak.Location = new System.Drawing.Point(113, 156);
            this.btnOdaberiPolazak.Name = "btnOdaberiPolazak";
            this.btnOdaberiPolazak.Size = new System.Drawing.Size(82, 23);
            this.btnOdaberiPolazak.TabIndex = 10;
            this.btnOdaberiPolazak.Text = "Odaberite let";
            this.btnOdaberiPolazak.UseVisualStyleBackColor = true;
            this.btnOdaberiPolazak.Click += new System.EventHandler(this.btnOdaberiPolazak_Click);
            this.btnOdaberiPolazak.Validating += new System.ComponentModel.CancelEventHandler(this.btnOdaberiPolazak_Validating);
            // 
            // txtPolazisteP
            // 
            this.txtPolazisteP.Location = new System.Drawing.Point(82, 52);
            this.txtPolazisteP.Name = "txtPolazisteP";
            this.txtPolazisteP.ReadOnly = true;
            this.txtPolazisteP.Size = new System.Drawing.Size(148, 20);
            this.txtPolazisteP.TabIndex = 9;
            // 
            // txtPolazakP
            // 
            this.txtPolazakP.Location = new System.Drawing.Point(82, 104);
            this.txtPolazakP.Name = "txtPolazakP";
            this.txtPolazakP.ReadOnly = true;
            this.txtPolazakP.Size = new System.Drawing.Size(148, 20);
            this.txtPolazakP.TabIndex = 8;
            // 
            // txtDolazakP
            // 
            this.txtDolazakP.Location = new System.Drawing.Point(82, 130);
            this.txtDolazakP.Name = "txtDolazakP";
            this.txtDolazakP.ReadOnly = true;
            this.txtDolazakP.Size = new System.Drawing.Size(148, 20);
            this.txtDolazakP.TabIndex = 7;
            // 
            // txtDolazisteP
            // 
            this.txtDolazisteP.Location = new System.Drawing.Point(82, 78);
            this.txtDolazisteP.Name = "txtDolazisteP";
            this.txtDolazisteP.ReadOnly = true;
            this.txtDolazisteP.Size = new System.Drawing.Size(148, 20);
            this.txtDolazisteP.TabIndex = 6;
            // 
            // txtBrLetaP
            // 
            this.txtBrLetaP.Location = new System.Drawing.Point(82, 26);
            this.txtBrLetaP.Name = "txtBrLetaP";
            this.txtBrLetaP.ReadOnly = true;
            this.txtBrLetaP.Size = new System.Drawing.Size(148, 20);
            this.txtBrLetaP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dolazak:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Polazak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odredište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polazište:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj leta:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 485);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBrDana);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSmjestaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi ponudu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBrDana;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtSmjestaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOdaberiDolazak;
        private System.Windows.Forms.TextBox txtPolazisteD;
        private System.Windows.Forms.TextBox txtPolazakD;
        private System.Windows.Forms.TextBox txtDolazakD;
        private System.Windows.Forms.TextBox txtDolazisteD;
        private System.Windows.Forms.TextBox txtBrLetaD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaberiPolazak;
        private System.Windows.Forms.TextBox txtPolazisteP;
        private System.Windows.Forms.TextBox txtPolazakP;
        private System.Windows.Forms.TextBox txtDolazakP;
        private System.Windows.Forms.TextBox txtDolazisteP;
        private System.Windows.Forms.TextBox txtBrLetaP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}