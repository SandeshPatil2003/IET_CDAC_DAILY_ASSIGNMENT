#include<iostream>

using namespace std;

class Date {

    int dd,mm,yy;

    public:
    Date(int,int,int);
    Date(Date&);
    void display();

};

Date::Date(int d, int m, int y)
{
    dd=d;
    mm=m;
    yy=y;
}
Date::Date(Date &Date_new)
{
    this->dd=Date_new.dd;
    this->mm=Date_new.mm;
    this->yy=Date_new.yy+1;


}
void Date::display()
{
    cout<<"Date is :"<<dd<<"/"<<mm<<"/"<<yy<<endl;
}
int main()
{
    Date d(10,9,2003);
    d.display();
    Date d2(d);
    d2.display();
    // d2.display();
}