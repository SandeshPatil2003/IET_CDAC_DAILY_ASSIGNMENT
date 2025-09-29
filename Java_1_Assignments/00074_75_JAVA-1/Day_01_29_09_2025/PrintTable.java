import java.util.Scanner;

class PrintTable{

	public void generateTable(int num){
	
	for(int i=1;i<=10;i++){
	System.out.println(num+ "*" +i+ " =\t " +(num*i));	
	}
	
    }
	public static void main(String args []){
	
	Scanner sc = new Scanner(System.in);

	System.out.println("Enter Number :");
	int num = sc.nextInt();
		

	PrintTable obj = new PrintTable();
	
	 obj.generateTable(num);
	

}
}