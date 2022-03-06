using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Studente : Persona
    {
        public string Matricola { get; }

        public Studente(string nome, string cognome, string matricola) : base(nome, cognome)
        {
            Matricola = matricola;
        }
    }
}
