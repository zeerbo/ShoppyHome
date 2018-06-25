namespace ShoppyHomeClient.Views
{
    partial class Carrello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrello));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.Termina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Catalogo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrello";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(64, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(61, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prodotti scelti:";
            // 
            // Termina
            // 
            this.Termina.Location = new System.Drawing.Point(64, 215);
            this.Termina.Name = "Termina";
            this.Termina.Size = new System.Drawing.Size(133, 26);
            this.Termina.TabIndex = 3;
            this.Termina.Text = "Termina spesa";
            this.Termina.UseVisualStyleBackColor = true;
            this.Termina.Click += new System.EventHandler(this.Termina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(64, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo prodotti:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(170, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Catalogo
            // 
            this.Catalogo.AutoSize = true;
            this.Catalogo.BackColor = System.Drawing.Color.Transparent;
            this.Catalogo.Location = new System.Drawing.Point(453, 92);
            this.Catalogo.Name = "Catalogo";
            this.Catalogo.Size = new System.Drawing.Size(121, 17);
            this.Catalogo.TabIndex = 6;
            this.Catalogo.TabStop = true;
            this.Catalogo.Text = "Torna al Catalogo";
            this.Catalogo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Catalogo_LinkClicked);
            // 
            // Carrello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 373);
            this.Controls.Add(this.Catalogo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Termina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Carrello";
            this.Text = "Carrello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Termina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel Catalogo;
    }
}