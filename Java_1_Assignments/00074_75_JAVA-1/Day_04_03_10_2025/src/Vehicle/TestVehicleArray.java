package Vehicle;
import java.util.Scanner;

public class TestVehicleArray {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int choice =0;
		do {
			
			System.out.println("MENU");
			System.out.println(" 1. Add Vehicle \n 2.Remove Vehicle \n 3.Display ALL \n 4.Display Last Added \n 5.Exit");
			
			System.out.print("Enter choice :");
			choice = sc.nextInt();
			
			switch(choice) {
			
			case 1: VehicleService.add();
					VehicleService.display();
					break;
			case 2 : VehicleService.remove();
			case 3 :
				VehicleService.display();
				break;
			case 4 :
				VehicleService.displayLast();
				break;
			}
		}
		while(choice != 5);
		
		
		VehicleService.display();
		

	}

}
