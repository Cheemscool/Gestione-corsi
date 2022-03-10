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
    public partial class FrmInfoLezioni : Form
    {
        public FrmInfoLezioni(Lezione lezione)
        {
            InitializeComponent();
            LblMateria.Text = lezione.Materia;
            LblDocente.Text = lezione.Docente.Nome+" "+lezione.Docente.Cognome;
            LblDescrizione.Text = lezione.Descrizione;
            LblAula.Text = lezione.Aula.CodiceAula;
            LblData.Text = lezione.DateInizio + "" + lezione.DateFine;
            
        }
    }
}
