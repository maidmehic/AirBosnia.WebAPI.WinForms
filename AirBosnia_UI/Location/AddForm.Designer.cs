namespace AirBosnia_UI.Location
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
            this.spremiBtn = new System.Windows.Forms.Button();
            this.oznakaTxt = new System.Windows.Forms.TextBox();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // spremiBtn
            // 
            this.spremiBtn.Location = new System.Drawing.Point(185, 64);
            this.spremiBtn.Name = "spremiBtn";
            this.spremiBtn.Size = new System.Drawing.Size(75, 23);
            this.spremiBtn.TabIndex = 13;
            this.spremiBtn.Text = "Spremi";
            this.spremiBtn.UseVisualStyleBackColor = true;
            this.spremiBtn.Click += new System.EventHandler(this.spremiBtn_Click);
            // 
            // oznakaTxt
            // 
            this.oznakaTxt.Location = new System.Drawing.Point(98, 38);
            this.oznakaTxt.Name = "oznakaTxt";
            this.oznakaTxt.Size = new System.Drawing.Size(162, 20);
            this.oznakaTxt.TabIndex = 12;
            this.oznakaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.oznakaTxt_Validating);
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(98, 12);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(162, 20);
            this.nazivTxt.TabIndex = 10;
            this.nazivTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivTxt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oznaka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
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
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 107);
            this.Controls.Add(this.spremiBtn);
            this.Controls.Add(this.oznakaTxt);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova lokacija";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
    }
}