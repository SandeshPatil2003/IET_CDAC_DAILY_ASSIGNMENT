#include<iostream>

using namespace std;


int custPow(int num, int p)
{
      int i,pow=1;
      for(i=1;i<=p;i++)
      {
        pow =pow*num;
      }
      return pow;
}

int main()
{
    int num,rem=0,sum=0,check=0,count=0;
    cout<<"Enter the number :";
    cin>>num;
    int orgNum=num;
      check=num;
    while(check !=0)
    {
        count++;
        check/=10;
    }
    cout<<count<<"This is count"<<endl;


    while(num != 0)
    {
        rem=num%10;

        sum=sum+custPow(rem,3);
        num/=10;
    }
// cout<<sum<<endl;
    if(orgNum == sum)
    {
        cout<<"Number "<<orgNum<<" Is armstrong number";
    }
    else{
        cout<<"Number "<<orgNum<<" Is not armstrong number";
    }
}