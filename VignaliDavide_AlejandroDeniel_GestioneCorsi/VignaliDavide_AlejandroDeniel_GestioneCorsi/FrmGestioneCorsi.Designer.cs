
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
            this.personeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lezioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnStrp
            // 
            this.mnStrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem,
            this.aggiungiToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.mnStrp.Location = new System.Drawing.Point(0, 0);
            this.mnStrp.Name = "mnStrp";
            this.mnStrp.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnStrp.Size = new System.Drawing.Size(700, 24);
            this.mnStrp.TabIndex = 0;
            this.mnStrp.Text = "menuStrip1";
            // 
            // personeToolStripMenuItem
            // 
            this.personeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.lezioniToolStripMenuItem1});
            this.personeToolStripMenuItem.Name = "personeToolStripMenuItem";
            this.personeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.personeToolStripMenuItem.Text = "Visualizza";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentiToolStripMenuItem.Text = "Persone";
            // 
            // lezioniToolStripMenuItem1
            // 
            this.lezioniToolStripMenuItem1.Name = "lezioniToolStripMenuItem1";
            this.lezioniToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lezioniToolStripMenuItem1.Text = "Lezioni";
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem1,
            this.corsiToolStripMenuItem,
            this.lezioniToolStripMenuItem});
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aggiungiToolStripMenuItem.Text = "Aggiungi";
            // 
            // personeToolStripMenuItem1
            // 
            this.personeToolStripMenuItem1.Name = "personeToolStripMenuItem1";
            this.personeToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.personeToolStripMenuItem1.Text = "Persone";
            // 
            // corsiToolStripMenuItem
            // 
            this.corsiToolStripMenuItem.Name = "corsiToolStripMenuItem";
            this.corsiToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.corsiToolStripMenuItem.Text = "Corso";
            // 
            // lezioniToolStripMenuItem
            // 
            this.lezioniToolStripMenuItem.Name = "lezioniToolStripMenuItem";
            this.lezioniToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.lezioniToolStripMenuItem.Text = "Lezioni";
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeToolStripMenuItem2,
            this.corsiToolStripMenuItem1,
            this.lezioneToolStripMenuItem});
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // personeToolStripMenuItem2
            // 
            this.personeToolStripMenuItem2.Name = "personeToolStripMenuItem2";
            this.personeToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.personeToolStripMenuItem2.Text = "Persone";
            // 
            // corsiToolStripMenuItem1
            // 
            this.corsiToolStripMenuItem1.Name = "corsiToolStripMenuItem1";
            this.corsiToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.corsiToolStripMenuItem1.Text = "Corso";
            // 
            // lezioneToolStripMenuItem
            // 
            this.lezioneToolStripMenuItem.Name = "lezioneToolStripMenuItem";
            this.lezioneToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.lezioneToolStripMenuItem.Text = "Lezione";
            // 
            // FrmGestioneCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 388);
            this.Controls.Add(this.mnStrp);
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
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lezioniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lezioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lezioneToolStripMenuItem;
    }
}

