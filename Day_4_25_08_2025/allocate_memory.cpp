#include<iostream>
using namespace std;

int main()
{
//Allocate deallocate memory to single
    // int * ptr = new int;
    // *ptr =10;
    // delete ptr;
    // cout<<*ptr;

//Allocate deallocate memory to n number of integers

   int n;
   cout<<"Enter number of elements :";
   cin>>n;

   int * ptr = new int[n];  
   

   for (int i = 0; i < n; i++)
   {
        cin>>ptr[i];
   }

//    delete [] ptr;
    for (int i = 0; i < n; i++)
   {
        cout<<ptr[i];
   }
   
      delete [] ptr;
}

  