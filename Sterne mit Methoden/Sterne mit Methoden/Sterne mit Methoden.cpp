// Sterne mit Methoden.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <cstdlib>
using namespace std;


void sterne(int anzahl)
{
    while (anzahl > 0) {
        cout << "*";
        anzahl--;
    }
    cout << endl;
}

int main()
{
    int anzahl;
    cout << "Geb die anzahl der Sterne ein: ";
    cin >> anzahl;
    cout << "\n";
    sterne(anzahl);
}
