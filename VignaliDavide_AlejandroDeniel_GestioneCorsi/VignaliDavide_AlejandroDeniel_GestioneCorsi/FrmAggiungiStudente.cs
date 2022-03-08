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
    public partial class FrmAggiungiStudente : Form
    {
        Gestione gestioneCorsi;
        public FrmAggiungiStudente(Gestione gestione)
        {
            InitializeComponent();
            gestioneCorsi = gestione;
        }

        private void btnAggiungiDocente_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text == "" || txtBoxCognome.Text == "" || txtBoxMatricola.Text == "")
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
            else
            {
                Studente studente = new Studente(txtBoxNome.Text, txtBoxCognome.Text, txtBoxMatricola.Text);
                gestioneCorsi.Studenti.Add(studente);
                Close();
            }
        }
    }
}
