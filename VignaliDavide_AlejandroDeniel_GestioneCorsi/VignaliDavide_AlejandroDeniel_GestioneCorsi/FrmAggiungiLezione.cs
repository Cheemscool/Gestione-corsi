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
        private List<Corso> Corsi=new List<Corso>();    
        public FrmAggiungiLezione(List<Corso> corsi)
        {
            InitializeComponent();
            if (corsi!=null) Corsi = corsi;
            CmbBoxCorso.DataSource = null;
            CmbBoxCorso.DataSource = Corsi;
            Corso CorsoSelezionato = CmbBoxCorso.SelectedItem as Corso;
            CkLstPresenti.DataSource = null;
            CkLstPresenti.DataSource = CorsoSelezionato.Studenti;
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {

        }

        private void CmbBoxCorso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Corso CorsoSelezionato=CmbBoxCorso.SelectedItem as Corso;
            CkLstPresenti.DataSource = null;
            CkLstPresenti.DataSource = CorsoSelezionato.Studenti;
        }
    }
}
