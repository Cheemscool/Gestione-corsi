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
            this.CmbBoxCorso = new System.Windows.Forms.ComboBox();
            this.CkLstPresenti = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBoxMateria = new System.Windows.Forms.ComboBox();
            this.TxtDescrizione = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDataFine = new System.Windows.Forms.TextBox();
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
            this.BtnAggiungi.Location = new System.Drawing.Point(650, 37);
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
            this.label4.Location = new System.Drawing.Point(284, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data fine:";
            // 
            // CmbBoxCorso
            // 
            this.CmbBoxCorso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCorso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbBoxCorso.FormattingEnabled = true;
            this.CmbBoxCorso.Location = new System.Drawing.Point(126, 86);
            this.CmbBoxCorso.Name = "CmbBoxCorso";
            this.CmbBoxCorso.Size = new System.Drawing.Size(121, 26);
            this.CmbBoxCorso.TabIndex = 5;
            this.CmbBoxCorso.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCorso_SelectedIndexChanged);
            // 
            // CkLstPresenti
            // 
            this.CkLstPresenti.FormattingEnabled = true;
            this.CkLstPresenti.Location = new System.Drawing.Point(284, 186);
            this.CkLstPresenti.Name = "CkLstPresenti";
            this.CkLstPresenti.Size = new System.Drawing.Size(235, 256);
            this.CkLstPresenti.TabIndex = 6;
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
            // CmbBoxMateria
            // 
            this.CmbBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbBoxMateria.FormattingEnabled = true;
            this.CmbBoxMateria.Items.AddRange(new object[] {
            "Informatica",
            "Web designer",
            "Progettzione",
            "Musica",
            "Marketing"});
            this.CmbBoxMateria.Location = new System.Drawing.Point(126, 125);
            this.CmbBoxMateria.Name = "CmbBoxMateria";
            this.CmbBoxMateria.Size = new System.Drawing.Size(121, 26);
            this.CmbBoxMateria.TabIndex = 8;
            // 
            // TxtDescrizione
            // 
            this.TxtDescrizione.AllowDrop = true;
            this.TxtDescrizione.Location = new System.Drawing.Point(12, 186);
            this.TxtDescrizione.Multiline = true;
            this.TxtDescrizione.Name = "TxtDescrizione";
            this.TxtDescrizione.Size = new System.Drawing.Size(235, 256);
            this.TxtDescrizione.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(284, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Presenti:";
            // 
            // TxtDataFine
            // 
            this.TxtDataFine.Location = new System.Drawing.Point(284, 123);
            this.TxtDataFine.Name = "TxtDataFine";
            this.TxtDataFine.Size = new System.Drawing.Size(235, 23);
            this.TxtDataFine.TabIndex = 11;
            // 
            // FrmAggiungiLezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDataFine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDescrizione);
            this.Controls.Add(this.CmbBoxMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CkLstPresenti);
            this.Controls.Add(this.CmbBoxCorso);
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
        private System.Windows.Forms.ComboBox CmbBoxCorso;
        private System.Windows.Forms.CheckedListBox CkLstPresenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBoxMateria;
        private System.Windows.Forms.TextBox TxtDescrizione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDataFine;
    }
}