//program to print pascals triangle

#include<iostream>

using namespace std;

int main()
{
    int rows;

    cout<<"Enter number or rows : ";
    cin>>rows;

    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < rows-i-1 ; j++)
        {
           cout<<" ";
        }
        int value = 1;
          for ( int j = 0; j <= i ; j++)
        {
            cout << value << " ";
             value = value * (i-j)/(j+1);
        }
        cout<<endl;
    }
    
}