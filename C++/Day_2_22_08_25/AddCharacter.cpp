#include<iostream>

using namespace std;

void addChar(char c1, char c2)
{
    char ch = c1+c2;
    cout<<c1*1;
    cout<<c1+c2<<endl;
    cout<<"Addition of Two character is :"<<ch;
}
int main ()
{
    char c1,c2;
    cout<<"Enter two Character ";
    cin>>c1>>c2;
    addChar(c1,c2);
}