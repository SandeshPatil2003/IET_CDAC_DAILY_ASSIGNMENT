#include<iostream>

using namespace std;


class check 
{
    public:
        template<class T, class Y>
    void add(T a, Y b)
    {

        cout<<"a + b in 2nd is :"<<a+b<<endl;;
    }

    template<class T>
    void add(T a, T b)
    {
        cout<<"a + b in 1st is :"<<a+b<<endl;
    }

   
};

int main()
{
    check c;
    c.add(1,2);
    // c.add(1,2.1);

}