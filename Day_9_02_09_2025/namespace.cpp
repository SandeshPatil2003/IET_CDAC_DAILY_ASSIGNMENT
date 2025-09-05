#include<iostream>
using namespace std;

#include "custom_namespace.h"


namespace Student
{
       
    int SchoolNo = 101343;
    void func()
    {
     cout << "Inside student invoked by using namespace" << endl;
     cout<<SchoolNo<<endl;
    }


}

using namespace Student;

int main()
{
    first_namespace::func();
    func();

        
}