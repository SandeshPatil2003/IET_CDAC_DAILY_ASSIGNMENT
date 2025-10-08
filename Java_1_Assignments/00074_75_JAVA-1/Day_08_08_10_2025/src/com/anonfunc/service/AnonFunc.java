package com.anonfunc.service;

public class AnonFunc {

	public static void main(String[] args) {
		
		MyAdd obj = (a,b) ->{
			System.out.println("From compare anno fun :");
			return a+b;
		};
		
		System.out.println(obj.add(10, 20));
		
	}

}
