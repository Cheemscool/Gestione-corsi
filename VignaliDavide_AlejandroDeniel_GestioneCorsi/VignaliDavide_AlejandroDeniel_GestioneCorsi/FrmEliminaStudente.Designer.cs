
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmEliminaStudente
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
            this.ckdListBoxStudenti = new System.Windows.Forms.CheckedListBox();
            this.btnRimuoviStudenti = new System.Windows.Forms.Button();
            this.Docenti = new System.Windows.Forms.Label();
            this.EliminaiStudenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckdListBoxStudenti
            // 
            this.ckdListBoxStudenti.FormattingEnabled = true;
            this.ckdListBoxStudenti.Location = new System.Drawing.Point(79, 147);
            this.ckdListBoxStudenti.Name = "ckdListBoxStudenti";
            this.ckdListBoxStudenti.Size = new System.Drawing.Size(235, 246);
            this.ckdListBoxStudenti.TabIndex = 27;
            // 
            // btnRimuoviStudenti
            // 
            this.btnRimuoviStudenti.Location = new System.Drawing.Point(146, 426);
            this.btnRimuoviStudenti.Name = "btnRimuoviStudenti";
            this.btnRimuoviStudenti.Size = new System.Drawing.Size(94, 25);
            this.btnRimuoviStudenti.TabIndex = 25;
            this.btnRimuoviStudenti.Text = "Rimuovi";
            this.btnRimuoviStudenti.UseVisualStyleBackColor = true;
            this.btnRimuoviStudenti.Click += new System.EventHandler(this.btnRimuoviStudenti_Click);
            // 
            // Docenti
            // 
            this.Docenti.AutoSize = true;
            this.Docenti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Docenti.Location = new System.Drawing.Point(27, 101);
            this.Docenti.Name = "Docenti";
            this.Docenti.Size = new System.Drawing.Size(319, 23);
            this.Docenti.TabIndex = 26;
            this.Docenti.Text = "Seleziona gli studenti da rimuovere:";
            // 
            // EliminaiStudenti
            // 
            this.EliminaiStudenti.AutoSize = true;
            this.EliminaiStudenti.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminaiStudenti.Location = new System.Drawing.Point(12, 9);
            this.EliminaiStudenti.Name = "EliminaiStudenti";
            this.EliminaiStudenti.Size = new System.Drawing.Size(294, 45);
            this.EliminaiStudenti.TabIndex = 24;
            this.EliminaiStudenti.Text = "Elimina studenti";
            // 
            // FrmEliminaStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 460);
            this.Controls.Add(this.ckdListBoxStudenti);
            this.Controls.Add(this.btnRimuoviStudenti);
            this.Controls.Add(this.Docenti);
            this.Controls.Add(this.EliminaiStudenti);
            this.Name = "FrmEliminaStudente";
            this.Text = "FrmEliminaStudente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckdListBoxStudenti;
        private System.Windows.Forms.Button btnRimuoviStudenti;
        private System.Windows.Forms.Label Docenti;
        private System.Windows.Forms.Label EliminaiStudenti;
    }
}