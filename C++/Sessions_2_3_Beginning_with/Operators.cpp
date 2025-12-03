#include <iostream>
using namespace std;

int main() {
    int a = 8, b = 3;

    cout << "a + b = " << a + b << "\n";
    cout << "a - b = " << a - b << "\n";
    cout << "a * b = " << a * b << "\n";
    cout << "a / b = " << a / b << "\n";
    cout << "a % b = " << a % b << "\n";

    if (a > b)
        cout << "a is bigger\n";

    cout << (a > b ? "a > b\n" : "a <= b\n");

    int c = a;
    c += b;
    cout << "c after += b: " << c << "\n";

    int x = 5;
    cout << "x before increment: " << x << "\n";
    cout << "x after increment: " << ++x << "\n";

    return 0;
}
