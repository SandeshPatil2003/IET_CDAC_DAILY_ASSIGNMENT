package temp;

public class Temp1 {

	public static void main(String[] args) {
		
		
		
		int[][]a= {{1,2,3},{4,5,6},{7,8,9}};
		
		
		 ShiftRight(a);

	}

	private static void ShiftRight(int[][] array) {
		
		int[][]temp= new int[(array.length)][(array[0].length)];
		
		for (int i = 0; i < array.length; i++) {
			
			for (int j = 0; j < array[0].length; j++) {
				
				if(j==(array[0].length-1))
				{
					temp[i][0]=array[i][j];
				}
				else {
					temp[i][j+1]=array[i][j];
				}
				
				
				
			}
		}
		
		
		
for (int i1 = 0; i1 < array.length; i1++) {
			
			for (int j = 0; j < array[0].length; j++) {
				
				System.out.print(array[i1][j]+"\t");
				
				
			}
			
			System.out.println();}System.out.println();
			
			
		
for (int i = 0; i < temp.length; i++) {
			
			for (int j = 0; j < temp[0].length; j++) {
				
				System.out.print(temp[i][j]+"\t");
				
				
			}
			
			System.out.println();
			
		}
	}

}
