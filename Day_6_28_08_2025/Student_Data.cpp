#include<iostream>

using namespace std;

class Student
{
     
    int rollno;
    float totalmarks;
   // char dob[10];
    int dd,mm,yy;
    public:
   
    void accept();
    void display();
    int getRollNo();
    int getMarks();
    int getDD();
    int getMonth();
    int getYear();
   
};
int Student::getDD()
{
    return dd;
}
int Student::getMonth()
{
    return mm;
}
int Student::getYear()
{
    return yy;
}

int Student::getRollNo()
{
    return rollno;
}
int Student::getMarks()
{
    return totalmarks;
}
void Student::accept(){

    cout<<"Enter roll_no of student :";
    cin>>rollno;

     cout<<endl;

    cout<<"Enter Date of birth of student in form of dd mm and yy :";
    cin>>dd>>mm>>yy;
     cout<<endl;

    cout<<"Enter total marks of student :";
    cin>>totalmarks;

    cout<<endl;
   
}
void sortByRollNo(Student s[], int n)
 {
    for(int i=0;i<n-1;i++) 
    {
        for(int j=0;j<n-i-1;j++) 
        {
            if(s[j].getRollNo() > s[j+1].getRollNo())
             {
                Student temp = s[j];
                s[j] = s[j+1];
                s[j+1] = temp;
            }
        }
    }
}

void sortByMarks(Student s[], int n) 
{
    for(int i=0;i<n-1;i++) 
    {
        for(int j=0;j<n-i-1;j++)
         {
            if(s[j].getMarks() > s[j+1].getMarks())
             {
                Student temp = s[j];
                s[j] = s[j+1];
                s[j+1] = temp;
            }
        }
    }
}
void sortByDOB(Student s[], int n) 
{
    for(int i=0;i<n-1;i++) 
    {
        for(int j=0;j<n-i-1;j++)
         {
        if ( (s[j].getYear() > s[j + 1].getYear()) ||
             (s[j].getYear() == s[j + 1].getYear() && s[j].getMonth() > s[j + 1].getMonth()) ||
             (s[j].getYear() == s[j + 1].getYear() && s[j].getMonth() == s[j + 1].getMonth() && s[j].getDD() > s[j + 1].getDD()) )
            {
                    Student temp = s[j];
                    s[j] = s[j+1];
                     s[j+1] = temp;
            }
        
        }
    }
}

void Student::display()
{
    cout<<"roll_no of student is:"<<rollno<<endl;
    cout<<" Date of birth of student is :"<<dd<<"/"<<mm<<"/"<<yy<<endl;
    cout<<" total marks of student :"<<totalmarks<<endl;
    cout<<endl;
}

int main()
{
    const int n = 5;
    Student s[n];
    int ch;
    cout<<"Accepting student details :"<<endl;
     for(int i=0;i<n;i++)
    {
       s[i].accept();
    }
while (true) {
    cout<<"enter your choice"<<endl;
    cout<<"1. Sort by rollno \n 2. Sort by Marks \n 3. Sort by Date of birth\n 4. Exit "<<endl;
      cin>>ch;
    
    switch(ch)
       {
        case 1 :
    cout << "\nSorted by Roll No:\n";
   sortByRollNo(s, n);
     for(int i=0;i<n;i++)
    {
            s[i].display();
    }
     break;
     case 2 : 
    cout << "\nSorted by Total Marks:\n";
    sortByMarks(s, n);
      for(int i=0;i<n;i++)
    {
            s[i].display();
    }
     break;
 case 3 : 
        cout << "\nSorted by Date of Birth:\n";
    sortByDOB(s, n);
      for(int i=0;i<n;i++)
    {
            s[i].display();
            
    }
     break;
    case 4 :
    break;

    default:
    cout<<"Invalid choice";
}
}
}