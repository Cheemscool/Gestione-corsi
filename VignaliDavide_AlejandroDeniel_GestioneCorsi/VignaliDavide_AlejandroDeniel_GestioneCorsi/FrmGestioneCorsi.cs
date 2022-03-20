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
    public partial class FrmGestioneCorsi : Form
    {
        Gestione gestioneCorsi;
        public FrmGestioneCorsi()
        {
            InitializeComponent();
            gestioneCorsi = new Gestione();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiDocente frmAggiungiDocente = new FrmAggiungiDocente(gestioneCorsi);
            frmAggiungiDocente.ShowDialog();
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiStudente frmAggiungiStudente = new FrmAggiungiStudente(gestioneCorsi);
            frmAggiungiStudente.ShowDialog();
        }

        private void corsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Aule.Count == 0 || gestioneCorsi.Docenti.Count == 0 || gestioneCorsi.Lezioni.Count == 0 || gestioneCorsi.Studenti.Count == 0)
            {
                MessageBox.Show("Non sono presenti i requisiti per aggiungere un corso.");
                return;
            }
            FrmAggiungiCorso frmAggiungiCorso = new FrmAggiungiCorso(gestioneCorsi);
            frmAggiungiCorso.ShowDialog();
            StampaCorsi();
        }

        private void lezioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Docenti.Count == 0 || gestioneCorsi.Studenti.Count == 0 || gestioneCorsi.Aule.Count == 0)
            {
                MessageBox.Show("Non sono presenti i requisiti per aggiungere una lezione.");
                return;
            }
            FrmAggiungiLezione frmAggiungiLezione = new FrmAggiungiLezione(gestioneCorsi);
            frmAggiungiLezione.ShowDialog();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiAula frmAggiungiAula = new FrmAggiungiAula(gestioneCorsi);
            frmAggiungiAula.ShowDialog();
        }

        private void btnMoreCorso_Click(object sender, EventArgs e)
        {
            if (listBoxCorsi.Items.Count == 0)
            {
                MessageBox.Show("Non esistono corsi.");
                return;
            }

            if (listBoxCorsi.SelectedIndex == -1)
            {
                MessageBox.Show("Non è stato selezionato nessun corso.");
                return;
            }
                
            FrmInfoCorso frmInfoCorso = new FrmInfoCorso(listBoxCorsi.SelectedItem as Corso);
            frmInfoCorso.ShowDialog();
        }

        private void eliminaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Docenti.Count == 0)
            {
                MessageBox.Show("Non esistono docenti da rimuovere.");
                return;
            }

            FrmEliminaDocente frmEliminaDocente = new FrmEliminaDocente(gestioneCorsi);
            frmEliminaDocente.ShowDialog();
        }

        private void eliminaStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Studenti.Count == 0)
            {
                MessageBox.Show("Non esistono studenti da rimuovere.");
                return;
            }

            FrmEliminaStudente frmEliminaStudente = new FrmEliminaStudente(gestioneCorsi);
            frmEliminaStudente.ShowDialog();
        }

        private void eliminaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Aule.Count == 0)
            {
                MessageBox.Show("Non esistono aule da rimuovere.");
                return;
            }

            FrmEliminaAula frmEliminaAula = new FrmEliminaAula(gestioneCorsi);
            frmEliminaAula.ShowDialog();
        }

        private void eiminaLezioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Lezioni.Count == 0)
            {
                MessageBox.Show("Non esistono lezioni da rimuovere.");
                return;
            }

            FrmEliminaLezione frmEliminaLezione = new(gestioneCorsi);
            frmEliminaLezione.ShowDialog();
        }

        private void corsiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gestioneCorsi.Corsi.Count == 0)
            {
                MessageBox.Show("Non esistono corsi da rimuovere.");
                return;
            }

            FrmEliminaCorsi frmEliminaCorsi = new FrmEliminaCorsi(gestioneCorsi);
            frmEliminaCorsi.ShowDialog();
        }
        
        public void StampaCorsi()
        {
            listBoxCorsi.Items.Clear();
            foreach (Corso corso in gestioneCorsi.Corsi)
                listBoxCorsi.Items.Add(corso);
        }
    }
}