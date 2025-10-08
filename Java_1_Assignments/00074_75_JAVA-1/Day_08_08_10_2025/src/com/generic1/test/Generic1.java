package com.generic1.test;

public class Generic1<S> {
	
	<S extends Number> double add(S a, S b) {
		return a.doubleValue()+b.doubleValue();
	}
	public static void main(String[] args) {
		
		
		Generic1<Integer> ob= new Generic1<Integer> ();
		
		
		int sum = ob.add(100, 34);
		System.out.println(sum);

	}

}
