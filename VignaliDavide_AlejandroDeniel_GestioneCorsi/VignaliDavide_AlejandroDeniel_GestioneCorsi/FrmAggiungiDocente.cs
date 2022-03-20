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
    public partial class FrmAggiungiDocente : Form
    {
        Gestione gestioneCorsi;
        public FrmAggiungiDocente(Gestione gestione)
        {
            InitializeComponent();
            gestioneCorsi = gestione;
        }

        private void btnAggiungiDocente_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text == "" || txtBoxCognome.Text == "" || cmbBoxTitoloStudio.SelectedItem == null)
            {
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
                return;
            }

            Docente docente = new Docente(txtBoxNome.Text, txtBoxCognome.Text, cmbBoxTitoloStudio.Text);
            gestioneCorsi.Docenti.Add(docente);
            Close();
        }
    }
}