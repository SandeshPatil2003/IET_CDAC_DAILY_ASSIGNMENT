#include<iostream>

using namespace std;

int main()
{
    int a[5];
    int size = sizeof(a)/sizeof(a[0]);
    cout<<"Size of array is :"<<size;
}