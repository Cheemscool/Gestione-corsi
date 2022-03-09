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
        public FrmInfoCorso(List<Lezione> Lezioni,List<Studente> Studenti,List<Docente> Docenti,List<Aula> Aule,string Nome,int Edizione)
        {
            InitializeComponent();
            LblEdizione.Text = Edizione.ToString();
            LblNomeCorso.Text = Nome.ToString();

            LstLezioni.DataSource = null;
            LstStudenti.DataSource = null;
            LstDocenti.DataSource = null;
            LstAule.DataSource = null;

            LstLezioni.DataSource= Lezioni;
            LstStudenti.DataSource= Studenti;
            LstDocenti.DataSource= Docenti;
            LstAule.DataSource= Aule;
        }
    }
}
