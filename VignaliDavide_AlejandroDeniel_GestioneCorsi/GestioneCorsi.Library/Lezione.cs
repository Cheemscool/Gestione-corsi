using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Lezione
    {
        public string Materia { get; }
        public string Descrizione { get; }
        public DateTime DataInizio { get; }
        public DateTime DataFine { get; }
        public Docente Docente { get; }
        public List<Studente> Presenti { get; }
        public Aula Aula { get; }

        public Lezione(string materia, string descrizione, DateTime dataInizio, DateTime dataFine, List<Studente> presenti, Docente docente, Aula aula)
        {
            Materia = materia;
            Descrizione = descrizione;
            DataInizio = dataInizio;
            DataFine = dataFine;
            Presenti = presenti;
            Docente = docente;
            Aula = aula;
        }

        public override string ToString()
        {
            return Materia;
        }
    }
}