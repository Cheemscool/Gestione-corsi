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
    public partial class FrmAggiungiLezione : Form
    {
        Gestione gestioneCorsi;      
        public FrmAggiungiLezione(Gestione corsi)
        {
            InitializeComponent();
            gestioneCorsi = corsi;

            foreach (Studente studente in gestioneCorsi.Studenti)
                ckdLstBoxPresenti.Items.Add(studente);
            ckdLstBoxPresenti.DataSource = null;
            ckdLstBoxPresenti.DataSource = gestioneCorsi.Studenti;
            ckdLstBoxPresenti.DisplayMember = "Nome" + "Cognome";

            foreach (Docente docente in gestioneCorsi.Docenti)
                cmbBoxDocente.Items.Add(docente);
            cmbBoxDocente.DataSource = null;
            cmbBoxDocente.DataSource = gestioneCorsi.Docenti;
            cmbBoxDocente.DisplayMember = "Nome" + "Cognome";

            foreach (Aula aula in gestioneCorsi.Aule)
                cmbBoxAula.Items.Add(aula);
            cmbBoxAula.DataSource = null;
            cmbBoxAula.DataSource = gestioneCorsi.Aule;
            cmbBoxAula.DisplayMember = "CodiceAula";
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            if (dttFine.Value <= DateTime.Now)
            {
                MessageBox.Show("La data non può essere passata.");
                return;
            }

            if (cmbBoxMateria.Text == "" || txtBoxDescrizione.Text == "" || cmbBoxDocente.SelectedItem == null || ckdLstBoxPresenti.CheckedItems == null ||cmbBoxAula.SelectedItem == null)
            {
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
                return;
            }

            Aula aula = cmbBoxAula.SelectedItem as Aula;
            int presenti = ckdLstBoxPresenti.CheckedItems.Count;
            if (aula.Capienza < presenti)
            {
                MessageBox.Show("Gli studenti selezionati superano la capienza dell'aula.");
                return;
            }

            List<Studente> studenti = new List<Studente>();
            foreach (Studente studente in ckdLstBoxPresenti.Items)
                studenti.Add(studente);

            Lezione lezione = new Lezione(cmbBoxMateria.Text, txtBoxDescrizione.Text, DateTime.Now, dttFine.Value, studenti, cmbBoxDocente.SelectedItem as Docente, cmbBoxAula.SelectedItem as Aula);
            gestioneCorsi.Lezioni.Add(lezione);
            Close();
        }
    }
}