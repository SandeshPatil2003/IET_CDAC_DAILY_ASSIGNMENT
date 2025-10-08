package com.anonfunc2.test;

import com.anonfunc.service.MyAdd;

public class Class1 {

	public static void main(String[] args) {
		
		
		MyAdd obj1 = (a,b)->{
			
			 System.out.println(a-b); return a-b;
		};
		
		
		
		obj1.add(30, 20);
		
		
		

	}

}
