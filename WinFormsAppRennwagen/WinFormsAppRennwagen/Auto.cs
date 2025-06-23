using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppRennwagen
{
    internal class Auto
    {
        private int xpos=60;
        private int ypos=0;
        private string farbe;
        private bool aktiv;
        Random rnd;

        private bool bVerfuegbar = true;
        private int bAktiv = 0;
        
        //Rot Y=500; Grün Y=650; Blau  Y=800
        public Auto(int ypos, string farbe) 
        {
            this.ypos = ypos;
            this.farbe = farbe; 
            rnd = new Random();
        }
        #region Setter
        public void setXpos(int xpos) 
        { 
            this.xpos=xpos;
        }
        public void setYpos(int ypos) 
        { 
            this.ypos=ypos; 
        }
        #endregion
        #region Getter
        public int getYpos()
        {
            return ypos;
        }
        public int getXpos()
        {
            return xpos;
        }
        public string getFarbe()
        {
            return this.farbe;
        }
        #endregion

        #region Update-Methoden
        public bool newPositon()
        {
            int bewegung = rnd.Next(1, 30);
            bool bVerbraucht = false;

            if(bAktiv > 0)
            {
                bewegung *= 4;
                if(bewegung <= 15)
                {
                    bewegung = 15;
                }

                if(bAktiv == 1)
                {

                    bVerbraucht = true;
                }
                bAktiv -= 1;
            }
            this.xpos += bewegung;
            return bVerbraucht;
        }

        public void AktiviereBoost()
        {
            if (bVerfuegbar)
            {
                bAktiv = 5;
                bVerfuegbar = false;
            }
        }

        public bool IstBoostVerfuegbar()
        {
            return this.bVerfuegbar;
        }

        public void ResetBoost()
        {
            bVerfuegbar = true;
            bAktiv = 0;
        }
        #endregion
    }
}
