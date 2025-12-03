#include <iostream>
using namespace std;

int main() {
    cout << "Welcome! Control Structures Demo\n";

    //  if, else if, else
    int num;
    cout << "Enter a number: ";
    cin >> num;
    if (num > 0) {
        cout << "Positive\n";
    } else if (num < 0) {
        cout << "Negative\n";
    } else {
        cout << "Zero\n";
    }

    // Switch statement
    cout << "Enter a choice (1-3): ";
    int choice;
    cin >> choice;
    switch(choice) {
        case 1: cout << "You chose ONE.\n"; break;
        case 2: cout << "You chose TWO.\n"; break;
        case 3: cout << "You chose THREE.\n"; break;
        default: cout << "Invalid choice.\n";
    }

    // for loop
    cout << "For loop output: ";
    for (int i = 0; i < 5; i++) {
        cout << i << " ";
    }
    cout << endl;

    // While loop
    cout << "While loop output: ";
    int j = 0;
    while (j < 5) {
        if (j == 3) {
            j++;
            continue; 
        }
        if (j == 4) {
            break;   
        }
        cout << j << " ";
        j++;
    }
    cout << endl;

    // Do-while loop
    cout << "Do-while loop output: ";
    int k = 0;
    do {
        cout << k << " ";
        k++;
    } while (k < 3);
    cout << endl;

    // Array
    int arr[10] = {5, 10, 15, 20, 25};
    cout << "Array output: ";
    for (int i = 0; i < 5; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    // Array 2-D 
    int mat[11][11] = {{1,2},{3,4}};
    cout << "2-D Array output:\n";
    for(int r = 0; r < 2; r++) {
        for(int c = 0; c < 2; c++) {
            cout << mat[r][c] << " ";
        }
        cout << endl;
    }

    // Use of return 
    cout << "Program completed." << endl;
    return 0;
}
