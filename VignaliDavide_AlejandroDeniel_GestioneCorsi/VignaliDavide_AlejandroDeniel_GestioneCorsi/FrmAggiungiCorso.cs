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

            foreach (Lezione lezioni in gestioneCorsi.Lezioni)
                ckdLstBoxLezioni.Items.Add(lezioni);
            ckdLstBoxLezioni.DataSource = null;
            ckdLstBoxLezioni.DataSource = gestioneCorsi.Lezioni;

            foreach (Studente studenti in gestioneCorsi.Studenti)
                ckdLstBoxStudenti.Items.Add(studenti);
            ckdLstBoxStudenti.DataSource = null;
            ckdLstBoxStudenti.DataSource = gestioneCorsi.Studenti;

            foreach (Docente docente in gestioneCorsi.Docenti)
                ckdLstBoxDocenti.Items.Add(docente);
            ckdLstBoxDocenti.DataSource = null;
            ckdLstBoxDocenti.DataSource = gestioneCorsi.Docenti;
            ckdLstBoxDocenti.DisplayMember = "Nome" + "Cognome";

            foreach (Aula aule in gestioneCorsi.Aule)
                ckdLstBoxAule.Items.Add(aule);
            ckdLstBoxAule.DataSource = null;
            ckdLstBoxAule.DataSource = gestioneCorsi.Aule;
        }

        private void btnAggiungiCorso_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text == "" || txtBoxEdizione.Text == "" || ckdLstBoxLezioni.CheckedItems == null || ckdLstBoxStudenti.CheckedItems == null || ckdLstBoxDocenti.CheckedItems == null || ckdLstBoxAule.CheckedItems == null)
            {
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
                return;
            }

            if (!Int32.TryParse(txtBoxEdizione.Text, out edizione))
            {
                MessageBox.Show("Devi inserire un numero per l'edizione");
                //Corso corso = new Corso(txtBoxNome.Text, edizione, ckdLstBoxLezioni.CheckedItems, ckdLstBoxStudenti.CheckedItems, ckdLstBoxDocenti.CheckedItems, ckdLstBoxAule.CheckedItems);
                //Close();
                return;
            }
        }
    }
}