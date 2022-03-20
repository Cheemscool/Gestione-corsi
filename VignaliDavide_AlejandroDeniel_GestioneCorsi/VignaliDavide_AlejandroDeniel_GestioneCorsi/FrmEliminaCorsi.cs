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
    public partial class FrmEliminaCorsi : Form
    {
        Gestione gestioneCorsi;
        public FrmEliminaCorsi(Gestione corsi)
        {
            InitializeComponent();
            gestioneCorsi = corsi;

            foreach (Corso corso in gestioneCorsi.Corsi)
                ckdListBoxCorsi.Items.Add(corso);
            ckdListBoxCorsi.DataSource = null;
            ckdListBoxCorsi.DataSource = gestioneCorsi.Docenti;
            ckdListBoxCorsi.DisplayMember = "Nome";
        }

        private void btnRimuoviCorso_Click(object sender, EventArgs e)
        {
            if (ckdListBoxCorsi.SelectedItem == null)
            {
                MessageBox.Show("Non sono stati selezionati corsi da eliminare.");
                return;
            }

            foreach (Corso corso in ckdListBoxCorsi.CheckedItems)
                gestioneCorsi.Corsi.Remove(corso);

            MessageBox.Show("Sono stati rimossi i corsi selezionati.");
            Close();
        }
    }
}
