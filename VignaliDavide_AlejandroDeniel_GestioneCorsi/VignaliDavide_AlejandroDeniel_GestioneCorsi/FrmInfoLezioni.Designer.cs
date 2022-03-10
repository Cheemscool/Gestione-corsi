namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
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
            this.LblMateria = new System.Windows.Forms.Label();
            this.LstStudenti = new System.Windows.Forms.ListBox();
            this.LblDescrizione = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.LblDocente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMateria.Location = new System.Drawing.Point(21, 9);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(0, 55);
            this.LblMateria.TabIndex = 0;
            // 
            // LstStudenti
            // 
            this.LstStudenti.FormattingEnabled = true;
            this.LstStudenti.ItemHeight = 15;
            this.LstStudenti.Location = new System.Drawing.Point(407, 116);
            this.LstStudenti.Name = "LstStudenti";
            this.LstStudenti.Size = new System.Drawing.Size(371, 334);
            this.LstStudenti.TabIndex = 1;
            // 
            // LblDescrizione
            // 
            this.LblDescrizione.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LblDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescrizione.Location = new System.Drawing.Point(21, 116);
            this.LblDescrizione.Name = "LblDescrizione";
            this.LblDescrizione.Size = new System.Drawing.Size(371, 334);
            this.LblDescrizione.TabIndex = 2;
            // 
            // LblData
            // 
            this.LblData.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblData.Location = new System.Drawing.Point(606, 9);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(182, 22);
            this.LblData.TabIndex = 3;
            // 
            // LblDocente
            // 
            this.LblDocente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LblDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDocente.Location = new System.Drawing.Point(606, 41);
            this.LblDocente.Name = "LblDocente";
            this.LblDocente.Size = new System.Drawing.Size(182, 23);
            this.LblDocente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(407, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Studenti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrizione:";
            // 
            // LblAula
            // 
            this.LblAula.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LblAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAula.Location = new System.Drawing.Point(606, 73);
            this.LblAula.Name = "LblAula";
            this.LblAula.Size = new System.Drawing.Size(182, 23);
            this.LblAula.TabIndex = 7;
            // 
            // FrmInfoLezioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.LblAula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDocente);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblDescrizione);
            this.Controls.Add(this.LstStudenti);
            this.Controls.Add(this.LblMateria);
            this.Name = "FrmInfoLezioni";
            this.Text = "FrmInfoLezioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.ListBox LstStudenti;
        private System.Windows.Forms.Label LblDescrizione;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAula;
    }
}