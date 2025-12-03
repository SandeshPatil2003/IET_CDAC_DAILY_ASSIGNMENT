#include<iostream>

using namespace std;

class Shape
{
    int rad,len,width;
    public:
    Shape();
    Shape(int,int,int);
    void display();
    virtual float CalArea()=0;
};

Shape::Shape()
{
    cout<<"In default const"<<endl;
    r=l=w=0;
}
Shape::Shape(int r,int l,int w);
{
    cout<<"In Para const"<<endl;
    rad=r;
    len=l;
    width=w;
}
class circle : public Shape
{
    float area;
    public :
    float CalArea();
};

