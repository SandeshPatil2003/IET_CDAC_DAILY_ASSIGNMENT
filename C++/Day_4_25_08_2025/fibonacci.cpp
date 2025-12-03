#include<iostream>
using namespace std;

int main()
{
    int n,i,fst=0,snd=1,trd;
    cout<<"Enter limit of series :";
    cin>>n;
     cout<<fst<<" "<<snd<<" ";
    for(i=2;i<n;i++){ 
        trd=fst+snd;
        fst=snd;
        snd=trd;
      cout<<trd<<" ";
    }

}