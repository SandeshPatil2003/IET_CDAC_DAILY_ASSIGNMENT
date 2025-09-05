#include<iostream>

using namespace std;

void user_strcpy(char *s2, char *s1)
{

     while(*s2 != '\0')
     {
        *s2=*s1;
        s1++;
        s2++;
     }
     *s2='\0';
}
int main()
{
    char str1[20],str2[20];
    cout<<"Enter first string : ";
    cin>>str1;
    // cout<<"Enter second string : ";
    // cin>>str2;
   user_strcpy(str2,str1);
   cout<<"String 1 copied in string 2  is "<<str2;

}