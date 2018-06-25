namespace ShoppyHomeClient.Views
{
    partial class RecuperoPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RispostaRecupero = new System.Windows.Forms.TextBox();
            this.RichiediRecupero = new System.Windows.Forms.Button();
            this.TornaLogin = new System.Windows.Forms.Button();
            this.DomandeRecupero = new System.Windows.Forms.ComboBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recupero Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domanda Recupero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risposta Recupero";
            // 
            // RispostaRecupero
            // 
            this.RispostaRecupero.Location = new System.Drawing.Point(204, 134);
            this.RispostaRecupero.Name = "RispostaRecupero";
            this.RispostaRecupero.Size = new System.Drawing.Size(153, 22);
            this.RispostaRecupero.TabIndex = 4;
            // 
            // RichiediRecupero
            // 
            this.RichiediRecupero.Location = new System.Drawing.Point(274, 162);
            this.RichiediRecupero.Name = "RichiediRecupero";
            this.RichiediRecupero.Size = new System.Drawing.Size(83, 23);
            this.RichiediRecupero.TabIndex = 5;
            this.RichiediRecupero.Text = "Conferma";
            this.RichiediRecupero.UseVisualStyleBackColor = true;
            this.RichiediRecupero.Click += new System.EventHandler(this.RichiediRecupero_Click);
            // 
            // TornaLogin
            // 
            this.TornaLogin.Location = new System.Drawing.Point(15, 160);
            this.TornaLogin.Name = "TornaLogin";
            this.TornaLogin.Size = new System.Drawing.Size(118, 27);
            this.TornaLogin.TabIndex = 6;
            this.TornaLogin.Text = "Torna al Login";
            this.TornaLogin.UseVisualStyleBackColor = true;
            this.TornaLogin.Click += new System.EventHandler(this.TornaLogin_Click);
            // 
            // DomandeRecupero
            // 
            this.DomandeRecupero.Enabled = false;
            this.DomandeRecupero.FormattingEnabled = true;
            this.DomandeRecupero.Location = new System.Drawing.Point(204, 104);
            this.DomandeRecupero.Name = "DomandeRecupero";
            this.DomandeRecupero.Size = new System.Drawing.Size(153, 24);
            this.DomandeRecupero.TabIndex = 7;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 79);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 17);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username";
            // 
            // TextUsername
            // 
            this.TextUsername.Location = new System.Drawing.Point(204, 76);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(153, 22);
            this.TextUsername.TabIndex = 9;
            // 
            // RecuperoPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 264);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DomandeRecupero);
            this.Controls.Add(this.TornaLogin);
            this.Controls.Add(this.RichiediRecupero);
            this.Controls.Add(this.RispostaRecupero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecuperoPassword";
            this.Text = "RecuperoPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RispostaRecupero;
        private System.Windows.Forms.Button RichiediRecupero;
        private System.Windows.Forms.Button TornaLogin;
        private System.Windows.Forms.ComboBox DomandeRecupero;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox TextUsername;
    }
}