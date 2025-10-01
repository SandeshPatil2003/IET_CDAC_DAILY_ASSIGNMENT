package TwoDimensionalArray;
import java.util.Scanner;
public class TwoDimensionalArray {

	public static void main(String[] args) {
	Scanner sc = new Scanner(System.in);
		System.out.print("Enter number of array row :");
		int row = sc.nextInt();
		System.out.print("\nEnter number of array column :");
		int col = sc.nextInt();
		int [] [] arr = new int [row][col];
		
		ArrayServices.acceptArray(arr);
		
		ArrayServices.displayMenu(arr);
		
	}

}
