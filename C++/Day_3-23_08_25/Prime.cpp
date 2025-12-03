#include<iostream>

using namespace std;

int main()
{
    int i,num,flag=0;

    cout<<"Enter the number to check if its prime or not : ";
    cin>>num;

      if (num <= 1)
    {
         cout<<"Entered Number "<<num<<" is not valid prime number"<<endl;
          return 0;
    }
  
    for(i=2;i<=num/2;i++)
    {
       if(num % i ==0)
       {
            flag=1;
           break;
       }
      
    }
    if(flag ==0)
    {
        cout<<"Number "<<num<<" is prime number"<<endl;
    }
    else{
         cout<<"Number "<<num<<" is not prime number"<<endl;

    }
}