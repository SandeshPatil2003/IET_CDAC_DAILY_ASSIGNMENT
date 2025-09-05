// #include<iostream>
// #include <math.h>
// using namespace std;

// int customPow (float interest, float time ){
//     int i;
//  float result = 1.0;
//       for(i=1;i<=time;i++)
//       {

//      result *=interest;
//       }
//       return result;
// }
// int main()
// {
//     float principal,interest,time,amount=0,compoundInterest=0;
//     cout<<"enter princle, interest and time :";
//     cin>>principal>>interest>>time;

//     interest=interest/100;

//     amount=principal*customPow((1+interest),time);
//     cout<<"Compound Interest is : "<<amount-principal;
// }


// #include<iostream>

// using namespace std;


// double pow(double j, double e)
// {   
//     double power=1;

//     e=(int)e;

//     for(int i= 1;i<3;i++)
//     {
//         power=power*j;


//     }

//     return power;
// }
// int main()

// {
//     double p,r,t;
//     cout<<"Enter PRT";
// cin>>p>>r>>t;

// double a=(p*(pow(1+(r/100),t)))-p;
// cout<<a;


// }
#include <iostream>
using namespace std;

int main() {
    float principal, rate, time, amount, compoundInterest;

    cout << "Enter the Principal amount: ";
    cin >> principal;
    cout << "Enter the Rate of Interest: ";
    cin >> rate;
    cout << "Enter the Time (in years): ";
    cin >> time;

    amount = principal;
    for(int i = 0; i < time; ++i) {
        amount = amount * (1 + rate / 100);
    }

    compoundInterest = amount - principal;

    cout << "Compound Interest = " << compoundInterest << endl;
    cout << "Total Amount = " << amount << endl;

    return 0;
}
