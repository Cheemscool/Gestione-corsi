
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
            this.corsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxCorsi = new System.Windows.Forms.ListBox();
            this.lblGestioneCorsi = new System.Windows.Forms.Label();
            this.lblCorsi = new System.Windows.Forms.Label();
            this.lblLezioni = new System.Windows.Forms.Label();
            this.listBoxLezioni = new System.Windows.Forms.ListBox();
            this.btnAppello = new System.Windows.Forms.Button();
            this.btnMoreLezione = new System.Windows.Forms.Button();
            this.btnMoreCorso = new System.Windows.Forms.Button();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnStrp.Size = new System.Drawing.Size(566, 24);
            this.mnStrp.TabIndex = 0;
            this.mnStrp.Text = "Menu";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem1,
            this.corsiToolStripMenuItem,
            this.lezioniToolStripMenuItem});
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aggiungiToolStripMenuItem.Text = "Aggiungi";
            // 
            // personeToolStripMenuItem1
            // 
            this.personeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.studenteToolStripMenuItem});
            this.personeToolStripMenuItem1.Name = "personeToolStripMenuItem1";
            this.personeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.personeToolStripMenuItem1.Text = "Persona";
            // 
            // corsiToolStripMenuItem
            // 
            this.corsiToolStripMenuItem.Name = "corsiToolStripMenuItem";
            this.corsiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.corsiToolStripMenuItem.Text = "Corso";
            // 
            // lezioniToolStripMenuItem
            // 
            this.lezioniToolStripMenuItem.Name = "lezioniToolStripMenuItem";
            this.lezioniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lezioniToolStripMenuItem.Text = "Lezione";
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem2,
            this.corsiToolStripMenuItem1,
            this.lezioneToolStripMenuItem});
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // personeToolStripMenuItem2
            // 
            this.personeToolStripMenuItem2.Name = "personeToolStripMenuItem2";
            this.personeToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.personeToolStripMenuItem2.Text = "Persone";
            // 
            // corsiToolStripMenuItem1
            // 
            this.corsiToolStripMenuItem1.Name = "corsiToolStripMenuItem1";
            this.corsiToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.corsiToolStripMenuItem1.Text = "Corso";
            // 
            // lezioneToolStripMenuItem
            // 
            this.lezioneToolStripMenuItem.Name = "lezioneToolStripMenuItem";
            this.lezioneToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.lezioneToolStripMenuItem.Text = "Lezione";
            // 
            // listBoxCorsi
            // 
            this.listBoxCorsi.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxCorsi.FormattingEnabled = true;
            this.listBoxCorsi.ItemHeight = 16;
            this.listBoxCorsi.Location = new System.Drawing.Point(13, 126);
            this.listBoxCorsi.Name = "listBoxCorsi";
            this.listBoxCorsi.Size = new System.Drawing.Size(250, 372);
            this.listBoxCorsi.TabIndex = 1;
            // 
            // lblGestioneCorsi
            // 
            this.lblGestioneCorsi.AutoSize = true;
            this.lblGestioneCorsi.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestioneCorsi.Location = new System.Drawing.Point(3, 33);
            this.lblGestioneCorsi.Name = "lblGestioneCorsi";
            this.lblGestioneCorsi.Size = new System.Drawing.Size(299, 49);
            this.lblGestioneCorsi.TabIndex = 2;
            this.lblGestioneCorsi.Text = "Gestione corsi";
            // 
            // lblCorsi
            // 
            this.lblCorsi.AutoSize = true;
            this.lblCorsi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorsi.Location = new System.Drawing.Point(13, 96);
            this.lblCorsi.Name = "lblCorsi";
            this.lblCorsi.Size = new System.Drawing.Size(41, 16);
            this.lblCorsi.TabIndex = 4;
            this.lblCorsi.Text = "Corsi:";
            // 
            // lblLezioni
            // 
            this.lblLezioni.AutoSize = true;
            this.lblLezioni.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLezioni.Location = new System.Drawing.Point(304, 99);
            this.lblLezioni.Name = "lblLezioni";
            this.lblLezioni.Size = new System.Drawing.Size(52, 16);
            this.lblLezioni.TabIndex = 6;
            this.lblLezioni.Text = "Lezioni:";
            // 
            // listBoxLezioni
            // 
            this.listBoxLezioni.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxLezioni.FormattingEnabled = true;
            this.listBoxLezioni.ItemHeight = 16;
            this.listBoxLezioni.Location = new System.Drawing.Point(304, 127);
            this.listBoxLezioni.Name = "listBoxLezioni";
            this.listBoxLezioni.Size = new System.Drawing.Size(250, 372);
            this.listBoxLezioni.TabIndex = 5;
            // 
            // btnAppello
            // 
            this.btnAppello.Location = new System.Drawing.Point(455, 96);
            this.btnAppello.Name = "btnAppello";
            this.btnAppello.Size = new System.Drawing.Size(58, 23);
            this.btnAppello.TabIndex = 11;
            this.btnAppello.Text = "Appello";
            this.btnAppello.UseVisualStyleBackColor = true;
            // 
            // btnMoreLezione
            // 
            this.btnMoreLezione.Location = new System.Drawing.Point(519, 96);
            this.btnMoreLezione.Name = "btnMoreLezione";
            this.btnMoreLezione.Size = new System.Drawing.Size(35, 23);
            this.btnMoreLezione.TabIndex = 12;
            this.btnMoreLezione.Text = "Info";
            this.btnMoreLezione.UseVisualStyleBackColor = true;
            // 
            // btnMoreCorso
            // 
            this.btnMoreCorso.Location = new System.Drawing.Point(230, 93);
            this.btnMoreCorso.Name = "btnMoreCorso";
            this.btnMoreCorso.Size = new System.Drawing.Size(35, 23);
            this.btnMoreCorso.TabIndex = 13;
            this.btnMoreCorso.Text = "Info";
            this.btnMoreCorso.UseVisualStyleBackColor = true;
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // studenteToolStripMenuItem
            // 
            this.studenteToolStripMenuItem.Name = "studenteToolStripMenuItem";
            this.studenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studenteToolStripMenuItem.Text = "Studente";
            // 
            // FrmGestioneCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 511);
            this.Controls.Add(this.btnMoreCorso);
            this.Controls.Add(this.btnMoreLezione);
            this.Controls.Add(this.btnAppello);
            this.Controls.Add(this.lblLezioni);
            this.Controls.Add(this.listBoxLezioni);
            this.Controls.Add(this.lblCorsi);
            this.Controls.Add(this.lblGestioneCorsi);
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
        private System.Windows.Forms.Label lblGestioneCorsi;
        private System.Windows.Forms.Label lblCorsi;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lezioneToolStripMenuItem;
        private System.Windows.Forms.Label lblLezioni;
        private System.Windows.Forms.ListBox listBoxLezioni;
        private System.Windows.Forms.Button btnAppello;
        private System.Windows.Forms.Button btnMoreLezione;
        private System.Windows.Forms.Button btnMoreCorso;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studenteToolStripMenuItem;
    }
}

