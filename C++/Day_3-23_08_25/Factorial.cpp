#include<iostream>

using namespace std;

int factorial(int num)
{
    int i,fact=1;
    // cout<<num<<endl;
    //  cout<<fact<<endl;

        for ( i = num; i >= 1; i--)
        {
            fact=fact*i;
            // cout<<fact<<endl;
        }
        // cout<<fact;
        return fact;
        
}
int main()
{
    int num;

    cout<<"Enter the number to calculate factorial :";
    cin>>num;

    cout<<"Factorial of num "<<num<<" is : "<<factorial(num);
}