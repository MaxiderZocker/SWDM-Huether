using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoPrototyp
{
    internal class Konto
    {
        private int kontoNr;
        private double saldo;

        public void setKontoNr(int kontoNr)
        {
            this.kontoNr = kontoNr;
        }
        public void setSaldo (double saldo)
        {
            this.saldo = saldo;
        }
        public int getKontoNr() 
        { 
            return this.kontoNr; 
        }
        public double getSaldo()
        {
            return this.saldo;
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
