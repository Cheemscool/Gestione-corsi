using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class GestioneCorsi
    {
        public List<Corso> CorsoList { get; }

        public void AggiungiCorso(Corso corso)
        {
            CorsoList.Add(corso);
        }
    }
    public class Persona
    {
        public Persona(string Nome, string Cognome)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
        }

        public string Nome { get; }
        public string Cognome { get; }

    }
    public class Docenti: Persona
    {
        public Docenti(string Nome,string Cognome,string TitoloStudio) : base( Nome , Cognome )
        {
            this.TitoloStudio = TitoloStudio;
        }
        public string TitoloStudio { get; }
    }
    public class Studenti : Persona
    {
        public Studenti(string Nome, string Cognome, string Matricola) : base(Nome, Cognome)
        {
            this.Matricola = Matricola;
        }
        public string Matricola { get; }
    }
    public class Corso
    {
        public string Nome { get; }
        public int edizione { get; }
        public List<Lezione> LezioniList { get; }
        public List<Studenti> StudentiList { get; }

        public void AggiungiLezioni(Lezione lezione)
        {
            LezioniList.Add(lezione);
        }
        public void AggiungiStudenti(Studenti studenti)
        {
            StudentiList.Add(studenti);
        }
    }
    public class Lezione
    {
        public string Descrizione { get; }
        public DateTime DateInizio { get; }
        public DateTime DateFine { get; }

    }
    public class Aula
    {
        public string CodiceAula { get; }
        public double Capienza { get; }


    }

}
