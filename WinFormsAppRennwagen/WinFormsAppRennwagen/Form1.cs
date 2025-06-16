namespace WinFormsAppRennwagen
{

    public partial class Form1 : Form
    {

        Auto AutoRot;
        Auto AutoGruen;
        Auto AutoBlau;
        Controller meinController;

        public Form1()
        {
            AutoRot = new Auto(305, "rot");
            AutoGruen = new Auto(400, "gruen");
            AutoBlau = new Auto(500, "blau");
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            meinController = new Controller(pictureAutoRot, pictureAutoGruen, pictureAutoBlau ,AutoRot, AutoGruen, AutoBlau);
            meinController.start();
            await Task.Delay(10000); // 10 Sekunden warten  
            //meinController.stop();
        }
    }
}
