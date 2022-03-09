
namespace GestioneCorsi.Library
{
    partial class FrmAggiungiCorso
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
            this.btnAggiungiCorso = new System.Windows.Forms.Button();
            this.txtBoxEdizione = new System.Windows.Forms.TextBox();
            this.Edizione = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.AggiungiCorso = new System.Windows.Forms.Label();
            this.Lezioni = new System.Windows.Forms.Label();
            this.Studenti = new System.Windows.Forms.Label();
            this.Docenti = new System.Windows.Forms.Label();
            this.Aule = new System.Windows.Forms.Label();
            this.ckdLstBoxLezioni = new System.Windows.Forms.CheckedListBox();
            this.ckdLstBoxStudenti = new System.Windows.Forms.CheckedListBox();
            this.ckdLstBoxDocenti = new System.Windows.Forms.CheckedListBox();
            this.ckdLstBoxAule = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnAggiungiCorso
            // 
            this.btnAggiungiCorso.Location = new System.Drawing.Point(534, 102);
            this.btnAggiungiCorso.Name = "btnAggiungiCorso";
            this.btnAggiungiCorso.Size = new System.Drawing.Size(113, 59);
            this.btnAggiungiCorso.TabIndex = 7;
            this.btnAggiungiCorso.Text = "Aggiungi";
            this.btnAggiungiCorso.UseVisualStyleBackColor = true;
            this.btnAggiungiCorso.Click += new System.EventHandler(this.btnAggiungiCorso_Click);
            // 
            // txtBoxEdizione
            // 
            this.txtBoxEdizione.Location = new System.Drawing.Point(201, 148);
            this.txtBoxEdizione.Name = "txtBoxEdizione";
            this.txtBoxEdizione.Size = new System.Drawing.Size(157, 25);
            this.txtBoxEdizione.TabIndex = 2;
            // 
            // Edizione
            // 
            this.Edizione.AutoSize = true;
            this.Edizione.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edizione.Location = new System.Drawing.Point(46, 148);
            this.Edizione.Name = "Edizione";
            this.Edizione.Size = new System.Drawing.Size(89, 23);
            this.Edizione.TabIndex = 11;
            this.Edizione.Text = "Edizione:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(201, 92);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxNome.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(46, 92);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(67, 23);
            this.Nome.TabIndex = 8;
            this.Nome.Text = "Nome:";
            // 
            // AggiungiCorso
            // 
            this.AggiungiCorso.AutoSize = true;
            this.AggiungiCorso.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AggiungiCorso.Location = new System.Drawing.Point(12, 9);
            this.AggiungiCorso.Name = "AggiungiCorso";
            this.AggiungiCorso.Size = new System.Drawing.Size(278, 45);
            this.AggiungiCorso.TabIndex = 6;
            this.AggiungiCorso.Text = "Aggiungi corso";
            // 
            // Lezioni
            // 
            this.Lezioni.AutoSize = true;
            this.Lezioni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lezioni.Location = new System.Drawing.Point(25, 238);
            this.Lezioni.Name = "Lezioni";
            this.Lezioni.Size = new System.Drawing.Size(76, 23);
            this.Lezioni.TabIndex = 13;
            this.Lezioni.Text = "Lezioni:";
            // 
            // Studenti
            // 
            this.Studenti.AutoSize = true;
            this.Studenti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Studenti.Location = new System.Drawing.Point(200, 238);
            this.Studenti.Name = "Studenti";
            this.Studenti.Size = new System.Drawing.Size(87, 23);
            this.Studenti.TabIndex = 14;
            this.Studenti.Text = "Studenti:";
            // 
            // Docenti
            // 
            this.Docenti.AutoSize = true;
            this.Docenti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Docenti.Location = new System.Drawing.Point(374, 238);
            this.Docenti.Name = "Docenti";
            this.Docenti.Size = new System.Drawing.Size(82, 23);
            this.Docenti.TabIndex = 15;
            this.Docenti.Text = "Docenti:";
            // 
            // Aule
            // 
            this.Aule.AutoSize = true;
            this.Aule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aule.Location = new System.Drawing.Point(548, 238);
            this.Aule.Name = "Aule";
            this.Aule.Size = new System.Drawing.Size(54, 23);
            this.Aule.TabIndex = 16;
            this.Aule.Text = "Aule:";
            // 
            // ckdLstBoxLezioni
            // 
            this.ckdLstBoxLezioni.FormattingEnabled = true;
            this.ckdLstBoxLezioni.Location = new System.Drawing.Point(25, 289);
            this.ckdLstBoxLezioni.Name = "ckdLstBoxLezioni";
            this.ckdLstBoxLezioni.Size = new System.Drawing.Size(154, 224);
            this.ckdLstBoxLezioni.TabIndex = 3;
            // 
            // ckdLstBoxStudenti
            // 
            this.ckdLstBoxStudenti.FormattingEnabled = true;
            this.ckdLstBoxStudenti.Location = new System.Drawing.Point(200, 289);
            this.ckdLstBoxStudenti.Name = "ckdLstBoxStudenti";
            this.ckdLstBoxStudenti.Size = new System.Drawing.Size(154, 224);
            this.ckdLstBoxStudenti.TabIndex = 4;
            // 
            // ckdLstBoxDocenti
            // 
            this.ckdLstBoxDocenti.FormattingEnabled = true;
            this.ckdLstBoxDocenti.Location = new System.Drawing.Point(374, 289);
            this.ckdLstBoxDocenti.Name = "ckdLstBoxDocenti";
            this.ckdLstBoxDocenti.Size = new System.Drawing.Size(154, 224);
            this.ckdLstBoxDocenti.TabIndex = 5;
            // 
            // ckdLstBoxAule
            // 
            this.ckdLstBoxAule.FormattingEnabled = true;
            this.ckdLstBoxAule.Location = new System.Drawing.Point(548, 289);
            this.ckdLstBoxAule.Name = "ckdLstBoxAule";
            this.ckdLstBoxAule.Size = new System.Drawing.Size(154, 224);
            this.ckdLstBoxAule.TabIndex = 6;
            // 
            // FrmAggiungiCorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 530);
            this.Controls.Add(this.ckdLstBoxAule);
            this.Controls.Add(this.ckdLstBoxDocenti);
            this.Controls.Add(this.ckdLstBoxStudenti);
            this.Controls.Add(this.ckdLstBoxLezioni);
            this.Controls.Add(this.Aule);
            this.Controls.Add(this.Docenti);
            this.Controls.Add(this.Studenti);
            this.Controls.Add(this.Lezioni);
            this.Controls.Add(this.btnAggiungiCorso);
            this.Controls.Add(this.txtBoxEdizione);
            this.Controls.Add(this.Edizione);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AggiungiCorso);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmAggiungiCorso";
            this.Text = "Aggiungi corso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiCorso;
        private System.Windows.Forms.TextBox txtBoxEdizione;
        private System.Windows.Forms.Label Edizione;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label AggiungiCorso;
        private System.Windows.Forms.Label Lezioni;
        private System.Windows.Forms.Label Studenti;
        private System.Windows.Forms.Label Docenti;
        private System.Windows.Forms.Label Aule;
        private System.Windows.Forms.CheckedListBox ckdLstBoxLezioni;
        private System.Windows.Forms.CheckedListBox ckdLstBoxStudenti;
        private System.Windows.Forms.CheckedListBox ckdLstBoxDocenti;
        private System.Windows.Forms.CheckedListBox ckdLstBoxAule;
    }
}