
namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    partial class FrmEliminaAula
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
            this.ckdListBoxAule = new System.Windows.Forms.CheckedListBox();
            this.btnRimuoviAule = new System.Windows.Forms.Button();
            this.Aule = new System.Windows.Forms.Label();
            this.EliminaAule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckdListBoxAule
            // 
            this.ckdListBoxAule.FormattingEnabled = true;
            this.ckdListBoxAule.Location = new System.Drawing.Point(75, 149);
            this.ckdListBoxAule.Name = "ckdListBoxAule";
            this.ckdListBoxAule.Size = new System.Drawing.Size(235, 246);
            this.ckdListBoxAule.TabIndex = 31;
            // 
            // btnRimuoviAule
            // 
            this.btnRimuoviAule.Location = new System.Drawing.Point(146, 426);
            this.btnRimuoviAule.Name = "btnRimuoviAule";
            this.btnRimuoviAule.Size = new System.Drawing.Size(94, 25);
            this.btnRimuoviAule.TabIndex = 29;
            this.btnRimuoviAule.Text = "Rimuovi";
            this.btnRimuoviAule.UseVisualStyleBackColor = true;
            this.btnRimuoviAule.Click += new System.EventHandler(this.btnRimuoviAule_Click);
            // 
            // Aule
            // 
            this.Aule.AutoSize = true;
            this.Aule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aule.Location = new System.Drawing.Point(27, 101);
            this.Aule.Name = "Aule";
            this.Aule.Size = new System.Drawing.Size(283, 23);
            this.Aule.TabIndex = 30;
            this.Aule.Text = "Seleziona le aule da rimuovere:";
            // 
            // EliminaAule
            // 
            this.EliminaAule.AutoSize = true;
            this.EliminaAule.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminaAule.Location = new System.Drawing.Point(12, 9);
            this.EliminaAule.Name = "EliminaAule";
            this.EliminaAule.Size = new System.Drawing.Size(232, 45);
            this.EliminaAule.TabIndex = 28;
            this.EliminaAule.Text = "Elimina aule";
            // 
            // FrmEliminaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 467);
            this.Controls.Add(this.ckdListBoxAule);
            this.Controls.Add(this.btnRimuoviAule);
            this.Controls.Add(this.Aule);
            this.Controls.Add(this.EliminaAule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmEliminaAula";
            this.Text = "FrmEliminaAula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckdListBoxAule;
        private System.Windows.Forms.Button btnRimuoviAule;
        private System.Windows.Forms.Label Aule;
        private System.Windows.Forms.Label EliminaAule;
    }
}