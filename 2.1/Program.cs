// Lab_02.cpp
// < Подлєсний Любомир >
// Лабораторна робота № 2.1
// Лінійні програми.
// Варіант 33
# include <iostream>
# include <cmath>
using namespace std;
int main()
{
    double a; // вхідний параметр
    double b; // вхідний параметр
    double z1; // результат обчислення 1-го виразу
    double z2; // результат обчислення 2-го виразу
    cout << "a = "; cin >> a;
    cout << "b = "; cin >> b;

    z1 = sin(a) + cos(2b - a) / cos(a) - sin(2b - a)
    z2 = 1 + sin(2b) / cos(2b)

    cout << endl;
    cout << "z1 = " << z1 << endl;
    cout << "z2 = " << z2 << endl;
    cin.get();
    return 0;