// // #include<iostream>

// // using namespace std;

// // int main()
// // {
// //     int a[3][3] = {1,2,3,4,5,6,7,8,9};
// //     int b[3][3] = {1,2,3,4,5,6,7,8,9};
// //     int c[3][3],i,j;

// //     for ( i = 0; i < 3; i++)
// //     {
// //          for ( j = 0; j < 3; j++)
// //          {
// //             c[i][j] = a[i][j]*b[i][j];
// //          }
// //     }
    
// //     for ( i = 0; i < 3; i++)
// //     {

// //          for ( j = 0; j < 3; j++)
// //          {
// //             cout<<c[i][j]<<"\t";
// //             //    cout<<"\t";
// //          }
// //          cout<<endl;
// //     }
    
// // }


#include <iostream>
using namespace std;

int main() {

    int r1 = 2, c1 = 3, r2 = 3, c2 = 2;

    
 int A[2][3] = {1,2,3,4,5,6};
    int B[3][2] = {7,8,9,10,11,12};
    if (c1 != r2) {
        cout << "Matrix multiplication is not possible!";
        return 0;
    }

    int result[2][10] = {0};

   
    for (int i = 0; i < r1; i++) {
        for (int j = 0; j < c2; j++) {
            result[i][j] = 0;
            for (int k = 0; k < c1; k++)
                result[i][j] += A[i][k] * B[k][j];
        }
    }

    cout << "Resultant Matrix:\n";
    for (int i = 0; i < r1; i++) {
        for (int j = 0; j < c2; j++)
            cout << result[i][j] << " ";
        cout << endl;
    }

    return 0;
}
