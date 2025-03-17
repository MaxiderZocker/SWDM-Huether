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
using KontoPrototypErweiterung2;

namespace KontoPrototyp
{
    public partial class Form1 : Form
    {
        // **Neu:** Liste für Konto-Objekte erstellen
        private List<Konto> kontoListe;
        // **Neu:** Index für das aktuelle Konto in der Liste
        private int currentKontoIndex = -1;


        Konto meinKonto;
        public Form1()
        {
            InitializeComponent();
            // **Neu:** Liste im Konstruktor instanziieren
           kontoListe = new List<Konto>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Konto meinKonto = new Konto();
            meinKonto.setKontoNr(1234);
            meinKonto.setSaldo(10);
            meinKonto.setName("Mustermann");
            meinKonto.setVorname("Max");

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
            textBoxVorname.Text = "";
            textBoxNachname.Text = "";
        }

        private void buttonSpeichernAenderung_Click(object sender, EventArgs e)
        {
            try
            {
                meinKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));
                meinKonto.setSaldo(double.Parse(textBoxSaldo.Text));
                meinKonto.setName(textBoxNachname.Text);
                meinKonto.setVorname(textBoxVorname.Text);
                MessageBox.Show("Änderungen am aktuellen Konto gespeichert!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Änderungen: " + ex.Message);
            }
        }

        private void buttonSpeichernNeuesKonto_Click(object sender, EventArgs e)
        {
            // **Neu:** Temporäres Konto-Objekt erstellen
            Konto neuesKonto = new Konto();

            // **Neu:** Daten aus Textboxen in das neue Konto-Objekt speichern
            try
            {
                neuesKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));
                neuesKonto.setSaldo(double.Parse(textBoxSaldo.Text));
                neuesKonto.setName(textBoxNachname.Text);
                neuesKonto.setVorname(textBoxVorname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einlesen der Daten: " + ex.Message + ". Konto nicht gespeichert.");
                return; // Abbruch, falls Fehler beim Einlesen
            }

            // **Neu:** Neues Konto-Objekt zur Liste hinzufügen
            kontoListe.Add(neuesKonto);

            // **Neu:** Index auf das neu hinzugefügte Konto setzen
            currentKontoIndex = kontoListe.Count - 1;

            MessageBox.Show("Neues Konto gespeichert!");
            UpdateTextBoxesFromKonto(); // Textboxen mit den Daten des neuen Kontos aktualisieren
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            // **Neu:** Zurück zum vorherigen Konto in der Liste
            if (kontoListe.Count == 0)
            {
                MessageBox.Show("Keine Konten vorhanden.");
                return;
            }

            if (currentKontoIndex > 0)
            {
                currentKontoIndex--;
                UpdateTextBoxesFromKonto();
            }
            else
            {
                MessageBox.Show("Sie sind bereits am Anfang der Konto-Liste.");
            }
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            // **Neu:** Vor zum nächsten Konto in der Liste
            if (kontoListe.Count == 0)
            {
                MessageBox.Show("Keine Konten vorhanden.");
                return;
            }

            if (currentKontoIndex < kontoListe.Count - 1)
            {
                currentKontoIndex++;
                UpdateTextBoxesFromKonto();
            }
            else
            {
                MessageBox.Show("Sie sind bereits am Ende der Konto-Liste.");
            }
        }


        private void UpdateTextBoxesFromKonto()
        {
            // **Neu:** Anzeigen des aktuellen Kontos aus der Liste, falls vorhanden
            if (currentKontoIndex >= 0 && currentKontoIndex < kontoListe.Count)
            {
                Konto aktuellesKonto = kontoListe[currentKontoIndex];
                textBoxKontoNr.Text = aktuellesKonto.getKontoNr().ToString();
                textBoxSaldo.Text = aktuellesKonto.getSaldo().ToString();
                textBoxVorname.Text = aktuellesKonto.getVorname();
                textBoxNachname.Text = aktuellesKonto.getName();
            }
            else
            {
                // **Neu:** Leere Textboxen, wenn kein Konto ausgewählt ist (z.B. am Anfang)
                buttonLoeschen_Click(this, EventArgs.Empty); // Leert die Textboxen
            }
        }
    }
}