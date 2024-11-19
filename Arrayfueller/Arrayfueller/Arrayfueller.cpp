// Arrayfueller.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;
int feld[10], felds[5][5], o = 10, a = 0;

int main()
{
    for (int i = 0; i <= 9; i++) {
        feld[i] = o;
        cout << feld[i] << " " ;
        o--;
    }
    cout << endl << endl;
    for (int i = 10; i <= 50; i += 10) {
        a = 0;
        for (int g = 1;g <= 5;g += 1) {
            felds[i][a] = g + i;
            cout << felds[i][a] << " " ;
            a++;

        }
        cout << endl;
    }
}

