#include<iostream>
using namespace std;

int main()
{
    int rows,i,j;
    char ch = 'A';
    cout << "Enter the number of rows : ";
    cin >> rows;

    for (i = 1; i <= rows; i++) {
        // Print leading spaces for the slant
        for (j = 1; j <= rows - i; j++) {
            cout << " ";
        }
        // Print the alphabet for the rhombus
        for (j = 1; j <= rows; j++) {
            cout << ch;
        }
        ch++;
        cout << endl;
    }
    return 0;
}
