#include <iostream>

using namespace std;

int main()
{
    int num;
    double area;
    cout<<"Enter number :";
    cin>>num;

    area=num;

    cout << "Implicit int to double: " << area << endl;
    cout<<"Size is "<<sizeof(area)<<endl;
 
    int intArea = (int)area;  
    cout << "Explicit double to int: " << intArea << endl;
     cout<<"Size is "<<sizeof(intArea)<<endl;

}