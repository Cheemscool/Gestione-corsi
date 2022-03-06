using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Corso
    {
        public string Nome { get; }
        public int Edizione { get; }
        public List<Lezione> Lezioni { get; }
        public List<Studente> Studenti { get; }

        public Corso(string nome, int edizione, List<Lezione> lezioni, List<Studente> studenti)
        {
            Nome = nome;
            Edizione = edizione;
            Lezioni = lezioni;
            Studenti = studenti;
        }

        public void AggiungiLezioni(Lezione lezione)
        {
            Lezioni.Add(lezione);
        }
        public void AggiungiStudenti(Studente studenti)
        {
            Studenti.Add(studenti);
        }
    }
}