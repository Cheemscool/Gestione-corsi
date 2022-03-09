
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmAggiungiStudente
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
            this.btnAggiungiStudente = new System.Windows.Forms.Button();
            this.Matricola = new System.Windows.Forms.Label();
            this.txtBoxCognome = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.AggiungiStudente = new System.Windows.Forms.Label();
            this.txtBoxMatricola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAggiungiStudente
            // 
            this.btnAggiungiStudente.Location = new System.Drawing.Point(165, 269);
            this.btnAggiungiStudente.Name = "btnAggiungiStudente";
            this.btnAggiungiStudente.Size = new System.Drawing.Size(94, 25);
            this.btnAggiungiStudente.TabIndex = 4;
            this.btnAggiungiStudente.Text = "Aggiungi";
            this.btnAggiungiStudente.UseVisualStyleBackColor = true;
            this.btnAggiungiStudente.Click += new System.EventHandler(this.btnAggiungiStudente_Click);
            // 
            // Matricola
            // 
            this.Matricola.AutoSize = true;
            this.Matricola.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Matricola.Location = new System.Drawing.Point(59, 221);
            this.Matricola.Name = "Matricola";
            this.Matricola.Size = new System.Drawing.Size(97, 23);
            this.Matricola.TabIndex = 13;
            this.Matricola.Text = "Matricola:";
            // 
            // txtBoxCognome
            // 
            this.txtBoxCognome.Location = new System.Drawing.Point(214, 146);
            this.txtBoxCognome.Name = "txtBoxCognome";
            this.txtBoxCognome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxCognome.TabIndex = 2;
            // 
            // Cognome
            // 
            this.Cognome.AutoSize = true;
            this.Cognome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cognome.Location = new System.Drawing.Point(59, 146);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(100, 23);
            this.Cognome.TabIndex = 11;
            this.Cognome.Text = "Cognome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(214, 76);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxNome.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(59, 76);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(67, 23);
            this.Nome.TabIndex = 9;
            this.Nome.Text = "Nome:";
            // 
            // AggiungiStudente
            // 
            this.AggiungiStudente.AutoSize = true;
            this.AggiungiStudente.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AggiungiStudente.Location = new System.Drawing.Point(12, 8);
            this.AggiungiStudente.Name = "AggiungiStudente";
            this.AggiungiStudente.Size = new System.Drawing.Size(331, 45);
            this.AggiungiStudente.TabIndex = 8;
            this.AggiungiStudente.Text = "Aggiungi studente";
            // 
            // txtBoxMatricola
            // 
            this.txtBoxMatricola.Location = new System.Drawing.Point(214, 221);
            this.txtBoxMatricola.Name = "txtBoxMatricola";
            this.txtBoxMatricola.Size = new System.Drawing.Size(157, 25);
            this.txtBoxMatricola.TabIndex = 3;
            // 
            // FrmAggiungiStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 304);
            this.Controls.Add(this.txtBoxMatricola);
            this.Controls.Add(this.btnAggiungiStudente);
            this.Controls.Add(this.Matricola);
            this.Controls.Add(this.txtBoxCognome);
            this.Controls.Add(this.Cognome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AggiungiStudente);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAggiungiStudente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi studente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiStudente;
        private System.Windows.Forms.Label Matricola;
        private System.Windows.Forms.TextBox txtBoxCognome;
        private System.Windows.Forms.Label Cognome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label AggiungiStudente;
        private System.Windows.Forms.TextBox txtBoxMatricola;
    }
}