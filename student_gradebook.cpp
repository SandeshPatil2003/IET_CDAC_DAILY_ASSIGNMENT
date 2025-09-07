#include<iostream>
#include<vector>
#include<fstream>
#include<exception>
#define n 3
using namespace std;

class Student{
    int rollNo;
    string name;
    float marks [n];

    public:
    Student& operator++();
    void acceptData();
    int getRollNo() const;
    string getName() const;
    float getMarks(int) const;
    void setRollNo(int) ;
    void setMark(int index, float value);

  
};
void Student::setMark(int index, float value) {
    if (index >= 0 && index < n && value >= 0 && value <= 100) {
        marks[index] = value;
    } else {
        throw runtime_error("Invalid index or mark value");
    }
}

int Student::getRollNo()const {
    return rollNo;
}
string Student::getName() const {
    return name;
}
float Student::getMarks(int m) const{
    return marks[m];
}

void  Student::acceptData()
{

    // cout<<"Enter rollNo of student :";
    // cin>>rollNo;
   
    cin.ignore();
    cout<<"Enter Student name :";
    getline(cin, name);

    cout<<"Enter Marks for 3 subject :";
    float totalMarks = 0.0;
    for (int i = 0; i < n; i++)
    {
              
        cout << "Subject " << (i + 1) << ": ";
        cin>>marks[i];
         if (marks[i] < 0 || marks[i] > 100)
        {
           throw runtime_error("Invalid Marks");
        //    return 0;
        }
        totalMarks +=marks[i]; 
    }

    cout<<"Marks :"<<totalMarks<<endl;
}

class Gradebook {
    vector<Student> student;

    public :
    void addStudent();

    void loadFromGradebook() const;
    void saveToGradeboook() const;
    bool isDuplicateRollNo(int) const;    
  void searchByRollNo() const;
    void display();
    void updateMarksByRollNo();
   

};

void Gradebook::searchByRollNo() const {
    int r;
    cout << "Enter roll No to search: ";
    cin >> r;

    ifstream grad_file("gradebook.txt");
    if (!grad_file.is_open()) {
        cout << "No saved gradebook data found." << endl;
        return;
    }

    string line;
    bool found = false;
    while (getline(grad_file, line)) {
        // Each student entry spans multiple lines as currently saved:
        // Roll No: x
        // Name: y
        // Marks: ...
        // ...

        // Check if this line contains the roll number
        if (line.find("Roll No: ") != string::npos) {
            // Extract roll number from the line text
            int fileRollNo = stoi(line.substr(9)); // substring after "Roll No: "
            if (fileRollNo == r) {
                found = true;
                cout << line << endl; // Print Roll No line

                // Print next two lines: Name and Marks lines
                getline(grad_file, line);
                cout << line << endl;

                getline(grad_file, line);
                cout << line << endl;

                break; // stop after first match
            }
        }
    }

    if (!found) {
        cout << "Student with Roll No " << r << " not found in saved data." << endl;
    }

    grad_file.close();
}

void Gradebook::updateMarksByRollNo() {
    int roll;
    cout << "Enter roll number to update marks: ";
    cin >> roll;
    
    ifstream fin("gradebook.txt");
    ofstream fout("temp.txt");
    if (!fin || !fout) {
        cout << "File opening error" << endl;
        return;
    }
    
    string line;
    bool found = false;
    while (getline(fin, line)) {
        if (line.find("Roll No: ") != string::npos) {
            int fileRollNo = stoi(line.substr(9));
            if (fileRollNo == roll) {
                found = true;
                fout << line << "\n";  // Write roll no line
                
                // Write name line
                getline(fin, line);
                fout << line << "\n";
                
                // Update marks line
                getline(fin, line);
                cout << "Enter new marks for 3 subjects:\n";
                float marks[n];
                for (int i = 0; i < n; i++) {
                    cout << "Subject " << (i+1) << ": ";
                    cin >> marks[i];
                    if (marks[i] < 0 || marks[i] > 100) {
                        cout << "Invalid mark!" << endl;
                        fin.close(); fout.close();
                        remove("temp.txt");
                        return;
                    }
                }
                fout << "Marks: ";
                for (int i = 0; i < n; i++) fout << marks[i] << " ";
                fout << "\n\n";
                
                // Skip the blank line in original file, if any
                getline(fin, line);

                continue;
            }
        }
        fout << line << "\n";  // Write lines unchanged
    }
    
    fin.close();
    fout.close();
    
    if (!found) {
        cout << "Roll number not found in file." << endl;
        remove("temp.txt");
        return;
    }
    
    // Replace old file with new updated file
    remove("gradebook.txt");
    rename("temp.txt", "gradebook.txt");
    
    cout << "Marks updated successfully." << endl;
}

// void Gradebook::searchByRollNo() const{
//     int r;

//     cout<<"Enter roll No to search :";
//     cin>>r;
//     for(const auto& s:student){
//         if (s.getRollNo() == r)
//         {
//              cout << "Roll No: " << s.getRollNo() << ", Name: " << s.getName() << ", Marks: ";
//         for (int i = 0; i < 3; i++)
//             cout << s.getMarks(i) << " ";
//         cout << endl;
//         }
        
//     }
// }
void Gradebook::display()
{
    cout << "Students Details are :" << endl;
    for (const auto& s : student)
    {
        cout << "Roll No: " << s.getRollNo() << ", Name: " << s.getName() << ", Marks: ";
        for (int i = 0; i < 3; i++)
            cout << s.getMarks(i) << " ";
        cout << endl;
    }
}
void Gradebook::saveToGradeboook() const{
       if (student.empty()) {
        return; // nothing to save
    }
    ofstream grad_file("gradebook.txt");

    if (!grad_file)
    {
        throw runtime_error("Error opening File");
        
    }


    // Only save the most recently added student
    const Student& s = student.back();

       for (const auto& s : student) {
        grad_file << "Roll No: " << s.getRollNo() << "\n";
        grad_file << "Name: " << s.getName() << "\n";
        grad_file << "Marks: ";
        for (int i = 0; i < n; i++) {
            grad_file << s.getMarks(i) << " ";
        }
        grad_file << "\n\n";
    }

    grad_file.close();
}
bool Gradebook::isDuplicateRollNo(int rollNo) const {
    for (const auto& s : student) {
        if (s.getRollNo() == rollNo) {
            return true;
        }
    }
    return false;
}

// void Gradebook::display()
// {
//     cout<<"Students Details are :"<<endl;
    
//     for(const &auto s : student  ){

//     }   
// }
void Student::setRollNo(int roll) {
    rollNo = roll;
}

void Gradebook::addStudent()
{
    int roll;
    while (true) {
        cout << "Enter roll number of student: ";
        cin >> roll;

        if (isDuplicateRollNo(roll)) {
            cout << "Roll number already exists. Enter a unique roll number." << endl;
        } else {
            break;  // Unique roll no entered
        }
    }
    Student s;
     s.setRollNo(roll); 
    s.acceptData();
    student.push_back(s);
}


int main()
{
    try {
    // Student s;
    // s.acceptData();
    // student.push_back(s);
    
    ifstream all_gradebook("gradebook.txt",ios::in);

    if (!all_gradebook.is_open())
    {
        cout << "No previous student details found. Starting fresh." << endl;
    }
    else{

        cout<<"Prev student Details :"<<endl;
        string line;
        //  while(getline(all_gradebook, line)) {
        // cout << line << endl;
        while(!all_gradebook.eof())
        {

        getline(all_gradebook,line);
        cout<<line<<endl;
    }
        all_gradebook.close();
    }
    int choice;

    char ch;
    Gradebook gradebook;
     do{
    cout<<"Enter choice 1.Add student \t 2.search by roll no \t 3.Update mark\t4.exit ";
    cin>>choice;
   
switch(choice)
{
    case 1:
    do{
    gradebook.addStudent();
    gradebook.saveToGradeboook();

    cout<<"Add another student (y/n)";
    cin>>ch;
    
    }while (ch== 'Y' || ch== 'y');
    gradebook.display();
    break;
    case 2:
    gradebook.searchByRollNo();
    break;
    case 3 :
    gradebook.updateMarksByRollNo() ;
    break;
    case 4:
    break;
    default :
    cout<<"Invalid choice";
    break;
}
    }while (choice!=4);
    //
}
    catch(const exception& e)
    {
    cout<<"Error :"<<e.what()<<endl;
    }
}