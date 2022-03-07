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
    public partial class FrmGestioneCorsi : Form
    {
        Gestione gestioneCorsi;
        public FrmGestioneCorsi()
        {
            InitializeComponent();
            gestioneCorsi = new Gestione();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiDocente frmAggiungiDocente = new FrmAggiungiDocente(gestioneCorsi);
            frmAggiungiDocente.ShowDialog();
        }
    }
}