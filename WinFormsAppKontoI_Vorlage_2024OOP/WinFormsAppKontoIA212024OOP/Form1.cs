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

            textBoxKontoNr.Text = meinKonto.getKontoNr().ToString(); //Erzeugung eines Test Kontos
            textBoxSaldo.Text = meinKonto.getSaldo().ToString();
            textBoxName.Text = meinKonto.getName();
            textBoxVorname.Text = meinKonto.getVorname();

        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        { 
            textBoxKontoNr.Text = ""; //L�schen der Konto und Saldo Nummern
            textBoxSaldo.Text = "";
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                Konto aktuellesKonto = kontenListe[currentKontoIndex]; //Anzeigen des Aktuellen Kontos
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
            //Tempor�res Konto-Objekt erstellen
            Konto neuesKonto = new Konto();

            //Daten aus Textboxen in das neue Konto-Objekt speichern
            try
            {
                neuesKonto.setKontoNr(int.Parse(textBoxKontoNr.Text));//Textboxen auslesen und Speichern
                neuesKonto.setSaldo(double.Parse(textBoxSaldo.Text));
                neuesKonto.setName(textBoxName.Text);
                neuesKonto.setVorname(textBoxVorname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einlesen der Daten: " + ex.Message + ". Konto nicht gespeichert.");
                return; // Abbruch, falls Fehler beim Einlesen
            }

            //Neues Konto-Objekt zur Liste hinzuf�gen
            kontenListe.Add(neuesKonto);

            //Index auf das neu hinzugef�gte Konto setzen
            currentKontoIndex = kontenListe.Count - 1;

            MessageBox.Show("Neues Konto gespeichert!");
            UpdateTextBoxesFromKonto(); // Textboxen mit den Daten des neuen Kontos aktualisieren
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dateipfad;//Datei Laden mit Dialog
            openFileDialog1.FileName = "kunden";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.ShowDialog();
            dateipfad = openFileDialog1.FileName;

            try
            {
                using (StreamReader sr = new StreamReader(dateipfad))
                {
                    int zaehler;//Einzelne objekte pro fileline
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
            string dateipfad;//Datei Speichern mit Dateidialog
            saveFileDialog1.FileName = "kunden";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.ShowDialog();
            dateipfad = saveFileDialog1.FileName;
            try
            {
                using (StreamWriter sw = new StreamWriter(dateipfad))
                {
                    sw.WriteLine(kontenListe.Count); //Anzahl der Konten
                    foreach (var konto in kontenListe)
                    {
                        sw.WriteLine(konto.getVorname());//Ein Objekt pro Line
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
            //Anzeigen des aktuellen Kontos aus der Liste, falls vorhanden
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
                //Leere Textboxen, wenn kein Konto ausgew�hlt ist (z.B. am Anfang)
                buttonLoeschen_Click(this, EventArgs.Empty); // Leert die Textboxen
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            //Vor zum n�chsten Konto in der Liste
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
            //Zur�ck zum vorherigen Konto in der Liste
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
