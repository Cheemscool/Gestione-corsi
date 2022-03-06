using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Docente : Persona
    {
        public string TitoloStudio { get; }

        public Docente(string nome, string cognome, string titoloStudio) : base(nome, cognome)
        {
            TitoloStudio = titoloStudio;
        }
    }
}