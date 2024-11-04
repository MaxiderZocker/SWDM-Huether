// Benutzeranmeldung.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
using namespace std;
int vers = 0;
string name, pw;
bool erfolg;

int main()
{
    while (vers < 3 && erfolg == false) {
        cout << "Geben sie den Benutzernamen ein: ";
        cin >> name;
        cout << "Geben sie das Passwort ein: ";
        cin >> pw;
        if (pw == "Hallo" && name == "Max") {
            erfolg = true;
        }
        else {
            vers++;
            cout << "\nPassword oder Benutzername Falsch. Versuchen sie es Erneut\n\n";
        }
    }
    if (vers >= 3) {
        cout << "\nDu hast mehr als 3 versuche gebraucht. Dein konto wurde Geloescht.\n";
    }
    else if (erfolg == true) {
        cout << "\nDu hast dich erfolgreich angemeldet!\n";
    }
}

