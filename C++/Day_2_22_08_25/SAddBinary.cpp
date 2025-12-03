#include<iostream>

using namespace std;

int main()
{

    int power=1,num,e;

    cin>>num>>e;
for(int i=1;i<=e;i++)
{
    power=power*num;
}

cout<<power;

return 0;
}
