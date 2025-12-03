#include<iostream>

using namespace std;

class Temp {
    int a;
    public:
    void get();
    Temp add(Temp & b1)
    {
        Temp obj3;
        obj3.a=this->a + b1.a;
        return obj3;
    }
    void show()
    {
        cout<<"Addition is :"<<a;
    }
};

void Temp::get()
{
    cout<<"Enter value :";
    cin>>this->a;
}

int main()
{
    Temp obj1,obj2;
    obj1.get();
    obj2.get();
    Temp obj4 = obj1.add(obj2);
    obj4.show();
}