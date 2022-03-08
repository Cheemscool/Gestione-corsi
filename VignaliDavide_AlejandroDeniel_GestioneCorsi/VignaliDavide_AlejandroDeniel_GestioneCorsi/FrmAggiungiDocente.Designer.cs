
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
            this.lblAggiungiDocente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblTitoloStudio = new System.Windows.Forms.Label();
            this.cmbBoxTitoloStudio = new System.Windows.Forms.ComboBox();
            this.btnAggiungiDocente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAggiungiDocente
            // 
            this.lblAggiungiDocente.AutoSize = true;
            this.lblAggiungiDocente.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAggiungiDocente.Location = new System.Drawing.Point(12, 9);
            this.lblAggiungiDocente.Name = "lblAggiungiDocente";
            this.lblAggiungiDocente.Size = new System.Drawing.Size(322, 45);
            this.lblAggiungiDocente.TabIndex = 0;
            this.lblAggiungiDocente.Text = "Aggiungi docente";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(59, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(214, 90);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxNome.TabIndex = 2;
            // 
            // txtBoxCognome
            // 
            this.txtBoxCognome.Location = new System.Drawing.Point(214, 172);
            this.txtBoxCognome.Name = "txtBoxCognome";
            this.txtBoxCognome.Size = new System.Drawing.Size(157, 25);
            this.txtBoxCognome.TabIndex = 4;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCognome.Location = new System.Drawing.Point(59, 172);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(100, 23);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblTitoloStudio
            // 
            this.lblTitoloStudio.AutoSize = true;
            this.lblTitoloStudio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitoloStudio.Location = new System.Drawing.Point(59, 260);
            this.lblTitoloStudio.Name = "lblTitoloStudio";
            this.lblTitoloStudio.Size = new System.Drawing.Size(142, 23);
            this.lblTitoloStudio.TabIndex = 5;
            this.lblTitoloStudio.Text = "Titolo di studio:";
            // 
            // cmbBoxTitoloStudio
            // 
            this.cmbBoxTitoloStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTitoloStudio.FormattingEnabled = true;
            this.cmbBoxTitoloStudio.Items.AddRange(new object[] {
            "Informatica",
            "Web Design",
            "Progettazione",
            "Musica",
            "Marketing"});
            this.cmbBoxTitoloStudio.Location = new System.Drawing.Point(214, 260);
            this.cmbBoxTitoloStudio.Name = "cmbBoxTitoloStudio";
            this.cmbBoxTitoloStudio.Size = new System.Drawing.Size(157, 25);
            this.cmbBoxTitoloStudio.TabIndex = 6;
            // 
            // btnAggiungiDocente
            // 
            this.btnAggiungiDocente.Location = new System.Drawing.Point(165, 317);
            this.btnAggiungiDocente.Name = "btnAggiungiDocente";
            this.btnAggiungiDocente.Size = new System.Drawing.Size(94, 29);
            this.btnAggiungiDocente.TabIndex = 7;
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
            this.Controls.Add(this.lblTitoloStudio);
            this.Controls.Add(this.txtBoxCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAggiungiDocente);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAggiungiDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAggiungiDocente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAggiungiDocente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblTitoloStudio;
        private System.Windows.Forms.ComboBox cmbBoxTitoloStudio;
        private System.Windows.Forms.Button btnAggiungiDocente;
    }
}