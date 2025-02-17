using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontoPrototyp
{
    public partial class Form1 : Form
    {
        Konto meinKonto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            meinKonto = new Konto();
            meinKonto.setKontoNr(1234);
            meinKonto.setSaldo(10);
        }

        private void anzeigen_Click(object sender, EventArgs e)
        {
            textBoxKontoNr.Text = meinKonto.getKontoNr().ToString();
            textBoxSaldo.Text = meinKonto.getSaldo().ToString();
        }

        private void loeschen_Click(object sender, EventArgs e)
        {
            textBoxKontoNr.Text = "";
            textBoxSaldo.Text = "";
        }

        private void speichern_Click(object sender, EventArgs e)
        {
            meinKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));
            meinKonto.setSaldo(double.Parse(textBoxSaldo.Text));
        }
    }
}
