#include<iostream>
# define MAX 100
using namespace std;

int main()
{
	int bin1,bin2,carry=0,s[MAX],rem1=0,rem2=0,i=0,sum=0;

	cout<<"Enter First Binary number =";
	cin>>bin1;
    	cout<<"Enter second Binary number =";
	cin>>bin2;

    while(bin1>0 || bin2>0 || carry >0){
        rem1=bin1%10;
        rem2=bin2%10;
        sum = rem1 + rem2 + carry;
        s[i] = sum % 2;
        carry = sum / 2;

        bin1/=10;
        bin2/=10;
        i++;
    }
	cout << "Sum = ";
    for(int j = i - 1; j >= 0; j--)
        cout << s[j];
    cout << endl;

    return 0;
}

