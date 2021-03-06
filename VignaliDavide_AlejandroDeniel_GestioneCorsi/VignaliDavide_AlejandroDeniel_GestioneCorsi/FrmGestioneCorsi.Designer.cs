
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmGestioneCorsi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnStrp = new System.Windows.Forms.MenuStrip();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxCorsi = new System.Windows.Forms.ListBox();
            this.Gestione_Corsi = new System.Windows.Forms.Label();
            this.Corsi = new System.Windows.Forms.Label();
            this.btnMoreCorso = new System.Windows.Forms.Button();
            this.mnStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrp
            // 
            this.mnStrp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnStrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.mnStrp.Location = new System.Drawing.Point(0, 0);
            this.mnStrp.Name = "mnStrp";
            this.mnStrp.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnStrp.Size = new System.Drawing.Size(431, 28);
            this.mnStrp.TabIndex = 0;
            this.mnStrp.Text = "Menu";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem1,
            this.corsiToolStripMenuItem,
            this.lezioniToolStripMenuItem,
            this.aulaToolStripMenuItem});
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.aggiungiToolStripMenuItem.Text = "Aggiungi";
            // 
            // personeToolStripMenuItem1
            // 
            this.personeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.studenteToolStripMenuItem});
            this.personeToolStripMenuItem1.Name = "personeToolStripMenuItem1";
            this.personeToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.personeToolStripMenuItem1.Text = "Persona";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // studenteToolStripMenuItem
            // 
            this.studenteToolStripMenuItem.Name = "studenteToolStripMenuItem";
            this.studenteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.studenteToolStripMenuItem.Text = "Studente";
            this.studenteToolStripMenuItem.Click += new System.EventHandler(this.studenteToolStripMenuItem_Click);
            // 
            // corsiToolStripMenuItem
            // 
            this.corsiToolStripMenuItem.Name = "corsiToolStripMenuItem";
            this.corsiToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.corsiToolStripMenuItem.Text = "Corso";
            this.corsiToolStripMenuItem.Click += new System.EventHandler(this.corsiToolStripMenuItem_Click);
            // 
            // lezioniToolStripMenuItem
            // 
            this.lezioniToolStripMenuItem.Name = "lezioniToolStripMenuItem";
            this.lezioniToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.lezioniToolStripMenuItem.Text = "Lezione";
            this.lezioniToolStripMenuItem.Click += new System.EventHandler(this.lezioniToolStripMenuItem_Click);
            // 
            // aulaToolStripMenuItem
            // 
            this.aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
            this.aulaToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.aulaToolStripMenuItem.Text = "Aula";
            this.aulaToolStripMenuItem.Click += new System.EventHandler(this.aulaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem2,
            this.corsiToolStripMenuItem1,
            this.lezioneToolStripMenuItem,
            this.aulaToolStripMenuItem1});
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // personeToolStripMenuItem2
            // 
            this.personeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.studentiToolStripMenuItem});
            this.personeToolStripMenuItem2.Name = "personeToolStripMenuItem2";
            this.personeToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.personeToolStripMenuItem2.Text = "Persone";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.toolStripMenuItem1.Text = "Docenti";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.eliminaDocenteToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.eliminaStudenteToolStripMenuItem_Click);
            // 
            // corsiToolStripMenuItem1
            // 
            this.corsiToolStripMenuItem1.Name = "corsiToolStripMenuItem1";
            this.corsiToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.corsiToolStripMenuItem1.Text = "Corso";
            this.corsiToolStripMenuItem1.Click += new System.EventHandler(this.corsiToolStripMenuItem1_Click);
            // 
            // lezioneToolStripMenuItem
            // 
            this.lezioneToolStripMenuItem.Name = "lezioneToolStripMenuItem";
            this.lezioneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lezioneToolStripMenuItem.Text = "Lezione";
            this.lezioneToolStripMenuItem.Click += new System.EventHandler(this.eiminaLezioneToolStripMenuItem_Click);
            // 
            // aulaToolStripMenuItem1
            // 
            this.aulaToolStripMenuItem1.Name = "aulaToolStripMenuItem1";
            this.aulaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aulaToolStripMenuItem1.Text = "Aula";
            this.aulaToolStripMenuItem1.Click += new System.EventHandler(this.eliminaAulaToolStripMenuItem_Click);
            // 
            // listBoxCorsi
            // 
            this.listBoxCorsi.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxCorsi.FormattingEnabled = true;
            this.listBoxCorsi.ItemHeight = 18;
            this.listBoxCorsi.Location = new System.Drawing.Point(64, 142);
            this.listBoxCorsi.Name = "listBoxCorsi";
            this.listBoxCorsi.Size = new System.Drawing.Size(289, 346);
            this.listBoxCorsi.TabIndex = 1;
            // 
            // Gestione_Corsi
            // 
            this.Gestione_Corsi.AutoSize = true;
            this.Gestione_Corsi.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gestione_Corsi.Location = new System.Drawing.Point(3, 33);
            this.Gestione_Corsi.Name = "Gestione_Corsi";
            this.Gestione_Corsi.Size = new System.Drawing.Size(373, 61);
            this.Gestione_Corsi.TabIndex = 2;
            this.Gestione_Corsi.Text = "Gestione corsi";
            // 
            // Corsi
            // 
            this.Corsi.AutoSize = true;
            this.Corsi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Corsi.Location = new System.Drawing.Point(27, 115);
            this.Corsi.Name = "Corsi";
            this.Corsi.Size = new System.Drawing.Size(53, 19);
            this.Corsi.TabIndex = 4;
            this.Corsi.Text = "Corsi:";
            // 
            // btnMoreCorso
            // 
            this.btnMoreCorso.Location = new System.Drawing.Point(308, 112);
            this.btnMoreCorso.Name = "btnMoreCorso";
            this.btnMoreCorso.Size = new System.Drawing.Size(45, 23);
            this.btnMoreCorso.TabIndex = 13;
            this.btnMoreCorso.Text = "Info";
            this.btnMoreCorso.UseVisualStyleBackColor = true;
            this.btnMoreCorso.Click += new System.EventHandler(this.btnMoreCorso_Click);
            // 
            // FrmGestioneCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 510);
            this.Controls.Add(this.btnMoreCorso);
            this.Controls.Add(this.Corsi);
            this.Controls.Add(this.Gestione_Corsi);
            this.Controls.Add(this.listBoxCorsi);
            this.Controls.Add(this.mnStrp);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnStrp;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmGestioneCorsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione dei corsi";
            this.mnStrp.ResumeLayout(false);
            this.mnStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrp;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lezioniToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxCorsi;
        private System.Windows.Forms.Label Gestione_Corsi;
        private System.Windows.Forms.Label Corsi;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lezioneToolStripMenuItem;
        private System.Windows.Forms.Button btnMoreCorso;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
    }
}

