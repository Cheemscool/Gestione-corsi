﻿namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmInfoLezioni
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
            this.lblMateria = new System.Windows.Forms.Label();
            this.lstBoxStudenti = new System.Windows.Forms.ListBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.Studenti = new System.Windows.Forms.Label();
            this.Descrizione = new System.Windows.Forms.Label();
            this.lblAula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(24, 10);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(0, 67);
            this.lblMateria.TabIndex = 0;
            // 
            // lstBoxStudenti
            // 
            this.lstBoxStudenti.FormattingEnabled = true;
            this.lstBoxStudenti.ItemHeight = 17;
            this.lstBoxStudenti.Location = new System.Drawing.Point(466, 167);
            this.lstBoxStudenti.Name = "lstBoxStudenti";
            this.lstBoxStudenti.Size = new System.Drawing.Size(423, 378);
            this.lstBoxStudenti.TabIndex = 1;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescrizione.Location = new System.Drawing.Point(25, 167);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(424, 379);
            this.lblDescrizione.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Location = new System.Drawing.Point(681, 19);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(208, 25);
            this.lblData.TabIndex = 3;
            // 
            // lblDocente
            // 
            this.lblDocente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDocente.Location = new System.Drawing.Point(681, 69);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(208, 26);
            this.lblDocente.TabIndex = 4;
            // 
            // Studenti
            // 
            this.Studenti.AutoSize = true;
            this.Studenti.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Studenti.Location = new System.Drawing.Point(466, 134);
            this.Studenti.Name = "Studenti";
            this.Studenti.Size = new System.Drawing.Size(108, 32);
            this.Studenti.TabIndex = 5;
            this.Studenti.Text = "Studenti:";
            // 
            // Descrizione
            // 
            this.Descrizione.AutoSize = true;
            this.Descrizione.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Descrizione.Location = new System.Drawing.Point(25, 134);
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Size = new System.Drawing.Size(142, 32);
            this.Descrizione.TabIndex = 6;
            this.Descrizione.Text = "Descrizione:";
            // 
            // lblAula
            // 
            this.lblAula.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAula.Location = new System.Drawing.Point(681, 119);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(208, 26);
            this.lblAula.TabIndex = 7;
            // 
            // FrmInfoLezioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 557);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.Descrizione);
            this.Controls.Add(this.Studenti);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.lstBoxStudenti);
            this.Controls.Add(this.lblMateria);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmInfoLezioni";
            this.Text = "FrmInfoLezioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ListBox lstBoxStudenti;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label Studenti;
        private System.Windows.Forms.Label Descrizione;
        private System.Windows.Forms.Label lblAula;
    }
}