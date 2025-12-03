#include<iostream>

using namespace std;

void swap(int* p, int* q)
{
	int temp;
	temp =*p;
	*p=*q;
	*q=temp;
	cout<<"Value of p and q after swapping : "<<endl;
	cout<<"p ="<<*p<<"\t q = "<<*q<<endl;
	
	cout<<endl;
		
	cout<<"Address of p and q is : "<<endl;
	cout<<"p = "<<&p<<"\t q= "<<&q<<endl;
	cout<<endl;
	
	
}

int main()
{
	int a=10,b=20;
	cout<<"Value of a and b Before swapping : "<<endl;
	cout<<"a = "<<a<<"\t b = "<<b<<endl;
		cout<<endl;
	swap(&a,&b);
	cout<<"Value of a and b after swapping : "<<endl;
	cout<<"a = "<<a<<"\t b = "<<b<<endl;
	
		cout<<endl;
		
		cout<<"Address of a and b is : "<<endl;
	cout<<"a = "<<&a<<"\t b= "<<&b<<endl;
}


