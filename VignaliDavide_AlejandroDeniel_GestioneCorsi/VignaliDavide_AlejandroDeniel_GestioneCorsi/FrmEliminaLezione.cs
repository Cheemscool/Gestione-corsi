using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestioneCorsi.Library;

namespace VignaliDavide_AlejandroDeniel_GestioneCorsi
{
    public partial class FrmEliminaLezione : Form
    {
        Gestione gestioneCorsi;
        public FrmEliminaLezione(Gestione corsi)
        {
            InitializeComponent();
            gestioneCorsi = corsi;

            foreach (Lezione lezione in gestioneCorsi.Lezioni)
                ckdListBoxLezioni.Items.Add(lezione);
            ckdListBoxLezioni.DataSource = null;
            ckdListBoxLezioni.DataSource = gestioneCorsi.Docenti;
            ckdListBoxLezioni.DisplayMember = "Materia";
        }

        private void btnRimuoviLezione_Click(object sender, EventArgs e)
        {
            if (ckdListBoxLezioni.SelectedItem == null)
            {
                MessageBox.Show("Non sono state selezionate lezioni da eliminare.");
                return;
            }

            foreach (Lezione lezione in ckdListBoxLezioni.CheckedItems)
                gestioneCorsi.Lezioni.Remove(lezione);

            MessageBox.Show("Sono state rimosse le lezioni selezionate.");
            Close();
        }
    }
}
