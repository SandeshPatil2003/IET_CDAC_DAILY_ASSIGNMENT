#include<iostream>
#include<string.h>

using namespace std;

void _strlen()
{
     char name[20];
    cout<<"Enter string :";

    cin.getline(name, 20);
     
    cout<<"Length of string "<<name<<" :"<<strlen(name)<<endl;
}

void _strcpy()
{
     char str1[] = "Hello";
    char str2[] = "World";
    char str3[20];

    strcpy(str3, str2);
    cout << "strcpy str3 = " << str3 << endl;
}

void _strcat()
{
    char str1[] = "Hello";
    char str2[] = "World";
    strcat(str1, str2);
    cout << "strcat: str1 = " << str1 << endl;
}
int main()
{
    // int n;
    // cout<<"Enter size";
    // char name[20];
    // char str1[] = "Hello";
    // char str2[] = "World";
    // char str3[20];
    // cout<<"Enter string :";

    // cin.getline(name, 20);
    
    // cout<<"Length of string is :"<<strlen(name);
   

    // strcat
    // strcat(str1, str2);
    // cout << "strcat: str1 = " << str1 << endl;

    _strlen();
    _strcpy();
    _strcat();
}
