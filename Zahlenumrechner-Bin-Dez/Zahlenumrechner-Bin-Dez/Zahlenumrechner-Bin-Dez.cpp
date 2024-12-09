// Zahlenumrechner-Bin-Dez.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <iostream>
#include <string>

using namespace std;

bool isBinary(string num) {
    for (char digit : num) {
        if (digit != '0' && digit != '1') {
            return false;
        }
    }
    return true;
}

int binaryToDecimal(string binaryNum) {
    int decimalNum = 0, base = 1, i = binaryNum.length();
    while (i--) {
        if (binaryNum[i] == '1')
            decimalNum += base;
        base = base * 2;
    }
    return decimalNum;
}

int main() {
    string binaryString;
    char choice;

    do {
        cout << "Bitte geben Sie eine Binaerzahl ein: ";
        cin >> binaryString;

        while (!isBinary(binaryString)) {
            cout << "Ungueltige Eingabe. Bitte geben Sie eine Binaerzahl ein: ";
            cin >> binaryString;
        }

        int decimalNum = binaryToDecimal(binaryString);
        cout << "Die dezimale Darstellung ist: " << decimalNum << endl;

        bool validChoice = false;
        do {
            cout << "Moechten Sie das Programm erneut ausfuehren? (y/n): ";
            cin >> choice;
            if (choice == 'y' || choice == 'Y' || choice == 'n' || choice == 'N') {
                validChoice = true;
            }
            else {
                cout << "Ungueltige Eingabe. Bitte geben Sie 'y' oder 'n' ein." << endl;
            }
        } while (!validChoice);

    } while (choice == 'y' || choice == 'Y');

    return 0;
}