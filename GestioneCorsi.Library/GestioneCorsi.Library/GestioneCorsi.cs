using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneCorsi.Library
{
    public class GestioneCorsi
    {
        public List<Corso> Corsi { get; }

        public void AggiungiCorso(Corso corso)
        {
            Corsi.Add(corso);
        }
    }
}
