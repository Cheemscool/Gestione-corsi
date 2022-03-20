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
    public partial class FrmEliminaDocente : Form
    {
        Gestione gestioneCorsi;
        public FrmEliminaDocente(Gestione corsi)
        {
            InitializeComponent();
            gestioneCorsi = corsi;

            foreach (Docente docente in gestioneCorsi.Docenti)
                ckdListBoxDocenti.Items.Add(docente);
            ckdListBoxDocenti.DataSource = null;
            ckdListBoxDocenti.DataSource = gestioneCorsi.Docenti;
            ckdListBoxDocenti.DisplayMember = "Nome" + "Cognome";
        }

        private void btnRimuoviDocente_Click(object sender, EventArgs e)
        {
            if (ckdListBoxDocenti.SelectedItem == null)
            {
                MessageBox.Show("Non sono stati selezionati docenti da eliminare.");
                return;
            }

            foreach (Docente docente in ckdListBoxDocenti.CheckedItems)
                gestioneCorsi.Docenti.Remove(docente);

            MessageBox.Show("Sono stati rimossi i docenti selezionati.");
            Close();
        }
    }
}