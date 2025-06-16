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
        
        //Rot Y=500; Grün Y=650; Blau  Y=800
        public Auto(int ypos, string farbe) 
        {
            this.ypos = ypos;
            this.farbe = farbe; 
            rnd = new Random();
        }
        public void setXpos(int xpos) 
        { 
            this.xpos=xpos;
        }
        public void setYpos(int ypos) 
        { 
            this.ypos=ypos; 
        }
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

        public void newPositon()
        {
            //this.xpos += 1;
            this.xpos += rnd.Next(1, 30);
        }
    }
}
