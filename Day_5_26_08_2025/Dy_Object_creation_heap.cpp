//Dynamic object creation on heap

#include <iostream>
using namespace std;

class Complex
{
    int real,img;
    public:

    Complex();
    Complex(int,int);
    void display();
};

Complex::Complex(){
    cout<<"In default Constructor :"<<endl;
    real=img=0;
}

Complex::Complex(int r,int i)
{
    real=r;
    img=i;
}

void Complex::display()
{
    cout<<"Complex number is :"<<endl;
    cout<<real<<"+"<<img<<"i"<<endl;
}

int main()
{
    Complex* ptr=new Complex();

    ptr->display();

    Complex* ptr1=new Complex(10,2);
    ptr1->display();
}