#include<iostream>

using namespace std;

// class Student
// {
//     int *id;
//     public :

//     Student();
//     void show();

// };
// Student::Student()
// {
//     id = new int;
//     *id=10;
// }

// void Student::show()
// {
//     cout<<"Value in ptr is :"<<*id;
// }

// int main()
// {
//     Student s;
//     s.show();

// }

class Employee
{
    int id;
    char name[20];
    public :

    // Employee();
    void accept();
    void show();

    ~Employee()
    {
        cout<<"Destructor is called"<<endl;
    }
};

void Employee::accept()
{
    cout<<"Enter Id :";
    cin>>id;
     cout<<"Enter Name :";
    cin>>name;
}

void Employee::show()
{
    cout<<"Id of Emp is :"<<id<<"\t Name of Emp is :"<<name<<endl;
}

int main()
{
    int n;

    cout<<"Enter number of Employees :";
    cin>>n;

    Employee *s = new Employee[n];

    cout<<"Enter Details :"<<endl;
    for (int i = 0; i < n; i++)
    {
       (s+i)->accept();
    }

      cout<<"Displaying Details :"<<endl;
    for (int i = 0; i < n; i++)
    {
       (s+i)->show();
    }
    
}