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
        public List<Docente> Docenti { get; }
        public List<Aula> Aule { get; }

        public Corso(string nome, int edizione, List<Lezione> lezioni, List<Studente> studenti, List<Docente> docenti, List<Aula> aule)
        {
            Nome = nome;
            Edizione = edizione;
            Lezioni = lezioni;
            Studenti = studenti;
            Docenti = docenti;
            Aule = aule;
        }

        public void AggiungiLezione(Lezione lezione) => Lezioni.Add(lezione);
        public void AggiungiStudente(Studente studente) => Studenti.Add(studente);
        public void AggiungiDocente(Docente docente) => Docenti.Add(docente);
        public void AggiungiAula(Aula aula) => Aule.Add(aula);

        public override string ToString()
        {
            return Nome;
        }
    }
}