namespace ShoppyHomeClient.Views
{
    partial class Verifica_Conferma
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
            this.VistaCarrello = new System.Windows.Forms.ListView();
            this.Prodotto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.DataConsegna = new System.Windows.Forms.DateTimePicker();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.CambiaIndirizzo = new System.Windows.Forms.CheckBox();
            this.Concludi = new System.Windows.Forms.Button();
            this.Annulla = new System.Windows.Forms.Button();
            this.Civico = new System.Windows.Forms.TextBox();
            this.Via = new System.Windows.Forms.TextBox();
            this.Citta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Provincia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verifica e conferma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prodotti nel carrello:";
            // 
            // VistaCarrello
            // 
            this.VistaCarrello.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Prodotto,
            this.Prezzo,
            this.Quantita});
            this.VistaCarrello.Location = new System.Drawing.Point(15, 94);
            this.VistaCarrello.Name = "VistaCarrello";
            this.VistaCarrello.Size = new System.Drawing.Size(408, 223);
            this.VistaCarrello.TabIndex = 3;
            this.VistaCarrello.UseCompatibleStateImageBehavior = false;
            this.VistaCarrello.View = System.Windows.Forms.View.Details;
            // 
            // Prodotto
            // 
            this.Prodotto.Text = "Prodotto";
            this.Prodotto.Width = 200;
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            this.Prezzo.Width = 90;
            // 
            // Quantita
            // 
            this.Quantita.Text = "Quantità";
            this.Quantita.Width = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data per la consegna del pacco:";
            // 
            // DataConsegna
            // 
            this.DataConsegna.Location = new System.Drawing.Point(663, 89);
            this.DataConsegna.Name = "DataConsegna";
            this.DataConsegna.Size = new System.Drawing.Size(210, 22);
            this.DataConsegna.TabIndex = 8;
            // 
            // Telefono
            // 
            this.Telefono.Enabled = false;
            this.Telefono.Location = new System.Drawing.Point(663, 231);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(150, 22);
            this.Telefono.TabIndex = 76;
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(663, 203);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(150, 22);
            this.Email.TabIndex = 75;
            // 
            // Cognome
            // 
            this.Cognome.Enabled = false;
            this.Cognome.Location = new System.Drawing.Point(663, 175);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(150, 22);
            this.Cognome.TabIndex = 72;
            // 
            // Nome
            // 
            this.Nome.Enabled = false;
            this.Nome.Location = new System.Drawing.Point(663, 147);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(150, 22);
            this.Nome.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(444, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 17);
            this.label15.TabIndex = 70;
            this.label15.Text = "Indirizzo per consegna";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(444, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 68;
            this.label17.Text = "E-mail";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(444, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 17);
            this.label22.TabIndex = 67;
            this.label22.Text = "Numero di telefono";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(444, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 66;
            this.label23.Text = "Cognome";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(444, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 17);
            this.label24.TabIndex = 65;
            this.label24.Text = "Nome";
            // 
            // CambiaIndirizzo
            // 
            this.CambiaIndirizzo.AutoSize = true;
            this.CambiaIndirizzo.Checked = true;
            this.CambiaIndirizzo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CambiaIndirizzo.Location = new System.Drawing.Point(605, 258);
            this.CambiaIndirizzo.Name = "CambiaIndirizzo";
            this.CambiaIndirizzo.Size = new System.Drawing.Size(208, 21);
            this.CambiaIndirizzo.TabIndex = 77;
            this.CambiaIndirizzo.Text = "Salva indirizzo come Default";
            this.CambiaIndirizzo.UseVisualStyleBackColor = true;
            // 
            // Concludi
            // 
            this.Concludi.Location = new System.Drawing.Point(447, 393);
            this.Concludi.Name = "Concludi";
            this.Concludi.Size = new System.Drawing.Size(75, 23);
            this.Concludi.TabIndex = 78;
            this.Concludi.Text = "Concludi";
            this.Concludi.UseVisualStyleBackColor = true;
            this.Concludi.Click += new System.EventHandler(this.Concludi_Click);
            // 
            // Annulla
            // 
            this.Annulla.Location = new System.Drawing.Point(528, 393);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(75, 23);
            this.Annulla.TabIndex = 79;
            this.Annulla.Text = "Annulla";
            this.Annulla.UseVisualStyleBackColor = true;
            this.Annulla.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // Civico
            // 
            this.Civico.Location = new System.Drawing.Point(728, 316);
            this.Civico.Name = "Civico";
            this.Civico.Size = new System.Drawing.Size(85, 22);
            this.Civico.TabIndex = 87;
            // 
            // Via
            // 
            this.Via.Location = new System.Drawing.Point(516, 313);
            this.Via.Name = "Via";
            this.Via.Size = new System.Drawing.Size(146, 22);
            this.Via.TabIndex = 86;
            // 
            // Citta
            // 
            this.Citta.Location = new System.Drawing.Point(676, 284);
            this.Citta.Name = "Citta";
            this.Citta.Size = new System.Drawing.Size(137, 22);
            this.Citta.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Civico";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(621, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 83;
            this.label14.Text = "Città";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 82;
            this.label13.Text = "Provincia";
            // 
            // Provincia
            // 
            this.Provincia.Location = new System.Drawing.Point(516, 285);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(77, 22);
            this.Provincia.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 80;
            this.label11.Text = "Via";
            // 
            // Verifica_Conferma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.Civico);
            this.Controls.Add(this.Via);
            this.Controls.Add(this.Citta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Provincia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Concludi);
            this.Controls.Add(this.CambiaIndirizzo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Cognome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.DataConsegna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VistaCarrello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Verifica_Conferma";
            this.Text = "Verifica_Conferma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView VistaCarrello;
        private System.Windows.Forms.ColumnHeader Prodotto;
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.ColumnHeader Quantita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DataConsegna;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Cognome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox CambiaIndirizzo;
        private System.Windows.Forms.Button Concludi;
        private System.Windows.Forms.Button Annulla;
        private System.Windows.Forms.TextBox Civico;
        private System.Windows.Forms.TextBox Via;
        private System.Windows.Forms.TextBox Citta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Provincia;
        private System.Windows.Forms.Label label11;
    }
}