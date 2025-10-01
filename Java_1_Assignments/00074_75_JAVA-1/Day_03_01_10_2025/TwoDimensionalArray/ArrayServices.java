package TwoDimensionalArray;

import java.util.Scanner;
public class ArrayServices {

	public static void displayMenu(int[][] arr) {
		
		byte choice=0;
		do {
		System.out.println("Welcome to Menu..");
		
		System.out.println("1. Add all elements");

		System.out.println("2. Addition of each row");

		System.out.println("3. Addition of each column.");
		
		System.out.println("4. Find max of elements of array.");
		System.out.println("5. Find max of elements row wise.");
		System.out.println("6. Find max of elements col wise.");
		
		
		
		
		System.out.println("7. Exit");
		
		
		
		Scanner sc = new Scanner(System.in);
		
		choice=sc.nextByte();
		
		
		switch(choice)
		{
		
		
		case 1: AddAll(arr);break;
		case 2:	AddRow(arr);break;
		case 3:	AddCol(arr);break;
		case 4: MaxTwoDimensional(arr);break;
		case 5: MaxRowTwoDimensional(arr);break;
		case 6: MaxColTwoDimensional(arr);break;
		
		
		case 7: break;
			
		}
		
		}while(choice!=7);
		
		
		
		

	}



	private static void MaxColTwoDimensional(int[][] arr) {
int max=0;
		
		
		for (int i = 0; i < arr[0].length; i++) {
			max=0;
			
			for (int j = 0; j < arr.length; j++) {
				
				
				if(max<arr[j][i])
				{
					max=arr[j][i];
				}
					
			}
			
			System.out.println("MAX of ALL elements in col "+(i+1)+" : "+max);
			
		}
		
	}

	private static void MaxRowTwoDimensional(int[][] arr) {
	int max=0;
		
		
		for (int i = 0; i < arr.length; i++) {
			max=0;
			
			for (int j = 0; j < arr[i].length; j++) {
				
				
				if(max<arr[i][j])
				{
					max=arr[i][j];
				}
					
			}
			
			System.out.println("MAX of ALL elements in row "+(i+1)+" : "+max);
			
		}
		
		
		
	}

	private static void MaxTwoDimensional(int[][] arr) {
			int max=0;
		
		
		for (int i = 0; i < arr.length; i++) {
			
			for (int j = 0; j < arr[i].length; j++) {
				
				
				if(max<arr[i][j])
				{
					max=arr[i][j];
				}
					
			}
			
		}
		
		System.out.println("MAX of ALL elements is : "+max);
		
	}

	private static void AddCol(int[][] arr) {
int sum=0;
		
		
		for (int i = 0; i < arr[0].length; i++) {sum=0;
			
			for (int j = 0; j < arr.length; j++) {
				sum+=arr[j][i];
			}
			
			System.out.println("Sum of ALL elements in col"+(i+1)+" : "+sum);
			
		}
		
		
	}

	private static void AddRow(int[][] arr) {
		int sum=0;
		
		
		for (int i = 0; i < arr.length; i++) {
			
			sum=0;
			
			for (int j = 0; j < arr[i].length; j++) {
				sum+=arr[i][j];
			}
			
			System.out.println("Sum of ALL elements in row"+(i+1)+" : "+sum);
			
		}
		
		
		
	}

	private static void AddAll(int[][] arr) {
		
		int sum=0;
		
		
		for (int i = 0; i < arr.length; i++) {
			
			for (int j = 0; j < arr[i].length; j++) {
				sum+=arr[i][j];
			}
			
		}
		
		System.out.println("Sum of ALL elements is : "+sum);
		
		
	}

	public static void acceptArray(int[][] arr) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter all elements :");
		
for (int i = 0; i < arr.length; i++) {
			
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j]=sc.nextInt();
			}
			
			
			
		}

		System.out.print("all elements are:");
		System.out.println("");
		
for (int i = 0; i < arr.length; i++) {
			
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j]+"\t");
				
			}
			System.out.println("");
			
			
		}
		
	}
	
	
	
	
	
	
}








