using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class Aula
    {
        public string CodiceAula { get; }
        public int Capienza { get; }
        List<string> Risorse { get; }

        public Aula(string codiceAula, int capienza, List<string> risorse)
        {
            CodiceAula = codiceAula;
            Capienza = capienza;
            Risorse = risorse;
        }

        public void AggiungiRisorse(string Risorsa) => Risorse.Add(Risorsa);
    }
}
