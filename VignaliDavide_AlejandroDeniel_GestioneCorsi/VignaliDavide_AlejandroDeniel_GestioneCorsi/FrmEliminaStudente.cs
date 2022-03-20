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
    public partial class FrmEliminaStudente : Form
    {
        Gestione gestioneCorsi;
        public FrmEliminaStudente(Gestione corsi)
        {
            InitializeComponent();
            gestioneCorsi = corsi;

            foreach (Studente studente in gestioneCorsi.Studenti)
                ckdListBoxStudenti.Items.Add(studente);
            ckdListBoxStudenti.DataSource = null;
            ckdListBoxStudenti.DataSource = gestioneCorsi.Studenti;
            ckdListBoxStudenti.DisplayMember = "Nome" + "Cognome";
        }

        private void btnRimuoviStudenti_Click(object sender, EventArgs e)
        {
            if (ckdListBoxStudenti.SelectedItem == null)
            {
                MessageBox.Show("Non sono stati selezionati studenti da eliminare.");
                return;
            }

            foreach (Studente studente in ckdListBoxStudenti.CheckedItems)
                gestioneCorsi.Studenti.Remove(studente);

            MessageBox.Show("Sono stati rimossi gli studenti selezionati.");
            Close();
        }
    }
}
