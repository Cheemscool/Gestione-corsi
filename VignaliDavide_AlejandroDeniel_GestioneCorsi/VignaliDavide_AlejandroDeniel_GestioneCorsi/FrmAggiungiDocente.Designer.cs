
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmAggiungiDocente
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
            this.AggiungiDocente = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCognome = new System.Windows.Forms.TextBox();
            this.Cognome = new System.Windows.Forms.Label();
            this.TitoloStudio = new System.Windows.Forms.Label();
            this.cmbBoxTitoloStudio = new System.Windows.Forms.ComboBox();
            this.btnAggiungiDocente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AggiungiDocente
            // 
            this.AggiungiDocente.AutoSize = true;
            this.AggiungiDocente.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AggiungiDocente.Location = new System.Drawing.Point(12, 9);
            this.AggiungiDocente.Name = "AggiungiDocente";
            this.AggiungiDocente.Size = new System.Drawing.Size(322, 45);
            this.AggiungiDocente.TabIndex = 0;
            this.AggiungiDocente.Text = "Aggiungi docente";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(59, 90);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(67, 23);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(214, 90);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxNome.TabIndex = 1;
            // 
            // txtBoxCognome
            // 
            this.txtBoxCognome.Location = new System.Drawing.Point(214, 172);
            this.txtBoxCognome.Name = "txtBoxCognome";
            this.txtBoxCognome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxCognome.TabIndex = 2;
            // 
            // Cognome
            // 
            this.Cognome.AutoSize = true;
            this.Cognome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cognome.Location = new System.Drawing.Point(59, 172);
            this.Cognome.Name = "Cognome";
            this.Cognome.Size = new System.Drawing.Size(100, 23);
            this.Cognome.TabIndex = 3;
            this.Cognome.Text = "Cognome:";
            // 
            // TitoloStudio
            // 
            this.TitoloStudio.AutoSize = true;
            this.TitoloStudio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitoloStudio.Location = new System.Drawing.Point(59, 260);
            this.TitoloStudio.Name = "TitoloStudio";
            this.TitoloStudio.Size = new System.Drawing.Size(142, 23);
            this.TitoloStudio.TabIndex = 5;
            this.TitoloStudio.Text = "Titolo di studio:";
            // 
            // cmbBoxTitoloStudio
            // 
            this.cmbBoxTitoloStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTitoloStudio.FormattingEnabled = true;
            this.cmbBoxTitoloStudio.ItemHeight = 17;
            this.cmbBoxTitoloStudio.Items.AddRange(new object[] {
            "Informatica",
            "Web Design",
            "Progettazione",
            "Musica",
            "Marketing"});
            this.cmbBoxTitoloStudio.Location = new System.Drawing.Point(214, 260);
            this.cmbBoxTitoloStudio.Name = "cmbBoxTitoloStudio";
            this.cmbBoxTitoloStudio.Size = new System.Drawing.Size(157, 25);
            this.cmbBoxTitoloStudio.TabIndex = 3;
            // 
            // btnAggiungiDocente
            // 
            this.btnAggiungiDocente.Location = new System.Drawing.Point(165, 317);
            this.btnAggiungiDocente.Name = "btnAggiungiDocente";
            this.btnAggiungiDocente.Size = new System.Drawing.Size(94, 29);
            this.btnAggiungiDocente.TabIndex = 4;
            this.btnAggiungiDocente.Text = "Aggiungi";
            this.btnAggiungiDocente.UseVisualStyleBackColor = true;
            this.btnAggiungiDocente.Click += new System.EventHandler(this.btnAggiungiDocente_Click);
            // 
            // FrmAggiungiDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 358);
            this.Controls.Add(this.btnAggiungiDocente);
            this.Controls.Add(this.cmbBoxTitoloStudio);
            this.Controls.Add(this.TitoloStudio);
            this.Controls.Add(this.txtBoxCognome);
            this.Controls.Add(this.Cognome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AggiungiDocente);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAggiungiDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiungi docente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AggiungiDocente;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCognome;
        private System.Windows.Forms.Label Cognome;
        private System.Windows.Forms.Label TitoloStudio;
        private System.Windows.Forms.ComboBox cmbBoxTitoloStudio;
        private System.Windows.Forms.Button btnAggiungiDocente;
    }
}