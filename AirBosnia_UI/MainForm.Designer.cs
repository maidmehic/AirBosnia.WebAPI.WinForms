namespace AirBosnia_UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPonude = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(110, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Avioni";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(269, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lokacije";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(110, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zaposlenici";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(420, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "Letovi";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPonude
            // 
            this.btnPonude.FlatAppearance.BorderSize = 0;
            this.btnPonude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonude.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonude.Image = ((System.Drawing.Image)(resources.GetObject("btnPonude.Image")));
            this.btnPonude.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPonude.Location = new System.Drawing.Point(269, 181);
            this.btnPonude.Name = "btnPonude";
            this.btnPonude.Size = new System.Drawing.Size(136, 97);
            this.btnPonude.TabIndex = 4;
            this.btnPonude.Text = "Posebne ponude";
            this.btnPonude.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPonude.UseVisualStyleBackColor = true;
            this.btnPonude.Click += new System.EventHandler(this.btnPonude_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposlenikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposlenikToolStripMenuItem
            // 
            this.zaposlenikToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zaposlenikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.računToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.zaposlenikToolStripMenuItem.Name = "zaposlenikToolStripMenuItem";
            this.zaposlenikToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.zaposlenikToolStripMenuItem.Text = "Zaposlenik";
            // 
            // računToolStripMenuItem
            // 
            this.računToolStripMenuItem.Name = "računToolStripMenuItem";
            this.računToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.računToolStripMenuItem.Text = "Promjena lozinke";
            this.računToolStripMenuItem.Click += new System.EventHandler(this.računToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.FlatAppearance.BorderSize = 0;
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacije.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervacije.Image")));
            this.btnRezervacije.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRezervacije.Location = new System.Drawing.Point(420, 181);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(136, 97);
            this.btnRezervacije.TabIndex = 6;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 324);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnPonude);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirBosnia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPonude;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računToolStripMenuItem;
        private System.Windows.Forms.Button btnRezervacije;
    }
}

