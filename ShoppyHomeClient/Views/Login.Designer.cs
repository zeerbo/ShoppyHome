namespace ShoppyHomeClient.Views
{
    partial class Login
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Registrati = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Recupero = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(322, 95);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(139, 22);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(322, 138);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(139, 22);
            this.Password.TabIndex = 4;
            // 
            // Registrati
            // 
            this.Registrati.Location = new System.Drawing.Point(576, 311);
            this.Registrati.Name = "Registrati";
            this.Registrati.Size = new System.Drawing.Size(94, 32);
            this.Registrati.TabIndex = 7;
            this.Registrati.Text = "Registrati";
            this.Registrati.UseVisualStyleBackColor = true;
            this.Registrati.Click += new System.EventHandler(this.Registrati_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Non sei registrato?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hai dimenticato la password?";
            // 
            // Recupero
            // 
            this.Recupero.Location = new System.Drawing.Point(212, 313);
            this.Recupero.Name = "Recupero";
            this.Recupero.Size = new System.Drawing.Size(153, 29);
            this.Recupero.TabIndex = 10;
            this.Recupero.Text = "Recupera password";
            this.Recupero.UseVisualStyleBackColor = true;
            this.Recupero.Click += new System.EventHandler(this.Recupero_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(386, 189);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 26);
            this.LoginButton.TabIndex = 11;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 361);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Recupero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Registrati);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Registrati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Recupero;
        private System.Windows.Forms.Button LoginButton;
    }
}