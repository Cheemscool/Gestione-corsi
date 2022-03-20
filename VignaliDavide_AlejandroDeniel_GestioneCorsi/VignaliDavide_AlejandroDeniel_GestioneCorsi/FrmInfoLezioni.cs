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
    public partial class FrmInfoLezioni : Form
    {
        Lezione lezione;
        public FrmInfoLezioni(Lezione l)
        {
            InitializeComponent();
            lezione = l;
            lblMateria.Text = lezione.Materia;
            lblDocente.Text = lezione.Docente.ToString();
            lblDescrizione.Text = lezione.Descrizione;
            lblAula.Text = lezione.Aula.CodiceAula;
            lblData.Text = lezione.DataInizio.ToString() + " " + lezione.DataFine.ToString();
            foreach (Studente studente in lezione.Presenti)
                lstBoxStudenti.Items.Add(studente);
        }
    }
}
