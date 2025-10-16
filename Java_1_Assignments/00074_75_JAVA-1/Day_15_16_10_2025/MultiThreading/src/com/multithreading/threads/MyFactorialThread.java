package com.multithreading.threads;

import com.multithreading.beans.MyOperationClass;

public class MyFactorialThread extends Thread{

	private int n;
	private MyOperationClass ob;
	
	
	public MyFactorialThread(int n, MyOperationClass ob) {
		super();
		this.n = n;
		this.ob = ob;
	}
	
	public void run() {
		int ans  = ob.factorial(n);
		System.out.println("Factorial of "+n+ " is :"+ans);
	}
	

}
