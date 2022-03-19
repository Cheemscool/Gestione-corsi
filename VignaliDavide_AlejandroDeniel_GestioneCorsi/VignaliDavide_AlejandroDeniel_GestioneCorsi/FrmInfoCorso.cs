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
        public FrmInfoCorso(Corso corso)
        {
            InitializeComponent();
            lblNomeCorso.Text = corso.Nome.ToString();
            lblEdizione.Text = corso.Edizione.ToString();

            LstLezioni.DataSource = null;
            LstStudenti.DataSource = null;
            LstDocenti.DataSource = null;
            LstAule.DataSource = null;

            LstLezioni.DataSource = corso.Lezioni;
            LstStudenti.DataSource = corso.Studenti;
            LstDocenti.DataSource = corso.Docenti;
            LstAule.DataSource = corso.Aule;
        }
    }
}
