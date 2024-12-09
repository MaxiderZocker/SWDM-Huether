// Zahlenumrechner.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>
using namespace std;

string dtb(int n) {
    string bin = "";

    if (n == 0) {
        return "0";
    }

    while (n > 0) {
        bin = to_string(n % 2) + bin;
        n /= 2;
    }

    return bin;
}

int main()
{
    bool wdh = true;
    while (wdh == true) {
        int eing, t = 0;
        string eing2;
       

        cout << "Geben Sie eine Dezimalzahl ein: ";
        cin >> eing;

        string bin = dtb(eing);

        cout << "Die Binaerzahl lautet: " << bin << endl;
        cout << "Moechtest du eine weitere eingabe taetigen? [y/n] ";
        cin >> eing2;

        while (t == 0) {
            if (eing2 == "y") {
                wdh = true;
                t = 1;
            }
            else if (eing2 == "n") {
                wdh = false;
                t = 1;
            }
            else {
                cout << "Wiederhole die eingabe. [y/n] ";
                cin >> eing2;
                t = 0;
            }
        }
        
    }

    return 0;
}
