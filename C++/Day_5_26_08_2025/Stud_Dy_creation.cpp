
#include <iostream>
using namespace std;

int main()
{
    int n,count,i,sum=0;
    float avg;
    cout<<"Enter number of subjects :";
    cin>>n;
   cout<<"Enter no of characters in name :";
   cin>>count;
  
    int* s_marks = new int[n];
    char* s_name = new char[count+1];
   cout<<"Enter marks for each subject :";

   for(i=0;i<n;i++){
        cin>>s_marks[i];
        sum=sum+s_marks[i];
   }

   cout<<"Enter name :";
   cin>>s_name;

   avg=(float)sum/n;

   cout<<"Name of student is "<<s_name<<endl;
   cout<<"Average of mark is :"<<avg;
}