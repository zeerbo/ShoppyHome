namespace ShoppyHomeClient.Views
{
    partial class VisualStorici
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
            this.TornaProfilo = new System.Windows.Forms.LinkLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Supermercato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDSpesa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Storici";
            // 
            // TornaProfilo
            // 
            this.TornaProfilo.AutoSize = true;
            this.TornaProfilo.Location = new System.Drawing.Point(684, 347);
            this.TornaProfilo.Name = "TornaProfilo";
            this.TornaProfilo.Size = new System.Drawing.Size(104, 17);
            this.TornaProfilo.TabIndex = 1;
            this.TornaProfilo.TabStop = true;
            this.TornaProfilo.Text = "Torna al profilo";
            this.TornaProfilo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TornaProfilo_LinkClicked);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Supermercato,
            this.Data,
            this.IDSpesa,
            this.Importo});
            this.listView1.Location = new System.Drawing.Point(177, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 266);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Supermercato
            // 
            this.Supermercato.DisplayIndex = 1;
            this.Supermercato.Text = "Supermercato";
            this.Supermercato.Width = 117;
            // 
            // Data
            // 
            this.Data.DisplayIndex = 2;
            this.Data.Text = "Data";
            this.Data.Width = 110;
            // 
            // IDSpesa
            // 
            this.IDSpesa.DisplayIndex = 0;
            this.IDSpesa.Text = "IDSpesa";
            this.IDSpesa.Width = 108;
            // 
            // Importo
            // 
            this.Importo.Text = "Importo";
            this.Importo.Width = 114;
            // 
            // VisualStorici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TornaProfilo);
            this.Controls.Add(this.label1);
            this.Name = "VisualStorici";
            this.Text = "VisualStorici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel TornaProfilo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Supermercato;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader IDSpesa;
        private System.Windows.Forms.ColumnHeader Importo;
    }
}