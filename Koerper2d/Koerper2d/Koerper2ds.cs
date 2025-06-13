using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koerper2d
{
    class Koerper2ds
    {
        private double breite;
        private double laenge;
        private string name;
        private double radius;
        private double hoehe;
        private double flaeche;

        public void setBreite(double breite)
        {
            this.breite = breite;
            this.setFlaeche();
        }

        public double getBreite()
        {
            return this.breite;
        }

        public void setLaenge(double laenge)
        {
            this.laenge = laenge;
            this.setFlaeche();
        }

        public double getLaenge()
        {
            return this.laenge;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
            this.setFlaeche();
        }

        public double getRadius()
        {
            return this.radius;
        }

        public void setHoehe(double hoehe)
        {
            this.hoehe = hoehe;
            this.setFlaeche();
        }

        public double getHoehe()
        {
            return this.hoehe;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setFlaeche()
        {
            if (hoehe != 0 && laenge != 0 && radius == 0)
            {
                this.flaeche = laenge * hoehe / 2;
                this.name = "Dreieck";
            }

            if (radius != 0 && breite == 0 && laenge == 0)
            {
                this.flaeche = radius * radius * 3.14;
                this.name = "Kreis";
            }
            
            if (laenge != 0 && breite != 0)
            {
                this.flaeche = breite * laenge;
                this.name = "Rechteck";
            }
        }

        public double getFlaeche()
        {
            return this.flaeche;
        }

    }
    
}
