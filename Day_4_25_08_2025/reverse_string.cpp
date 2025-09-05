#include<iostream>

#include<string.h>
using namespace std;

// void    custom_strrev(char *s1,char *s2)
// {
//     while(*s1!='\0')
//     *s1++;
//     while(*s2!='\0')
//     {
//         s1--;
//         *s2=*s1;
//         s2++; 
//     }
//     *s2 ='\0';
// }
void custom_strrev(char *s1, char *s2) {
    char *end = s1;
    while (*end) end++;       // Move 'end' to the null terminator
    end--;                    // Step back to the last character
    while (end >= s1) {
        *s2 = *end;
        s2++;
        end--;
    }
    *s2 = '\0';
}

int main()
{
    char str1[20];
    char str2[20];
    cout<<"enter string :";
    cin.getline(str1, 20);
    
    // cin>>str1;
    //  cout<<strlen(str1);
  
    custom_strrev(str1,str2);
    cout<<"Reverse string is :"<<str2;
   
    // cout<<strlen(str2);
}
