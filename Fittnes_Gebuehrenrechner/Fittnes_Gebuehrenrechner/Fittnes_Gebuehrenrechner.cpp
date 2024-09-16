// Fittnes_Gebuehrenrechner.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;

int main()
{
    int fam, betrag = 40, jahr;
    double kosten, rabatt;
    cout << "Geben sie die Anzahl der weiteren Familienmitglieder an, die eine Mitgliedschaft besitzen: ";
    cin >> fam;
    cout << "Geben sie ihr aktuelles Mitgliedsjahr an: ";
    cin >> jahr;
    if (fam == 1) {
        rabatt = 0.05;
    }
    else if (fam == 2) {
        rabatt = 0.15;
    }
    else if (fam >= 3) {
        rabatt = 0.2;
    }
    else {
        rabatt = 0;
    }
    if (jahr > 5) {
        rabatt += 0.05;
    }
    kosten = betrag - betrag * rabatt;
    cout << "Ihre kosten belaufen sich auf " << kosten << " Euro";
}