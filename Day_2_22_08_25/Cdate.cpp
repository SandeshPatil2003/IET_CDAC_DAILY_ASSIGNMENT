#include <iostream>
using namespace std;
class Cdate 
{
	int dd,mm,yy;
	public :
		Cdate();
		Cdate(int);
		void accept();
		void display() const;
		void setDate(int);
		int getMonth() const;
		
};
Cdate::Cdate()
{
		cout<<"Default constructor"<<endl;

}
Cdate::Cdate(int m){
	cout<<"Para constructor"<<endl;
	mm=m;
}
void Cdate::accept()
{
	cout<<"Enter date month and year"<<endl;
	cin>>dd>>mm>>yy;
	
}
void Cdate::display() const
{
	cout<<"Date is "<<dd<<"/"<<mm<<"/"<<yy<<endl;
}
void Cdate::setDate(int d) {
	dd=d;
}

int Cdate::getMonth() const
{
	return mm;
}
int main()
{
	Cdate c;
//	Cdate c1();
	c.accept();
	c.display();
	c.setDate(23);
	cout<<"Month is "<<c.getMonth()<<endl;
	const Cdate c1(9);
	
	cout<<"month new is "<<c1.getMonth();
	
}
