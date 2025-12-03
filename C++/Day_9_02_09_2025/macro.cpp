#include<iostream>

#define size 5

using namespace std;

int main()

{

   int array[size];

   cout<<"Enter array elements";
   

   for(int i=0;i<size;i++){
    cin>>array[i];
   }

   cout<<"Elements are:  ";

   for(int i=0;i<size;i++){
    cout<<array[i];
   }
   
}