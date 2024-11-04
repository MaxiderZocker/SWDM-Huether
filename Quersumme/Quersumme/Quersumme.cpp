// Quersumme.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;
int ziffer, summe;
bool pos;
string zahl;
int main()
{
    while (pos == false) {
        cout << "Geb eine Positive Zahl ein: ";
        cin >> zahl;
        if (zahl[0] == '-') {
            cout << "\nGeb eine Positive Zahl an. Keine Negative!\n\n";
        }
        else {
            pos = true;
        }
    }

    for (char ziffer : zahl) {
        summe += ziffer - '0';
    }

    cout << "\nDie Quersumme der Zahl lautet: " << summe;

   
}
