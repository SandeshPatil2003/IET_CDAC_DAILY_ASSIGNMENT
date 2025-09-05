#include<iostream>

using namespace std;

class Student {

    int totalMarks;

    public:
    Student(int);
    Student(Student&);
    void display();

};

Student::Student(int tm)
{
    totalMarks=tm;
}
Student::Student(Student &s_new)
{
    this->totalMarks=s_new.totalMarks;
}
void Student::display()
{
    cout<<"Total Marks are :"<<totalMarks<<endl;
}
int main()
{
    Student s(20);
    s.display();
    Student s2(s);
    s2.display();
    // d2.display();
}