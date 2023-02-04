using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassaforte_Oggietti.Mosconi
{
    public class Documenti: Oggetto
    {
        //attributi
        private string _tipo;

        //properties
        public string Tipo
        {
            get
            {
                return _tipo;
            }

            private set
            {
                if (value != null)
                    _tipo = value;
                else
                    throw new Exception("Tipo non valido");
            }
        }

        //costruttori

        //metodi
        public override float OttieniValoreAssicurato()
        {
            if (Valore >= 100)
                return 100;
            else
                return 50;
        }
    }
}
