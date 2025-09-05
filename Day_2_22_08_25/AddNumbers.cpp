#include<iostream>

using namespace std;

void addNumber(int num1, int num2)
{
	int sum=num1+num2;
	cout<<"Addition of num1 and num2 is :";
	cout<<sum;
}

int main()
{
	int num1,num2,sum=0;
	
	cout<<"Enter the values of num1 and num2 :";
	cin>>num1>>num2;
	addNumber(num1,num2);
}
