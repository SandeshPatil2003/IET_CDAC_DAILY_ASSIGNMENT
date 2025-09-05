#include<iostream>

using namespace std;

int pow(int num, int p)
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
    int num,p;
    cout<<"Enter the number to cal its power :";
    cin>>num;
    cout<<"Enter the Power:";
    cin>>p;
    int result=pow(num,p);
    cout<<"Result is  "<<result;
}