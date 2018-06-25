namespace ShoppyHomeClient.Views
{
    partial class HomeSpesa
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
            this.SelezionaMarket = new System.Windows.Forms.LinkLabel();
            this.VaiProfilo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(323, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Benvenuto!";
            // 
            // SelezionaMarket
            // 
            this.SelezionaMarket.AutoSize = true;
            this.SelezionaMarket.BackColor = System.Drawing.Color.Transparent;
            this.SelezionaMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelezionaMarket.LinkColor = System.Drawing.Color.Blue;
            this.SelezionaMarket.Location = new System.Drawing.Point(626, 153);
            this.SelezionaMarket.Name = "SelezionaMarket";
            this.SelezionaMarket.Size = new System.Drawing.Size(181, 26);
            this.SelezionaMarket.TabIndex = 3;
            this.SelezionaMarket.TabStop = true;
            this.SelezionaMarket.Text = "Seleziona market";
            this.SelezionaMarket.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelezionaMarket_LinkClicked);
            // 
            // VaiProfilo
            // 
            this.VaiProfilo.AutoSize = true;
            this.VaiProfilo.BackColor = System.Drawing.Color.Transparent;
            this.VaiProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VaiProfilo.LinkColor = System.Drawing.Color.Blue;
            this.VaiProfilo.Location = new System.Drawing.Point(29, 153);
            this.VaiProfilo.Name = "VaiProfilo";
            this.VaiProfilo.Size = new System.Drawing.Size(132, 26);
            this.VaiProfilo.TabIndex = 0;
            this.VaiProfilo.TabStop = true;
            this.VaiProfilo.Text = "Vai al profilo";
            this.VaiProfilo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VaiProfilo_LinkClicked);
            // 
            // HomeSpesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.SelezionaMarket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VaiProfilo);
            this.Name = "HomeSpesa";
            this.Text = "HomeSpesa";
            this.Load += new System.EventHandler(this.HomeSpesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel SelezionaMarket;
        private System.Windows.Forms.LinkLabel VaiProfilo;
    }
}