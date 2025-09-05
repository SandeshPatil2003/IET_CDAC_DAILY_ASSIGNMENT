#include<iostream>

using namespace std;

int main()
{
    int arr[5];
    int* ptr1[5];
    cout<<"Enter array elements :";

    for (int i = 0; i < 5; i++)
    {
        cin>>arr[i];
    }

    
    for (int i = 0; i < 5; i++)
    {
        ptr1[i]=&arr[i];
    }

    cout<<"Address i array of ptr1 are :"<<endl;
     for (int i = 0; i < 5; i++)
    {
        cout<<"Address of element : "<<*ptr1[i]<<" is :"<<ptr1[i]<<endl;
    }
    
}