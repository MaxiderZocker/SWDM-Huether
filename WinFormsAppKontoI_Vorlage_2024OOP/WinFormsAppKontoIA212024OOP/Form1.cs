namespace WinFormsAppKontoIA212024OOP
{
    public partial class Form1 : Form
    {
        Konto meinKonto;
        List<Konto> kontenListe;
        private int currentKontoIndex = -1;
        public Form1()
        {

            InitializeComponent();
            kontenListe = new List<Konto>();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // List<Konto> kontenListe = new List<Konto>();

            meinKonto = new Konto(); //Erzeugung des Objektes meinKonto
            meinKonto.setKontoNr(1234); //Verwendung der Methode setKontoNr
            meinKonto.setSaldo(200);
            meinKonto.setName("Mustermann");
            meinKonto.setVorname("Jasmin");

            textBoxKontoNr.Text = meinKonto.getKontoNr().ToString();
            textBoxSaldo.Text = meinKonto.getSaldo().ToString();
            textBoxName.Text = meinKonto.getName();
            textBoxVorname.Text = meinKonto.getVorname();

        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            textBoxKontoNr.Text = "";
            textBoxSaldo.Text = "";
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                Konto aktuellesKonto = kontenListe[currentKontoIndex];
                aktuellesKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));
                aktuellesKonto.setSaldo(double.Parse(textBoxSaldo.Text));
                aktuellesKonto.setVorname(textBoxVorname.Text);
                aktuellesKonto.setName(textBoxName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einlesen der Daten: " + ex.Message + ". Bestehendes Konto nicht gespeichert.");
                return; // Abbruch, falls Fehler beim Einlesen
            }

            MessageBox.Show("Konto Aktualisiert!");

            UpdateTextBoxesFromKonto();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // **Neu:** Temporäres Konto-Objekt erstellen
            Konto neuesKonto = new Konto();

            // **Neu:** Daten aus Textboxen in das neue Konto-Objekt speichern
            try
            {
                neuesKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));
                neuesKonto.setSaldo(double.Parse(textBoxSaldo.Text));
                neuesKonto.setName(textBoxName.Text);
                neuesKonto.setVorname(textBoxVorname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einlesen der Daten: " + ex.Message + ". Konto nicht gespeichert.");
                return; // Abbruch, falls Fehler beim Einlesen
            }

            // **Neu:** Neues Konto-Objekt zur Liste hinzufügen
            kontenListe.Add(neuesKonto);

            // **Neu:** Index auf das neu hinzugefügte Konto setzen
            currentKontoIndex = kontenListe.Count - 1;

            MessageBox.Show("Neues Konto gespeichert!");
            UpdateTextBoxesFromKonto(); // Textboxen mit den Daten des neuen Kontos aktualisieren
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateipfad = "konten.txt";
            try
            {
                using (StreamReader sr = new StreamReader(dateipfad))
                {
                    int zaehler;
                    zaehler = int.Parse(sr.ReadLine());
                    for (var i = 0; i < zaehler; i++)
                    {
                        Konto kontotemp = new Konto();
                        kontotemp.setVorname(sr.ReadLine());
                        kontotemp.setName(sr.ReadLine());
                        kontotemp.setKontoNr(int.Parse(sr.ReadLine()));
                        kontotemp.setSaldo(double.Parse(sr.ReadLine()));
                        //sr.ReadLine();
                        kontenListe.Add(kontotemp);

                    }
                    sr.Close();
                }
                MessageBox.Show("Datei erfolgreich gelesen", "Erfolgreich", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Datei nicht gelesen", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateipfad = "konten.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(dateipfad))
                {
                    sw.WriteLine(kontenListe.Count); //Anzahl der Konten
                    foreach (var konto in kontenListe)
                    {
                        sw.WriteLine(konto.getVorname());
                        sw.WriteLine(konto.getName());
                        sw.WriteLine(konto.getKontoNr().ToString());
                        sw.WriteLine(konto.getSaldo().ToString());

                    }
                    sw.Close();
                }
                MessageBox.Show("Datei erfolgreich gespeichert", "Erfolgreich", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datei nicht gespeichert", "Fehler", MessageBoxButtons.OK);
            }
        }

        private void UpdateTextBoxesFromKonto()
        {
            // **Neu:** Anzeigen des aktuellen Kontos aus der Liste, falls vorhanden
            if (currentKontoIndex >= 0 && currentKontoIndex < kontenListe.Count)
            {
                Konto aktuellesKonto = kontenListe[currentKontoIndex];
                textBoxKontoNr.Text = aktuellesKonto.getKontoNr().ToString();
                textBoxSaldo.Text = aktuellesKonto.getSaldo().ToString();
                textBoxVorname.Text = aktuellesKonto.getVorname();
                textBoxName.Text = aktuellesKonto.getName();
            }
            else
            {
                // **Neu:** Leere Textboxen, wenn kein Konto ausgewählt ist (z.B. am Anfang)
                buttonLoeschen_Click(this, EventArgs.Empty); // Leert die Textboxen
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            // **Neu:** Vor zum nächsten Konto in der Liste
            if (kontenListe.Count == 0)
            {
                MessageBox.Show("Keine Konten vorhanden.");
                return;
            }

            if (currentKontoIndex < kontenListe.Count - 1)
            {
                currentKontoIndex++;
                UpdateTextBoxesFromKonto();
            }
            else
            {
                MessageBox.Show("Sie sind bereits am Ende der Konto-Liste.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // **Neu:** Zurück zum vorherigen Konto in der Liste
            if (kontenListe.Count == 0)
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
    }
}
