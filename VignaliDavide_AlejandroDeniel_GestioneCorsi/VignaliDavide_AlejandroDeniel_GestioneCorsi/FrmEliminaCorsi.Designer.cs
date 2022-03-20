
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmEliminaCorsi
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
            this.ckdListBoxCorsi = new System.Windows.Forms.CheckedListBox();
            this.btnRimuoviCorso = new System.Windows.Forms.Button();
            this.Corsi = new System.Windows.Forms.Label();
            this.EliminaCorsi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckdListBoxCorsi
            // 
            this.ckdListBoxCorsi.FormattingEnabled = true;
            this.ckdListBoxCorsi.Location = new System.Drawing.Point(79, 118);
            this.ckdListBoxCorsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckdListBoxCorsi.Name = "ckdListBoxCorsi";
            this.ckdListBoxCorsi.Size = new System.Drawing.Size(235, 220);
            this.ckdListBoxCorsi.TabIndex = 27;
            // 
            // btnRimuoviCorso
            // 
            this.btnRimuoviCorso.Location = new System.Drawing.Point(146, 355);
            this.btnRimuoviCorso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRimuoviCorso.Name = "btnRimuoviCorso";
            this.btnRimuoviCorso.Size = new System.Drawing.Size(94, 36);
            this.btnRimuoviCorso.TabIndex = 25;
            this.btnRimuoviCorso.Text = "Rimuovi";
            this.btnRimuoviCorso.UseVisualStyleBackColor = true;
            this.btnRimuoviCorso.Click += new System.EventHandler(this.btnRimuoviCorso_Click);
            // 
            // Corsi
            // 
            this.Corsi.AutoSize = true;
            this.Corsi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Corsi.Location = new System.Drawing.Point(49, 81);
            this.Corsi.Name = "Corsi";
            this.Corsi.Size = new System.Drawing.Size(278, 23);
            this.Corsi.TabIndex = 26;
            this.Corsi.Text = "Seleziona i corsi da rimuovere:";
            // 
            // EliminaCorsi
            // 
            this.EliminaCorsi.AutoSize = true;
            this.EliminaCorsi.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminaCorsi.Location = new System.Drawing.Point(12, 7);
            this.EliminaCorsi.Name = "EliminaCorsi";
            this.EliminaCorsi.Size = new System.Drawing.Size(241, 45);
            this.EliminaCorsi.TabIndex = 24;
            this.EliminaCorsi.Text = "Elimina corsi";
            // 
            // FrmEliminaCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 402);
            this.Controls.Add(this.ckdListBoxCorsi);
            this.Controls.Add(this.btnRimuoviCorso);
            this.Controls.Add(this.Corsi);
            this.Controls.Add(this.EliminaCorsi);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmEliminaCorsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elimina corsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckdListBoxCorsi;
        private System.Windows.Forms.Button btnRimuoviCorso;
        private System.Windows.Forms.Label Corsi;
        private System.Windows.Forms.Label EliminaCorsi;
    }
}