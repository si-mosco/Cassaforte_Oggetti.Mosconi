using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassaforte_Oggietti.Mosconi
{
    public class CassettaSpeciale: CassettaSicurezza
    {
        public override float OttieniValoreAssicurato()
        {
            if (oggetto.GetType() == typeof(Gioielli))
                return oggetto.Valore * (float)0.9;
            else if (oggetto.GetType() == typeof(Documenti))
                return oggetto.Valore * (float)0.8;
            else if (oggetto.GetType() == typeof(Chiavi))
                return oggetto.Valore * (float)0.7;
            else
                throw new Exception("Oggetto non valido");
        }
    }
}
