namespace ShoppyHomeClient.Views
{
    partial class Catalogo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cibo",
            "1",
            "5$",
            "5%",
            "nd"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bere",
            "2",
            "2$",
            "/",
            "nd"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Alcool",
            "e",
            "10$",
            "/",
            "nd"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.label1 = new System.Windows.Forms.Label();
            this.Carrello = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Termina = new System.Windows.Forms.Button();
            this.Prodotto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Immagine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VistaCatalogo = new System.Windows.Forms.ListView();
            this.AggiungiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalogo";
            // 
            // VaiCarrelloLink
            // 
            this.Carrello.AutoSize = true;
            this.Carrello.BackColor = System.Drawing.Color.Transparent;
            this.Carrello.LinkColor = System.Drawing.Color.White;
            this.Carrello.Location = new System.Drawing.Point(543, 361);
            this.Carrello.Name = "VaiCarrelloLink";
            this.Carrello.Size = new System.Drawing.Size(57, 17);
            this.Carrello.TabIndex = 2;
            this.Carrello.TabStop = true;
            this.Carrello.Text = "Carrello";
            this.Carrello.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Carrello_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(172, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hai concluso la spesa?";
            // 
            // TerminaSpesaButton
            // 
            this.Termina.Location = new System.Drawing.Point(332, 353);
            this.Termina.Name = "TerminaSpesaButton";
            this.Termina.Size = new System.Drawing.Size(75, 32);
            this.Termina.TabIndex = 4;
            this.Termina.Text = "Termina";
            this.Termina.UseVisualStyleBackColor = true;
            this.Termina.Click += new System.EventHandler(this.Termina_Click);
            // 
            // Prodotto
            // 
            this.Prodotto.Text = "Prodotto";
            this.Prodotto.Width = 78;
            // 
            // IdProdotto
            // 
            this.Prodotto.Text = "IdProdotto";
            this.Prodotto.Width = 95;
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            this.Prezzo.Width = 84;
            // 
            // Sconto
            // 
            this.Sconto.Text = "Sconto";
            // 
            // Immagine
            // 
            this.Immagine.Text = "Immagine";
            this.Immagine.Width = 103;
            // 
            // ListaProdottiView
            // 
            this.VistaCatalogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Prodotto,
            this.Prezzo,
            this.Sconto,
            this.Immagine});
            listViewItem1.StateImageIndex = 0;
            this.VistaCatalogo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.VistaCatalogo.Location = new System.Drawing.Point(175, 53);
            this.VistaCatalogo.MultiSelect = false;
            this.VistaCatalogo.Name = "ListaProdottiView";
            this.VistaCatalogo.Size = new System.Drawing.Size(425, 294);
            this.VistaCatalogo.TabIndex = 1;
            this.VistaCatalogo.UseCompatibleStateImageBehavior = false;
            this.VistaCatalogo.View = System.Windows.Forms.View.Details;
            // 
            // AggiungiButton
            // 
            this.AggiungiButton.Location = new System.Drawing.Point(462, 353);
            this.AggiungiButton.Name = "AggiungiButton";
            this.AggiungiButton.Size = new System.Drawing.Size(75, 32);
            this.AggiungiButton.TabIndex = 5;
            this.AggiungiButton.Text = "Aggiungi";
            this.AggiungiButton.UseVisualStyleBackColor = true;
            this.AggiungiButton.Click += new System.EventHandler(this.AggiungiButton_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AggiungiButton);
            this.Controls.Add(this.Termina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Carrello);
            this.Controls.Add(this.VistaCatalogo);
            this.Controls.Add(this.label1);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Carrello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Termina;
        private System.Windows.Forms.ColumnHeader Descrizione;
        private System.Windows.Forms.ColumnHeader Prodotto;
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.ColumnHeader Sconto;
        private System.Windows.Forms.ColumnHeader Immagine;
        private System.Windows.Forms.ListView VistaCatalogo;
        private System.Windows.Forms.Button AggiungiButton;
    }
}