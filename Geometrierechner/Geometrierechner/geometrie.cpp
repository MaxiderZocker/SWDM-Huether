#include "geometrie.h"

double flrechteck(int a, int b) {
    return a * b;
}

double fldreieck(int a, int b) {
    return flrechteck(a, b) / 2;
}

double flkreis(int r) {
    return pi * r * r;
}