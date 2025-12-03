#include <iostream>

using namespace std;

// int main()
// {   int flag=0;

//     for (int j = 2; j < 100; j++)
//     {
//     for (int i = 3; i < 100; i++)
//     {
//         if(i%j==0)
//         flag=1;
//         else flag=0;

//         if(flag==0)
//        { cout<<i<<endl;}
//     }
//     flag=0;
// }
    
// }

int main()
{
    int num,cnt=0;
    cout<<"Enter Number :";
    cin>>num;
     cout<<"Prime numbers are :"<<endl;

    for (int i = 1; i <= num; i++)
    {
        cnt=0;
        for (int j = 1; j <= i; j++)
        {
            if(i % j == 0)
            {
                cnt++;
            }
        }
        if(cnt <= 2)
        {
            cout<<i<<"\t";
        }
        
    }
    
}