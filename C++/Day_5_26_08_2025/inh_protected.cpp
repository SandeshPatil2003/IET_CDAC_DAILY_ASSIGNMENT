#include <iostream> 
using namespace std; 
  
class Student { 
private: 
    int id_1 = 1; 
  
protected: 
    int id_2 = 2; 
  
public: 
    int id_3 = 3; 
  
    int getId_1() { return id_1; } 
}; 
  
class ProtectedDerived : protected Student { 
public: 
    int getId2() { 
        return id_2; } 
  
    int getId3() { 
        return id_3; } 
}; 
  
int main() 
{ 
    ProtectedDerived object1; 
    cout << "Private cannot be accessed." << endl; 
    cout << "Protected = " << object1.getId2() << endl; 
    cout << "Public = " << object1.getId3() << endl; 
// cout<<object1.prot;//error
// cout<<object1.pub;//error
// cout<<object1.getId_1();//error


    return 0; 
}
