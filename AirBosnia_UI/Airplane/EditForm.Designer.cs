namespace AirBosnia_UI.Airplane
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
            this.spremiBtn = new System.Windows.Forms.Button();
            this.oznakaTxt = new System.Windows.Forms.TextBox();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.brSjedistaE = new System.Windows.Forms.NumericUpDown();
            this.brSjedistaB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brSjedistaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brSjedistaB)).BeginInit();
            this.SuspendLayout();
            // 
            // spremiBtn
            // 
            this.spremiBtn.Location = new System.Drawing.Point(189, 117);
            this.spremiBtn.Name = "spremiBtn";
            this.spremiBtn.Size = new System.Drawing.Size(75, 23);
            this.spremiBtn.TabIndex = 13;
            this.spremiBtn.Text = "Spremi";
            this.spremiBtn.UseVisualStyleBackColor = true;
            this.spremiBtn.Click += new System.EventHandler(this.spremiBtn_Click);
            // 
            // oznakaTxt
            // 
            this.oznakaTxt.Location = new System.Drawing.Point(102, 38);
            this.oznakaTxt.Name = "oznakaTxt";
            this.oznakaTxt.Size = new System.Drawing.Size(162, 20);
            this.oznakaTxt.TabIndex = 12;
            this.oznakaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.oznakaTxt_Validating);
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(102, 12);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(162, 20);
            this.nazivTxt.TabIndex = 10;
            this.nazivTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oznaka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // brSjedistaE
            // 
            this.brSjedistaE.BackColor = System.Drawing.SystemColors.Window;
            this.brSjedistaE.Location = new System.Drawing.Point(102, 90);
            this.brSjedistaE.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.brSjedistaE.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.brSjedistaE.Name = "brSjedistaE";
            this.brSjedistaE.Size = new System.Drawing.Size(162, 20);
            this.brSjedistaE.TabIndex = 16;
            this.brSjedistaE.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // brSjedistaB
            // 
            this.brSjedistaB.BackColor = System.Drawing.SystemColors.Window;
            this.brSjedistaB.Location = new System.Drawing.Point(102, 64);
            this.brSjedistaB.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.brSjedistaB.Name = "brSjedistaB";
            this.brSjedistaB.Size = new System.Drawing.Size(162, 20);
            this.brSjedistaB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Broj sjedišta (B):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Broj sjedišta (E):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "(E)-Ekonomska klasa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "(B)-Bussiness klasa";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(295, 182);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brSjedistaE);
            this.Controls.Add(this.brSjedistaB);
            this.Controls.Add(this.spremiBtn);
            this.Controls.Add(this.oznakaTxt);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi avion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brSjedistaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brSjedistaB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spremiBtn;
        private System.Windows.Forms.TextBox oznakaTxt;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown brSjedistaE;
        private System.Windows.Forms.NumericUpDown brSjedistaB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}