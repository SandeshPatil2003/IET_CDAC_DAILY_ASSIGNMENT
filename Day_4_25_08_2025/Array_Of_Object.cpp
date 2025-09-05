#include<iostream>
using namespace std;

static char clg[10];
class Students
{
    int id;
    char name[30];
    
    public:
    void getclg()
    {
        cout<<"Enter college name :";
        cin>>clg;
    }
    void getdata();
    void putdata();
};

void Students::getdata()
{
    cout<<"Enter student id :";
    cin>>id;
    cout<<"Enter student name :";
    cin>>name;
  
}
void Students::putdata()
{
    cout<<"student id is :"<<id<<endl;
  
    cout<<"student name :"<<name<<endl;
    cout<<"College name :"<<clg<<endl;
    // cout<<endl;
}

int main()
{
    int n,i;
    cout<<"Enter size :";
    cin>>n;
    Students s[n];
    s[n].getclg();
    cout<<"Accept values :"<<endl;
    for ( i = 0; i < n; i++)
    {
       s[i].getdata();
    }
      cout<<"Display values :"<<endl;
    for ( i = 0; i < n; i++)
    {
       s[i].putdata();
    }
}