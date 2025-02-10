using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoPrototyp
{
    internal class Konto
    {
        int kontoNr;
        double saldo;

        public void setKontoNr(int kontoNr)
        {
            this.kontoNr = kontoNr;
        }
        public int getKontoNr() 
        { 
            return this.kontoNr; 
        }
        public void auszahlen (double betrag)
        {
            saldo = saldo - betrag;
        }
        public void einzahlen (double betrag)
        {
            saldo = saldo + betrag;
        }
    }
}
