// Kechnungserstellung_Kassenbeleg.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;

int main()
{
    double netto, mwst, brutto, mehrwert;
    cout << "Geben sie den Nettowert ein: ";
    cin >> netto;
    cout << "Geben sie die Mehrwertsteuer-Kennziffer ein: ";
    cin >> mwst;
    if (mwst == 1) {
        mwst = 7;
        cout << "Warenwert in Netto: " << netto;
        mehrwert = netto * mwst * 0.01;
        cout << "\nMehrwertsteuer: " << mehrwert;
        brutto = netto + mehrwert;
        cout << "\nRechnungsbetrag: " << brutto;
    }
    else {
        mwst = 19;
        cout << "Warenwert in Netto: " << netto;
        mehrwert = netto * mwst * 0.01;
        cout << "\nMehrwertsteuer: " << mehrwert;
        brutto = netto + mehrwert;
        cout << "\nRechnungsbetrag: " << brutto;
    }
    
}
