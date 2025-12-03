#include<iostream>

using namespace std;


class Complex
{
    public :
    static int cnt;
    
        Complex();
};
int Complex::cnt=5;

int main()
{
     cout<<"Count is :"<<Complex::cnt;
}