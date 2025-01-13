// LottoDT112024.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <cstdlib>
#include <iostream>
using namespace std;

int main()
{
	int zahl;
	srand(time(NULL));
	for (int j = 0; j < 12; j++) {
		for (int i = 0; i < 6; i++) {
			zahl = rand() % 49 + 1;
			cout << zahl << "\t";
		}
		cout << endl;
	}
	
	
	
	
}
