
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmEliminaLezione
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
            this.ckdListBoxLezioni = new System.Windows.Forms.CheckedListBox();
            this.btnRimuoviLezione = new System.Windows.Forms.Button();
            this.Lezioni = new System.Windows.Forms.Label();
            this.EliminaLezioni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckdListBoxLezioni
            // 
            this.ckdListBoxLezioni.FormattingEnabled = true;
            this.ckdListBoxLezioni.Location = new System.Drawing.Point(79, 147);
            this.ckdListBoxLezioni.Name = "ckdListBoxLezioni";
            this.ckdListBoxLezioni.Size = new System.Drawing.Size(235, 246);
            this.ckdListBoxLezioni.TabIndex = 27;
            // 
            // btnRimuoviLezione
            // 
            this.btnRimuoviLezione.Location = new System.Drawing.Point(146, 426);
            this.btnRimuoviLezione.Name = "btnRimuoviLezione";
            this.btnRimuoviLezione.Size = new System.Drawing.Size(94, 25);
            this.btnRimuoviLezione.TabIndex = 25;
            this.btnRimuoviLezione.Text = "Rimuovi";
            this.btnRimuoviLezione.UseVisualStyleBackColor = true;
            this.btnRimuoviLezione.Click += new System.EventHandler(this.btnRimuoviLezione_Click);
            // 
            // Lezioni
            // 
            this.Lezioni.AutoSize = true;
            this.Lezioni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lezioni.Location = new System.Drawing.Point(49, 101);
            this.Lezioni.Name = "Lezioni";
            this.Lezioni.Size = new System.Drawing.Size(300, 23);
            this.Lezioni.TabIndex = 26;
            this.Lezioni.Text = "Seleziona le lezioni da rimuovere:";
            // 
            // EliminaLezioni
            // 
            this.EliminaLezioni.AutoSize = true;
            this.EliminaLezioni.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminaLezioni.Location = new System.Drawing.Point(12, 9);
            this.EliminaLezioni.Name = "EliminaLezioni";
            this.EliminaLezioni.Size = new System.Drawing.Size(268, 45);
            this.EliminaLezioni.TabIndex = 24;
            this.EliminaLezioni.Text = "Elimina lezioni";
            // 
            // FrmEliminaLezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 465);
            this.Controls.Add(this.ckdListBoxLezioni);
            this.Controls.Add(this.btnRimuoviLezione);
            this.Controls.Add(this.Lezioni);
            this.Controls.Add(this.EliminaLezioni);
            this.Name = "FrmEliminaLezione";
            this.Text = "FrmEliminaLezione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckdListBoxLezioni;
        private System.Windows.Forms.Button btnRimuoviLezione;
        private System.Windows.Forms.Label Lezioni;
        private System.Windows.Forms.Label EliminaLezioni;
    }
}