// Dahrlensrechner.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double darlehnsbetrag, monatlicheTilgung, zinssatz, restDarlehen, gesamtTilgung;
    int jahr = 1, laufzeitInMonaten;

    cout << "Geben Sie den Darlehnsbetrag ein: ";
    cin >> darlehnsbetrag;

    cout << "Geben Sie die monatliche Tilgung ein: ";
    cin >> monatlicheTilgung;

    cout << "Geben Sie den Zinssatz in Prozent ein: ";
    cin >> zinssatz;

    laufzeitInMonaten = (int)(darlehnsbetrag / monatlicheTilgung * 12);

    restDarlehen = darlehnsbetrag;
    gesamtTilgung = 0;

    cout << "Jahr\tRestdarlehen\tGesamttilgung\n";
    while (restDarlehen > 0) {
        for (int monat = 1; monat <= 12 && restDarlehen > 0; monat++) {
            double zinsen = restDarlehen * (zinssatz / 100) / 12;
            double tilgung = monatlicheTilgung - zinsen;
            restDarlehen -= tilgung;
            gesamtTilgung += tilgung;
        }

        cout << jahr << "\t" << restDarlehen << "\t\t" << gesamtTilgung << endl;
        jahr++;
    }
}