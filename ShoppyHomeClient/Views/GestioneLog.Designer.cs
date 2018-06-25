namespace ShoppyHomeClient.Views
{
    partial class GestioneLog
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
            this.AnalisiOperazioneB = new System.Windows.Forms.Button();
            this.VisioneLogB = new System.Windows.Forms.Button();
            this.AnalisiMessaggiB = new System.Windows.Forms.Button();
            this.ElencoAnomalieB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestione dei Log";
            // 
            // AnalisiOperazioneB
            // 
            this.AnalisiOperazioneB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AnalisiOperazioneB.Location = new System.Drawing.Point(130, 98);
            this.AnalisiOperazioneB.Name = "AnalisiOperazioneB";
            this.AnalisiOperazioneB.Size = new System.Drawing.Size(139, 49);
            this.AnalisiOperazioneB.TabIndex = 1;
            this.AnalisiOperazioneB.Text = " Analisi anomalie Operazione";
            this.AnalisiOperazioneB.UseVisualStyleBackColor = false;
            this.AnalisiOperazioneB.Click += new System.EventHandler(this.AnalisiOperazioneB_Click);
            // 
            // VisioneLogB
            // 
            this.VisioneLogB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VisioneLogB.Location = new System.Drawing.Point(365, 249);
            this.VisioneLogB.Name = "VisioneLogB";
            this.VisioneLogB.Size = new System.Drawing.Size(127, 32);
            this.VisioneLogB.TabIndex = 2;
            this.VisioneLogB.Text = "Visiona Log";
            this.VisioneLogB.UseVisualStyleBackColor = false;
            this.VisioneLogB.Click += new System.EventHandler(this.VisioneLogB_Click);
            // 
            // AnalisiMessaggiB
            // 
            this.AnalisiMessaggiB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AnalisiMessaggiB.Location = new System.Drawing.Point(365, 98);
            this.AnalisiMessaggiB.Name = "AnalisiMessaggiB";
            this.AnalisiMessaggiB.Size = new System.Drawing.Size(127, 47);
            this.AnalisiMessaggiB.TabIndex = 3;
            this.AnalisiMessaggiB.Text = "Analisi anomalie Messaggi";
            this.AnalisiMessaggiB.UseVisualStyleBackColor = false;
            // 
            // ElencoAnomalieB
            // 
            this.ElencoAnomalieB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ElencoAnomalieB.Location = new System.Drawing.Point(130, 249);
            this.ElencoAnomalieB.Name = "ElencoAnomalieB";
            this.ElencoAnomalieB.Size = new System.Drawing.Size(139, 32);
            this.ElencoAnomalieB.TabIndex = 4;
            this.ElencoAnomalieB.Text = "Elenco Anomalie";
            this.ElencoAnomalieB.UseVisualStyleBackColor = false;
            this.ElencoAnomalieB.Click += new System.EventHandler(this.ElencoAnomalieB_Click);
            // 
            // GestioneLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 357);
            this.Controls.Add(this.ElencoAnomalieB);
            this.Controls.Add(this.AnalisiMessaggiB);
            this.Controls.Add(this.VisioneLogB);
            this.Controls.Add(this.AnalisiOperazioneB);
            this.Controls.Add(this.label1);
            this.Name = "GestioneLog";
            this.Text = "GestioneLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnalisiOperazioneB;
        private System.Windows.Forms.Button VisioneLogB;
        private System.Windows.Forms.Button AnalisiMessaggiB;
        private System.Windows.Forms.Button ElencoAnomalieB;
    }
}