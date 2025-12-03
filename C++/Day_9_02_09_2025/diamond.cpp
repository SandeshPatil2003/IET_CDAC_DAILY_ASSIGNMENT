#include<iostream>

using namespace std;


// class A 
// {
// public:
// A(){
//     cout<<" in default A";
// }
// };

// class B : virtual public A
// {
// public:
// B(){
//     cout<<" in default B";

// }};

// class C : virtual public A
// {
// public:
// C(){
//     cout<<" in default C";
// }};


// class D : public B,C
// {public:
// D(){
//     cout<<" in default D";

// }};

// int main()
// {

//     D a;

// }


class Person 
{
public:
Person()
{
    cout<<"Default person constructor"<<endl;
}
Person(int x)
{
    cout<<" in para of  Person";
    cout<<x<<endl;
}
};

class Faculty : virtual public Person
{
public:
Faculty(int x):Person(x){
    cout<<" in Para Faculty";
    cout<<x<<endl;

}};

class Student : virtual public Person
{
public:
Student(int x):Person(x){
    cout<<" in Para of Student :";
    cout<<x<<endl;
}};


class Assistance : public Faculty ,public Student
{public:
Assistance(int x):Student(x), Faculty(x){
    cout<<" in Para of Assistance :";
    cout<<x<<endl;
}};

int main()
{

    Assistance P(30);

}