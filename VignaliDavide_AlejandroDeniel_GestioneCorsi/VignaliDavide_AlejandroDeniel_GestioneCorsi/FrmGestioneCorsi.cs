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
            Docente docente = new Docente("Ilgo", "Dimento", "Web Marketing");
            gestioneCorsi.Docenti.Add(docente);
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiDocente frmAggiungiDocente = new FrmAggiungiDocente(gestioneCorsi);
            frmAggiungiDocente.ShowDialog();
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiStudente frmAggiungiStudente = new FrmAggiungiStudente(gestioneCorsi);
            frmAggiungiStudente.ShowDialog();
        }

        private void corsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAggiungiCorso frmAggiungiCorso = new FrmAggiungiCorso(gestioneCorsi);
            frmAggiungiCorso.ShowDialog();
        }
    }
}