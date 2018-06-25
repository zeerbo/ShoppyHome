namespace ShoppyHomeClient.Views
{
    partial class SelezioneMarket
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
            this.ListaMarketBox = new System.Windows.Forms.ListBox();
            this.ConfermaMarket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supermercati disponbili";
            // 
            // ListaMarketBox
            // 
            this.ListaMarketBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListaMarketBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMarketBox.FormattingEnabled = true;
            this.ListaMarketBox.ItemHeight = 25;
            this.ListaMarketBox.Items.AddRange(new object[] {
            "Coop",
            "Eurospin",
            "Conad",
            "Metà",
            "Lidl",
            "MD",
            "LD",
            "Despar"});
            this.ListaMarketBox.Location = new System.Drawing.Point(308, 77);
            this.ListaMarketBox.Name = "ListaMarketBox";
            this.ListaMarketBox.Size = new System.Drawing.Size(182, 179);
            this.ListaMarketBox.TabIndex = 2;
            // 
            // ConfermaMarket
            // 
            this.ConfermaMarket.Location = new System.Drawing.Point(348, 277);
            this.ConfermaMarket.Name = "ConfermaMarket";
            this.ConfermaMarket.Size = new System.Drawing.Size(92, 35);
            this.ConfermaMarket.TabIndex = 3;
            this.ConfermaMarket.Text = "Conferma";
            this.ConfermaMarket.UseVisualStyleBackColor = true;
            this.ConfermaMarket.Click += new System.EventHandler(this.ConfermaButton_Click);
            // 
            // SelezioneMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfermaMarket);
            this.Controls.Add(this.ListaMarketBox);
            this.Controls.Add(this.label1);
            this.Name = "SelezioneMarket";
            this.Text = "SelezioneMarket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaMarketBox;
        private System.Windows.Forms.Button ConfermaMarket;
    }
}