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
    public partial class Form1 : Form
    {
        Gestione gestioneCorsi;
        public Form1()
        {
            InitializeComponent();
            gestioneCorsi = new Gestione();
        }

    }
}