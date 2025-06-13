using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koerper2d
{
    class Koerper3d:Koerper2ds
    {
        double hoehe3d;
        double volumen;

        public void setHoehe3d(double hoehe3d)
        {
            this.hoehe3d = hoehe3d;
            this.setVolumen();
        }

        public double getHoehe3d()
        {
            return this.hoehe3d;
        }

        public double getVolumen()
        {
            return this.volumen;
        }

        public void setVolumen()
        {
            this.volumen = this.getFlaeche() * this.getHoehe3d();
        }
    }
}
