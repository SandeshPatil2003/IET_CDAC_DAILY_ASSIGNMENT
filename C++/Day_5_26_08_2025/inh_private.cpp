#include <iostream>
using namespace std;

class Student {
private:
    int id_1 = 1;          

protected:
    int id_2 = 2;          

public:
    int id_3 = 3;          

    int getId_1() {        
        return id_1;
    }
};

class PrivateDerived : private Student {   
public:

    int getId2() {
        return id_2;      
    }

    int getId3() {
        return id_3;      
    }

    int getId1FromBase() {
        return getId_1();  
    }
};

int main() {
    PrivateDerived object1;

    cout << "Private cannot be accessed directly from object." << endl;
    cout << "Protected (via getter) = " << object1.getId2() << endl;
    cout << "Public (via getter) = " << object1.getId3() << endl;
    cout << "Private (via base getter) = " << object1.getId1FromBase() << endl;

    // not allowed because of private inheritance
    // cout << object1.id_2;
    // cout << object1.id_3;
    // cout << object1.getId_1();

    return 0;
}
