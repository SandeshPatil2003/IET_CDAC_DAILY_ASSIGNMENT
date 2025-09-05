#include<iostream>


using namespace std;


void secondLargestEl(int a[],int n)
{
    int max = a[0],temp=a[0];

    for (int i = 0; i < n; i++)
    {
        if(a[i]>max)
        {
         //temp=max;
         max=a[i];
        }

        // if(a[i]>temp<=max)
        // {
        //  //temp=max;
        //  temp=a[i];
        // }
    }
    for (int i = 0; i < n; i++)
    {
         if(a[i]<max && a[i]>temp)
            temp=a[i];
    }

    cout<<"Max element is "<<max<<endl;
    cout<<"Second Max element is "<<temp<<endl;
}
int main()
{
    int n;

    cout<<"Enter size of array :";
    cin>>n;

    int a[n];

    cout<<"enter array elements :";

    for(int i=0;i<n;i++){
        cin>>a[i];
    }

    secondLargestEl(a,n);

}