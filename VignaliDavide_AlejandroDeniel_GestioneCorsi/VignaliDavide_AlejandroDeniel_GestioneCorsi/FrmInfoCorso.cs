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
        Corso corso;
        public FrmInfoCorso(Corso c)
        {
            InitializeComponent();
            corso = c;
            lblNomeCorso.Text = corso.Nome;
            lblEdizione.Text = corso.Edizione.ToString();
            int media=0;
            for (int i = 0; i < c.Lezioni.Count; i++)
            {
                media+=c.Lezioni[i].Presenti.Count;
            }
            LbLMedia.Text = $"Media presenti ({media/ c.Lezioni.Count})";
            LstLezioni.DataSource = null;
            LstStudenti.DataSource = null;
            LstDocenti.DataSource = null;
            LstAule.DataSource = null;

            LstLezioni.DataSource = corso.Lezioni;
            LstStudenti.DataSource = corso.Studenti;
            LstDocenti.DataSource = corso.Docenti;
            LstAule.DataSource = corso.Aule;
        }

        private void btnMoreLezione_Click(object sender, EventArgs e)
        {
            if (LstLezioni.SelectedIndex == -1)
            {
                MessageBox.Show("Non è stato selezionato nessun corso.");
                return;
            }

            FrmInfoLezioni frmInfoLezioni = new FrmInfoLezioni(LstLezioni.SelectedItem as Lezione);
            frmInfoLezioni.Show();
        }

        private void FrmInfoCorso_Load(object sender, EventArgs e)
        {

        }
    }
}