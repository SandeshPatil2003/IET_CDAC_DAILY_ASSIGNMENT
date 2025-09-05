// Program to print Inverted number pyramnid

#include<iostream>
using namespace std;

int main()
{
    int rows,i,j,k,m,num=1;
    m=1;
    cout<<"Enter the number of rows : ";
    cin>>rows;

    for( i = rows; i >=1 ; i--)
    { 
        for(j=0 ; j<m ; j++)
        {
            cout<<" ";
        }
        for ( k = 0; k < i-1; k++)
        {
           // cout<<"*";
            cout<<num<<" ";
            num++;
            if(num>=10)
            num%=10;
        }
        m++;
        cout<<endl;
    }
}