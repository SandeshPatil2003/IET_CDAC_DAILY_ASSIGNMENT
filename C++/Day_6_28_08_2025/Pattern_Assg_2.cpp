// Program to print Alphabet

#include<iostream>
using namespace std;

int main()
{
    int rows,i,j,k;
    char ch='A';
 
    cout<<"Enter the number of rows : ";
    cin>>rows;

    for( i = rows; i >= 1 ; i--)
    { 
        for(j=0 ; j < i ; j++)
        {
            cout<<" ";
        }
        for ( k = 0; k < i; k++)
        {
           // cout<<"*";
            cout<<ch<<" ";
            ch++;
        }
         

        cout<<endl;
    }
}