#include <iostream>  
using namespace std;  
 class Student {  
    
   float totalMarks = 30;  
   public:
   int gettotalMarks() 
   {
   		return totalMarks;
   }
 };  
   class Marks: public Student {  
   public:  
   float grace_marks= 5;  //protected:float totalMarks
   void CalculateMarks()
   {
       cout<<"Total Marks: "<< grace_marks+gettotalMarks()<<endl;  
   }
   };       
int main() {  
     Marks m1;  
     m1.CalculateMarks();
      cout<<"Total Marks: "<<m1.grace_marks+m1.gettotalMarks();  
    return 0;  
}  