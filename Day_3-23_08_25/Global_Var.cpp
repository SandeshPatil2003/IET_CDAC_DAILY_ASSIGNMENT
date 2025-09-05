#include<iostream>

using namespace std;
int y =10;

void show()
{
    cout<<"value of y in show : "<<y<<endl;
    int x = 0;
 //  cout<<x;
 cout<<"Value of x : "<<x<<endl;
    x++;
    cout<<"Value of x : "<<x<<endl;

}

int main ()
{
    cout<<"Value of y is :"<<y<<endl;
    y++;
    show();
  //  show();
    cout<<"Value of y after show is :"<<y<<endl;
}