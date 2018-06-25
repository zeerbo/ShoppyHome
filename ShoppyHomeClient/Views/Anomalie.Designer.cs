namespace ShoppyHomeClient.Views
{
    partial class Anomalie
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
            this.ChiudiB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anomalia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChiudiB
            // 
            this.ChiudiB.Location = new System.Drawing.Point(424, 393);
            this.ChiudiB.Name = "ChiudiB";
            this.ChiudiB.Size = new System.Drawing.Size(75, 22);
            this.ChiudiB.TabIndex = 8;
            this.ChiudiB.Text = "Chiudi";
            this.ChiudiB.UseVisualStyleBackColor = true;
            this.ChiudiB.Click += new System.EventHandler(this.ChiudiB_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Descrizione,
            this.Anomalia});
            this.listView1.Location = new System.Drawing.Point(135, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 266);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Descrizione
            // 
            this.Descrizione.DisplayIndex = 1;
            this.Descrizione.Text = "Descrizione";
            this.Descrizione.Width = 248;
            // 
            // Anomalia
            // 
            this.Anomalia.DisplayIndex = 0;
            this.Anomalia.Text = "Anomalia";
            this.Anomalia.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Anomalie";
            // 
            // Anomalie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 464);
            this.Controls.Add(this.ChiudiB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Anomalie";
            this.Text = "Anomalie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChiudiB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Descrizione;
        private System.Windows.Forms.ColumnHeader Anomalia;
        private System.Windows.Forms.Label label1;
    }
}