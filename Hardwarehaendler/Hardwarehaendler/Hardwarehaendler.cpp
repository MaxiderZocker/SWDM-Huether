// Hardwarehaendler.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;

int main()
{
    int kategorie;
    double anzahl, preis, rabatt, rabattpreis, rabatteur, netto, brutto, mwst;
    cout << "Geben Sie die anzahl der Produkte ein: ";
    cin >> anzahl;
    cout << "Geben sie den Einzelpreis des Produktes an: ";
    cin >> preis;
    cout << "Geben sie Ihre Kategorie an: ";
    cin >> kategorie;

    switch (kategorie) {

        case 1:
            rabatt = 10;
            break;

        case 2:
            rabatt = 12;
            break;

        case 3:
            rabatt = 15;
            break;

        case 4:
            rabatt = 20;
            break;

        case 5:
            rabatt = 30;
            break;

        default:
            rabatt = 0;
            break;
    }

    netto = preis * anzahl;
    rabattpreis = netto - netto * (rabatt / 100);
    rabatteur = netto * (rabatt / 100);
    mwst = rabattpreis * 0.19;
    brutto = rabattpreis + mwst;

    cout << "Warenwert: " << netto << " Eur, Rabatt: " << rabatteur << " Eur, Netto: " << rabattpreis << " Eur, Mwst: " << mwst << " Eur, Brutto: " << brutto << " Eur";
    
}