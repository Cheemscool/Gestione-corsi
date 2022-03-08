
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
            this.btnAggiungiDocente = new System.Windows.Forms.Button();
            this.lblMatricola = new System.Windows.Forms.Label();
            this.txtBoxCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAggiungiStudente = new System.Windows.Forms.Label();
            this.txtBoxMatricola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAggiungiDocente
            // 
            this.btnAggiungiDocente.Location = new System.Drawing.Point(165, 269);
            this.btnAggiungiDocente.Name = "btnAggiungiDocente";
            this.btnAggiungiDocente.Size = new System.Drawing.Size(94, 25);
            this.btnAggiungiDocente.TabIndex = 15;
            this.btnAggiungiDocente.Text = "Aggiungi";
            this.btnAggiungiDocente.UseVisualStyleBackColor = true;
            this.btnAggiungiDocente.Click += new System.EventHandler(this.btnAggiungiDocente_Click);
            // 
            // lblMatricola
            // 
            this.lblMatricola.AutoSize = true;
            this.lblMatricola.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMatricola.Location = new System.Drawing.Point(59, 221);
            this.lblMatricola.Name = "lblMatricola";
            this.lblMatricola.Size = new System.Drawing.Size(97, 23);
            this.lblMatricola.TabIndex = 13;
            this.lblMatricola.Text = "Matricola:";
            // 
            // txtBoxCognome
            // 
            this.txtBoxCognome.Location = new System.Drawing.Point(214, 146);
            this.txtBoxCognome.Name = "txtBoxCognome";
            this.txtBoxCognome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxCognome.TabIndex = 12;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCognome.Location = new System.Drawing.Point(59, 146);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(100, 23);
            this.lblCognome.TabIndex = 11;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(214, 76);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxNome.TabIndex = 10;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(59, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 23);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // lblAggiungiStudente
            // 
            this.lblAggiungiStudente.AutoSize = true;
            this.lblAggiungiStudente.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAggiungiStudente.Location = new System.Drawing.Point(12, 8);
            this.lblAggiungiStudente.Name = "lblAggiungiStudente";
            this.lblAggiungiStudente.Size = new System.Drawing.Size(331, 45);
            this.lblAggiungiStudente.TabIndex = 8;
            this.lblAggiungiStudente.Text = "Aggiungi studente";
            // 
            // txtBoxMatricola
            // 
            this.txtBoxMatricola.Location = new System.Drawing.Point(214, 221);
            this.txtBoxMatricola.Name = "txtBoxMatricola";
            this.txtBoxMatricola.Size = new System.Drawing.Size(157, 25);
            this.txtBoxMatricola.TabIndex = 16;
            // 
            // FrmAggiungiStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 304);
            this.Controls.Add(this.txtBoxMatricola);
            this.Controls.Add(this.btnAggiungiDocente);
            this.Controls.Add(this.lblMatricola);
            this.Controls.Add(this.txtBoxCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAggiungiStudente);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAggiungiStudente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAggiungiStudente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiDocente;
        private System.Windows.Forms.Label lblMatricola;
        private System.Windows.Forms.TextBox txtBoxCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAggiungiStudente;
        private System.Windows.Forms.TextBox txtBoxMatricola;
    }
}