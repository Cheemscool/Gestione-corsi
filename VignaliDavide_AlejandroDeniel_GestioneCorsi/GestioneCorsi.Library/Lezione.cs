using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Lezione
    {
        public string Descrizione { get; }
        public DateTime DateInizio { get; }
        public DateTime DateFine { get; }
        private List<Studente> Presenti;

        public Lezione(string descrizione, DateTime dateInizio, DateTime dateFine, List<Studente> presenti)
        {
            Descrizione = descrizione;
            DateInizio = dateInizio;
            DateFine = dateFine;
            Presenti = presenti;
        }

        public void SegnaPresenti(List<Studente> presenti) => Presenti = presenti;
    }
}
