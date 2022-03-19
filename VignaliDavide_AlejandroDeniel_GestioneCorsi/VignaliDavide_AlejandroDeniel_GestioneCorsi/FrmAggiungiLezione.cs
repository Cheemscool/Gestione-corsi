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
        private List<Corso> Corsi;
        private int index = 0;
        
        public FrmAggiungiLezione(List<Corso> corsi)
        {
            InitializeComponent();
            CmbCorso.DataSource = null;
            CmbCorso.DataSource = corsi;
            DttFine.MinDate = DateTime.Now;
            DttFine.MaxDate = DateTime.Now.AddYears(2);
        }

        public void Ricarica()
        {
            ChcPresenti.DataSource = null;
            CmbDocente.DataSource = null;
            CmbAule.DataSource = null;

            ChcPresenti.DataSource = Corsi[index].Studenti;           
            CmbDocente.DataSource = Corsi[index].Docenti;
            CmbAule.DataSource = Corsi[index].Aule;
        }

        private void CmbCorso_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = CmbCorso.SelectedIndex;
            Ricarica();
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            List<Studente> studenti = new List<Studente>();
            foreach (Studente studente in ChcPresenti.Items)
                studenti.Add(studente);

            Lezione lezione = new Lezione(CmbMateria.Text, lblDescrizione.Text, DttFine.Value,studenti,CmbDocente.SelectedItem as Docente,CmbAule.SelectedItem as Aula);
            Corsi[index].AggiungiLezione(lezione);
            Close();
        }
    }
}
