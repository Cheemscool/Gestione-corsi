namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmAggiungiLezione
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
            this.AggiungiLezione = new System.Windows.Forms.Label();
            this.btnAggiungiLezione = new System.Windows.Forms.Button();
            this.Aula = new System.Windows.Forms.Label();
            this.Descrizione = new System.Windows.Forms.Label();
            this.DataFine = new System.Windows.Forms.Label();
            this.ckdLstBoxPresenti = new System.Windows.Forms.CheckedListBox();
            this.cmbBoxAula = new System.Windows.Forms.ComboBox();
            this.Presenti = new System.Windows.Forms.Label();
            this.dttFine = new System.Windows.Forms.DateTimePicker();
            this.Docente = new System.Windows.Forms.Label();
            this.cmbBoxDocente = new System.Windows.Forms.ComboBox();
            this.txtBoxDescrizione = new System.Windows.Forms.TextBox();
            this.cmbBoxMateria = new System.Windows.Forms.ComboBox();
            this.Materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AggiungiLezione
            // 
            this.AggiungiLezione.AutoSize = true;
            this.AggiungiLezione.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AggiungiLezione.Location = new System.Drawing.Point(14, 10);
            this.AggiungiLezione.Name = "AggiungiLezione";
            this.AggiungiLezione.Size = new System.Drawing.Size(324, 54);
            this.AggiungiLezione.TabIndex = 0;
            this.AggiungiLezione.Text = "Aggiungi lezione";
            // 
            // btnAggiungiLezione
            // 
            this.btnAggiungiLezione.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAggiungiLezione.Location = new System.Drawing.Point(464, 15);
            this.btnAggiungiLezione.Name = "btnAggiungiLezione";
            this.btnAggiungiLezione.Size = new System.Drawing.Size(125, 61);
            this.btnAggiungiLezione.TabIndex = 1;
            this.btnAggiungiLezione.Text = "Aggiungi";
            this.btnAggiungiLezione.UseVisualStyleBackColor = true;
            this.btnAggiungiLezione.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // Aula
            // 
            this.Aula.AutoSize = true;
            this.Aula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aula.Location = new System.Drawing.Point(14, 175);
            this.Aula.Name = "Aula";
            this.Aula.Size = new System.Drawing.Size(54, 23);
            this.Aula.TabIndex = 2;
            this.Aula.Text = "Aula:";
            // 
            // Descrizione
            // 
            this.Descrizione.AutoSize = true;
            this.Descrizione.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Descrizione.Location = new System.Drawing.Point(12, 231);
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Size = new System.Drawing.Size(117, 23);
            this.Descrizione.TabIndex = 3;
            this.Descrizione.Text = "Descrizione:";
            // 
            // DataFine
            // 
            this.DataFine.AutoSize = true;
            this.DataFine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataFine.Location = new System.Drawing.Point(281, 120);
            this.DataFine.Name = "DataFine";
            this.DataFine.Size = new System.Drawing.Size(95, 23);
            this.DataFine.TabIndex = 4;
            this.DataFine.Text = "Data fine:";
            // 
            // ckdLstBoxPresenti
            // 
            this.ckdLstBoxPresenti.FormattingEnabled = true;
            this.ckdLstBoxPresenti.Location = new System.Drawing.Point(287, 258);
            this.ckdLstBoxPresenti.Name = "ckdLstBoxPresenti";
            this.ckdLstBoxPresenti.Size = new System.Drawing.Size(302, 284);
            this.ckdLstBoxPresenti.TabIndex = 5;
            // 
            // cmbBoxAula
            // 
            this.cmbBoxAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxAula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxAula.FormattingEnabled = true;
            this.cmbBoxAula.Location = new System.Drawing.Point(115, 172);
            this.cmbBoxAula.Name = "cmbBoxAula";
            this.cmbBoxAula.Size = new System.Drawing.Size(138, 31);
            this.cmbBoxAula.TabIndex = 2;
            // 
            // Presenti
            // 
            this.Presenti.AutoSize = true;
            this.Presenti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Presenti.Location = new System.Drawing.Point(287, 231);
            this.Presenti.Name = "Presenti";
            this.Presenti.Size = new System.Drawing.Size(88, 23);
            this.Presenti.TabIndex = 10;
            this.Presenti.Text = "Presenti:";
            // 
            // dttFine
            // 
            this.dttFine.Location = new System.Drawing.Point(382, 117);
            this.dttFine.Name = "dttFine";
            this.dttFine.Size = new System.Drawing.Size(207, 25);
            this.dttFine.TabIndex = 3;
            // 
            // Docente
            // 
            this.Docente.AutoSize = true;
            this.Docente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Docente.Location = new System.Drawing.Point(281, 175);
            this.Docente.Name = "Docente";
            this.Docente.Size = new System.Drawing.Size(89, 23);
            this.Docente.TabIndex = 12;
            this.Docente.Text = "Docente:";
            // 
            // cmbBoxDocente
            // 
            this.cmbBoxDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDocente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxDocente.FormattingEnabled = true;
            this.cmbBoxDocente.Location = new System.Drawing.Point(382, 172);
            this.cmbBoxDocente.Name = "cmbBoxDocente";
            this.cmbBoxDocente.Size = new System.Drawing.Size(207, 31);
            this.cmbBoxDocente.TabIndex = 4;
            // 
            // txtBoxDescrizione
            // 
            this.txtBoxDescrizione.Location = new System.Drawing.Point(12, 258);
            this.txtBoxDescrizione.Multiline = true;
            this.txtBoxDescrizione.Name = "txtBoxDescrizione";
            this.txtBoxDescrizione.Size = new System.Drawing.Size(250, 281);
            this.txtBoxDescrizione.TabIndex = 15;
            // 
            // cmbBoxMateria
            // 
            this.cmbBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxMateria.FormattingEnabled = true;
            this.cmbBoxMateria.Items.AddRange(new object[] {
            "Informatica",
            "Web Designer",
            "Progettazione",
            "Musica",
            "Marketing"});
            this.cmbBoxMateria.Location = new System.Drawing.Point(115, 117);
            this.cmbBoxMateria.Name = "cmbBoxMateria";
            this.cmbBoxMateria.Size = new System.Drawing.Size(138, 31);
            this.cmbBoxMateria.TabIndex = 16;
            // 
            // Materia
            // 
            this.Materia.AutoSize = true;
            this.Materia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Materia.Location = new System.Drawing.Point(14, 120);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(83, 23);
            this.Materia.TabIndex = 17;
            this.Materia.Text = "Materia:";
            // 
            // FrmAggiungiLezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 551);
            this.Controls.Add(this.cmbBoxMateria);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.txtBoxDescrizione);
            this.Controls.Add(this.cmbBoxDocente);
            this.Controls.Add(this.Docente);
            this.Controls.Add(this.dttFine);
            this.Controls.Add(this.Presenti);
            this.Controls.Add(this.cmbBoxAula);
            this.Controls.Add(this.ckdLstBoxPresenti);
            this.Controls.Add(this.DataFine);
            this.Controls.Add(this.Descrizione);
            this.Controls.Add(this.Aula);
            this.Controls.Add(this.btnAggiungiLezione);
            this.Controls.Add(this.AggiungiLezione);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAggiungiLezione";
            this.Text = "Aggiungi lezione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AggiungiLezione;
        private System.Windows.Forms.Button btnAggiungiLezione;
        private System.Windows.Forms.Label Aula;
        private System.Windows.Forms.Label Descrizione;
        private System.Windows.Forms.Label DataFine;
        private System.Windows.Forms.CheckedListBox ckdLstBoxPresenti;
        private System.Windows.Forms.ComboBox cmbBoxAula;
        private System.Windows.Forms.Label Presenti;
        private System.Windows.Forms.DateTimePicker dttFine;
        private System.Windows.Forms.Label Docente;
        private System.Windows.Forms.ComboBox cmbBoxDocente;
        private System.Windows.Forms.TextBox txtBoxDescrizione;
        private System.Windows.Forms.ComboBox cmbBoxMateria;
        private System.Windows.Forms.Label Materia;
    }
}