package OneDimensionalArray;
import java.util.Scanner;

class OneDimensionalArray{

public static void main(String args []){
	Scanner sc = new Scanner(System.in);
	
	System.out.print("Enter Size of Array :");
	int size = sc.nextInt();
	
	int [] arr = new int[size];

	ArrayServices.acceptElements(arr);
//	ArrayServices.displayElements(arr);
	ArrayServices.displayMenu(arr);
	


}
}