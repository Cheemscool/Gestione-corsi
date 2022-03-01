using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Studente : Persona
    {
        public Studente(string Nome, string Cognome, string Matricola) : base(Nome, Cognome)
        {
            this.Matricola = Matricola;
        }
        public string Matricola { get; }
    }
}
