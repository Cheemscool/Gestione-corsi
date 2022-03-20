
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmAggiungiAula
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
            this.Risorse = new System.Windows.Forms.Label();
            this.txtBoxCapienza = new System.Windows.Forms.TextBox();
            this.Capienza = new System.Windows.Forms.Label();
            this.txtBoxCodiceAula = new System.Windows.Forms.TextBox();
            this.CodiceAula = new System.Windows.Forms.Label();
            this.AggiungiAula = new System.Windows.Forms.Label();
            this.ckdListBoxRisorse = new System.Windows.Forms.CheckedListBox();
            this.btnAggiungiRisorsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAggiungiDocente
            // 
            this.btnAggiungiDocente.Location = new System.Drawing.Point(164, 496);
            this.btnAggiungiDocente.Name = "btnAggiungiDocente";
            this.btnAggiungiDocente.Size = new System.Drawing.Size(94, 29);
            this.btnAggiungiDocente.TabIndex = 12;
            this.btnAggiungiDocente.Text = "Aggiungi";
            this.btnAggiungiDocente.UseVisualStyleBackColor = true;
            this.btnAggiungiDocente.Click += new System.EventHandler(this.btnAggiungiDocente_Click);
            // 
            // Risorse
            // 
            this.Risorse.AutoSize = true;
            this.Risorse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Risorse.Location = new System.Drawing.Point(59, 250);
            this.Risorse.Name = "Risorse";
            this.Risorse.Size = new System.Drawing.Size(83, 23);
            this.Risorse.TabIndex = 13;
            this.Risorse.Text = "Risorse:";
            // 
            // txtBoxCapienza
            // 
            this.txtBoxCapienza.Location = new System.Drawing.Point(214, 172);
            this.txtBoxCapienza.Name = "txtBoxCapienza";
            this.txtBoxCapienza.Size = new System.Drawing.Size(157, 25);
            this.txtBoxCapienza.TabIndex = 9;
            // 
            // Capienza
            // 
            this.Capienza.AutoSize = true;
            this.Capienza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Capienza.Location = new System.Drawing.Point(59, 172);
            this.Capienza.Name = "Capienza";
            this.Capienza.Size = new System.Drawing.Size(97, 23);
            this.Capienza.TabIndex = 11;
            this.Capienza.Text = "Capienza:";
            // 
            // txtBoxCodiceAula
            // 
            this.txtBoxCodiceAula.Location = new System.Drawing.Point(214, 90);
            this.txtBoxCodiceAula.Name = "txtBoxCodiceAula";
            this.txtBoxCodiceAula.Size = new System.Drawing.Size(157, 25);
            this.txtBoxCodiceAula.TabIndex = 7;
            // 
            // CodiceAula
            // 
            this.CodiceAula.AutoSize = true;
            this.CodiceAula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodiceAula.Location = new System.Drawing.Point(59, 90);
            this.CodiceAula.Name = "CodiceAula";
            this.CodiceAula.Size = new System.Drawing.Size(119, 23);
            this.CodiceAula.TabIndex = 8;
            this.CodiceAula.Text = "Codice aula:";
            // 
            // AggiungiAula
            // 
            this.AggiungiAula.AutoSize = true;
            this.AggiungiAula.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AggiungiAula.Location = new System.Drawing.Point(12, 9);
            this.AggiungiAula.Name = "AggiungiAula";
            this.AggiungiAula.Size = new System.Drawing.Size(255, 45);
            this.AggiungiAula.TabIndex = 6;
            this.AggiungiAula.Text = "Aggiungi aula";
            // 
            // ckdListBoxRisorse
            // 
            this.ckdListBoxRisorse.FormattingEnabled = true;
            this.ckdListBoxRisorse.Location = new System.Drawing.Point(214, 260);
            this.ckdListBoxRisorse.Name = "ckdListBoxRisorse";
            this.ckdListBoxRisorse.Size = new System.Drawing.Size(157, 204);
            this.ckdListBoxRisorse.TabIndex = 14;
            // 
            // btnAggiungiRisorsa
            // 
            this.btnAggiungiRisorsa.Location = new System.Drawing.Point(59, 287);
            this.btnAggiungiRisorsa.Name = "btnAggiungiRisorsa";
            this.btnAggiungiRisorsa.Size = new System.Drawing.Size(83, 42);
            this.btnAggiungiRisorsa.TabIndex = 15;
            this.btnAggiungiRisorsa.Text = "Aggiungi risorsa";
            this.btnAggiungiRisorsa.UseVisualStyleBackColor = true;
            this.btnAggiungiRisorsa.Click += new System.EventHandler(this.btnAggiungiRisorsa_Click);
            // 
            // FrmAggiungiAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 537);
            this.Controls.Add(this.btnAggiungiRisorsa);
            this.Controls.Add(this.ckdListBoxRisorse);
            this.Controls.Add(this.btnAggiungiDocente);
            this.Controls.Add(this.Risorse);
            this.Controls.Add(this.txtBoxCapienza);
            this.Controls.Add(this.Capienza);
            this.Controls.Add(this.txtBoxCodiceAula);
            this.Controls.Add(this.CodiceAula);
            this.Controls.Add(this.AggiungiAula);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAggiungiAula";
            this.Text = "Aggiungi aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiDocente;
        private System.Windows.Forms.Label Risorse;
        private System.Windows.Forms.TextBox txtBoxCapienza;
        private System.Windows.Forms.Label Capienza;
        private System.Windows.Forms.TextBox txtBoxCodiceAula;
        private System.Windows.Forms.Label CodiceAula;
        private System.Windows.Forms.Label AggiungiAula;
        private System.Windows.Forms.CheckedListBox ckdListBoxRisorse;
        private System.Windows.Forms.Button btnAggiungiRisorsa;
    }
}