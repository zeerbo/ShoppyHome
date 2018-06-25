namespace ShoppyHomeClient.Views
{
    partial class Log
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
            this.ListaLog = new System.Windows.Forms.ListView();
            this.Descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ChiudiB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaLog
            // 
            this.ListaLog.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListaLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Descrizione,
            this.Data});
            this.ListaLog.Location = new System.Drawing.Point(171, 63);
            this.ListaLog.Name = "ListaLog";
            this.ListaLog.Size = new System.Drawing.Size(364, 266);
            this.ListaLog.TabIndex = 4;
            this.ListaLog.UseCompatibleStateImageBehavior = false;
            this.ListaLog.View = System.Windows.Forms.View.Details;
            // 
            // Descrizione
            // 
            this.Descrizione.DisplayIndex = 1;
            this.Descrizione.Text = "Descrizione";
            this.Descrizione.Width = 248;
            // 
            // Data
            // 
            this.Data.DisplayIndex = 0;
            this.Data.Text = "Data";
            this.Data.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // ChiudiB
            // 
            this.ChiudiB.Location = new System.Drawing.Point(460, 393);
            this.ChiudiB.Name = "ChiudiB";
            this.ChiudiB.Size = new System.Drawing.Size(75, 22);
            this.ChiudiB.TabIndex = 5;
            this.ChiudiB.Text = "Chiudi";
            this.ChiudiB.UseVisualStyleBackColor = true;
            this.ChiudiB.Click += new System.EventHandler(this.Chiudi_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 463);
            this.Controls.Add(this.ChiudiB);
            this.Controls.Add(this.ListaLog);
            this.Controls.Add(this.label1);
            this.Name = "Log";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaLog;
        private System.Windows.Forms.ColumnHeader Descrizione;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChiudiB;
    }
}