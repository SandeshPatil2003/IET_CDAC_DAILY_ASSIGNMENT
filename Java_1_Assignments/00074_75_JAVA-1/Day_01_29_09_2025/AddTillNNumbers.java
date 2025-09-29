import java.util.Scanner;

class AddTillNNumbers{

	public int addNumbers(int num){
		int sum =0;
	for(int i=1;i<=num;i++){
		sum +=i;
	}
	return sum;
    }
	public static void main(String args []){
	
	Scanner sc = new Scanner(System.in);

	System.out.println("Enter Number :");
	int num = sc.nextInt();
		

	AddTillNNumbers obj = new AddTillNNumbers();
	long result= obj.addNumbers(num);
	
	System.out.println("Addition till "+num+ " is :" +result);

}
}