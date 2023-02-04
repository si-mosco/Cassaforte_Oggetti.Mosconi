using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassaforte_Oggietti.Mosconi
{
    abstract class Oggetto
    {
        //attributi
        private string _id;
        private float _valore;

        //properties
        public string Id
        {
            get
            {
                return _id;
            }

            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Id non valido");
            }
        }
        public float Valore
        {
            get
            {
                return _valore;
            }

            private set
            {
                if (value >=0)
                    _valore = value;
                else
                    throw new Exception("Valore non valido");
            }
        }

        //costruttori

        //metodi
        public virtual float OttieniValoreAssicurato()
        {
            return Valore;  
        }
    }
}
