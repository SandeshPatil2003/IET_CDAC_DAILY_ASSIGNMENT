#include<iostream>

using namespace std;


class Complex
{
    int real,img;
    static int cnt;
    public :
    void show();
    Complex();
    Complex(int,int);
    static int getcnt();
};
int Complex::cnt;

void Complex::show()
{
    cout<<"Complex number is :";
    cout<<real<<"+"<<img<<"i"<<endl;
}
Complex::Complex()
{
    cout<<"Default constructor"<<endl;
    real=2;
    img=1;
    cnt++;
}

Complex::Complex(int r, int i)
{
    cout<<"in parametrized constructor\n";
    real=r;
    img=i;
    cnt++;
}

int Complex::getcnt()
{
    return cnt;
}

int main()
{
    Complex c1;
    c1.show();
    Complex c2(10,2);
    
    c2.show();
    cout<<"Number of Objects created are "<<c1.getcnt()<<endl;
    // cout<<"Count is :"<<Complex::cnt;
}