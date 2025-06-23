namespace WinFormsAppRennwagen
{

    public partial class Form1 : Form
    {

        Auto AutoRot;
        Auto AutoGruen;
        Auto AutoBlau;
        Controller meinController;

        private int pRot = 0;
        private int pGruen = 0;
        private int pBlau = 0;
        private const int START_X_POS = 60;
        private Auto aktivesBAuto = null;

        public Form1()
        {
            AutoRot = new Auto(305, "rot");
            AutoGruen = new Auto(400, "gruen");
            AutoBlau = new Auto(500, "blau");
            InitializeComponent();

            pictureAutoRot.Location = new Point(START_X_POS, AutoRot.getYpos());
            pictureAutoGruen.Location = new Point(START_X_POS, AutoGruen.getYpos());
            pictureAutoBlau.Location = new Point(START_X_POS, AutoBlau.getYpos());

            buttonBoostBlau.Enabled = false;
            buttonBoostGruen.Enabled = false;
            buttonBoostBlau.Enabled = false;
        }

        #region Control-Buttos Eventhandler
        private async void button1_Click(object sender, EventArgs e)
        {
            if(AutoRot.IstBoostVerfuegbar())buttonBoostRot.Enabled = true;
            if(AutoGruen.IstBoostVerfuegbar()) buttonBoostGruen.Enabled = true;
            if(AutoBlau.IstBoostVerfuegbar()) buttonBoostBlau.Enabled = true;

            meinController = new Controller(this, pictureAutoRot, pictureAutoGruen, pictureAutoBlau, AutoRot, AutoGruen, AutoBlau, pRot, pGruen, pBlau);
            meinController.start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            meinController?.stop();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            meinController?.stop();

            AutoRot.ResetBoost();
            AutoGruen.ResetBoost();
            AutoBlau.ResetBoost();

            AutoRot.setXpos(START_X_POS);
            AutoGruen.setXpos(START_X_POS);
            AutoBlau.setXpos(START_X_POS);

            pictureAutoRot.Location = new Point(START_X_POS, AutoRot.getYpos());
            pictureAutoGruen.Location = new Point(START_X_POS, AutoGruen.getYpos());
            pictureAutoBlau.Location = new Point(START_X_POS, AutoBlau.getYpos());

            aktivesBAuto = null;
            labelGewinner.Visible = false;

            buttonBoostRot.Enabled = false;
            buttonBoostGruen.Enabled = false;
            buttonBoostBlau.Enabled = false;

            /*AutoRot.setXpos(305);
            AutoGruen.setXpos(400);
            AutoBlau.setXpos(500);

            meinController.UpdatePictureBox(pictureAutoRot, AutoRot);
            meinController.UpdatePictureBox(pictureAutoGruen, AutoGruen);
            meinController.UpdatePictureBox(pictureAutoBlau, AutoBlau);*/

        }
        #endregion

        #region Boost-Buttons Event Handler
        private void buttonBoostRot_Click(object sender, EventArgs e)
        {
            if (aktivesBAuto == null && AutoRot.IstBoostVerfuegbar())
            {
                aktivesBAuto = AutoRot;
                AutoRot.AktiviereBoost();
                DeaktiviereAlleBButtons();
                labelGewinner.Text = "Boost für Rot aktiv!";
                labelGewinner.Visible = true;
            }
        }

        private void buttonBoostGruen_Click(object sender, EventArgs e)
        {
            if (aktivesBAuto == null && AutoGruen.IstBoostVerfuegbar())
            {
                aktivesBAuto = AutoGruen;
                AutoGruen.AktiviereBoost();
                DeaktiviereAlleBButtons();
                labelGewinner.Text = "Boost für Grün aktiv!";
                labelGewinner.Visible = true;
            }
        }

        private void buttonBoostBlau_Click(object sender, EventArgs e)
        {
            if (aktivesBAuto == null && AutoBlau.IstBoostVerfuegbar())
            {
                aktivesBAuto = AutoBlau;
                AutoBlau.AktiviereBoost();
                DeaktiviereAlleBButtons();
                labelGewinner.Text = "Boost für Blau aktiv!";
                labelGewinner.Visible = true;
            }
        }

        private void DeaktiviereAlleBButtons()
        {
            buttonBoostRot.Enabled = false;
            buttonBoostGruen.Enabled = false;
            buttonBoostBlau.Enabled = false;
        }
        #endregion

        public void OnBVerbraucht()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)OnBVerbraucht);
                return;
            }

            aktivesBAuto = null;
            labelGewinner.Visible = false;

            if (AutoRot.IstBoostVerfuegbar()) buttonBoostRot.Enabled = true;
            if (AutoGruen.IstBoostVerfuegbar()) buttonBoostGruen.Enabled = true;
            if (AutoBlau.IstBoostVerfuegbar()) buttonBoostBlau.Enabled = true;
        }

        #region Update-Methoden
        public void UpdateScore(int newTotalRot, int newTotalGruen, int newTotalBlau)
        {
            this.pRot = newTotalRot;
            this.pGruen = newTotalGruen;
            this.pBlau = newTotalBlau;

            if (pRotBox.InvokeRequired)
            {
                pRotBox.Invoke((MethodInvoker)(() =>
                {
                    pRotBox.Text = this.pRot.ToString();
                    pGruenBox.Text = this.pGruen.ToString();
                    pBlauBox.Text = this.pBlau.ToString();
                }));
            }
            else
            {
                pRotBox.Text = this.pRot.ToString();
                pGruenBox.Text = this.pGruen.ToString();
                pBlauBox.Text = this.pBlau.ToString();
            }
        }
        public async void ShowWinner(string winnerColor)
        {
            // UI-Update aus dem Controller-Thread heraus
            labelGewinner.Invoke((MethodInvoker)(() =>
            {
                if (winnerColor == "rot")
                {
                    labelGewinner.Text = $"Auto Rot hat gewonnen!";
                }
                else if (winnerColor == "gruen")
                {
                    labelGewinner.Text = $"Auto Grün hat gewonnen!";
                }
                else if (winnerColor == "blau")
                {
                    labelGewinner.Text = $"Auto Blau hat gewonnen!";
                }
                labelGewinner.Visible = true;
            }));

            // 5 Sekunden warten
            await Task.Delay(5000);

            // UI-Update zum Ausblenden
            labelGewinner.Invoke((MethodInvoker)(() =>
            {
                labelGewinner.Visible = false;
            }));
        }
        #endregion    
    }
}
