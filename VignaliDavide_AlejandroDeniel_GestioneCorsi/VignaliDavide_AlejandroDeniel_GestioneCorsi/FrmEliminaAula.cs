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
    public partial class FrmEliminaAula : Form
    {
        Gestione gestioneCorsi;
        public FrmEliminaAula(Gestione corsi)
        {
            InitializeComponent();
            gestioneCorsi = corsi;

            foreach (Aula aula in gestioneCorsi.Aule)
                ckdListBoxAule.Items.Add(aula);
            ckdListBoxAule.DataSource = null;
            ckdListBoxAule.DataSource = gestioneCorsi.Aule;
            ckdListBoxAule.DisplayMember = "CodiceAula";
        }

        private void btnRimuoviAule_Click(object sender, EventArgs e)
        {
            if (ckdListBoxAule.SelectedItem == null)
            {
                MessageBox.Show("Non sono state selezionate aule da eliminare.");
                return;
            }

            foreach (Aula aula in ckdListBoxAule.CheckedItems)
                gestioneCorsi.Aule.Remove(aula);

            MessageBox.Show("Sono stati rimosse le aule selezionati.");
            Close();
        }
    }
}
