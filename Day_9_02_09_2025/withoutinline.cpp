#include<iostream>
#include <chrono>
using namespace std;

static int cnt;

 int add(int a, int b)
{
   
    cout<<a+b;
}
int main()

{
    auto start_time = std::chrono::high_resolution_clock::now();
    
        add(2,3);
        for(int i=0;i<10000;i++){
             cnt++;
         }

        add(5,3);
        add(2,75);
        add(78,3);

         for(int i=0;i<10000;i++){
            cnt++;
            }


        add(2,247);
        add(2579,3);
        
        
        for(int i=0;i<10000;i++){
             cnt++;
         }

        add(2,824);

     
        auto end_time = std::chrono::high_resolution_clock::now();
        auto duration = std::chrono::duration_cast<std::chrono::microseconds>(end_time - start_time);
        std::cout << "Execution time: " << duration.count() << " microseconds" << std::endl;


}
