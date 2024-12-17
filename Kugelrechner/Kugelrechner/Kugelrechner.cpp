// Kugelrechner.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;
double flaeche, volumen, rad;

void kugel(double r)
{
    flaeche = 4 * 3.14 * r * r;
    volumen = (4 / 3) + 3.14 * r * r * r;
}

int main()
{
    cout << "Geben Sie den Radius ein: ";
    cin >> rad;
    kugel(rad);
    cout << "Die Oberflaeche betraegt: " << flaeche << endl;
    cout << "Das Volumen betraegt: " << volumen << endl;
}

