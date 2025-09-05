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
    Complex(int,int,int);
    static int getcnt();
};
int Complex::cnt;

void Complex::show()
{
    cout<<"Complex number is :";
    cout<<real<<"+"<<img<<"i"<<endl;
        // cout<<endl;

}
Complex::Complex()
{
    cout<<"Default constructor"<<endl;
    real=2;
    img=1;
    cnt++;
        cout<<endl;

}

Complex::Complex(int real, int img)
{
    cout<<"in parametrized constructor\n";
    this->real=real;
    this->img=img;
    cout<<"Complex number is in para with this ptr:";
    cout<<real<<"+"<<img<<"i"<<endl;
    cnt++;
        cout<<endl;

}
Complex::Complex(int real, int img, int temp)
{
    cout<<"in 3 parametrized constructor\n";
    real=real;
    img=img;
    // cout<<"Complex number is in para without this ptr:";
    // cout<<real<<"+"<<img<<"i"<<endl;
    cnt++;
    cout<<endl;
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
    Complex c3(15,2,0);
    cout<<"After calling show without this ptr"<<endl;
    c3.show();
   // c2.show();
    cout<<"Number of Objects created are "<<c1.getcnt()<<endl;
    // cout<<"Count is :"<<Complex::cnt;
}