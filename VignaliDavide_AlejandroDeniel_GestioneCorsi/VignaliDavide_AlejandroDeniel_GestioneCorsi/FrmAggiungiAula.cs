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
    public partial class FrmAggiungiAula : Form
    {
        Gestione gestioneCorsi;
        int capienza;
        List<string> risorse = new List<string>();
        public FrmAggiungiAula(Gestione gestione)
        {
            InitializeComponent();
            gestioneCorsi = gestione;
        }

        private void btnAggiungiDocente_Click(object sender, EventArgs e)
        {
            if (txtBoxCodiceAula.Text == "" || txtBoxCapienza.Text == "" || ckdListBoxRisorse.CheckedItems == null)
            {
                MessageBox.Show("Per procedere devi compilare tutti i campi.");
                return;
            }

            if (!Int32.TryParse(txtBoxCapienza.Text, out capienza))
            {
                MessageBox.Show("Devi inserire un numero per la capienza");
                return;
            }

            ckdListBoxRisorse.DataSource = null;
            ckdListBoxRisorse.DataSource = risorse;

            Aula aula = new Aula(txtBoxCodiceAula.Text, capienza, risorse);
            gestioneCorsi.Aule.Add(aula);
            MessageBox.Show($"L'aula {txtBoxCodiceAula.Text} è stata aggiunta.");
            Close();
        }

        private void btnAggiungiRisorsa_Click(object sender, EventArgs e)
        {
            string stringa = Microsoft.VisualBasic.Interaction.InputBox("Aggiungi una risorsa");
            if (Int32.TryParse(stringa, out capienza))
            {
                MessageBox.Show("La risorsa non è un numero.");
                return;
            }

            risorse.Add(stringa);
            ckdListBoxRisorse.Items.Add(stringa);
            MessageBox.Show(stringa + " è stata aggiunta come risorsa.");
        }
    }
}