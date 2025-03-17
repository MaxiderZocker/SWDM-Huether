// Form1.cs
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
            meinKonto.setName("Mustermann"); // Optional: Set initial name for testing
            meinKonto.setVorname("Max"); // Optional: Set initial vorname for testing

            // Optional: Display initial values in TextBoxes on load if needed for testing
            UpdateTextBoxesFromKonto();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            UpdateTextBoxesFromKonto();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            textBoxKontoNr.Text = "";
            textBoxSaldo.Text = "";
            textBoxVorname.Text = ""; // Clear Vorname TextBox
            textBoxNachname.Text = ""; // Clear Nachname TextBox
        }

        private void buttonSpeichernAenderung_Click(object sender, EventArgs e)
        {
            try
            {
                meinKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));
                meinKonto.setSaldo(double.Parse(textBoxSaldo.Text));
                meinKonto.setName(textBoxNachname.Text); // Save Name from TextBox
                meinKonto.setVorname(textBoxVorname.Text); // Save Vorname from TextBox
                MessageBox.Show("Änderungen gespeichert!"); // Optional feedback
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Änderungen: " + ex.Message);
            }
        }

        private void buttonSpeichernNeuesKonto_Click(object sender, EventArgs e)
        {
            meinKonto = new Konto(); // Create a new Konto object
            buttonLoeschen_Click(sender, e); // Clear the TextBoxes for new input
            MessageBox.Show("Bereit für ein neues Konto!"); // Optional feedback
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            // Implement logic for "Zurück" (previous account) if needed.
            // For now, it's empty.
            MessageBox.Show("Funktion 'Zurück' noch nicht implementiert."); // Optional feedback
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            // Implement logic for "Vor" (next account) if needed.
            // For now, it's empty.
            MessageBox.Show("Funktion 'Vor' noch nicht implementiert."); // Optional feedback
        }


        private void UpdateTextBoxesFromKonto()
        {
            textBoxKontoNr.Text = meinKonto.getKontoNr().ToString();
            textBoxSaldo.Text = meinKonto.getSaldo().ToString();
            textBoxVorname.Text = meinKonto.getVorname(); // Display Vorname
            textBoxNachname.Text = meinKonto.getName();   // Display Name
        }
    }
}