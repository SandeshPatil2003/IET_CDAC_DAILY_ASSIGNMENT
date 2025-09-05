#include<iostream>

using namespace std;

int main()
{
    int a=10,b=20;

    a=a+b;
    b=a-b;
    a=a-b;

    cout<<"Values of a and b after swapping is : ";
    cout<<"a = " <<a<<"\t b="<<b;

}