// Konto.cs
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
        private string name; // Neu: Attribut Name
        private string vorname; // Neu: Attribut Vorname

        public void setKontoNr(int kontoNr)
        {
            this.kontoNr = kontoNr;
        }
        public void setSaldo(double saldo)
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
        public void auszahlen(double betrag)
        {
            saldo = saldo - betrag;
        }
        public void einzahlen(double betrag)
        {
            saldo = saldo + betrag;
        }

        // Neue Getter und Setter Methoden für Name und Vorname
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getVorname()
        {
            return this.vorname;
        }
        public void setVorname(string vorname)
        {
            this.vorname = vorname;
        }
    }
}