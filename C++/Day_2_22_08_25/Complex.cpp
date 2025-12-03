#include<iostream>
using namespace std;

class Complex
{
	int real,img;
	
	public:
		
		
		void accept();
		void display();
		void setReal(int);
		void setImg(int);
		int getReal();
		int getImg();
		
};

void Complex::accept()
{
	cout<<"Enter real followed by imaginary number"<<endl;
	
	cin>>real>>img;
	
}


void Complex::display()
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

int Complex::getReal()
{
	return real;
}

int Complex::getImg()
{
	return img;
}

int main()

{
	
	Complex c1;
	c1.accept();
	c1.display();
	c1.setReal(4);
	c1.setImg(6);
	
	cout<<"New Real is \t"<<c1.getReal()<<endl;
	cout<<"New Real is \t"<<c1.getImg()<<endl;
	
	
}
