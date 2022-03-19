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
        public DateTime DateInizio { get; }
        public DateTime DateFine { get; }
        public Docente Docente { get; }
        private List<Studente> Presenti;
        public Aula Aula { get; }

        public Lezione(string materia,string descrizione, DateTime dateFine, List<Studente> presenti,Docente docente,Aula aula)
        {
            Materia = materia;
            Descrizione = descrizione;
            DateInizio = DateTime.Now;
            DateFine = dateFine;
            Presenti = presenti;
            Docente = docente;
            Aula = aula;
        }

        public void SegnaPresenti(List<Studente> presenti) => Presenti = presenti;

        public override string ToString()
        {
            return Materia;
        }
    }
}
