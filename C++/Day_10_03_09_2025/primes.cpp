#include <iostream>

#define RESET   "\033[0m"
#define RED     "\033[31m"
#define GREEN   "\033[32m"
#define YELLOW  "\033[33m"
#define BLUE    "\033[34m"
#define MAGENTA "\033[35m"
#define CYAN    "\033[36m"
#define BOLD    "\033[1m"

using namespace std;

 int main()
 {   int flag=0,i;

     for (int j = 2; j < 100; j++)
     {
        flag=0;
    for ( i = 2; i<j ; i++)
     {
        if(j%i==0)
         flag=1;
         
       
     }
       if(flag==0)
       { for (int z  = 0; z < i; z++)
       {
        cout<<RED<<"*";
       }
       cout<<" "<<BLUE<<i;
        }
        cout<<"\t";
     
}
    
 }