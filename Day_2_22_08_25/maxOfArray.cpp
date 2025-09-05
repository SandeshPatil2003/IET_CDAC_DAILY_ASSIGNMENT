#include<iostream>

using namespace std;

int main()
{
	int a[5],i,max=0;
	
	cout<<"Enter array elements :"<<endl;
	
	for(i=0;i<5;i++)
	{
		cin>>*(a+i);
	}
	max=*(a+0);
	
	cout<<"Max Array elements is : ";
	for(i=1;i<5;i++)
	{
		if(max<*(a+i))
		max=*(a+i);
	}
	cout<<max;
	
}

