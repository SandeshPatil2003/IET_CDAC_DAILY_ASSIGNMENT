#include <iostream>

using namespace std;

class Student {
     int id;

     public:
     Student()
     {
        cout<<"Enter Student Id :";
         cin>>id;
     }
     char name[10];
     void accept();
     int getId();
};

int Student::getId()
{
    return id;
}

class Marks : public Student
{
    float marks;
    public :
    void getDetails();
    void display();
};

void Marks::getDetails()
{

    Student::accept();
     cout<<"Enter marks of student :";
    cin>>marks;
}

void Marks::display()
{
   // cout<<"Id of student :"<<id; error as id is private to student
   cout<<"Id of student :"<<Student::getId()<<endl; 
    cout<<"Name of student :"<<name<<endl;
     cout<<"Marks of student :"<<marks<<endl;
}


void Student::accept(){
    cout<<"Enter Name of student :";
    cin>>name;
   

}

int main()
{
    Marks m;
    m.getDetails();
    m.display();
    
}