package OneDimensionalArray;
import java.util.Scanner;

class ArrayServices{


// Method to accept array elements from user
	public static void acceptElements(int [] arr){
	Scanner sc = new Scanner(System.in);
	
	System.out.println("Enter Array Elements");
	
	for(int i=0; i<arr.length; i++){
		System.out.print("Enter Array Element " +(i+1)+ " : ");
		arr[i] = sc.nextInt();
		System.out.println();
	}
	
}

public static void displayElements(int [] arr)
{

	System.out.println("Array Elements Are.");
	
	for(int i=0; i<arr.length; i++){
		System.out.print("Array Element " +(i+1)+ " is :" +arr[i]);
		
		System.out.println();
	}

	
}

private static int[] findPrimeNumbers(int[] arr) {
	int [] primeNumbers = new int [arr.length];
	
	int n=0;
	
	for(int i=0 ; i<arr.length; i++) {
		int flag =0;
		
		
		for(int j=2;j<arr[i];j++) {
			
			if(arr[i] % j == 0)
				flag =1;
			
			
		}
		
		if(arr[i]==2||arr[i]==1)
		{
			flag=0;
		}
		
		if(flag == 0) {
			primeNumbers[n] = arr[i];
			n++;
		}
	}
	return primeNumbers;
}


private static int[] findFactorialLt7(int[] arr) {
	int [] factorial = new int [arr.length];
	int fact = 0, n=0;
	
	for(int i = 0;i<arr.length;i++) {
		if(arr[i] <= 7) {
			fact = getfactorial(arr[i]);
			factorial[n] = fact;
			n++;
		}
	}
		
		
	return factorial;
}


private static int getfactorial(int num) {

	int fact =1;
	for (int i=1;i<=num;i++) {
		fact *= i;
	}
	return fact;
}

public static int addOddNumbers(int [] arr) {
	
	int sum = 0;
		for(int i =0; i<arr.length; i++) {
			
			if(arr[i] % 2 != 0) {
				sum+=arr[i];
			}
		}
	return sum;
}

	public static void displayMenu(int [] arr){
	Scanner sc = new Scanner(System.in);
	byte choice ;
	
	do{
	System.out.println("Welcome to Menu :");
	System.out.println("1.Display all Primes");
	System.out.println("2.Addition of all Odd Numbers");
	System.out.println("3.Factorial of all Numbers less than 7");
	System.out.println("4.Find Nth Maximum Prime Number");
	System.out.println("5.Find Nth Minimum Prime Number");
	System.out.println("6.Exit");
	
	System.out.println("Enter Your Choice :");
	choice=sc.nextByte();

	switch(choice){
	
		case 1 : 
			int [] pn =findPrimeNumbers(arr);
			 displayElements(pn);
			 break;
		case 2 :int result = addOddNumbers(arr);
				System.out.println("Addition of all odd numbers is : "+result);
				break;
				
		case 3 : 
			int [] fn =findFactorialLt7(arr);
			 displayElements(fn);
			 break;
			 
		case 4:
			int [] pn1 =findPrimeNumbers(arr);
			findNthMax(pn1);
			
		case 5:
			int [] pn2 =findPrimeNumbers(arr);
			findNthMin(pn2);
			
		case 6 :
            System.out.println("Exiting menu.");
            break;
			
	}
	
	}while(choice != 6);
	}

	private static void findNthMax(int[] a) {
		
		System.out.println("Enter N for Nth max prime ");
		Scanner sc = new Scanner(System.in);
		int num=0 ;
		
		num=sc.nextInt();
	
		
		
		
		for(int j=0;j<a.length;j++)
		{
			int temp=0;
		
		for(int i=0;i<a.length-1;i++)
		{
			if(a[i]<a[i+1])
			{
				temp=a[i];
				a[i]=a[i+1];
				a[i+1]=temp;
			
			}
			
			
			
			
			
			
		
		
	}}
		System.out.println("Nth max prime is "+a[num-1]);
		
		

	
}
	



private static void findNthMin(int[] a) {
		
		System.out.println("Enter N for Nth min prime ");
		Scanner sc = new Scanner(System.in);
		int num=0 ;
		
		num=sc.nextInt();
	
		
		
		
		for(int j=0;j<a.length;j++)
		{
			int temp=0;
		
		for(int i=0;i<a.length-1;i++)
		{
			if(a[i]<a[i+1])
			{
				temp=a[i];
				a[i]=a[i+1];
				a[i+1]=temp;
			
			}
			
			
			
			
			
			
		
		
	}}
		System.out.println("Nth min prime is "+a[a.length-num-1]);
		
		

	
}
}