
import java.util.*;

public class TestServices {
	
	public static void menu(Question[] q_list) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Welcome .....");
		
		byte choice=0;
		
		do {
			
		System.out.println("1.Add new Test\n 2. Display Test\n 3.Exit");
		
		System.out.print("Enter choice :");
		choice = sc.nextByte();
		switch(choice) {
		
		case 1 :addTest();
			break;
		case 2 : displayAll(q_list);
				break;
		case 3 : System.out.println("Goodbyyyyy");
		break;
		}
		
		
		}while(choice != 3);
	}

	private static void displayAll(Question[] q_list) {
		for(int i=0;i<q_list.length;i++) 

		{
			System.out.println(q_list[i]);
		}
		
	}

	private static void addTest() {
		Test t = new Test();
		Scanner sc = new Scanner(System.in);
		String ch;
		do {
			System.out.print("Enter test id :");
			int id = sc.nextInt();
			t.settId(id);
			
			System.out.print("\nEnter Name of test :");
			String name = sc.nextLine();
			sc.next();
			t.settName(name);
			
			System.out.print("\nEnter test Date :");
		
			System.out.println("Do you want to add another test");
			
		}while(ch!='n' || ch!='N')
		
		
		
//		char ch='y';
//		char ch2='y';
//		int cnt=0;
//		int nooftests=0;
//		
//		
//		
//			System.out.println("How many Tests do you want to add?");
//			nooftests=sc.nextInt();
//			
//			
//			Test[] t= new Test[nooftests];
//			
//		for(int j=0;j<nooftests;j++)
//		{
//			
//			System.out.println("Enter details for TEST");
//			
//			System.out.println("Enter tID");
//			
//			
//			t[j].settId(sc.nextInt());
//			
//			System.out.println("Enter tName");
//			
//			t[j].settName(sc.nextLine());
//			
//			sc.next();
//			Date d=new Date();
//			t[j].settDate(d);
//			
//		
//		for(int i=0;i<10;i++) 
//
//		{
//			System.out.println("Do you want to add question no"+(i+1));
//			ch=sc.next().charAt(0);
//		
//			
//			
//			if(ch=='y'||ch =='Y')
//				{
//				
//				System.out.println("Enter details for question no"+(i+1));
//				
//				
//				
//				
//				
//				t[j].getQlist()[i]=sc.next();
//				t[j].setQlist(qlist[i].setqNo(i));
//						
//				}
//			
//			else {break;};
//				
//				
//				
//		}
//		
//		
//}
		
		
		
		
		
	
		
	}

}
