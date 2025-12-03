#include<iostream>

using namespace std;

template <class S>
class Addition
{
   
    public :
    S num1;
    S num2;
    Addition(S val1, S val2){
        num1=val1;
        num2=val2;
    }
    void add()
    {
        cout<<"Addition of num1 and num2 is :"<<num1+num2<<endl;
    }
};

int main()
{
    Addition<int> a(2,3);
    a.add();
}