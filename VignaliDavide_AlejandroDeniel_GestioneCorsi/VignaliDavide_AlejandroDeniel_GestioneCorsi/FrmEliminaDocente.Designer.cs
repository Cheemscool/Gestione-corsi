
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmEliminaDocente
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
            this.ckdListBoxDocenti = new System.Windows.Forms.CheckedListBox();
            this.btnRimuoviDocente = new System.Windows.Forms.Button();
            this.Docenti = new System.Windows.Forms.Label();
            this.EliminaiDocenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckdListBoxDocenti
            // 
            this.ckdListBoxDocenti.FormattingEnabled = true;
            this.ckdListBoxDocenti.Location = new System.Drawing.Point(79, 146);
            this.ckdListBoxDocenti.Name = "ckdListBoxDocenti";
            this.ckdListBoxDocenti.Size = new System.Drawing.Size(235, 264);
            this.ckdListBoxDocenti.TabIndex = 23;
            // 
            // btnRimuoviDocente
            // 
            this.btnRimuoviDocente.Location = new System.Drawing.Point(146, 425);
            this.btnRimuoviDocente.Name = "btnRimuoviDocente";
            this.btnRimuoviDocente.Size = new System.Drawing.Size(94, 25);
            this.btnRimuoviDocente.TabIndex = 21;
            this.btnRimuoviDocente.Text = "Rimuovi";
            this.btnRimuoviDocente.UseVisualStyleBackColor = true;
            this.btnRimuoviDocente.Click += new System.EventHandler(this.btnRimuoviDocente_Click);
            // 
            // Docenti
            // 
            this.Docenti.AutoSize = true;
            this.Docenti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Docenti.Location = new System.Drawing.Point(49, 100);
            this.Docenti.Name = "Docenti";
            this.Docenti.Size = new System.Drawing.Size(299, 23);
            this.Docenti.TabIndex = 22;
            this.Docenti.Text = "Seleziona i docenti da rimuovere:";
            // 
            // EliminaiDocenti
            // 
            this.EliminaiDocenti.AutoSize = true;
            this.EliminaiDocenti.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminaiDocenti.Location = new System.Drawing.Point(12, 8);
            this.EliminaiDocenti.Name = "EliminaiDocenti";
            this.EliminaiDocenti.Size = new System.Drawing.Size(285, 45);
            this.EliminaiDocenti.TabIndex = 16;
            this.EliminaiDocenti.Text = "Elimina docenti";
            // 
            // FrmEliminaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 462);
            this.Controls.Add(this.ckdListBoxDocenti);
            this.Controls.Add(this.btnRimuoviDocente);
            this.Controls.Add(this.Docenti);
            this.Controls.Add(this.EliminaiDocenti);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEliminaDocente";
            this.Text = "Elimina docenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckdListBoxDocenti;
        private System.Windows.Forms.Button btnRimuoviDocente;
        private System.Windows.Forms.Label Docenti;
        private System.Windows.Forms.Label EliminaiDocenti;
    }
}