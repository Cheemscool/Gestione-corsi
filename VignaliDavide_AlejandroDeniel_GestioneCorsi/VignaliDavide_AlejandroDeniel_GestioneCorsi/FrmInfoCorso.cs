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
    public partial class FrmInfoCorso : Form
    {
        public FrmInfoCorso(List<Lezione> lezioni, List<Studente> studenti, List<Docente> docenti, List<Aula> aule, string nome, int edizione)
        {
            InitializeComponent();
            lblNomeCorso.Text = nome.ToString();
            lblEdizione.Text = edizione.ToString();

            LstLezioni.DataSource = null;
            LstStudenti.DataSource = null;
            LstDocenti.DataSource = null;
            LstAule.DataSource = null;

            LstLezioni.DataSource = lezioni;
            LstStudenti.DataSource = studenti;
            LstDocenti.DataSource = docenti;
            LstAule.DataSource = aule;
        }
    }
}
