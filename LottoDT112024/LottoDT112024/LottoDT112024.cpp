// LottoDT112024.cpp : Diese Datei enthält die Funktion "main". Hier beginnt und endet die Ausführung des Programms.
//

#include <cstdlib>
#include <iostream>
using namespace std;

bool isInArray(int arr[], int size, int number) {
    for (int i = 0; i < size; i++) {
        if (arr[i] == number) {
            return true; // Zahl ist bereits im Array
        }
    }
    return false; // Zahl ist noch nicht im Array
}

void bubbleSort(int arr[], int n) {
    int i, j;
    for (i = 0; i < n - 1; i++) {
        for (j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                // Vertausche Elemente
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

int main() {
    int zahl[6];
    srand(time(NULL));

    for (int i = 0; i < 6; i++) {
        int newNumber;
        do {
            newNumber = rand() % 49 + 1;
        } while (isInArray(zahl, i, newNumber)); // Solange die Zahl schon drin ist, wiederhole
        zahl[i] = newNumber;
    }

    // Ausgabe vor dem Sortieren
    cout << "Unsortiert: ";
    for (int i = 0; i < 6; i++) {
        cout << zahl[i] << " ";
    }
    cout << endl;

    // Sortieren mit Bubble Sort
    bubbleSort(zahl, 6);

    // Ausgabe nach dem Sortieren
    cout << "Sortiert: ";
    for (int i = 0; i < 6; i++) {
        cout << zahl[i] << " ";
    }
    cout << endl;

    return 0;
}