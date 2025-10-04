package Vehicle;
import java.util.Scanner;
import java.util.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
@SuppressWarnings("deprecation")
public class VehicleService
{
	
	
	
	static Vehicle[] varr;
	static int cnt;
	static{
		
		varr=new Vehicle[100];
		
		varr[0]= new Vehicle(1,"John","4 wheeler",new Date(2025,02,3));
		
		varr[1]= new Vehicle(2,"Cena","3 wheeler",new Date(2025,01,2));
		varr[2]= new Vehicle(3,"Michael","2 wheeler",new Date(2025,06,8));
		
		cnt=3;
				
		
	}
	public static void display() {
		
		for(int i=0;i<cnt;i++)
		{
		System.out.println(varr[i]);
		}
		
		
	}
	public static void add() {
		Scanner sc = new Scanner(System.in);
		Vehicle v = new Vehicle();
		
		char ch='y'; 
		
		do {
			
		System.out.print("Enter vehicle Id :");
		int id = sc.nextInt();
		v.setVid(id) ;
		
		System.out.print("\n Enter Owner Name :");
		String name = sc.nextLine();
		v.setOname(name);
		sc.nextLine();

		System.out.print("\n Enter Vehicle Type :");
		String vType = sc.nextLine();
		v.setVtype(vType);
		
		System.out.print("\n Enter purchase Date (dd/mm/yyyy) :");
		String d = sc.next();
		
		SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
		Date date = null;
		try {
			date = sdf.parse(d);
			v.setDpurchase(date);
		} catch (ParseException e) {
			e.printStackTrace();
		}
		
		
		varr[cnt] = new Vehicle(v.getVid(),v.getOname(), v.getVtype(), v.getDpurchase());
		cnt++;
		
		System.out.print("\n Add another vehicle (y/n) :");
	    ch = sc.next().charAt(0);
	    
		}while(Character.toLowerCase(ch) != 'n');
		System.out.println("Vehicle added successfully .......");
	}
	public static void displayLast() {
		System.out.println("Last added vehicle ");
		System.out.println(varr[cnt-1]);
		
	}
	public static void remove() {
		Scanner sc = new Scanner(System.in);
		Vehicle v = new Vehicle();
		System.out.println("Enter vehiche id to remove vehicle :");
		int id = sc.nextInt();
		
		
		
	}
}