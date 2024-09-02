// Hello_World_Anfang.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;
int main()
{
	int eingabe1, eingabe2, ergebnis;
   cout << "Gebe den ersten Wert ein: ";
   cin >> eingabe1;
   cout << "Gebe den zweiten Wert ein: ";
   cin >> eingabe2;
   ergebnis = eingabe1 + eingabe2;
   cout << ergebnis;
}