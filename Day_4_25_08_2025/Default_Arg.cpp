#include<iostream>

using namespace std;


void add(int a =5, int b=10)
{
    int c= a+b;
    cout<<"Addition is : "<<c<<endl;
}
void show(char ch = 'A')
{
    cout<<"Character is :"<<ch;
}
int main()
{
    int x=0;
    add();

    show();
}