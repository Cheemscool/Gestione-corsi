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

namespace GestioneCorsi.Library
{
    public partial class FrmAggiungiCorso : Form
    {
        Gestione gestioneCorsi;
        int edizione;
        public FrmAggiungiCorso(Gestione gestione)
        {
            InitializeComponent();
            gestioneCorsi = gestione;

            foreach (Lezione lezione in gestioneCorsi.Lezioni)
                ckdLstBoxLezioni.Items.Add(lezione);
            ckdLstBoxLezioni.DataSource = null;
            ckdLstBoxLezioni.DataSource = gestioneCorsi.Lezioni;
            ckdLstBoxLezioni.DisplayMember = "Materia";

            foreach (Studente studente in gestioneCorsi.Studenti)
                ckdLstBoxStudenti.Items.Add(studente);
            ckdLstBoxStudenti.DataSource = null;
            ckdLstBoxStudenti.DataSource = gestioneCorsi.Studenti;
            ckdLstBoxStudenti.DisplayMember = "Nome" + "Cognome";

            foreach (Docente docente in gestioneCorsi.Docenti)
                ckdLstBoxDocenti.Items.Add(docente);
            ckdLstBoxDocenti.DataSource = null;
            ckdLstBoxDocenti.DataSource = gestioneCorsi.Docenti;
            ckdLstBoxDocenti.DisplayMember = "Nome" + "Cognome";

            foreach (Aula aula in gestioneCorsi.Aule)
                ckdLstBoxAule.Items.Add(aula);
            ckdLstBoxAule.DataSource = null;
            ckdLstBoxAule.DataSource = gestioneCorsi.Aule;
            ckdLstBoxAule.DisplayMember = "CodiceAula";
        }

        private void btnAggiungiCorso_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtBoxEdizione.Text, out edizione))
            {
                MessageBox.Show("Devi inserire un numero per l'edizione");
                return;
            }

            if (txtBoxNome.Text == "" || txtBoxEdizione.Text == "" || ckdLstBoxLezioni.CheckedItems == null || ckdLstBoxStudenti.CheckedItems == null || ckdLstBoxDocenti.CheckedItems == null || ckdLstBoxAule.CheckedItems == null)
            {
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
                return;
            }

            List<Lezione> lezioni = new List<Lezione>();
            foreach (Lezione lezione in ckdLstBoxLezioni.Items)
                lezioni.Add(lezione);

            List<Studente> studenti = new List<Studente>();
            foreach (Studente studente in ckdLstBoxStudenti.Items)
                studenti.Add(studente);

            List<Docente> docenti = new List<Docente>();
            foreach (Docente docente in ckdLstBoxDocenti.Items)
                docenti.Add(docente);

            List<Aula> aule = new List<Aula>();
            foreach (Aula aula in ckdLstBoxAule.Items)
                aule.Add(aula);

            Corso corso = new Corso(txtBoxNome.Text, edizione, lezioni, studenti, docenti, aule);
            gestioneCorsi.Corsi.Add(corso);
            MessageBox.Show("È stato aggiunto un corso.");
            Close();
            return;
        }
    }
}