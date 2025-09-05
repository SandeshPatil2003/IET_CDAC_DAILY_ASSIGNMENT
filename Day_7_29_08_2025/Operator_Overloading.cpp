#include<iostream>

using namespace std;

class Complex
{
    int real,img;

    public:
    Complex();
    Complex(int,int);
    void display();
    Complex operator--();
    Complex operator--(int);
};

Complex::Complex()
{
    cout<<"In default Constructor";

}

Complex::Complex(int r, int i)
{
    cout<<"In para const"<<endl;
    real=r;
    img=i;
}

//pre decrement
Complex Complex::operator--()
{
    
    real--;//real=real-1
    img--;
    return *this;
}

//post decrement
Complex Complex::operator--(int)
{
      Complex temp= *this;
    real=real-1;
    img = img-1;
    return temp;
}
void Complex::display(){
    cout<<"Complex number is :";
    cout<<real<<"+"<<img<<"i"<<endl;
}
int main()
{
    Complex c1(4,5);
    c1.display();
    Complex c2 = --c1;//c2 = c1.operator--();
    c1.display();
    c2.display();

    Complex c3(4,5);
    c3.display();

    Complex c4 = c3--; // c4= c3.operator--(int)
    c4.display();
    c3.display();
    
}