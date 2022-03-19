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
            Docente docente = new Docente("Ilgo", "Dimento", "Web Marketing");
            gestioneCorsi.Docenti.Add(docente);
            Studente studente = new Studente("Vignali", "Davideo", "Matricolato");
            gestioneCorsi.Studenti.Add(studente);
            Studente studente2 = new Studente("Alesandjo", "dandiel", "Matricolame");
            List<Studente> presenti = new List<Studente>();
            presenti.Add(studente);
            presenti.Add(studente2);
            List<string> risorse = new List<string>();
            risorse.Add("computer");
            risorse.Add("laptop");
            Aula aula = new Aula("codice", 120, risorse);
            Lezione lezione = new Lezione("Web marketing", "super descrizione", DateTime.Now.AddDays(2), presenti, docente, aula);
            Lezione lezione2 = new Lezione("web design", "desc", DateTime.Now.AddDays(4), presenti, docente, aula);
            List<Lezione> lezioni = new List<Lezione>();
            lezioni.Add(lezione);
            lezioni.Add(lezione2);
            List<Docente> docenti = new List<Docente>();
            docenti.Add(docente);
            List<Aula> aule = new List<Aula>();
            aule.Add(aula);
            Corso corso = new Corso("Corso1", 1, lezioni, presenti, docenti, aule);
            Corso corso2 = new Corso("Corso2", 2, lezioni, presenti, docenti, aule);
            listBoxCorsi.Items.Add(corso);
            listBoxCorsi.Items.Add(corso2);
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
            if (gestioneCorsi.Aule.Count == 0 && gestioneCorsi.Docenti.Count == 0 && gestioneCorsi.Lezioni.Count == 0 && gestioneCorsi.Studenti.Count == 0)
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
            FrmAggiungiLezione frmAggiungiLezione = new FrmAggiungiLezione(gestioneCorsi.Corsi);
            frmAggiungiLezione.ShowDialog();
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

        public void StampaCorsi()
        {
            int i = 1;
            listBoxCorsi.Items.Clear();
            foreach (Corso corsi in gestioneCorsi.Corsi)
                listBoxCorsi.Items.Add($"{i++}. {corsi.ToString()}");
        }
    }
}