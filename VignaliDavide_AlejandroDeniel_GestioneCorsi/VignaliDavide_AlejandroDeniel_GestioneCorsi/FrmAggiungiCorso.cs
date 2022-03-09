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

namespace GestioneCorsi.Library
{
    public partial class FrmAggiungiCorso : Form
    {
        Gestione gestioneCorsi;
        public FrmAggiungiCorso(Gestione gestione)
        {
            InitializeComponent();
            gestioneCorsi = gestione;

            foreach (Lezione lezioni in gestioneCorsi.Lezioni)
                ckdLstBoxLezioni.Items.Add(lezioni);
            ckdLstBoxLezioni.DataSource = null;
            ckdLstBoxLezioni.DataSource = gestioneCorsi.Lezioni;
        }

        private void btnAggiungiCorso_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text == "" || txtBoxEdizione.Text == "" || ckdLstBoxLezioni.CheckedItems == null)
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
            else
            {
                Close();
            }
        }
    }
}
