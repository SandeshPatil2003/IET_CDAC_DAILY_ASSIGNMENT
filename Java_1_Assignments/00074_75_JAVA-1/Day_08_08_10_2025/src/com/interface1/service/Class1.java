package com.interface1.service;

public class Class1 implements Interface1
{

	public static void main(String[] args) {
		
	Interface1 ob = new Class1();
//		
//	
//	Interface1 ob1= ()->{System.out.println("in m1 of anno clas");};
//		
//		ob1.m1();
//		
//		
		ob.m1();
		
		
		//System.out.println(a+b+a+Interface1.super.f1());
		
		

	}
	

	@Override
	public void m1() {
		// TODO Auto-generated method stub
		System.out.println("in m1 of class 1");
		
		System.out.println(a+b+a+Interface1.super.f1());

	}
	

	
}
