// Geometrierechner.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include "geometrie.h"
using namespace std;

int main()
{
    int wahl, radius, hoehe, seitea, seiteb;
    double flaeche, volumen;

    do {
        cout << "Bitte waehlen sie eine Option: " << endl;
        cout << "Kreis: [1]" << endl;
        cout << "Rechteck: [2]" << endl;
        cout << "Dreieck: [3]" << endl;
        cout << "Beenden [0]" << endl;

        cin >> wahl;

        switch (wahl)
        {
        case 1: cout << "Bitte geben sie den Radius ein: ";
            cin >> radius;
            cout << "Die Flaeche betraegt: " << flkreis(radius) << endl;
            break;
        case 2: cout << "Bitte geben sie Seite A ein: ";
            cin >> seitea;
            cout << "Bitte geben sie Seite B ein: ";
            cin >> seiteb;
            cout << "Die Flaeche betraegt: " << flrechteck(seitea, seiteb) << endl;
            break;
        case 3: cout << "Bitte geben sie Seitenlaenge ein: ";
            cin >> seitea;
            cout << "Bitte geben sie Hoehe ein: ";
            cin >> seiteb;
            cout << "Die Flaeche betraegt: " << fldreieck(seitea, seiteb) << endl;
            break;
        }
    } while (wahl != 0);
    return 0;
}
