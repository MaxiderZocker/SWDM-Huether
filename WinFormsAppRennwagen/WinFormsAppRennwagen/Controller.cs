using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppRennwagen
{
    internal class Controller
    {
        private Form1 hauptformular;
        private System.Windows.Forms.PictureBox pictureAutoGruen;
        private System.Windows.Forms.PictureBox pictureAutoRot;
        private System.Windows.Forms.PictureBox pictureAutoBlau;
        Auto AutoRot;
        Auto AutoGruen;
        Auto AutoBlau;

        bool running = true;
        private int gewinner = 0;

        int pRot;
        int pGruen;
        int pBlau;

        public Controller(Form1 form, object pictureAutoRot, object pictureAutoGruen, object pictureAutoBlau, Auto a1, Auto a2, Auto a3,int currentPRot, int currentPGruen, int currentPBlau) 
        {
            this.hauptformular = form;
            this.pictureAutoRot = (PictureBox)pictureAutoRot;
            this.pictureAutoGruen = (PictureBox)pictureAutoGruen;
            this.pictureAutoBlau = (PictureBox)pictureAutoBlau;
            this.AutoRot = a1;
            this.AutoGruen = a2;
            this.AutoBlau = a3;
            this.pRot = currentPBlau;
            this.pGruen = currentPGruen;
            this.pBlau = currentPBlau;

        }

        public void stop()
        {
            running = false;
        }
        public void start()
        {
            Thread meinThread = new Thread(new ThreadStart(run));
            meinThread.Start();
        }

        public void run()
        {

            while (running)
            {
                bool rotBVerbraucht = AutoRot.newPositon();
                bool gruenBVerbraucht = AutoGruen.newPositon();
                bool blauBVerbraucht = AutoBlau.newPositon();

                if(rotBVerbraucht || gruenBVerbraucht || blauBVerbraucht)
                {
                    hauptformular.OnBVerbraucht();
                }

                UpdatePictureBox(pictureAutoRot, AutoRot);
                UpdatePictureBox(pictureAutoGruen, AutoGruen);
                UpdatePictureBox(pictureAutoBlau, AutoBlau);

                #region Gewinner-Logik
                if (AutoRot.getXpos()>=856)
                {
                    running = false;
                    gewinner = 1;
                    pRot += 1;
                    hauptformular.UpdateScore(pRot,pGruen,pBlau);
                    hauptformular.ShowWinner(AutoRot.getFarbe());
                }
                else if(AutoGruen.getXpos() >= 856)
                {
                    running = false;
                    gewinner = 2;
                    pGruen += 1;
                    hauptformular.UpdateScore(pRot, pGruen, pBlau);
                    hauptformular.ShowWinner(AutoGruen.getFarbe());

                }
                else if(AutoBlau.getXpos() >= 856)
                {
                    running = false;
                    gewinner = 3;
                    pBlau += 1;
                    hauptformular.UpdateScore(pRot, pGruen, pBlau);
                    hauptformular.ShowWinner(AutoBlau.getFarbe());
                }
                #endregion

                Thread.Sleep(500);
            }


        }
        public void UpdatePictureBox(PictureBox picture, Auto auto)
        {
            if (picture.InvokeRequired)
            {
                picture.Invoke((MethodInvoker)(() =>
                {
                    picture.Location = new System.Drawing.Point(auto.getXpos(), auto.getYpos());
                }));
            }
            else
            {
                picture.Location = new System.Drawing.Point(auto.getXpos(), auto.getYpos());
            }
        }
    }
}
