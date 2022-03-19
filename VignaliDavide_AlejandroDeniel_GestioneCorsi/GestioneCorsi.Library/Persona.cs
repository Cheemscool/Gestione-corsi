using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Persona
    {
        public string Nome { get; }
        public string Cognome { get; }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}";
        }
    }
}