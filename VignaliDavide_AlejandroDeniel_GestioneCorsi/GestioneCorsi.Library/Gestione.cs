using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Gestione
    {
        public List<Corso> Corsi { get; }
        public List<Studente> Studenti { get; }
        public List<Docente> Docenti { get; }

        public Gestione()
        {
            Corsi = new List<Corso>();
            Studenti = new List<Studente>();
            Docenti = new List<Docente>();
        }

        public void AggiungiCorso(Corso corso) => Corsi.Add(corso);
    }
}