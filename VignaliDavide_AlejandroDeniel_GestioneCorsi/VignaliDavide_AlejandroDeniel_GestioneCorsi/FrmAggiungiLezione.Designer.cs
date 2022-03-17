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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAggiungi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCorso = new System.Windows.Forms.ComboBox();
            this.ChcPresenti = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbMateria = new System.Windows.Forms.ComboBox();
            this.TxtDescrizione = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DttFine = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbDocente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbAule = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creazione lezione";
            // 
            // BtnAggiungi
            // 
            this.BtnAggiungi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAggiungi.Location = new System.Drawing.Point(680, 12);
            this.BtnAggiungi.Name = "BtnAggiungi";
            this.BtnAggiungi.Size = new System.Drawing.Size(108, 75);
            this.BtnAggiungi.TabIndex = 1;
            this.BtnAggiungi.Text = "Aggiungi";
            this.BtnAggiungi.UseVisualStyleBackColor = true;
            this.BtnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrizione:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(246, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data fine:";
            // 
            // CmbCorso
            // 
            this.CmbCorso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbCorso.FormattingEnabled = true;
            this.CmbCorso.Location = new System.Drawing.Point(101, 86);
            this.CmbCorso.Name = "CmbCorso";
            this.CmbCorso.Size = new System.Drawing.Size(121, 26);
            this.CmbCorso.TabIndex = 5;
            this.CmbCorso.SelectedIndexChanged += new System.EventHandler(this.CmbCorso_SelectedIndexChanged);
            // 
            // ChcPresenti
            // 
            this.ChcPresenti.FormattingEnabled = true;
            this.ChcPresenti.Location = new System.Drawing.Point(251, 186);
            this.ChcPresenti.Name = "ChcPresenti";
            this.ChcPresenti.Size = new System.Drawing.Size(265, 256);
            this.ChcPresenti.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Corso:";
            // 
            // CmbMateria
            // 
            this.CmbMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbMateria.FormattingEnabled = true;
            this.CmbMateria.Items.AddRange(new object[] {
            "Informatica",
            "Web Designer",
            "Progettazione",
            "Musica",
            "Marketing"});
            this.CmbMateria.Location = new System.Drawing.Point(101, 125);
            this.CmbMateria.Name = "CmbMateria";
            this.CmbMateria.Size = new System.Drawing.Size(121, 26);
            this.CmbMateria.TabIndex = 8;
            // 
            // TxtDescrizione
            // 
            this.TxtDescrizione.Location = new System.Drawing.Point(12, 186);
            this.TxtDescrizione.Multiline = true;
            this.TxtDescrizione.Name = "TxtDescrizione";
            this.TxtDescrizione.Size = new System.Drawing.Size(210, 256);
            this.TxtDescrizione.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(251, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Presenti:";
            // 
            // DttFine
            // 
            this.DttFine.Location = new System.Drawing.Point(327, 86);
            this.DttFine.Name = "DttFine";
            this.DttFine.Size = new System.Drawing.Size(189, 23);
            this.DttFine.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(246, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Docenti:";
            // 
            // CmbDocente
            // 
            this.CmbDocente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbDocente.FormattingEnabled = true;
            this.CmbDocente.Items.AddRange(new object[] {
            "Informatica",
            "Web Designer",
            "Progettazione",
            "Musica",
            "Marketing"});
            this.CmbDocente.Location = new System.Drawing.Point(327, 125);
            this.CmbDocente.Name = "CmbDocente";
            this.CmbDocente.Size = new System.Drawing.Size(189, 26);
            this.CmbDocente.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(522, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Aula:";
            // 
            // CmbAule
            // 
            this.CmbAule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbAule.FormattingEnabled = true;
            this.CmbAule.Items.AddRange(new object[] {
            "Informatica",
            "Web Designer",
            "Progettazione",
            "Musica",
            "Marketing"});
            this.CmbAule.Location = new System.Drawing.Point(522, 412);
            this.CmbAule.Name = "CmbAule";
            this.CmbAule.Size = new System.Drawing.Size(266, 26);
            this.CmbAule.TabIndex = 15;
            // 
            // FrmAggiungiLezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbAule);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbDocente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DttFine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDescrizione);
            this.Controls.Add(this.CmbMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChcPresenti);
            this.Controls.Add(this.CmbCorso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAggiungi);
            this.Controls.Add(this.label1);
            this.Name = "FrmAggiungiLezione";
            this.Text = "FrmAggiungiLezione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAggiungi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCorso;
        private System.Windows.Forms.CheckedListBox ChcPresenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbMateria;
        private System.Windows.Forms.TextBox TxtDescrizione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DttFine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbDocente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbAule;
    }
}