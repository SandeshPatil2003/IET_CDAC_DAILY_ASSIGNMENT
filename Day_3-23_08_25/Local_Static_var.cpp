// #include<iostream>

// using namespace std;
// static int x =10;


// void show()
// {
//      cout<<"value of static variable in show is : "<<x<<endl;
// }

// int main()
// {
//   int y=0;
//   cout<<"value of static variable is : "<<x<<endl;
//   show();
//   x++;
//   y++;
//   cout<<"Value of y is :"<<y<<endl;
// }

#include<iostream>

using namespace std;

  static int x;


void show()
{
   int y=0;
   cout<<"value of local variable is : "<<y<<endl;
   cout<<"value of static variable in show is : "<<x<<endl;
   y++;
   x++;
}
int main()
{
 
  cout<<"value of static variable Before is : "<<x<<endl;
  x++;
  show();
  show();
  cout<<"value of static variable after is : "<<x<<endl;
}