#include<iostream>

using namespace std;

class Employee 
{
   

   public:
   int id;
   Employee();
   Employee(int);
    void display();
   virtual int calculatesalary()=0;
  
};

Employee::Employee()
{
    cout<<"In default comstructor"<<endl;
    id=0;
}

Employee::Employee(int i)
{
    cout<<"In para comstructor"<<endl;
    id=i;
}

void Employee::display()
{
    cout<<"Employee id is:"<<id;
}

class WageEmployee : public Employee
{
   int hrs,rate;
   public:
   WageEmployee();
   WageEmployee(int,int,int);
   void display();

    int calculatesalary();

};
WageEmployee::WageEmployee()
{
    cout<<"In default comstructor of WageEmployee"<<endl;
    hrs=rate=0;

}

WageEmployee::WageEmployee(int i, int h, int r)
{
    cout<<"In para comstructor of WageEmployee"<<endl;
    hrs=h;
    rate=r;
    id=i;

}

int WageEmployee::calculatesalary()
{
        return hrs*rate;
}
void WageEmployee::display()
{
    Employee::display();
    cout<<"Salary is :"<<calculatesalary();
}
int main()
{
    // Employee e1(10);
    // e1.display();
    Employee * ptr;
    
    WageEmployee we(101,5,500);
    // Employee e;
    // ptr= &e;
    ptr = &we;
   cout<<"Salary of employee is :"<<ptr->calculatesalary()<<endl;

   ptr->display();

    

}