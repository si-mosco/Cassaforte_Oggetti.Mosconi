using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassaforte_Oggietti.Mosconi
{
    public class CassettaSicurezza
    {
        //attributi
        private string _produttore;
        private string _codiceseriale;
        private string _pin;
        private string _codicesblocco;
        private Oggetto _oggetto;

        //properties
        public string Produttore
        {
            get
            {
                return _produttore;
            }

            private set
            {
                if (value != null)
                    _produttore = value;
                else
                    throw new Exception("Produttore non valido");
            }
        }
        public string CodiceSeriale
        {
            get
            {
                return _codiceseriale;
            }

            private set
            {
                if (value != null)
                    _codiceseriale = value;
                else
                    throw new Exception("Codice seriale non valido");
            }
        }
        private string Pin
        {
            get
            {
                return _pin;
            }

            set
            {
                if (value != null || value.Length==5)
                    try
                    {
                        int prova = int.Parse(value);
                        _pin = value;
                    }
                    catch
                    {
                        throw new Exception("Pin non valido");
                    }
                    
            }
        }
        private string CodiceSblocco
        {
            get
            {
                return _codicesblocco;
            }

            set
            {
                if (value != null)
                    _codicesblocco = value;
                else
                    throw new Exception("Codice di sblocco non valido");
            }
        }
        public Oggetto oggetto
        {
            get
            {
                return _oggetto;
            }
            private set
            {
                if (value != null)
                    _oggetto = value;
                else
                    throw new Exception("Oggetto non valido");
            }
        }

        //costruttori

        //metodi
        public void Inserisci(string pin, Oggetto Oggetto1)
        {
            if (pin == this.Pin)
                this.oggetto = Oggetto1;
        }
        public void Rimuovi(string pin)
        {
            if (pin == this.Pin)
                this._oggetto = null;
        }
        public bool Stato()
        {
            if (this.oggetto == null)
                return false;
            else
                return true;
        }
        public void CambiaPin(string pin, string codicedisblocco)
        {
            if (codicedisblocco == this.CodiceSblocco)
                this.Pin = pin;
        }
        public virtual float OttieniValoreAssicurato()
        {
            if (this.Stato())
                return oggetto.Valore;
            return 0;
        }
    }
}
