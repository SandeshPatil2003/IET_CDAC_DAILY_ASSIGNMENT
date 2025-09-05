#include<iostream>
using namespace std;

class Complex
{
	int real,img;
	
	public:
		Complex();
		Complex(int,int);
		void accept();
		void display() const;
		void setReal(int);
		void setImg(int);
		int getReal() const; 
		int getImg() const;
		
};
Complex::Complex()
{
		cout<<"Default constructor"<<endl;
	   real=1;
	   img=7;	
}

Complex::Complex(int r,int i){
	cout<<"Para constructor"<<endl;
	real=r;
	img=i;
}

void Complex::accept()
{
	cout<<"Enter real followed by imaginary number"<<endl;
	
	cin>>real>>img;
	
}


void Complex::display() const
{
	cout<<"The Complex Number is : "<<real<<"+"<<img<<"i"<<endl;
	
}


void Complex::setReal(int r)
{
	real=r;
}

void Complex::setImg(int i)
{
	img=i;
}

int Complex::getReal() const
{
	return real;
}

int Complex::getImg() const
{
	return img;
}

int main()

{
	
    const Complex c1 ;
	Complex c2(5,6);
	c2.accept();
	c1.display();
	c2.setReal(4);
	c2.setImg(6);
	
	cout<<"New Real is \t"<<c2.getReal()<<endl;
	cout<<"New Img is \t"<<c2.getImg()<<endl;
	
	
}
