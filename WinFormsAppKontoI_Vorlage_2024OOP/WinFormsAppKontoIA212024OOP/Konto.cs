using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppKontoIA212024OOP
{
    internal class Konto
    {
        private int kontoNr;
        private double saldo;
        private string Vorname;
        private string Name;

        public void setKontoNr(int kontoNr)
        {
            this.kontoNr = kontoNr;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public int getKontoNr()
        {
            return this.kontoNr;
        }

        public string setVorname(string Vorname)
        {
            return this.Vorname = Vorname;
        }

        public string getVorname()
        {
            return this.Vorname;
        }

        public string setName(string Name)
        {
            return this.Name = Name;
        }

        public string getName()
        {
            return this.Name;
        }
        public void zahleEin(double betrag)
        {
            this.saldo += betrag; //this.saldo = saldo +betrag
        }

        public int zahleAus(double betrag)
        {
            if (saldo - betrag < 0)
            {
                return 0;
            }
            else
            {
                this.saldo -= betrag;
                return 1;
            }

        }
    }
}
