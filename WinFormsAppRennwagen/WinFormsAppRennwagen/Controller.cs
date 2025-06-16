using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppRennwagen
{
    internal class Controller
    {
        private System.Windows.Forms.PictureBox pictureAutoGruen;
        private System.Windows.Forms.PictureBox pictureAutoRot;
        private System.Windows.Forms.PictureBox pictureAutoBlau;
        Auto AutoRot;
        Auto AutoGruen;
        Auto AutoBlau;

        bool running = true;

        public Controller(object pictureAutoRot, object pictureAutoGruen, object pictureAutoBlau, Auto a1, Auto a2, Auto a3) 
        { 
            this.pictureAutoRot = (PictureBox)pictureAutoRot;
            this.pictureAutoGruen = (PictureBox)pictureAutoGruen;
            this.pictureAutoBlau = (PictureBox)pictureAutoBlau;
            this.AutoRot = a1;
            this.AutoGruen = a2;
            this.AutoBlau = a3;

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
                    AutoRot.newPositon();
                    AutoGruen.newPositon();
                    AutoBlau.newPositon();

                    UpdatePictureBox(pictureAutoRot, AutoRot);
                    UpdatePictureBox(pictureAutoGruen, AutoGruen);
                    UpdatePictureBox(pictureAutoBlau, AutoBlau);

                    Thread.Sleep(500);
                }


        }
        private void UpdatePictureBox(PictureBox picture, Auto auto)
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
