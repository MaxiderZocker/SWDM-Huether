#include <iostream>
#include <cmath>

using namespace std;

int main() {
    double start, zins, end = 1000000;
    int jahre = 0;

    cout << "Geben Sie das Startkapital ein: ";
    cin >> start;
    cout << "Geben Sie den Zinssatz in Prozent ein: ";
    cin >> zins;

    zins /= 100;

    while (start < end) {
        start *= (1 + zins);
        jahre++;
    }

    cout << "Nach " << jahre << " Jahren haben Sie " << start << " Euro angespart.";
}