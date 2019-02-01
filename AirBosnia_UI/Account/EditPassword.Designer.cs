namespace AirBosnia_UI.Account
{
    partial class EditPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.txtPotvrda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trenutna lozinka:";
            // 
            // txtStara
            // 
            this.txtStara.Location = new System.Drawing.Point(108, 23);
            this.txtStara.Name = "txtStara";
            this.txtStara.PasswordChar = '*';
            this.txtStara.Size = new System.Drawing.Size(136, 20);
            this.txtStara.TabIndex = 1;
            this.txtStara.Validating += new System.ComponentModel.CancelEventHandler(this.txtStara_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova lozinka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Potvrdite lozinku:";
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(108, 49);
            this.txtNova.Name = "txtNova";
            this.txtNova.PasswordChar = '*';
            this.txtNova.Size = new System.Drawing.Size(136, 20);
            this.txtNova.TabIndex = 4;
            this.txtNova.Validating += new System.ComponentModel.CancelEventHandler(this.txtNova_Validating);
            // 
            // txtPotvrda
            // 
            this.txtPotvrda.Location = new System.Drawing.Point(108, 75);
            this.txtPotvrda.Name = "txtPotvrda";
            this.txtPotvrda.PasswordChar = '*';
            this.txtPotvrda.Size = new System.Drawing.Size(136, 20);
            this.txtPotvrda.TabIndex = 5;
            this.txtPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPotvrda_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPotvrda);
            this.Controls.Add(this.txtNova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStara);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNova;
        private System.Windows.Forms.TextBox txtPotvrda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}