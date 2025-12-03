#include<iostream>
#include <string.h>
using namespace std;

static int cnt;

class String
{
    int len;
    char *ptr;

    public:
    String();
    String(char*);
    void show();

    ~String()
    {
        cnt--;
        cout<<"In destructor "<<endl;
        cout<<"Object Destroyed :"<<cnt<<endl;
        delete ptr;
        delete [] ptr;
    }

};

String::String(char *str1)
{
    cnt++;
    len= strlen(str1);
    ptr = new char[len+1];
    strcpy(ptr,str1);
}


void String::show()
{
	cout<<"length of string is "<<len<<endl;
			cout<<"string is "<<ptr<<endl;
	
    cout<<"Object created :"<<cnt<<endl;
}


int main()
{
    String s("Cdac");
  
  {
    String s1("IET");
    s1=s;
    
  }
    s.show();
  
}